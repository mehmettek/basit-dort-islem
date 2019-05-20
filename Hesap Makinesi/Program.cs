using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bolum1:Islemler klasöründeki classlara ulasim.
            Islemler.toplama islem1 = new Islemler.toplama(); 
            Islemler.cikarma islem2 = new Islemler.cikarma();
            Islemler.carpma islem3 = new Islemler.carpma();
            Islemler.bolme islem4 = new Islemler.bolme();
            //Bolum1:Islemler klasöründeki classlara ulasim.

            //Bolum2:Sayilarin kullanicidan alinmasi.
            Console.Write("1.Sayiyi Giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayiyi Giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            //Bolum2:Sayilarin kullanicidan alinmasi.
            
            //Bolum3:Methodlara deger gönderip sonucu alma.
            int sonuc1 = islem1.topla(sayi1, sayi2);
            int sonuc2 = islem2.cikar(sayi1, sayi2);
            int sonuc3 = islem3.carp(sayi1, sayi2);
            int sonuc4 = islem4.bol(sayi1, sayi2);
            //Bolum3:Methodlara deger gönderip sonucu alma.

            //Bolum4:Ekrana yazdirma.  
            Console.WriteLine("Girilen Sayilarin Toplami        : "+ sonuc1);
            Console.WriteLine("Girilen Sayilarin Farki          : " + sonuc2);
            Console.WriteLine("Girilen Sayilarin Carpimi        : " + sonuc3);
            Console.WriteLine("Girilen Sayilarin Bolumu         : " + sonuc4);
            //Bolum4:Ekrana yazdirma.
            Console.Read();

        }
    }
}
