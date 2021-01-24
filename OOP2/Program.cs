using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.SurName = "Demiroğ";
            customer1.TcNo = "123456789";

            //Kodlama.io
            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "12345678921";

            // gerçek müşteri- tüzel müşteri
            //individual-corporate
            //SOLID -> L
            
            //Ebeveyn classı/miras veren class (Customer) child/miras alan class'ların(Individual ve Corporate) referanslarını tutabilir
            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
