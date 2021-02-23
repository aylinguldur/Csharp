using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Array sehirler = Array.CreateInstance(typeof(string), 5);
            sehirler.SetValue("Ankara",0);
            sehirler.SetValue("İstanbul",1);
            sehirler.SetValue("Adana",2);
            sehirler.SetValue("Nevşehir",3);
            sehirler.SetValue("İzmir",4);
            Console.WriteLine("Dizi alfabetik sıralandı..");
            Array.Sort(sehirler);
            foreach (var t in sehirler)
            {
                Console.WriteLine(t);
                i++;
            }
            Console.WriteLine("Yazılan şehir sayısı:" + i);
            Console.WriteLine("----------------");
            Array.Reverse(sehirler);
            Console.WriteLine("Dizi ters çevrildi ");
            foreach (var t in sehirler)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Dizide aranacak ifadeyi giriniz :");
            string ifade = Console.ReadLine();
           int var= Array.IndexOf(sehirler,ifade);
            if (var > -1)
            {
                Console.WriteLine("VAR!!");
            }
            else
                Console.WriteLine("YOK!!");
            Array.Clear(sehirler,0,5);
            Console.WriteLine("Dizi Temizlendi");
            Console.ReadKey();
        }
            
        }
        
    }
