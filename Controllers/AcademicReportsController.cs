using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EducationTrackProject.Data;
using EducationTrackProject.Models;

namespace EducationTrackProject.Controllers
{
    public class AcademicReportsController : Controller
    {
        private readonly EducationTrackProjectContext _context;

        public AcademicReportsController(EducationTrackProjectContext context)
        {
            _context = context;
        }

        // GET: AcademicReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.AcademicReport.ToListAsync());
        }

        // GET: AcademicReports/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicReport = await _context.AcademicReport
                .FirstOrDefaultAsync(m => m.ReportId == id);
            if (academicReport == null)
            {
                return NotFound();
            }

            return View(academicReport);
        }

        // GET: AcademicReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AcademicReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportId,Scope,CompletionRate,AvgScore,DropOutRate,GeneratedDate")] AcademicReport academicReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(academicReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(academicReport);
        }

        // GET: AcademicReports/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicReport = await _context.AcademicReport.FindAsync(id);
            if (academicReport == null)
            {
                return NotFound();
            }
            return View(academicReport);
        }

        // POST: AcademicReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ReportId,Scope,CompletionRate,AvgScore,DropOutRate,GeneratedDate")] AcademicReport academicReport)
        {
            if (id != academicReport.ReportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academicReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcademicReportExists(academicReport.ReportId))
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
            return View(academicReport);
        }

        // GET: AcademicReports/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicReport = await _context.AcademicReport
                .FirstOrDefaultAsync(m => m.ReportId == id);
            if (academicReport == null)
            {
                return NotFound();
            }

            return View(academicReport);
        }

        // POST: AcademicReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var academicReport = await _context.AcademicReport.FindAsync(id);
            if (academicReport != null)
            {
                _context.AcademicReport.Remove(academicReport);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcademicReportExists(string id)
        {
            return _context.AcademicReport.Any(e => e.ReportId == id);
        }
    }
}
