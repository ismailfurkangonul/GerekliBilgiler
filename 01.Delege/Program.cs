using System;

//
namespace _01.Delege
{
    internal class Program
    {
        delegate void BenimDelegem(string adSoyad);

        static void Main(string[] args)
        {
            BenimDelegem delegem = new BenimDelegem(Kaydet);
            delegem += HosgeldinDe;
            delegem.Invoke("Furkan Gonul");
            
            Console.ReadLine(); 
        }

        static void Kaydet(string adSoyad)
        {
            Console.WriteLine(adSoyad + "kayıt işlemi yapıldı");
            HosgeldinDe(adSoyad);

        }
        static void HosgeldinDe(string adSoyad)
        {
            Console.WriteLine(adSoyad + "hosgeldiniz");



        }
    }
}
