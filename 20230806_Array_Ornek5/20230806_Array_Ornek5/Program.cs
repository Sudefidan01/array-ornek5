using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array_Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 5
            //Kullanıcıdan kaç adet isim soyisim gireceğini soralım
            //Kullanıcının girmiş olduğu sayı kadar ayrı ayrı şekilde isim ve soyisim talep edelim
            //Bu işlemler bittikten sonra isim soyisim şeklinde yan yana yazdıralım

            int sayi;
            Console.WriteLine("Kaç Kişi Gireceksiniz : ");
            sayi = int.Parse(Console.ReadLine());

            string[] isimler = new string[sayi];
            String[] soyisimler = new String[sayi];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Clear();
                Console.Write("İsim Giriniz : ");
                isimler[i] = Console.ReadLine();
                Console.Write("Soyisim Giriniz : ");
                soyisimler[i] = Console.ReadLine();
            }

            Console.Clear();

            for (int q = 0; q < isimler.Length; q++)
            {
                Console.WriteLine(isimler[q] + " " + soyisimler[q]);
            }

            Console.ReadKey();

        }
    }
}
