using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace emoney
{

    public class User
    {
        public string nama;
        public string role;
        public double saldo;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    throw new ArgumentException("Saldo tidak boleh negatif");
                }
            }

        }

        public User(string nama, string role, double saldo)
        {
            Nama = nama;
            Role = role;
            Saldo = saldo;
        }

    }

    public class Customer : User
    {
        public Customer(string nama, double saldo) : base(nama, "Customer", saldo) { }

        public void checkSaldo()
        {
            Console.WriteLine($"Saldo {Nama}: {Saldo}");
        }
    }

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
