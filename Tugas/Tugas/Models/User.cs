using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRoleManagement
{
    public class User
    {
        double eMoney;

        public string nama { get; set; }
        public string role { get; set; }

        public User(string nama, string role, double emoney)
        {
            this.nama = nama;
            this.role = role;
            this.eMoney = emoney;
        }

        public void SetEmoney(double value)
        {
            eMoney = value;
        }

        public double GetEmoney()
        {
            return eMoney;
        }
    }
}
