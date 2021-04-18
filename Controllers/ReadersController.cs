using LibraryApi.Data;
using LibraryApi.Models;
using LibraryApi.Models.VIewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public class ReadersController : Controller
    {
        private readonly LibraryContext _context;
        public ReadersController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Readers.ToListAsync());
        }
        public IActionResult AddReader()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddReader([Bind("FullName,Birthday")] Reader reader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteReader(int id)
        {
            var reader = await _context.Readers.FirstOrDefaultAsync(c => c.Id == id);
            if (reader != null)
            {
                _context.Remove(reader);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var reader = await _context.Readers.FirstOrDefaultAsync(c => c.Id == id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Author,ReleaseDate")] Reader reader)
        {
            if (ModelState.IsValid)
            {
                var dbReader = _context.Readers.FirstOrDefault(c => c.Id == id);
                dbReader.FullName = reader.FullName;
                dbReader.Birthday = reader.Birthday;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> FullInfo(int id)
        {
            var reader = await _context.Readers.FirstOrDefaultAsync(c => c.Id == id);
            var booksId = _context.BookIssues.Where(c => c.ReaderId == reader.Id
            && c.ReturnDate == null).Select(c => c.BookID);
            var readerBooks = _context.Books.Where(c => booksId.Contains(c.Id));

            ReaderViewModel model = new(reader, readerBooks);
            return View(model);
        }
        public async Task<IActionResult> ReaderSearch(string name)
        {
            var readers = await _context.Readers.Where(c => c.FullName.Contains(name)).ToListAsync();

            return View(readers);
        }
    }
}
