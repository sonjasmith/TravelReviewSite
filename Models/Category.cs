using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [DisplayName("Categories")]
        public string CategoryName { get; set; }
    }
}