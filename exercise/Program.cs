using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        // Deklrasi array int dengan ukuran 65
        private int[] Aida = new int[65];

        // Deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        // fungsi / method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 65)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 65 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Aida[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int AJ = 0; AJ < n; AJ++)
            {
                Console.WriteLine(Aida[AJ]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int AJ = 0; AJ < n; AJ++)
                {
                    if (Aida [AJ] > Aida [AJ + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = Aida [AJ];
                        Aida [AJ] = Aida [AJ + 1];
                        Aida [AJ + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of the BubbleSort class
            Program mylist = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();

            //pemanggilan fungsi untuk mengurutkan array 
            mylist.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            //exit
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }

}
