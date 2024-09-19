using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRoleManagement
{
    public class Customer : User
    {
            public Customer(string nama, string role, int emoney) : base(nama, role, emoney)
            {

            }

            public void tampilkanSaldo()
            {
                Console.WriteLine("Saldo: " + GetEmoney());
            }
    }
}
