using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModule2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tmp = 0;
            int tampungan =0 ;
            double hitung;
            Console.Write("Masukan Angaka :");
            n = int.Parse(Console.ReadLine());
            int[] larik = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("Masukan Array Ke ");
                larik[i] = int.Parse(Console.ReadLine());
           
            }
           
            for(int k=0; k<n; k++)
            {
                tmp += larik[k] ;
                tampungan = n;  
            }   

            hitung = tmp / tampungan;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Nilai Rata Rata :" + hitung);
            Console.ReadKey();
        }
    }
}
