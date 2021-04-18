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
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;
        public BooksController(LibraryContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var books = _context.Books.Where(c => c.Count > 0);

            if (books != null)
            {
                return View(await books.ToListAsync());
            }

            return View(new List<Book>());
        }
        public async Task<IActionResult> IssuedBooks()
        {
            var issues = _context.BookIssues.Where(c => c.ReturnDate == null);
            var list = new List<GivingBookViewModel>();
            if (issues == null)
            {
                return View(list);
            }

            foreach (var issue in issues)
            {
                Reader reader = await _context.Readers.FirstOrDefaultAsync(c => c.Id == issue.ReaderId);
                Book book = await _context.Books.FirstOrDefaultAsync(c => c.Id == issue.BookID);
                list.Add(new GivingBookViewModel(book, reader));
            }

            return View(list);
        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([Bind("Name,Author,ReleaseDate")] Book book)
        {
            if (ModelState.IsValid)
            {
                var dbBook = _context.Books.FirstOrDefault(c => c.Name == book.Name && c.Author == book.Author);
                if (dbBook == null)
                {
                    _context.Books.Add(book);
                }
                else
                {
                    dbBook.Count++;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(c => c.Id == id);
            if (book != null)
            {
                book.Count--;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(c => c.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Author,ReleaseDate")] Book book)
        {
            if (ModelState.IsValid)
            {
                var dbBook = _context.Books.FirstOrDefault(c => c.Id == id);
                dbBook.Name = book.Name;
                dbBook.Author = book.Author;
                dbBook.ReleaseDate = book.ReleaseDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        public async Task<IActionResult> ReturnBook(int id)
        {
            var dbBook = _context.Books.FirstOrDefault(c => c.Id == id);
            dbBook.Count++;
            var issue = await _context.BookIssues.FirstOrDefaultAsync(c => c.BookID == id
            && c.ReturnDate == null);
            issue.ReturnDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(IssuedBooks));
        }
        public async Task<IActionResult> GiveBook(int id)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(c => c.Id == id);
            var list = new List<GivingBookViewModel>();
            foreach (var reader in _context.Readers)
            {
                list.Add(new GivingBookViewModel(dbBook, reader));
            }

            return View(list);
        }
        
        public async Task<IActionResult> GiveBookForReader(int BookId, int ReaderId)
        {
            BookIssue issue = new()
            {
                BookID = BookId,
                ReaderId = ReaderId,
                IssueDate = DateTime.Now
            };
            _context.Add(issue);
            _context.Books.FirstOrDefault(c => c.Id == BookId).Count--;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(IssuedBooks));
        }
        public async Task<IActionResult> Details(int id)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(c => c.Id == id);

            return View(dbBook);
        }
        public async Task<IActionResult> BookSearch(string name)
        {
            var allbooks = await _context.Books.Where(c => c.Name.Contains(name)).ToListAsync();

            return View(allbooks);
        }
    }
}
