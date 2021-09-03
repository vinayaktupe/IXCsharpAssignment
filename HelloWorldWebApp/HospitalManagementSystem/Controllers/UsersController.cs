﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.DAL.Data.Model;
using Microsoft.AspNetCore.Http;
using HospitalManagementSystem.ViewModel;

namespace HospitalManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserDefinedDbContext _context;

        public UsersController(UserDefinedDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            //PASSING MODEL TO VIEW USING ViewData
            ViewData["Users"] = await _context.Users.Where(user => user.IsActive != false).ToListAsync();
            ViewBag.Users = await _context.Users.Where(user => user.IsActive != false).ToListAsync();
            return View();
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            var doctor = await _context.Doctors
                .FirstOrDefaultAsync(m => m.User.ID == id);

            UserDoctorDetailsViewModel viewModel = new UserDoctorDetailsViewModel() { Doctor = doctor, User = user };
            if (user == null)
            {
                return NotFound();
            }

            ////PASSING MODEL TO VIEW USING ViewBag
            //ViewBag.User = user;
            return View(viewModel);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(/*ID,*/"Number,Address,Role"/*,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy*/)] User user, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);


                if (user.Role == Role.Doctor)
                {
                    Doctor doctor = new Doctor()
                    {
                        User = user,
                        YOE = Convert.ToInt32(form["Doctor.YOE"]),
                        Specialization = form["Doctor.Specialization"]
                    };

                    _context.Add(doctor);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            UserDoctorDetailsViewModel model = new UserDoctorDetailsViewModel();

            model.User = await _context.Users.FindAsync(id);
            if (model.User.Role == Role.Doctor)
            {
                model.Doctor = await _context.Doctors.FindAsync(id);
                return View(model);
            }
            if (model.User == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Number,Address,Role,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy")] User user, IFormCollection form)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.IsActive = true;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                    if (user.Role == Role.Doctor)
                    {
                        var doctor = await _context.Doctors.FirstAsync(doctor => doctor.User.ID == user.ID);
                        doctor.YOE = Convert.ToInt32(form["Doctor.YOE"]);
                        doctor.Specialization = form["Doctor.Specialization"];
                        _context.Doctors.Update(doctor);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            user.IsActive = false;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }
    }
}
