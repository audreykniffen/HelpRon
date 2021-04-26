
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelpRon.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using HelpRon.Data;

namespace Needs.Controllers

{
    public class NeedsController : Controller
    {
        private readonly HelpRonContext _context;

        public NeedsController(HelpRonContext context)
        {
            _context = context;
        }

        #region snippet_details
        // GET: Needs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var need = await _context.Need
                .SingleOrDefaultAsync(m => m.Id == id);
            if (need == null)
            {
                return NotFound();
            }

            return View(need);
        }
        #endregion
        #region snippetCreate
        // GET: Needs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Needs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("ID,Name,DueDate,Helper")] Need need)
        {
            if (ModelState.IsValid)
            {
                _context.Add(need);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(need);
        }
        #endregion

        // GET: Needs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var need = await _context.Need.SingleOrDefaultAsync(m => m.Id == id);
            if (need == null)
            {
                return NotFound();
            }
            return View(need);
        }

        // POST: Needs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,DueDate,Helper")] Need need)
        {
            if (id != need.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(need);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NeedExists(need.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(need);
        }

        #region snippet_delete
        #region snippet_delete2
        // GET: Needs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            #endregion
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Need
                .SingleOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        #region snippet_delete3
        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            #endregion
            var need = await _context.Need.SingleOrDefaultAsync(m => m.Id == id);
            _context.Need.Remove(need);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        private bool NeedExists(int id)
        {
            return _context.Need.Any(e => e.Id == id);
        }
    }
}

#if snippet_1stSearch
        // First Search
#region snippet_1stSearch
        public async Task<IActionResult> Index(string searchString)
        {
            var need = from m in _context.need
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                need = needs.Where(s => s.Title.Contains(searchString));
            }

            return View(await needs.ToListAsync());
        }
#endregion
        // End first Search
#endif