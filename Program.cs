using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{

    static internal class UseFullTools //this make this class only accessible through methods, not through objects
    {
        public static void SayHi(String name)
        {
            Console.WriteLine("Hi  " + name);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //static method is abt the class itself, no need to create objects to gt th the class itself
            //C# already has many premade classes like the math class that we can call upon whenever without having to make objects 

            Console.WriteLine(Math.Sqrt(144));

            //usefull tools tools = new useFullTools(); if u makethe clss static as welll, u will only access it with direct methods
            //no more objects, just like ucant make an object of the Math class.

            UseFullTools.SayHi("Funanani"); //no need to make objects of the say hi class since we have a satic method in there 

            //freeze
            Console.ReadLine();
        }
    }
    
}
