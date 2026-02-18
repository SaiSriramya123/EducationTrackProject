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
    public class StudentAnswersController : Controller
    {
        private readonly EducationTrackProjectContext _context;

        public StudentAnswersController(EducationTrackProjectContext context)
        {
            _context = context;
        }

        // GET: StudentAnswers
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentAnswer.ToListAsync());
        }

        // GET: StudentAnswers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAnswer = await _context.StudentAnswer
                .FirstOrDefaultAsync(m => m.StudentAnswerId == id);
            if (studentAnswer == null)
            {
                return NotFound();
            }

            return View(studentAnswer);
        }

        // GET: StudentAnswers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentAnswers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentAnswerId,Answer,createdDate,QuestionId,AssessmentId,StudentId")] StudentAnswer studentAnswer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentAnswer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentAnswer);
        }

        // GET: StudentAnswers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAnswer = await _context.StudentAnswer.FindAsync(id);
            if (studentAnswer == null)
            {
                return NotFound();
            }
            return View(studentAnswer);
        }

        // POST: StudentAnswers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StudentAnswerId,Answer,createdDate,QuestionId,AssessmentId,StudentId")] StudentAnswer studentAnswer)
        {
            if (id != studentAnswer.StudentAnswerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentAnswer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentAnswerExists(studentAnswer.StudentAnswerId))
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
            return View(studentAnswer);
        }

        // GET: StudentAnswers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAnswer = await _context.StudentAnswer
                .FirstOrDefaultAsync(m => m.StudentAnswerId == id);
            if (studentAnswer == null)
            {
                return NotFound();
            }

            return View(studentAnswer);
        }

        // POST: StudentAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var studentAnswer = await _context.StudentAnswer.FindAsync(id);
            if (studentAnswer != null)
            {
                _context.StudentAnswer.Remove(studentAnswer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentAnswerExists(string id)
        {
            return _context.StudentAnswer.Any(e => e.StudentAnswerId == id);
        }
    }
}
