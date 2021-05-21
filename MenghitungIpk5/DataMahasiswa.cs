using System;
using System.Collections.Generic;

namespace MenghitungIpk5
{
    class DataMahasiswa
    {
        public string Nama { get; set; }
        public int Nim { get; set; }

        public string Prodi { get; set; }


        //public float Total_bobot { get; set; }
        //public float Total_sks { get; set; }
        //public float Total_akhir { get; set; }
        //public int Jml_sm { get; set; }

        //public float Ips { get; set; }
        public List<HitungIpk> HitungIpks { get; set; }

        public DataMahasiswa()
        {
            HitungIpks = new List<HitungIpk>();
        }

        public DataMahasiswa(string nama, int nim, string prodi)
        {
            Nama = nama;
            Nim = nim;
            Prodi = prodi;
            HitungIpks = new List<HitungIpk>();
        }



        public void ShowDetail()
        {
            Console.WriteLine("===========================================\n");
            //Console.WriteLine(" |       ----  ---        |\n");
            Console.WriteLine($"| Nama Mahasiswa  : {Nama}");
            Console.WriteLine($"| NIM Mahasiswa   : {Nim}");
            Console.WriteLine($"| Program Studi   : {Prodi}");
            Console.WriteLine("-------------------------------------------\n");

        }

        public void ShowDetailParticipants()
        {
            Console.WriteLine("===========================================\n");
            Console.WriteLine(" |       ---- Kartu Hasil Studi ---        |\n");
            Console.WriteLine($"| Nama Mahasiswa  : {Nama}");
            Console.WriteLine($"| NIM Mahasiswa   : {Nim}");
            Console.WriteLine($"| Program Studi   : {Prodi}");
            Console.WriteLine("-------------------------------------------\n");
            if (HitungIpks.Count >= 1)
            {
                Console.WriteLine("Nilai Semester ");
            }
            foreach (HitungIpk h in HitungIpks)
            {
                Console.WriteLine($"| Total seluruhan bobot : {h.Total_bobot}");
                Console.WriteLine($"| Total seluruhan SKS   : {h.Total_sks}");
                Console.WriteLine($"| Total IPK: {h.Total_akhir}");
                Console.WriteLine("-------------------------------------------\n");
                Console.WriteLine("");
                if (h.Total_akhir >= 3.51)
                {
                    Console.WriteLine("===========================================\n");
                    Console.WriteLine("|        SELAMAT !! Anda Cum Laude        |\n");
                    Console.WriteLine("===========================================\n");
                }
                else if (h.Total_akhir >= 3.01)
                {
                    Console.WriteLine("===========================================\n");
                    Console.WriteLine("|        IPK Anda Sangat Memuaskan        |\n");
                    Console.WriteLine("===========================================\n");
                }
                else if (h.Total_akhir >= 2.76)
                {
                    Console.WriteLine("===========================================\n");
                    Console.WriteLine("|            IPK Anda Memuaskan           |\n");
                    Console.WriteLine("===========================================\n");
                }
                else
                {
                    Console.WriteLine("===========================================\n");
                    Console.WriteLine("|        Terus Tingkatkan IPK Anda        |\n");
                    Console.WriteLine("===========================================\n");
                }
            }
            Console.WriteLine("");

        }
    }
}
