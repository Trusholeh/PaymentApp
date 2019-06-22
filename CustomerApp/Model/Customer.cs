using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactEmail { get; set; }
        public int MobileNumber { get; set; }
        public string RecentTransaction { get; set; }
    }
}
