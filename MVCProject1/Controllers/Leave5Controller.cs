using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class Leave5Controller : Controller
    {
        private readonly projectDemoContext _context;

        public Leave5Controller(projectDemoContext context)
        {
            _context = context;
        }

        // GET: Leave5
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leave5.ToListAsync());
        }

        // GET: Leave5/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave5 = await _context.Leave5
                .FirstOrDefaultAsync(m => m.Lid == id);
            if (leave5 == null)
            {
                return NotFound();
            }

            return View(leave5);
        }

        // GET: Leave5/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leave5/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Lid,EmployeeId,EmplLevel,ManagerId,LeavesInHand,LeaveStart,LeaveEnd,LeaveType,Reason,LeaveStatus")] Leave5 leave5)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leave5);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leave5);
        }

        // GET: Leave5/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave5 = await _context.Leave5.FindAsync(id);
            if (leave5 == null)
            {
                return NotFound();
            }
            return View(leave5);
        }

        // POST: Leave5/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Lid,EmployeeId,EmplLevel,ManagerId,LeavesInHand,LeaveStart,LeaveEnd,LeaveType,Reason,LeaveStatus")] Leave5 leave5)
        {
            if (id != leave5.Lid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leave5);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Leave5Exists(leave5.Lid))
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
            return View(leave5);
        }

        // GET: Leave5/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave5 = await _context.Leave5
                .FirstOrDefaultAsync(m => m.Lid == id);
            if (leave5 == null)
            {
                return NotFound();
            }

            return View(leave5);
        }

        // POST: Leave5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leave5 = await _context.Leave5.FindAsync(id);
            _context.Leave5.Remove(leave5);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Leave5Exists(int id)
        {
            return _context.Leave5.Any(e => e.Lid == id);
        }
    }
}
