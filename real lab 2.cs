using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            // James - Sweet, you used a do while! don't see them too often but it totally 
            // works just fine here, because we want to run all of this code at least once.
            do
            {
                // James - I like how you seperated your inputs into little blocks, nice job
                Console.WriteLine("Please enter the length of Room 1");
                decimal room1length = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of Room 1");
                decimal room1width = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Room Name");
                string roomname = (Console.ReadLine());


                decimal area1 = room1length * room1width;
                decimal perimiter1 = room1length + room1width;


                Console.WriteLine("The area of " + roomname + " is " + area1);
                Console.WriteLine("The perimiter of " + roomname + " is " + perimiter1);


                // James - I would be careful with too much whitespace because it may
                // be hard to read your code at the end of the day. 
                // orginzation is our best friend especially when reading large code bases all day.
                Console.ReadKey();

                Console.WriteLine("Would you like to continue? y/n");

                // for validating ReadLine == "y", I highly reccomend you use string.Equals() in this
                // situation, string.Equals() was made specifically to check strings
            } while (Console.ReadLine() == "y"); Console.WriteLine("have a good day");
            Console.ReadKey();

        }
    }
}
