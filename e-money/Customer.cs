using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoney
{
    public class Customer : User
    {
        public Customer(string nama, double saldo) : base(nama, "Customer", saldo) { }

        public void checkSaldo()
        {
            Console.WriteLine($"Saldo {Nama}: {Saldo}");
        }
    }

}
