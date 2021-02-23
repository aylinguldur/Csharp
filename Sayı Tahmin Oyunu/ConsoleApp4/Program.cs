using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0 , sayı, sayac = 0 ;
            Random rastgele = new Random();
            sayı = rastgele.Next(0, 10);
            Console.WriteLine(sayı);
            Console.WriteLine("Bir tahmin giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (sayı>a)
                { 
                    Console.WriteLine(a + "den büyük tahmin giriniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    sayac = sayac + 1;
                   
                }
                if (sayı<a)
                {
                    Console.WriteLine(a + " den küçük bir tahmin giriniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    sayac = sayac + 1;
                }
                if (sayı==a)
                {
                    Console.WriteLine("Doğru!!");
                    sayac = sayac + 1;
                  
                }
            } while (sayı != a);
            {
                
            }
            Console.WriteLine(sayac + " kerede tahmin ettiniz");
            Console.ReadKey();
        }

    }
}
