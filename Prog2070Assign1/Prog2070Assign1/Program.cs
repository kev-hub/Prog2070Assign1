using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2070Assign1
{ /* 
 Program Name : Prog2070Assign1
 Class Purpose : Menu
 Date : Feb 11,2020
 */
    class Program
    {
        static void Main(string[] args)
        {
            int userRadius;
            userRadius = 0;
            Circle circle = new Circle();
            Menu();


            ///creates menu 
            void Menu()
            {
                Console.WriteLine("Welcome to my circle application please select a number.");
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                ///calls methods
                switch (Console.ReadLine())
                {
                    case "1":
                        GetCircleRadius();
                        break;
                    case "2":
                        ChangeCircleRadius();
                        break;
                    case "3":
                        GetCircleCircumfrence();
                        break;
                    case "4":
                        GetCircleArea();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invaild Number: please enter a number");
                        break;
                }
            }
            /// displays radius
            void GetCircleRadius()
            {
                Console.WriteLine("Circle Radius : " + circle.GetRadius().ToString());
                Menu();
            }
            /// changes radius
            void ChangeCircleRadius()
            {
                Console.WriteLine("Enter a new Radius");

                if (int.TryParse(Console.ReadLine(), out userRadius))
                {

                    circle.SetRadius(userRadius);
                    Console.WriteLine("Circle Radius : " + circle.GetRadius().ToString());
                }
                else
                {
                    Console.WriteLine("Invalid Number :Please enter a number");
                    ChangeCircleRadius();
                }
                Menu();

            }
            /// displays circumfrence
            void GetCircleCircumfrence()
            {
                Console.WriteLine("Circle Circumfrence :" + circle.GetCircumference().ToString());
                Menu();
            }
            /// gets circle area
            void GetCircleArea()
            {
                Console.WriteLine("Circle Area :" + circle.GetArea().ToString());
                Menu();
            }
        }
    }
}
