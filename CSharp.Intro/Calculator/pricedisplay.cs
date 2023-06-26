// File: Calculator.cs
using System;

namespace CSharp.Intro
{
  class PriceDisplay
  {
    // what does this method return?
    public void display()
    {
      // note that the we have to declare a type (int) for the variable (result)
      string item = "Coffee Machine";
      double price = 15.99;
      Console.WriteLine("The price of the item {0} is {1:f}", item, price);
    }
  }
}