using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace enum_ornek
{
    internal class Program
    {
        enum MyEnum
        {
            BMW,
            Mercedes,
            Ford,
            Toyata,
            Ferrari,
            Audi,
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Bir Araba Markası Seçiniz");
            Console.WriteLine();
            Console.WriteLine("Bir araba markası seçin:");
            Console.WriteLine("0: BMW");
            Console.WriteLine("1: Mercedews");
            Console.WriteLine("2: Ford");
            Console.WriteLine("3: Toyata");
            Console.WriteLine("4: Ferrari");
            Console.WriteLine("5: Audi");

            int select = int.Parse(Console.ReadLine());
            MyEnum Markalar = (MyEnum)select;         // Enum değerini elde etmek için secim kullanılıyor

            Console.WriteLine("Seçilen araba markası: " + select);

            switch (select)
            {
                case (int)MyEnum.BMW:
                    Console.WriteLine("BMW Markası Hızlıdır");
                    break;
                case (int)MyEnum.Mercedes:
                    Console.WriteLine("Mercedes Marka araçlar dayanıklıdır");
                    break;
                case (int)MyEnum.Ford:
                    Console.WriteLine("Ford Markası Alman Markasıdır ve uzun ömürlüdür");
                    break;
                case (int)MyEnum.Toyata:
                    Console.WriteLine("Toyata Fiyat Performans Markasıdır");
                    break;
                case (int)MyEnum.Ferrari:
                    Console.WriteLine("Ferrari Marka araçlar çok Hızlıdır ve Pahalıdır");
                    break;
                case (int)MyEnum.Audi:
                    Console.WriteLine("Audi Marka Araçlar Güvenilir ve Hızlıdır ");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }
            Console.ReadLine();



        }
    }
}


           



    
    


