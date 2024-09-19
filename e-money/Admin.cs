using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoney
{
    public class Admin : User
    {
        public Admin(string nama, double saldo) : base(nama, "Admin", saldo) { }

        // Method untuk menambah saldo ke customer
        public void tambahSaldo(Customer customer, double jumlah)
        {
            if (jumlah > 0)
            {
                customer.Saldo += jumlah;
                Console.WriteLine($"Saldo {customer.Nama} berhasil ditambah {jumlah}, saldo sekarang: {customer.Saldo}");
            }
            else
            {
                Console.WriteLine("Jumlah saldo yang ditambahkan harus lebih dari 0.");
            }
        }

    }

}
