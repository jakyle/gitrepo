﻿using System;
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
            

            do
            {

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

                



               Console.ReadKey();

                Console.WriteLine("Would you like to continue? y/n");
               

            } while (Console.ReadLine() == "y") ; Console.WriteLine("have a good day");
            Console.ReadKey();

        } 
    }
    }

          


      




    