using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Please Enter a numeric grade from 0 to 100");
                int numberGrade = int.Parse(Console.ReadLine());

                if (numberGrade >= 98 && numberGrade <= 100)
                {
                    Console.WriteLine("A+");
                }

                else if (numberGrade >= 94 && numberGrade <= 97)
                {
                    Console.WriteLine("A");

                }
                else if (numberGrade >= 88 && numberGrade <= 93)
                {
                    Console.WriteLine("A-");

                }
                else if (numberGrade >= 86 && numberGrade <= 87)
                {
                    Console.WriteLine("b+");

                }

                else if (numberGrade >= 83 && numberGrade <= 86)
                {
                    Console.WriteLine("b");

                }
                else if (numberGrade >= 80 && numberGrade <= 82)
                {
                    Console.WriteLine("b-");

                }

                else if (numberGrade >= 77 && numberGrade <= 79)
                {
                    Console.WriteLine("c+");


                }
                else if (numberGrade >= 73 && numberGrade <= 76)
                {
                    Console.WriteLine("C");

                }
                else if (numberGrade >= 70 && numberGrade <= 72)
                {
                    Console.WriteLine("C-");

                }
                else if (numberGrade >= 68 && numberGrade <= 69)
                {
                    Console.WriteLine("D+");


                }
                else if (numberGrade >= 63 && numberGrade <= 67)
                {
                    Console.WriteLine("D");

                }
                else if (numberGrade >= 60 && numberGrade <= 62)
                {
                    Console.WriteLine("D-");

                }
                else if (numberGrade <= 59)
                {
                    Console.WriteLine("F");
                }





                Console.WriteLine("Would you like to continue? y/n");

            } while (Console.ReadLine() == "y"); Console.WriteLine("have a good day");
            Console.ReadKey();
        }

    }
}