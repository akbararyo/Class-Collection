using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "2354";
            mhs1.NamaMahasiswa = "chandra agung rizky";

            //membuat object mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "2314";
            mhs2.NamaMahasiswa = "akbar aryo wicaksono";

            //mebuat object dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "UwU";

            //membuat object list
            List<Mahasiswa> list = new List<Mahasiswa>();

            //menambahkan element list
            //tidak ada proses boxing
            list.Add(mhs1);
            list.Add(mhs2);

            //mengaskses element list
            //tidak ada proses unboxing
            Mahasiswa mhs = list[1];
            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========");
            Console.WriteLine(" Nim ,      nama      ");


            foreach (Mahasiswa ab in list)
            {
                Console.WriteLine("{0},{1}", ab.Nim, ab.NamaMahasiswa);
            }


            Console.ReadKey();
        }
    }
}
