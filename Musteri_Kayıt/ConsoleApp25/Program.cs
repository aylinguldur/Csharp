using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Musteri
    {
        public const int odaFiyat = 250;
        private string musAdSoyad;
        private string musTC;
        private int musOdaNo;
        public double tutar;
        public Musteri()
        {
            musAdSoyad = " ";
            musTC = "";
            musOdaNo = 0;
            tutar = 0;
        }
        public string MusAdSoyad
        {
            get { return MusAdSoyad; }
            set { musAdSoyad = value; }
        }
        public string MusTC
        {
            get { return musTC; }
            set
            {
                if (value.ToString().Length == 11)
                    musTC = value;
                else
                    Console.WriteLine("TC Kimlik numarsı hatalı!");
            }
                            
        }
        public int MusOdaNo
        {
            get { return musOdaNo; }
            set { musOdaNo = value; }
        }
        public void Bakiye(int günSayısı)
        {
            tutar += odaFiyat * günSayısı;
            Console.WriteLine(günSayısı+" gün için ödenecek tutar : "+ tutar);
        }
        public void Yazdır()
        {
            Console.WriteLine("Musteri AD SOYAD =" + musAdSoyad);
            Console.WriteLine("Musteri TC NO =  " + MusTC);
            Console.WriteLine("Musteri ODA NO =  " + MusOdaNo);
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musteri mus1 = new Musteri();
            Console.WriteLine("Müsteri Adı-Soyadı :");
            mus1.MusAdSoyad = Console.ReadLine();
            Console.WriteLine("Müsteri TckimlikNo :");
            mus1.MusTC = Console.ReadLine();
            Random r = new Random();
            mus1.MusOdaNo = r.Next(1, 250);
            Console.WriteLine("Kaç gün kalınacak?");
            int gün = Convert.ToInt32(Console.ReadLine());
            mus1.Bakiye(gün);
            mus1.Yazdır();

            Console.ReadKey();
        }
        
    }
}
