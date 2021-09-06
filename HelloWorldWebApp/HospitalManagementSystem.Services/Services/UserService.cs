using HospitalManagementSystem.DAL.Data.Model;
using HospitalManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Services.Services
{
    public interface IUserService
    {
        public Task<List<AppUser>> GetAllUsers();
        public Task<AppUser> GetUserByID(int Id);
        public Task<AppUser> CreateUser(AppUser user);
        public Task<AppUser> UpdateUser(AppUser user);
        public Task<bool> DeleteUser(int Id);
        public bool UserExists(int Id);
    }

    public class UserService : IUserService
    {
        //private readonly UserDefinedDbContext _context;

        //public UserService(UserDefinedDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<AppUser> CreateUser(AppUser user)
        {
            using (var _context = new UserDefinedDbContext())
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }

        }

        public async Task<bool> DeleteUser(int Id)
        {
            try
            {
                using (var _context = new UserDefinedDbContext())
                {
                    var user = await _context.Users.FindAsync(Id);
                    user.IsActive = false;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<List<AppUser>> GetAllUsers()
        {
            //using (var UserContext = new UserDefinedDbContext())
            //{
            //}
            using (var _context = new UserDefinedDbContext())
            {
                return await _context.Users.Where(user => user.IsActive != false).ToListAsync();
            }
        }

        public async Task<AppUser> GetUserByID(int Id)
        {
            using (var _context = new UserDefinedDbContext())
            {
                return await _context.Users.FirstOrDefaultAsync(user => user.ID == Id);
            }
        }

        public async Task<AppUser> UpdateUser(AppUser user)
        {
            using (var _context = new UserDefinedDbContext())
            {
                user.IsActive = true;
                _context.Update(user);
                await _context.SaveChangesAsync();
                return user;
            }
        }

        public bool UserExists(int Id)
        {
            using (var _context = new UserDefinedDbContext())
            {
                return _context.Users.Any(e => e.ID == Id);
            }
        }
    }
}
