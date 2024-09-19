using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcampData data = new UserBootcampData();
            data.NamaUser = "Farhan";
            data.RoleUser = "Backend";
            data.Emoney = 1000000;

            Console.WriteLine($"Nama : {data.NamaUser} {data.RoleUser} {data.Emoney}");
        }
    }
    public class UserBootcampData
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }
        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }
        public int Emoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }
}