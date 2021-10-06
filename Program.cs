using System;

namespace NumberAnalyzerLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prompt User to enter an integer between 1-100
            //2. Create variables to store within Console.ReadLine(); 
            //3. Establish if statements and logic
            //4. set of parameters to end program

            bool input = true;

            while (input)
            {
                {
                    Console.WriteLine("Enter your name: ");
                    string name = (Console.ReadLine()); 
                    Console.WriteLine("Enter an integer between 1 and 100.");
                    int num1 = int.Parse(Console.ReadLine());

                    if (num1 < 1 || num1 > 100)
                    {
                        Console.WriteLine("This is an invalid input." + $"\n You can only enter a number between 1 and 100 {name} "); 
                    }

                    if (num1 % 2 != 0)
                    {
                        Console.WriteLine($"{num1} is odd!");

                    }
                    else if (num1 % 2 == 0 && num1 >= 2 && num1 <= 25)

                    {
                        Console.WriteLine($"{num1} is even and less than 25.");
                    }
                    else if (num1 % 2 == 0 && num1 >= 26 && num1 <= 60)
                    {
                        Console.WriteLine("Even");

                    }
                    else if (num1 % 2 == 0 && num1 > 60)
                    {
                        Console.WriteLine($"{num1} is even!");

                    }
                    else if (num1 % 2 != 0 && num1 > 60)
                    {
                        Console.WriteLine($"{num1} is odd!");
                    }

                    Console.WriteLine("Continue? (y/n)");


                    string name1 = Console.ReadLine();

                    if (name1 == "Y" || name1 == "y")
                    {
                        input = true;
                    } else
                    {
                        input = false;
                        Console.WriteLine($"Bye! {name}"); 
                    }

                }

            }
        }

    }

}



            //            if (num1 % 2 != 0)
            //            {
            //                Console.WriteLine($"{num1} is odd!");

            //            } else if (num1 % 2 == 0 && num1 >= 2 && num1 <= 25)
            //            {

            //                Console.WriteLine($"{num1} is even and less than 25.");
            //            } 


            //            } else if (num1 % 2 == 0 && num1 >= 26 && num1 <= 60)

            //            {
            //                Console.WriteLine("Even");

            //            } else if (num1 % 2 == 0 && num1 > 60)

            //            {
            //                Console.WriteLine($"{num1} is even!");
            //            } else if (num1 % 2 != 0 && num1 > 60)

            //            {
            //                Console.WriteLine($"{num1} is odd!");
            //            }

            //            {

            //            }
            //        }
            //    }
            //}

        

  