using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRoleManagement
{
    public class Admin : User
    {
        public Admin(string nama, string role, int emoney) : base(nama, role, emoney)
        {

        }

        public void addEmoney(Customer customer, double value)
        {
            customer.SetEmoney(customer.GetEmoney() + value);
        }
    }
}
