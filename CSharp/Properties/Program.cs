using System;

namespace Properties
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1987, 2, 15));
            System.Console.WriteLine(person.Age);         
        }
    }
}