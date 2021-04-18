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
    public class BookIssuesController : Controller
    {
        private readonly LibraryContext _context;
        public BookIssuesController(LibraryContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<IssueViewModel> model = new List<IssueViewModel>();
            foreach (var issue in _context.BookIssues)
            {
                Book book = await _context.Books.FirstOrDefaultAsync(c => c.Id == issue.BookID);
                Reader reader = await _context.Readers.FirstOrDefaultAsync(c => c.Id == issue.ReaderId);
                model.Add(new IssueViewModel(book, reader, issue));
            }
            return View(model);
        }
    }
}
