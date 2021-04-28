using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteriler
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Batuhan";
            customer1.LastName = "Okyay";
            customer1.City = "Kütahya";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Celal";
            customer2.LastName = "Çınar";
            customer2.City = "Ankara";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Dudu Duygu";
            customer3.LastName = "Karabıyık";
            customer3.City = "İzmir";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Aslı";
            customer4.LastName = "Bekil";
            customer4.City = "Bursa";

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.FirstName = "Asya";
            customer5.LastName = "Akgül";
            customer5.City = "İzmir";

            // Müşteri ekleme - silme operasyonları
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer4);
            customerManager.Add(customer5);

            // Müşterileri Listeleme
            Console.WriteLine("-----------------Müşteri Listesi----------------------");
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id : " + customer.Id);
                Console.WriteLine("Müşteri Ad Soyad : " + customer.FirstName + " " + customer.LastName);
                Console.WriteLine("Müşteri Şehir : " + customer.City);
                Console.WriteLine("-----------------------");
            }


        }
    }
}