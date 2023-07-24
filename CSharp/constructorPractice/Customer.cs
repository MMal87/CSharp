using System.Collections.Generic;

namespace constructorPractice
{    

public class Customer
{
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() //this is a parameterless constructor
        {
         Orders = new List<Order>();
        }

        public Customer(int id)
        : this()// orders list will bew initialized
        { 
            this.Id = id;

            
        }
        public Customer(int id, string name)//overloading contructor
            : this(id)//now the id will be initialized from the constructor above, but this makes code unsightly, minimise using this methods
        {
            this.Name = name; 

        }
}
}