using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlexWilkinson.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string UrlSlug { get; set; }
        public string Author { get; set; }
        public string CoverImg { get; set; }

        [Display(Name = "Content")]
        public string Body { get; set; }

        public DateTime Created { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime Published { get; set; }

        public bool Draft { get; set; }
    }
}
