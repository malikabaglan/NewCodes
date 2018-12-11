using System;
using System.Collections.Generic;

namespace Generics_Example
{
    //Declare Generics 
    public class GenClass<T>
    {
        public void GenFunction(T printvalue)
        {
            Console.WriteLine(printvalue);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Printing Integer Value");
            GenClass<int> gen = new GenClass<int>();
            gen.GenFunction(144);

            Console.WriteLine("Printing String Value");
            GenClass<string> genstring = new GenClass<string>();
            genstring.GenFunction("Hello String");
        }
    }