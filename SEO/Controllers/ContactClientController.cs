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
    public class ContactClientController : Controller
    {
        private readonly cup50gu3 _context;

        public ContactClientController(cup50gu3 context)
        {
            _context = context;
        }

        // GET: ContactClient
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactClient.ToListAsync());
        }

        // GET: ContactClient/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClient = await _context.ContactClient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactClient == null)
            {
                return NotFound();
            }

            return View(contactClient);
        }

        // GET: ContactClient/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactClient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContactId")] ContactClient contactClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactClient);
        }

        // GET: ContactClient/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClient = await _context.ContactClient.FindAsync(id);
            if (contactClient == null)
            {
                return NotFound();
            }
            return View(contactClient);
        }

        // POST: ContactClient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContactId")] ContactClient contactClient)
        {
            if (id != contactClient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactClient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactClientExists(contactClient.Id))
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
            return View(contactClient);
        }

        // GET: ContactClient/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactClient = await _context.ContactClient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactClient == null)
            {
                return NotFound();
            }

            return View(contactClient);
        }

        // POST: ContactClient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactClient = await _context.ContactClient.FindAsync(id);
            if (contactClient != null)
            {
                _context.ContactClient.Remove(contactClient);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactClientExists(int id)
        {
            return _context.ContactClient.Any(e => e.Id == id);
        }
    }
}
