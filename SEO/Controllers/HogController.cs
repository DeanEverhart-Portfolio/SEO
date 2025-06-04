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
    public class HogController : Controller
    {
        private readonly cup50gu3 _context;

        public HogController(cup50gu3 context)
        {
            _context = context;
        }

        // GET: Hog
        public async Task<IActionResult> Index()
        {
            var cup50gu3 = _context.Hog.Include(h => h.Domain);
            return View(await cup50gu3.ToListAsync());
        }

        // GET: Hog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hog = await _context.Hog
                .Include(h => h.Domain)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hog == null)
            {
                return NotFound();
            }

            return View(hog);
        }

        // GET: Hog/Create
        public IActionResult Create()
        {
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id");
            return View();
        }

        // POST: Hog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,run,stringRun,rerun,stringRerun,IntField1,StringField1,BoolField1,DateField1,IntField2,StringField2,BoolField2,DateField2,IntField3,StringField3,BoolField3,DateField3,template,dateTemplate,location,keyword,stringKeyword,stringKeyword1,content,content1,content2,dateContent,dateContent1,dateContent2,dateContent3,stringContent,html,dateHtml,meta,stringMeta,dateMeta,seo,dateSeo,plugin,datePlugin,hero,hero1,stringHero,dateHero,backup,stringBackup,dateBackup,buildExport,dateBuildExport,stringBuildExport,hog1,dateHog,stringHog,post,stringPost,datePost,site,dateSite,stringSite,dev,hogOld,DomainId")] Hog hog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", hog.DomainId);
            return View(hog);
        }

        // GET: Hog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hog = await _context.Hog.FindAsync(id);
            if (hog == null)
            {
                return NotFound();
            }
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", hog.DomainId);
            return View(hog);
        }

        // POST: Hog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,run,stringRun,rerun,stringRerun,IntField1,StringField1,BoolField1,DateField1,IntField2,StringField2,BoolField2,DateField2,IntField3,StringField3,BoolField3,DateField3,template,dateTemplate,location,keyword,stringKeyword,stringKeyword1,content,content1,content2,dateContent,dateContent1,dateContent2,dateContent3,stringContent,html,dateHtml,meta,stringMeta,dateMeta,seo,dateSeo,plugin,datePlugin,hero,hero1,stringHero,dateHero,backup,stringBackup,dateBackup,buildExport,dateBuildExport,stringBuildExport,hog1,dateHog,stringHog,post,stringPost,datePost,site,dateSite,stringSite,dev,hogOld,DomainId")] Hog hog)
        {
            if (id != hog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HogExists(hog.Id))
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
            ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "Id", hog.DomainId);
            return View(hog);
        }

        // GET: Hog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hog = await _context.Hog
                .Include(h => h.Domain)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hog == null)
            {
                return NotFound();
            }

            return View(hog);
        }

        // POST: Hog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hog = await _context.Hog.FindAsync(id);
            if (hog != null)
            {
                _context.Hog.Remove(hog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HogExists(int id)
        {
            return _context.Hog.Any(e => e.Id == id);
        }
    }
}
