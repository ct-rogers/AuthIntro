using System;

namespace AuthIntro.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Foreign Key to a user 
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}