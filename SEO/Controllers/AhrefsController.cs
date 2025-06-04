using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SEO.Data;
using SEO.Models;

namespace SEO.Controllers
{
    public class AhrefsController : Controller
    {
        private readonly cup50gu3 _context;

        public AhrefsController(cup50gu3 context)
        {
            _context = context;
        }

        // GET: Ahrefs
        public async Task<IActionResult> Index()
        {
            var cup50gu3 = _context.Ahref.Include(a => a.Domain);
            return View(await cup50gu3.ToListAsync());
        }

        // GET: Ahrefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ahref = await _context.Ahref
                .Include(a => a.Domain)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ahref == null)
            {
                return NotFound();
            }

            return View(ahref);
        }

        // GET: Ahrefs/Create
        public IActionResult Create()
        {
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id");
            return View();
        }

        // POST: Ahrefs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,domain,date,value,stringValue,DomainId")] Ahref ahref)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ahref);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", ahref.DomainId);
            return View(ahref);
        }

        // GET: Ahrefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ahref = await _context.Ahref.FindAsync(id);
            if (ahref == null)
            {
                return NotFound();
            }
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", ahref.DomainId);
            return View(ahref);
        }

        // POST: Ahrefs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,domain,date,value,stringValue,DomainId")] Ahref ahref)
        {
            if (id != ahref.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ahref);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AhrefExists(ahref.Id))
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
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", ahref.DomainId);
            return View(ahref);
        }

        // GET: Ahrefs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ahref = await _context.Ahref
                .Include(a => a.Domain)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ahref == null)
            {
                return NotFound();
            }

            return View(ahref);
        }

        // POST: Ahrefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ahref = await _context.Ahref.FindAsync(id);
            if (ahref != null)
            {
                _context.Ahref.Remove(ahref);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AhrefExists(int id)
        {
            return _context.Ahref.Any(e => e.Id == id);
        }
    }
}
