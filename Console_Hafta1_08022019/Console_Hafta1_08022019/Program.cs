using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Hafta1_08022019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu bir açıklama satırıdır
            /*
             *Bu bir açıklama bloğudur 
             */

            /*
            Console.WriteLine("Merhaba Dünya!");
            int sayi;
            string isim;
            sayi = 10;
            Console.WriteLine(sayi);
            Console.Write("İsminiz:");
            isim=Console.ReadLine();
            Console.WriteLine("Merhaba " + isim);
            Console.Write("Bir sayi girin:");
            sayi = Convert.ToInt16(Console.ReadLine());
            //Console'dan okunan değerler string olarak okunur
            //Bu yüzden Convert, Parse veya başka bir ifadeyle
            //integer türüne dönüştürmek zorundayız.
            if (sayi==10)
            {
                Console.WriteLine("Sayı 10'a eşittir.");
            }
            else
            {
                Console.WriteLine("Sayı 10'a eşit değildir.");
            }

            const double pi= 3.14; //sabit değer tanımlama
            Console.WriteLine("pi="+pi);

            bool cinsiyet;
            //true=erkek
            //false=kadın
            string c;
            Console.WriteLine("Cinsiyet:");
            c = Console.ReadLine().ToLower();
            //.ToLower() --> Küçük harfe dönüştürür
            //.ToUpper() --> Büyük harfe dönüştürür
            if (c == "kadın" || c == "k")
                cinsiyet = false;
            else
                cinsiyet = true;
            if (cinsiyet) // if(cinsiyet==true) anlamına gelir
                //cinsiyet true ise if şartı çalışır,
                //false ise çalışmaz
                //if (!cinsiyet) cinsiyet değeri false ise çalışır
                Console.WriteLine("Hoşgeldiniz " + isim + " Bey");
            else
                Console.WriteLine("Hoşgeldiniz " + isim + " Hanım");
            */

            //Girilen sayının karesini hesaplayan program
            int s,kare;
            Console.Write("Sayı:");
            s = int.Parse(Console.ReadLine());
            kare = s * s;
            Console.WriteLine("Karesi:" + kare);
            //İki sayının toplamını hesaplayan program
            int s1, s2, toplam;
            Console.Write("1.Sayı:");
            s1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayı:");
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Toplam=" + s1 + s2);
            //Sayıları string gibi gördüğü için yan yana getirir
            //Yanyana toplar, gerçek toplama işlemi yapmaz

            Console.WriteLine("Toplam=" + (s1 + s2));
            //Önce parantez içindeki toplama işlemini yapar
            //(matematiksel toplama)
            //Daha sonra yazdırır

            toplam = s1 + s2;
            Console.WriteLine("Toplam=" + toplam);
            Console.ReadKey();
        }
    }
}
