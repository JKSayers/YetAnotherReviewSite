using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnotherReviewSite.Models
{
    public class Category
    {
            // Main key of Category model/foreign key of Review model
        public int CategoryID { get; set; }

        [Display(Name = "Tech type:")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}