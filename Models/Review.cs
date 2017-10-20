using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [DisplayName("Review Title")]
        public string ReviewTitle { get; set; }
        [DisplayName("Full Review")]
        public string FullReview { get; set; }
        [DisplayName("Publish Date")]
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}