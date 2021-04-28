using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + ": Id nolu -- " + customer.FirstName + " " + customer.LastName
                              + " : İsimli Müşteri sisteme EKLENDİ.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + ": Id nolu -- " + customer.FirstName + " " + customer.LastName
                              + " : İsimli Müşteri sistemden SİLİNDİ.");
        }


    }
}