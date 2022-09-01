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
    public class ManagersController : Controller
    {
        private readonly projectDemoContext _context;

        public ManagersController(projectDemoContext context)
        {
            _context = context;
        }

        private projectDemoContext db = new projectDemoContext();


        public ActionResult Index(string searchBy, string search)
        {


            //return View(_context.StudentTable.ToList());
            if (searchBy == "ManagerID")
            {
                int id = Convert.ToInt32(search);
                var data = _context.Leave5.Where(model => model.ManagerId == id).ToList();
                return View(data);
            }
            else if (searchBy == "Class")
            {
                int id = Convert.ToInt32(search);
                var data = _context.Leave5.Where(model => model.EmplLevel == id).ToList();
                //var data = _context.StudentTable.ToList();
                return View(data);
            }
            else
            {
                var data = _context.Leave5.ToList();
                return View(data);
            }
        }

        // GET: Managers
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Leave5.ToListAsync());
        //}


        // GET: Managers/Edit/5
        // GET: Leave5/Edit/5


        // POST: Managers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Leave5.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]

        public ActionResult Edit(Leave5 Model)
        {
            var data = _context.Leave5.Where(x => x.EmployeeId == Model.EmployeeId).FirstOrDefault();
            if (data != null)
            {
                data.LeaveStatus = Model.LeaveStatus;

                _context.SaveChanges();
            }

            return RedirectToAction("index");
        }




    }
    }
