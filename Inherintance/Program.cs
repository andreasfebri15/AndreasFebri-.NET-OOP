using System;
namespace Inherintance
{
    public class Lingkaran
    {
        double luas; 
        public int LuasLingkaran (double r)
        {
            luas = 3.14 * r * r;
            return (int) luas;  

        }
    }
    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung(int tinggi, double r)
        {
            //memenggunakan metode luas lingkaran dari kelas lingkaran 
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
                //membuat objek
                Tabung tabung = new Tabung(5,10);

            //Menampilkan volume tabung 
            Console.Write("volume = "  +tabung.getVolume());
        }
    }
}