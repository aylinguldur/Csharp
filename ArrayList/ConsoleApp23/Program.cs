using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DiziDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Dizi = { "Cuma", "Salı", "Pazartesi", "Perşembe", "Çarşamba" };
            Array.Sort(Dizi);
            // dizi sıralandı 
            foreach ( var t in Dizi)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("-----------------------------");
            Array.Reverse(Dizi);
            // dizi ters çevrildi
            foreach (var t in Dizi)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("-----------------------------");
            // Yeni bir dizi tanımlandı. "Dizi" bu yeni diziye aynen kopyalandı.
            string[] dizi2 = new string[Dizi.Length];
            Dizi.CopyTo(dizi2, 0);
            foreach (var t in dizi2)
            {
                Console.WriteLine("yeni dizi : "+ t);
            }
            Console.WriteLine("-----------------------------");
            // Dizi içinde arama yapılır. Varsa indis,yoksa (-1) döndürülür.
            Console.WriteLine(Array.IndexOf(Dizi, "Cuma"));
            Console.WriteLine("-----------------------------");
            Array.Clear(dizi2,0,3);
            // dizi2 3.indisten 0 a kadar silindi.
            for (int i = 0; i < Dizi.Length; i++)
            {
                Console.WriteLine(Dizi[i]+ "///// dizi2 "+ dizi2[i]);
            }
            Console.WriteLine("-----------------------------");
            // Array sınıfından dizi tanımlama
            Array dizi3 = Array.CreateInstance(typeof(int),2);
            // Arraylistten dizi tanımlama
            ArrayList aList = new ArrayList();
            aList.Add(1);
            aList.Add("ali");
            aList.Add("perş");
            aList.Add(2.60);
            foreach (var t in aList)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("-----------------------------");
            aList.Insert(4, "zeynep");
            foreach (var t in aList)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine(aList.Count);
            aList.Remove("zeynep");
            aList.RemoveAt(1);
            foreach (var t in aList)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
