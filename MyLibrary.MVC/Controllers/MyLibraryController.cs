using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLibrary.MVC.Entities;

namespace MyLibrary.MVC.Controllers
{
    public class MyLibraryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IEnumerable<object> myLibraryEntity;

        public MyLibraryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MyLibrary
         public async Task<IActionResult> Index(string searchBy, string search)
        {
           
            if (searchBy == "Author")
            {
                return View(_context.MyLibrary.Where(x => x.Author.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View(_context.MyLibrary.Where(x => x.Title.StartsWith(search) || search == null).ToList());
            }

        }


        // GET: MyLibrary/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myLibraryEntity = await _context.MyLibrary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myLibraryEntity == null)
            {
                return NotFound();
            }

            return View(myLibraryEntity);
        }

        // GET: MyLibrary/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyLibrary/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Author,Title,Reader,DateOfReturn,Contact")] MyLibraryEntity myLibraryEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myLibraryEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myLibraryEntity);
        }

        // GET: MyLibrary/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myLibraryEntity = await _context.MyLibrary.FindAsync(id);
            if (myLibraryEntity == null)
            {
                return NotFound();
            }
            return View(myLibraryEntity);
        }

        // POST: MyLibrary/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,Title,Reader,DateOfReturn,Contact")] MyLibraryEntity myLibraryEntity)
        {
            if (id != myLibraryEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myLibraryEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyLibraryEntityExists(myLibraryEntity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(myLibraryEntity);
        }

        // GET: MyLibrary/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myLibraryEntity = await _context.MyLibrary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myLibraryEntity == null)
            {
                return NotFound();
            }

            return View(myLibraryEntity);
        }

        // POST: MyLibrary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myLibraryEntity = await _context.MyLibrary.FindAsync(id);
            if (myLibraryEntity != null)
            {
                _context.MyLibrary.Remove(myLibraryEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyLibraryEntityExists(int id)
        {
            return _context.MyLibrary.Any(e => e.Id == id);
        }
    }
}
