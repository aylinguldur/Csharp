using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ELEMAN SAYISINI GİRİNİZ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];
            dizi[0] = 0;
            dizi[1] = 1;
            Console.WriteLine(sayi + "  elemanlı Fibonacci dizisi : ");
            Console.Write(dizi[0]);
            Console.Write(" ");
            Console.Write(dizi[1]);
            for (int i = 2; i <=sayi-1; i++)
            {
                Console.Write(" ");
                dizi[i] = dizi[i - 1] + dizi[i-2];            
                Console.Write(dizi[i]);
            }
        }
    }
}
