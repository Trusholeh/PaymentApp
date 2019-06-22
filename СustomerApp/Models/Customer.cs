using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace СustomerApp.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Field must be set")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Customer name must be set")]
        public string CustomerName { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email")]
        public string ContactEmail { get; set; }
        public int MobileNumber { get; set; }
        public string RecentTransaction { get; set; }
    }
}