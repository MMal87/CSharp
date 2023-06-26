// File: Calculator.cs
using System;

namespace CSharp.Intro
{
  class Clock
  {
    // what does this method return?
    public void DisplayTime()
    {
      // note that the we have to declare a type (int) for the variable (result)
      DateTime currentDateTime = DateTime.Now;
      string formattime = DateTime.Now.ToString("HH:mm:ss");
      Console.WriteLine("The current time is: {0}", formattime);
    }
  }
}