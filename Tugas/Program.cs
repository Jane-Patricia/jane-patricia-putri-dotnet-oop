using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace Tugas
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

    public class Customer : User
    {
        public Customer(string nama, string role, int emoney) : base(nama, role, emoney)
        {
            
        }

        public void tampilkanSaldo()
        {
            Console.WriteLine("Saldo: " +GetEmoney());
        }

    }

    public class Admin : User
    {
        public Admin(string nama, string role, int emoney) : base(nama, role, emoney)
        {

        }

        public void addEmoney(Customer customer,double value)
        {
            customer.SetEmoney(customer.GetEmoney() + value);
        }
    }

    public class utama
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Jane", "Customer", 100000);
            Console.WriteLine("Masukkan role anda: ");
            string role = Console.ReadLine();
            if (role == "customer")
            {
                Console.WriteLine("Masukkan nama customer:");
                string nama = Console.ReadLine();
                
                if (nama == customer1.nama)
                {
                    customer1.tampilkanSaldo();
                }
            }
            else if (role == "admin")
            {
                Console.WriteLine("Masukkan nama customer:");
                string nama = Console.ReadLine();
                Admin admin = new Admin("Jojo", "Admin", 0);
                Console.WriteLine("Masukkan jumlah saldo yang akan ditambahkan:");
                double saldoTambahan = Convert.ToInt32(Console.ReadLine());
                admin.addEmoney(customer1, saldoTambahan);
                customer1.tampilkanSaldo();
            }

        }
    }

}