using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using SEO.Data;
using SEO.Models;

namespace SEO.Controllers
{
    [Authorize]
    public class AhrefController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AhrefController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ahref
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ahref.Include(a => a.Domain);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                ModelState.AddModelError("file", "Please select a file.");
                return BadRequest(ModelState);
            }

            var ahrefList = new List<Ahref>();
            var errorList = new List<string>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Set the LicenseContext

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int row = 2; // Assuming the data starts from the second row

                    while (worksheet.Cells[row, 1].Value != null)
                    {
                        try
                        {
                            var ahref = new Ahref
                            {
                                domain = worksheet.Cells[row, 1].Value?.ToString(),
                                date = worksheet.Cells[row, 2].GetValue<DateTime?>(),
                                value = worksheet.Cells[row, 3].GetValue<int?>(),
                                stringValue = worksheet.Cells[row, 4].Value?.ToString()
                            };

                            ahrefList.Add(ahref);
                        }
                        catch (Exception ex)
                        {
                            errorList.Add($"Error processing row {row}: {ex.Message}");
                        }

                        row++;
                    }
                }
            }

           

            // Save to the database
            _context.Ahref.AddRange(ahrefList);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        // GET: Ahref/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ahref == null)
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

        // GET: Ahref/Create
        public IActionResult Create()
        {
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id");
            return View();
        }

        // POST: Ahref/Create
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

        // GET: Ahref/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ahref == null)
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

        // POST: Ahref/Edit/5
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

        // GET: Ahref/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ahref == null)
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

        // POST: Ahref/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ahref == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ahref'  is null.");
            }
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
          return (_context.Ahref?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
