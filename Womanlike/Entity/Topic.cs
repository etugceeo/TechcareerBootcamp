using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womanlike.Entity
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string? Text {get; set;}
        public List<Post> Posts {get; set;} = new List<Post>();
    }
}