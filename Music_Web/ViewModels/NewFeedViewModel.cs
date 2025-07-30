using Music_Web.Models;

namespace Music_Web.ViewModels
{
    public class NewFeedViewModel
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}
