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
    public class DomainController : Controller
    {
        private readonly cup50gu3 _context;

        public DomainController(cup50gu3 context)
        {
            _context = context;
        }

        // GET: Domain
        public async Task<IActionResult> Index()
        {
            var cup50gu3 = _context.Domain.Include(d => d.Contact);
            return View(await cup50gu3.ToListAsync());
        }

        // GET: Domain/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .Include(d => d.Contact)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // GET: Domain/Create
        public IActionResult Create()
        {
            ViewData["ContactId"] = new SelectList(_context.Contact, "ID", "ID");
            return View();
        }

        // POST: Domain/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Website,Protocol,Subdomain,Topleveldomain,Description,Type,ContactId")] Domain domain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContactId"] = new SelectList(_context.Contact, "ID", "ID", domain.ContactId);
            return View(domain);
        }

        // GET: Domain/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain.FindAsync(id);
            if (domain == null)
            {
                return NotFound();
            }
            ViewData["ContactId"] = new SelectList(_context.Contact, "ID", "ID", domain.ContactId);
            return View(domain);
        }

        // POST: Domain/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Website,Protocol,Subdomain,Topleveldomain,Description,Type,ContactId")] Domain domain)
        {
            if (id != domain.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomainExists(domain.Id))
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
            ViewData["ContactId"] = new SelectList(_context.Contact, "ID", "ID", domain.ContactId);
            return View(domain);
        }

        // GET: Domain/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .Include(d => d.Contact)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // POST: Domain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domain = await _context.Domain.FindAsync(id);
            if (domain != null)
            {
                _context.Domain.Remove(domain);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomainExists(int id)
        {
            return _context.Domain.Any(e => e.Id == id);
        }
    }
}
