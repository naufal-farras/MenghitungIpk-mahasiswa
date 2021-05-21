using System;
using System.Collections.Generic;

namespace MenghitungIpk5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataMahasiswa> dataMahasiswas = new List<DataMahasiswa>();

            while (true)
            {
                MainMenu();
                try
                {
                    int pilihan = Convert.ToInt32(Console.ReadLine());
                    if (pilihan < 1 || pilihan > 5)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    switch (pilihan)
                    {
                        case 1:
                            // Add
                            Console.Clear();
                            Console.WriteLine("Masukan Nama Mahasiswa :");
                            string nama = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Masukan NIM Mahasiswa :");
                            int nim = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Masukan Prodi Mahasiswa :");
                            string prodi = Convert.ToString(Console.ReadLine());

                            AddDataMahasiswa(nama, nim, prodi, dataMahasiswas);
                            Console.Clear();
                            break;

                        case 2:
                            Console.Clear();
                            // Delete

                            TampilDataMahasiswa(dataMahasiswas);
                            Console.Write("Pilih data yang akan di hapus :");
                            int idCodingCamp = Convert.ToInt32(Console.ReadLine());
                            if (idCodingCamp < 1 || idCodingCamp > dataMahasiswas.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            dataMahasiswas.RemoveAt(idCodingCamp - 1);

                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            // Show CodingCamp

                            TampilDataIpk(dataMahasiswas);

                            Console.WriteLine("Klik tombol sembarang (Any Key) untuk kembali ke menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();

                            TampilDataMahasiswa(dataMahasiswas);

                            Console.Write("Pilih Mahasiswa  :");
                            int idCodingCamp2 = Convert.ToInt32(Console.ReadLine());
                            if (idCodingCamp2 < 1 || idCodingCamp2 > dataMahasiswas.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }

                            Console.WriteLine("-------------------------------------------");
                            Console.Write("| Jumlah SKS      : ");
                            float jml_sks = Convert.ToInt32(Console.ReadLine());

                            Console.Write("| Jumlah Bobot    : ");
                            float jml_bobot = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("-------------------------------------------");

                            float total_bobot = 0;
                            float total_sks = 0;
                            float total_akhir = 0;
                            float ips = 0;

                            //Menghitung IPS 
                            ips = jml_bobot / jml_sks;

                            //Menampilkan IPS
                            Console.WriteLine("indeks Prestasi Semester (IPs) : " + ips);
                            Console.WriteLine("-------------------------------------------");

                            /*Menjumlahkan total bobot dan total sks setiap
                              proses perulangan */

                            total_bobot += jml_bobot;
                            total_sks += jml_sks;


                            //Menghitung IPK
                            total_akhir = total_bobot / total_sks;

                            AddDataIpk(idCodingCamp2 - 1, total_bobot, total_sks, total_akhir, ips, jml_sks, jml_bobot, dataMahasiswas);

                            Console.Clear();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Menu tidak ditemukan, silakan pilih menu yang tersedia");
                            break;
                    }

                }
                catch (Exception e)
                {
                    if (e is ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Inputan melebihi batas");
                    }
                }
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Add Data Mahasiswa");
            Console.WriteLine("2. Delete Data Mahasiswa");
            Console.WriteLine("3. Show Data Mahasiswa");
            Console.WriteLine("4. Hitung IPK Mahasiswa");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Masukan pilihan [1-5]: ");
        }

        public static void AddDataMahasiswa(string nama, int nim, string prodi, List<DataMahasiswa> dataMahasiswas)
        {
            DataMahasiswa newDataMahasiswa = new DataMahasiswa(nama, nim, prodi);
            dataMahasiswas.Add(newDataMahasiswa);

        }

        public static void AddDataIpk(int idCodingCamp2, float total_bobot, float total_sks, float total_akhir, float ips, float jml_sks, float jml_bobot, List<DataMahasiswa> dataMahasiswas)
        {
            // Add Participant

            dataMahasiswas[idCodingCamp2].HitungIpks.Add(new HitungIpk(total_bobot, total_sks, total_akhir, ips, jml_sks, jml_bobot));


        }


        public static void TampilDataMahasiswa(List<DataMahasiswa> dataMahasiswas)
        {
            int i = 1;
            foreach (DataMahasiswa dm in dataMahasiswas)
            {
                Console.WriteLine($"Data Mahasiswa Ke: {i++}");
                dm.ShowDetail();
            }
        }


        public static void TampilDataIpk(List<DataMahasiswa> dataMahasiswas)
        {
            int i = 1;
            foreach (DataMahasiswa dm in dataMahasiswas)
            {
                Console.WriteLine($"No : {i++}");
                dm.ShowDetailParticipants();
            }

        }

    }
}
