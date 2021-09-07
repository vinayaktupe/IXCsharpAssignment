using System;
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
using HospitalManagementSystem.Services.Services;
using Microsoft.Extensions.Logging;

namespace HospitalManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        //private readonly UserDefinedDbContext _context;
        private readonly IDoctorService _doctor;
        private readonly IUserService _user;

        public UsersController(/*UserDefinedDbContext context,*/ ILogger<UsersController> logger, IDoctorService doctor, IUserService user)
        {
            _logger = logger;
            //_context = context;
            _doctor = doctor;
            _user = user;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            //PASSING MODEL TO VIEW USING ViewData
            //ViewData["Users"] = await _context.Users.Where(user => user.IsActive != false).ToListAsync();
            //ViewBag.Users = await _context.Users.Where(user => user.IsActive != false).ToListAsync();
            ViewData["Users"] = await _user.GetAllUsers();
            ViewBag.Users = await _user.GetAllUsers();

            _logger.LogInformation($"View Data for Foo: {ViewData["Foo"]}");
            _logger.LogInformation($"View Bag for Foo: {ViewBag.Foo}");
            _logger.LogInformation($"Temp Data for Foo: {TempData["Foo"]}");
            TempData.Keep();

            return View();
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //var user = await _context.Users
            //    .FirstOrDefaultAsync(m => m.ID == id);
            //var doctor = await _context.Doctors
            //    .FirstOrDefaultAsync(m => m.User.ID == id);
            var doctor = await _doctor.GetDoctorByID(id);

            UserDoctorDetailsViewModel viewModel = new UserDoctorDetailsViewModel()
            {
                ID = doctor.ID,
                Number = doctor.Users?.Number,
                Role = doctor.Users.Role,
                Address = doctor.Users?.Address,
                Specialization = doctor.Specialization,
                YOE = doctor.YOE
            };

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
        public async Task<IActionResult> Create([Bind(/*ID,*/"Number,Address,Role"/*,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy*/)] AppUser user, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(user);
                var userRes = await _user.CreateUser(user);


                if (userRes != null && user.Role == Role.Doctor)
                {
                    Doctor doctor = new Doctor()
                    {
                        UserID = user.ID,
                        YOE = Convert.ToInt32(form["YOE"]),
                        Specialization = form["Specialization"]
                    };

                    //_context.Add(doctor);
                    await _doctor.CreateDoctor(doctor);
                }

                //await _context.SaveChangesAsync();

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

            //model.User = await _context.Users.FindAsync(id);
            var user = await _doctor.GetDoctorByID(id);
            if (user == null)
            {
                return NotFound();
            }
            if (user.Users.Role == Role.Doctor)
            {
                //model.Doctor = await _context.Doctors.FindAsync(id);
                UserDoctorDetailsViewModel viewModel = new UserDoctorDetailsViewModel()
                {
                    ID = user.ID,
                    Number = user.Users.Number,
                    Role = user.Users.Role,
                    Address = user.Users.Address,
                    Specialization = user.Specialization,
                    YOE = user.YOE
                };
                return View(viewModel);
            }

            return NotFound();
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Number,Address,Role,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy")] AppUser user, IFormCollection form)
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
                    //_context.Update(user);
                    //await _context.SaveChangesAsync();
                    var userRes = await _user.UpdateUser(user);
                    if (userRes != null && user.Role == Role.Doctor)
                    {
                        //var doctor = await _context.Doctors.FirstAsync(doctor => doctor.User.ID == user.ID);
                        var doctor = await _doctor.GetDoctorByID(user.ID);
                        doctor.YOE = Convert.ToInt32(form["Doctor.YOE"]);
                        doctor.Specialization = form["Doctor.Specialization"];
                        //_context.Doctors.Update(doctor);
                        //await _context.SaveChangesAsync();
                        await _doctor.UpdateDoctor(doctor);
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

            //var user = await _context.Users
            //    .FirstOrDefaultAsync(m => m.ID == id);
            var user = await _user.GetUserByID(id);
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
            //var user = await _context.Users.FindAsync(id);
            //user.IsActive = false;
            //_context.Update(user);
            //await _context.SaveChangesAsync();
            await _user.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            //return _context.Users.Any(e => e.ID == id);
            return _user.UserExists(id);
        }
    }
}
