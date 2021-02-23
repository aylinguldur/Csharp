using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            double sayi;
            int tam = 0;
            int i = 1;
            Console.WriteLine("Ondalıklı bir sayı giriniz :");
            sayi = Convert.ToDouble(Console.ReadLine());
            double k = sayi;
            while(i!=tam)
            {
                 sayi = k * i;
                if (sayi == (int)sayi)
                {
                    tam = i;
                }
                else
                {
                    ++i;
                }
               
            }
            Console.WriteLine("Girdiğiniz ondalıklı sayının kesirli olarak yazımı: ");
            Console.WriteLine(sayi+"/"+tam);
            Console.ReadKey();
        }
    }
}
