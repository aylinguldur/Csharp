using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, tahmın = 0;
            Random rastgele = new Random();  
            tahmın = rastgele.Next(0, 10);
            Console.WriteLine("Bilgisayar tarafından tutulan sayı : "+ tahmın);
            Console.WriteLine("tahmin giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4;)
            {
                if (a != tahmın)
                {
                    Console.WriteLine("tekrar deneyiniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("doğru bildiniz");
                    i = 4;
                }
                Console.ReadKey();
            }

        }
    }
}

