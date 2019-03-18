using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkCalisma08022019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen üç sayının 
            //ortalamasını hesaplayan program
            int s1, s2, s3;
            float ort;
            Console.WriteLine("Üç sayı giriniz:");
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            s3 = Convert.ToInt16(Console.ReadLine());
            //Parse ve Convert işlemi tip dönüşümü yapar
            //İkisini de kullanabilirsiniz
            ort = (s1 + s2 + s3 )/ 3;
            Console.WriteLine("Ortalama=" + ort);
            Console.ReadKey();
            //Bir tuşa basıncaya kadar Console ekranını bekletir!
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
