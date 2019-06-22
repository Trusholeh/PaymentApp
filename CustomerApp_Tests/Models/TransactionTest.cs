using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp_Tests.Models
{
    class TransactionTest
    {
        public int TransactionID { get; set; }
        public DateTime DataTime { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Status { get; set; }
    }
}
