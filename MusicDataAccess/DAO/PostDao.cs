using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDataAccess.DAO
{
    public class PostDao
    {
        public static List<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();
            try
            {
                using var _context = new Prn222ProjectContext();
                posts = _context.Posts.Include(p => p.User).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving posts.", ex);
            }
            return posts;
        }
        public static Post? GetPostById(int id)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Posts.Include(p => p.User).FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while retrieving post with ID {id}.", ex);
            }
        }
        public static void UpdatePost(Post post)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                _context.Posts.Update(post);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while updating the post.", ex);
            }
        }

        public static void DeletePost(int id)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                var post = _context.Posts.Find(id);
                if (post != null)
                {
                    _context.Posts.Remove(post);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while deleting post with ID {id}.", ex);
            }
        }


        public static void CreatePost(Post post)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                _context.Posts.Add(post);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while creating the post.", ex);
            }
        }
        public static List<Post> GetPostsByUserId(int userId)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Posts.Where(p => p.UserId == userId).Include(p => p.User).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while retrieving posts for user with ID {userId}.", ex);
            }
        }
        public static List<Post> GetPostsByKeyword(string keyword)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Posts
                    .Where(p => p.Content.Contains(keyword) || p.Title.Contains(keyword))
                    .Include(p => p.User)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while searching posts with keyword '{keyword}'.", ex);
            }
        }
        public static List<Post> GetPostsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using var _context = new Prn222ProjectContext();
                return _context.Posts
                    .Where(p => p.CreatedAt >= startDate && p.CreatedAt <= endDate)
                    .Include(p => p.User)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception($"An error occurred while retrieving posts between {startDate} and {endDate}.", ex);
            }
        }
    }
}
