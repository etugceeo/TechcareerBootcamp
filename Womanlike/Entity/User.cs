using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womanlike.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName {get; set;}
        public List<Post> Posts {get; set;} = new List<Post>();
        public List<Comment> Comments {get; set;} = new List<Comment>();
        public string? Image {get; set;}
    }
}