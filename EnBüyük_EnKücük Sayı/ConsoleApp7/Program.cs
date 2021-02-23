using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int toplam = 0;
            int enk = 0;
            int enb = 0;
            Console.WriteLine("10 tane sayı giriniz ");
            for (int i = 1; i < 10; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + a;
                if (a > enb)
                {
                    enb = a;
                }
                else if (a < enk) 
                {
                    enk = a;
                }
            }
            Console.WriteLine("Sayıların toplamı : ");
            Console.WriteLine("toplam = "+ toplam);
            Console.WriteLine("Sayıların ortalaması : ");
            Console.WriteLine("ortalama =" + toplam / 10);
            Console.WriteLine("En küçük sayı : ");
            Console.WriteLine(enk);
            Console.WriteLine("En büyük sayı : ");
            Console.WriteLine(enb);
            
        }
    }
}
