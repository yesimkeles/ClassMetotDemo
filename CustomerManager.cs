using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine(musteri.Id +" "+ musteri.Adi +" "+ musteri.Soyadi +" "+ musteri.TCKimlikNo +" "+ musteri.Dogumtarih);
            Console.WriteLine("Ekleme işlemi yapıldı.");
        }

        public void CustomerList(Customer [] musteri)
        {
            Console.WriteLine("Array List");
            foreach (var item in musteri)
            {
                Console.WriteLine(item.Id + " " + item.Adi + " " + item.Soyadi + " " + item.TCKimlikNo + " " + item.Dogumtarih);
            }
        }

        public void CustomerRemove(Customer musteri)
        {
            Console.WriteLine("Silme işlemi yapıldı." + musteri.Adi);
        }
    }
}
