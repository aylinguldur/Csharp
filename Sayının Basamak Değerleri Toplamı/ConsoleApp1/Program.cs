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
            int a = 0, onlar = 0, bırler = 0, yuzler = 0;
            Console.WriteLine("Bir sayı giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            bırler = a % 10;
            onlar = a / 10;
            onlar = onlar % 10;
            yuzler = a / 100;
            Console.WriteLine("Girdiğiniz sayının basamaklarını toplamı :");
            Console.WriteLine((bırler + onlar + yuzler));
            Console.ReadKey();
        }
    }
}
