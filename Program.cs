using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123-234-345";
            karyawanTetap.NAMA = "Michael Suyama";
            karyawanTetap.Gajiperbulan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "123-321-346";
            karyawanHarian.NAMA = "Laura Callahan";
            karyawanHarian.gajiperjam = 13000;
            karyawanHarian.jamkerja = 8;

            Sales sales = new Sales();
            sales.NIK = "123-333-347";
            sales.NAMA = "Andrew Fuller";
            sales.jumlahjual = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
