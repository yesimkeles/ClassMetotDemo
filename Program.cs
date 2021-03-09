using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Musteri = new Customer();
            Musteri.Id = 1;
            Musteri.Adi = "Yeşim";
            Musteri.Soyadi = "KELEŞ";
            Musteri.TCKimlikNo = "111111111111";
            Musteri.Dogumtarih = "10.01.1990";

            Customer Musteri2 = new Customer();
            Musteri2.Id = 2;
            Musteri2.Adi = "Betül";
            Musteri2.Soyadi = "CAN";
            Musteri2.TCKimlikNo = "222222222222";
            Musteri2.Dogumtarih = "14.06.1996";

            Customer Musteri3 = new Customer();
            Musteri3.Id = 3;
            Musteri3.Adi = "Ali";
            Musteri3.Soyadi = "KARA";
            Musteri3.TCKimlikNo = "5555555555555";
            Musteri3.Dogumtarih = "25.10.1988";

            Customer[] musteriler = new Customer[] { Musteri, Musteri2, Musteri3 };

            CustomerManager MusteriYonetimi = new CustomerManager();
            MusteriYonetimi.Add(Musteri);
            MusteriYonetimi.Add(Musteri2);
            MusteriYonetimi.Add(Musteri3);

            Console.WriteLine("--------------------------------");
            MusteriYonetimi.CustomerList(musteriler);

            Console.WriteLine("--------------------------------");

            MusteriYonetimi.CustomerRemove(Musteri3);
            


        }
    }
}
