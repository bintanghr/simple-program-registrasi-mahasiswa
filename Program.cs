using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat ibject dari kelas mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengisi properties Mahasiswa saya dan kamu
            saya.Nim = "12345";
            saya.Nama = "Jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "34523";
            kamu.Nama = "Doni";
            kamu.Ipk = 3.72f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
