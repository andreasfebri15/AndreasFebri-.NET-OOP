using System;

namespace Encapsulation
{
    public class Lingkaran
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih kecil dari 0");
                }
            }
        }
    
            public double Luas() {
            return 3.14 * radius * radius;
        }
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius;
                this.tinggi = tinggi;
            }
            public double hitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }
        }


        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(-2, 6);
                    Console.Write("volume "+tabung.hitungVolume());
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        }
    }
