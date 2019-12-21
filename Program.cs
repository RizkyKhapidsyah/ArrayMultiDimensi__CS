using System;

namespace ArrayMultiDimensi__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi variabel utama
            Mulai:
            string CJawab;
            String[] InputS = new String[3];
            String[] K = new String[30];

            int X, Y;

            /*Librari/kamus Untuk Kalimat yang akan ditampilkan Di Layar biar ndak berantakan, 
            perhatikan Variabel dan Index nya untuk memahami source code selanjutnya.*/

            K[0] = "*";
            K[1] = "ARRAY MULTI DIMENSI";
            K[2] = "Tekan 'Enter' Untuk Menampilkan Data...";
            K[3] = "-";
            K[4] = "Data";
            K[5] = "Array 1 Dimensi : ";
            K[6] = "Array 2 Dimensi : ";
            K[7] = "{";
            K[8] = ", ";
            K[9] = "}";
            K[10] = "{ 1, 4, 7, 0 }";
            K[11] = "{{ 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 }}";
            K[12] = "";
            K[13] = "\n";
            K[14] = "=> ";
            K[15] = "Jumlah Index hanya ";
            K[16] = "Ulangi? (y/n) : ";
            K[17] = "Tekan 'Enter' Untuk Mengakhiri..";
            K[18] = "Jumlah Dimensi hanya ";
            K[19] = "Tekan 'Enter' Untuk Melanjutkan ke Contoh Selanjutnya..";
            K[20] = "Menampilkan Data Array Ke Layar Menggunakan Perulangan For";

            //Mulai Program
            int[] Array1 = { 1, 4, 7, 0 };                                  //Mendeklarasikan dan Assignment Array 1 Dimensi
            int[,] Array2 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 } };       //Mendeklarasikan dan Assignment Array 2 Dimensi
                       
            CetakBanner(K[0], K[1], K[0]);
            Console.Write(K[2]); RL();

            CetakBanner(null, null, K[3]);
            Console.WriteLine(K[4]); 
            CetakBanner(K[3]); WL(K[12]);

            Console.WriteLine(K[5] + K[10]);
            Console.WriteLine(K[6] + K[11]);

            CetakBanner(K[3]); WL(K[13]);

            Console.Write(K[14] + "Masukkan Index Data [0 sd 3] Yang Ingin Ditampilkan Pada Array 1 [index dimulai dari 0]                   : ");
            int tiArray1 = Convert.ToInt32(InputS[0] = Console.ReadLine());
            
            //Hasil
            if (tiArray1 > 3 || tiArray1 < 0) 
            {
                Console.Write(K[13] + K[15] + Convert.ToString(Array1.Length) + " (0 sd 3)." + K[13] + K[16]);
                CJawab = Console.ReadLine(); WL(K[12]);

                if (CJawab == "y")
                {
                    Console.Clear();
                    goto Mulai;
                }
                else if (CJawab == "n")
                {
                    Console.Write(K[19]);
                    Console.ReadLine();
                }
            }
            else
            {
                WL(K[12]); CetakBanner(K[3]); WL(K[12]);
                Console.WriteLine("Data Array 1 Yang Dipilih  = {0}", Array1[tiArray1]);
                CetakBanner(K[3]); WL(K[13]);
            }

            Mulai2:
            Console.Write(K[14] + "Masukkan Index Dimensi ke-1 [0 sd 1] Yang Dipilih Pada Array 2 [index dimulai dari 0]                     : ");
            int ti_Dimensi_Array2 = Convert.ToInt32(InputS[1] = Console.ReadLine());
            Console.Write(K[14] + "Masukkan Index Data [0 sd 4] Pada Dimensi ke-1 Yang Ingin Ditampilkan Pada Array 2 [index dimulai dari 0] : ");
            int ti_Index_Array2 = Convert.ToInt32(InputS[2] = Console.ReadLine());

            //Hasil
            if (ti_Dimensi_Array2 > 1 || ti_Dimensi_Array2 < 0)
            {
                Console.Write(K[13] + K[18] + "2 (0 sd 1)" + K[13] + K[16]);
                CJawab = Console.ReadLine();

                if (CJawab == "y")
                {
                    WL(K[13]);
                    goto Mulai2;
                }
                else if (CJawab == "n")
                {
                    Console.WriteLine(K[17]);
                    Console.ReadLine();
                }
            }
            else
            {
                if (ti_Index_Array2 > 4 || ti_Index_Array2 < 0)
                {
                    Console.WriteLine(K[15] + "5 (0 sd 4)" + K[13] + K[16]);
                    CJawab = Console.ReadLine();

                    if (CJawab == "y")
                    {
                        WL(K[13]);
                        goto Mulai2;
                    }
                    else if (CJawab == "n")
                    {
                        Console.WriteLine(K[17]);
                        Console.ReadLine();
                    }
                }
                else
                {
                    WL(K[12]); CetakBanner(K[3]); WL(K[12]);
                    Console.WriteLine("Data Array 2 Yang Dipilih  = {0}", Array2[ti_Dimensi_Array2, ti_Index_Array2]);
                    CetakBanner(K[3], null, null);
                }
            }

            CetakBanner(null, null, K[3]);
            Console.WriteLine(K[20]);
            CetakBanner(K[3]); WL(K[12]);

            //Menampilkan Data Array 1 Ke Layar
            Console.Write(K[5] + K[7]);
            for (X = 0; X < Array1.Length; X++)
            {
                Console.Write(Array1[X]);
            }
            Console.WriteLine(K[9]);

            //Menampilkan Data Array 2 Ke Layar
            Console.Write(K[6] + K[7]);
            for (X = 0; X < Array2.GetLength(0); X++)
            {
                for (Y = 0; Y < Array2.GetLength(1); Y++)
                {
                    Console.Write(Array2[X, Y]);
                }
                Console.Write(K[8]);
            }

            Console.WriteLine(K[9]);
            Console.ReadLine();
        }

        //Abaikan Fungsi-Fungsi Di Bawah Ini, Hanya untuk Pelengkap Saja
        static void CetakBanner(string A, string B, string C)
        {
            for(int i = 0; i <= 55; i++)
            {
                Console.Write(A);
            }

            WL("");
            Console.WriteLine(B);

                for (int i = 0; i <= 55; i++)
                {
                    Console.Write(C);
                }

                WL("");
        }

        static void CetakBanner(string A)
        {
            for (int i = 0; i <= 55; i++)
            {
                Console.Write(A);
            }
        }

        static void WL(string S)
        {
            Console.WriteLine(S);
        }

        static void RL()
        {
            Console.ReadLine();
        }

    }
}
