using System;
namespace IntroductionToCsharp
{
    class ReadAndWrite
    {
       static void Main ()
        {
            Console.WriteLine("Please enter your name");
            String Firstname = Console.ReadLine();

            Console.WriteLine("Please enter last name");
          


            //Console.WriteLine("Hello " + Username);
           
            Console.WriteLine("Hello {0} , {1} ", Firstname, Lastname);
        }
    }
}
