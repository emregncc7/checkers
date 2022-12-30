using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.update();

            //ProductManager productManager = new ProductManager();
            //productManager.Add();
            //productManager.update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demirog";
            customer1.City = "İzmir";

            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Genç",
                City = "İstanbul"
            };
        }
    }
   
}
