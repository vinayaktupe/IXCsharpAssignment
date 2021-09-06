using HospitalManagementSystem.DAL.Data.Model;
using HospitalManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HospitalManagementSystem.Services.Services
{
    public interface IDoctorService
    {
        public Task<List<Doctor>> GetAllDoctors();
        public Task<Doctor> GetDoctorByID(int Id);
        public Task<Doctor> CreateDoctor(Doctor doctor);
        public Task<Doctor> UpdateDoctor(Doctor doctor);
        public Task<bool> DeleteDoctor(int Id);
    }
    public class DoctorService : IDoctorService
    {
        //private readonly UserDefinedDbContext _context;

        //public DoctorService(UserDefinedDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<Doctor> CreateDoctor(Doctor doctor)
        {
            using (var _context = new UserDefinedDbContext())
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return doctor;
            }
        }

        public async Task<bool> DeleteDoctor(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            using (var _context = new UserDefinedDbContext())
            {
                return await _context.Doctors.ToListAsync();
            }
        }

        public async Task<Doctor> GetDoctorByID(int Id)
        {
            using (var _context = new UserDefinedDbContext())
            {
                return await _context.Doctors
                .FirstOrDefaultAsync(m => m.User.ID == Id);
            }
        }

        public async Task<Doctor> UpdateDoctor(Doctor doctor)
        {
            using (var _context = new UserDefinedDbContext())
            {
                _context.Doctors.Update(doctor);
                await _context.SaveChangesAsync();
                return doctor;
            }
        }
    }
}
