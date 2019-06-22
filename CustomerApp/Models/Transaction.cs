using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace СustomerApp.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime DataTime { get; set; }

        [Range(0, 9999.99)]
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Status { get; set; }
    }
}