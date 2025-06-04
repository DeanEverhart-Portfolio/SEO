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
    public class ContactController : Controller
    {
        private readonly cup50gu3 _context;

        public ContactController(cup50gu3 context)
        {
            _context = context;
        }

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contact.ToListAsync());
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Company,Department,JobTitle,Phone1,Phone2,Phone3,Company2,Company3,MiddleName,FirstNamePreference,Pronouns,AreaCode,Prefix,Line,Extension,PhoneLabel,Gatekeeper,GatekeeperNote,PhoneNote,PhoneSort,AreaCode2,Prefix2,Line2,Extension2,Phone2Label,Gatekeeper2,Gatekeeper2Note,Phone2Note,Phone2Sort,AreaCode3,Prefix3,Line3,Extension3,Phone3Label,Gatekeeper3,Gatekeeper3Note,Phone3Note,Phone3Sort,Email,EmailLabel,EmailSort,Email2,Email21Label,Email2Sort,Email3,Email2Label,Email3Sort,Domain,Domain1,Website,WebsiteLabel,Website2,Website2Label,Website3,Website3Label,StreetNumber,StreetName,StreetDesignator,Street2,TownCity,State,ZipCode,County,Country,Map,Doh,Hold,DateHold,Dos,Tier1,Rank1,RecordFlag,RecordFlagString,RecordFlag1,RecordFlag1String,RecordNote,RecordNote1,RecordSelect,RecordSelect1,RecordCreated,RecordInactive,RecordDateInactive,IsClient")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Company,Department,JobTitle,Phone1,Phone2,Phone3,Company2,Company3,MiddleName,FirstNamePreference,Pronouns,AreaCode,Prefix,Line,Extension,PhoneLabel,Gatekeeper,GatekeeperNote,PhoneNote,PhoneSort,AreaCode2,Prefix2,Line2,Extension2,Phone2Label,Gatekeeper2,Gatekeeper2Note,Phone2Note,Phone2Sort,AreaCode3,Prefix3,Line3,Extension3,Phone3Label,Gatekeeper3,Gatekeeper3Note,Phone3Note,Phone3Sort,Email,EmailLabel,EmailSort,Email2,Email21Label,Email2Sort,Email3,Email2Label,Email3Sort,Domain,Domain1,Website,WebsiteLabel,Website2,Website2Label,Website3,Website3Label,StreetNumber,StreetName,StreetDesignator,Street2,TownCity,State,ZipCode,County,Country,Map,Doh,Hold,DateHold,Dos,Tier1,Rank1,RecordFlag,RecordFlagString,RecordFlag1,RecordFlag1String,RecordNote,RecordNote1,RecordSelect,RecordSelect1,RecordCreated,RecordInactive,RecordDateInactive,IsClient")] Contact contact)
        {
            if (id != contact.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ID))
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
            return View(contact);
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            if (contact != null)
            {
                _context.Contact.Remove(contact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ID == id);
        }
    }
}
