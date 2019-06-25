using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek list khusus untuk menampung tipe data string
            List<string> lstNamaMhs = new List<string>();

            //menambahkan elemen list
            //tidak ada proses boxing
            lstNamaMhs.Add("erick");
            lstNamaMhs.Add("wely");
            lstNamaMhs.Add("rully");

            //mengakses elemen list
            //tidak ada proses unboxing
            string namaMhs = lstNamaMhs[1];

            Console.WriteLine(namaMhs);
            Console.WriteLine();

            foreach(string nama in lstNamaMhs)
            {
                Console.WriteLine(nama);   
            }

            Console.ReadKey();
        }
    }
}
