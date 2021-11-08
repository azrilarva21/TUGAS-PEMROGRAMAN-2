using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2_1204011
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("MENENTUKAN INDEKS PRESTASI MAHASISWA\n---------------------------------");
                Console.WriteLine("Masukkan nama Mahasiswa: ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukkan Nilai: ");
                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Index Nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Index Nilai {0} adalah {1}", nama, grade[1]);

                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Index Nilai {0} adalah {1}", nama, grade[1]);

                }
                else
                {
                    Console.WriteLine("Index Nilai {0} adalah {1}", nama, grade[1]);

                }

                Console.Write("\n Masukkan index yang ditampilkan: ");
                char index = Convert.ToChar(Console.ReadLine());

                prestasi(index);

                Console.WriteLine("\nIngin Mengulang kembali (Y/N))?");

            } while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid indeks prestasi");
                    break;

            }
        }
    }
}
