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
        [Key]
        public int ID { get; set; }
        [Display (Name = "Reviewed Product")]
        public string Title { get; set; }
        [Display(Name = "User Review")]
        public string Content { get; set; }
        public double Cost { get; set; }
        [Display(Name = "Date of Review")]
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}