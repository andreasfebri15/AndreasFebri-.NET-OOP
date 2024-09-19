


using System;
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

}