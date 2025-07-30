using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDataAccess.DAO
{
    public class UserDao
    {
        public static List<User> GetAllUsers()
        {
            List<User> teams = new List<User>();
            try
            {
                using var _context = new Prn222ProjectContext();
                teams = _context.Teams.Include(t => t.Leader).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving users.", ex);
            }
            return teams;
        }

        public static User? GetUserById(int id)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Users.Include(u => u.Comments).FirstOrDefault(u => u.Id == id);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while retrieving user with ID {id}.", ex);
            }
        }

        public Static User? GetUserByEmail(string email)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Users.FirstOrDefault(u => u.Email == email);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while retrieving user with email {email}.", ex);
            }
        }

        public static void UpdateUser(User user)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while updating the user.", ex);
            }
        }

        public static void UpdateStatus(int userId, bool isActive)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                var user = _context.Users.Find(userId);
                if (user != null)
                {
                    user.IsActive = isActive;
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while updating the status of user with ID {userId}.", ex);
            }
        }
        public static void DeleteUser(int userId)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                var user = _context.Users.Find(userId);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while deleting the user with ID {userId}.", ex);
            }
        }
    }
}
