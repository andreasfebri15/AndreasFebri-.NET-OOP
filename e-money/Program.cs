using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoney
{
    public class Program
    {
        static void Main(string[] args)
        {

            Customer Andreas = new Customer("Andreas", 1000);
            Customer Febri = new Customer("Febri", 1000);

            Admin admin = new Admin("Admin", 100000);

            string role = "";
            string namaCustomer = "";
            double jumlahSaldo = 0;

            try
            {
                Console.Write("Masukkan Role Anda (Admin/Customer) : ");
                role = Console.ReadLine();
                if (role == "Admin")
                {
                    Console.Write("Pilih Customer (Andreas/Febri) : ");
                    namaCustomer = Console.ReadLine();

                    if (namaCustomer == "Andreas")
                    {
                        Console.Write("Masukkan jumlah saldo yang ingin ditambahkan : ");
                        jumlahSaldo = double.Parse(Console.ReadLine());
                        admin.tambahSaldo(Andreas, jumlahSaldo);
                    }
                    else if (namaCustomer == "Febri")
                    {
                        Console.Write("Masukkan jumlah saldo yang ingin ditambahkan : ");
                        jumlahSaldo = double.Parse(Console.ReadLine());
                        admin.tambahSaldo(Febri, jumlahSaldo);
                    }
                    else
                    {
                        Console.Write("Customer tidak terdaftar");
                    }
                }
                else if (role == "Customer")
                {
                    Console.Write("Masukkan Nama (Andreas/Febri) : ");
                    namaCustomer = Console.ReadLine();

                    if (namaCustomer == "Andreas")
                    {
                        Andreas.checkSaldo();
                    }
                    else if (namaCustomer == "Febri")
                    {
                        Febri.checkSaldo();
                    }
                    else
                    {
                        Console.WriteLine("Customer tidak ditemukan.");
                    }
                }
                else
                {
                    Console.WriteLine("Role tidak valid.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //User user = new User();
            //user.NamaUser = "Andreas";
            //Console.WriteLine($"Nama : {user.NamaUser}");

            //Console.Write("Masukkan Role Anda (Admin/Customer) :");
            //string masukkan = Console.ReadLine();


            //try
            //{

            //}
            //bool running = true;
            //while (running)
            //{
            //    Console.WriteLine('Masukkan Jumlah saldo yang ingin ditambahkan');
            //    string masukkan = Console.ReadLine();

            //}


        }
    }
}
