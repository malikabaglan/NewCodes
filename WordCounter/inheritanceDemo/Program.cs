
// concept of inheritance 
using System;
namespace ConsoleApplication1
{

    // Base class 
    class Demo
    {

        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the GFG class using :  
    class ihheritanceDemo : Demo
    {

        // constructor of derived class 
        public ihheritanceDemo()
        {
            Console.WriteLine("ihheritanceDemo");
        }
    }

    // Driver class 
    class Sudo
    {

        // Main Method 
        static void Main(string[] args)
        {

            // creating object of derived class 
            ihheritanceDemo g = new ihheritanceDemo();

            // calling the method of base class  
            // using the derived class object 
            g.readers("Malika", "C#");
        }
    }
}
