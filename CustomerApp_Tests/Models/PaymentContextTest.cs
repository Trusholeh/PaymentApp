using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CustomerApp_Tests.Models
{
    class PaymentContextTest : DbContext
    {
        public DbSet<CustomerTest> Customers { get; set; }
        public DbSet<TransactionTest> Transactions { get; set; }
    }
}
