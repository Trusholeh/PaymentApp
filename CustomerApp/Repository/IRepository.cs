using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository
{
    interface IRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        void Create(Customer p);
    }
}
