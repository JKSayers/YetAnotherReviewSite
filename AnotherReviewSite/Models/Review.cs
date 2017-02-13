using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AnotherReviewSite.Models
{
    public class Review
    {

        [Key] //Primary Key for Review table

        public int ID { get; set; }

        [Display(Name = "Reviewed by")]
        public string ReviewerName { get; set; }
        public string Title { get; set; }
        [Display(Name = "Review")]
        public string Content { get; set; }
        [Display(Name = "Posted on")]
        public DateTime PublishDate { get; set; }


        [ForeignKey("Category")]  // Foreign Key connecting to Category table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}