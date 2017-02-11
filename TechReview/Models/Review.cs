using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechReview.Models
{
    public class Review
    {
        [Key]   //these will be our main variables for our tech review site
        public int ID { get; set; }
        [Display (Name = "Reviewed Product")]
        public string Title { get; set; }
        [Display(Name = "User Review")]
        public string Content { get; set; }
        public double Cost { get; set; }
        [Display(Name = "Date of Review")]
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]    //this will enable the category to be a drop down or select types of devices our site reviews
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}