using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1=new Customer {Id=1,CustomerName="Ahmet",CustomerLastName="Demir",Age=34 };
            Customer customer2=new Customer {Id=2,CustomerName="Mehmet",CustomerLastName="Öz",Age=65 };
            Customer customer3=new Customer {Id=3,CustomerName="Ali",CustomerLastName="Saruhan",Age=54 };
            Customer customer4=new Customer {Id=4,CustomerName="Veli",CustomerLastName="Aydın",Age=23 };

            Customer[] customersArray=new Customer[]{customer1,customer2,customer3 };
            List<Customer> customersList=new List<Customer>(){customer1,customer2,customer3 };
            customersList.Add(customer4);

            CustomerManager customerManager= new CustomerManager();
            customerManager.GetAllCustomers(customersArray);
            customerManager.GetAllCustomers(customersList);

            customerManager.Add(customer4);
            customerManager.Update(customer3);
            customerManager.Delete(customer2);

        }
    }
}
