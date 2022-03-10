using System;

namespace LoopsAndBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExploreIf();
            // ExploreFor();
            // ExploreNestedLoop();

            void ExploreIf()
            {
                 int a = 9;
                 int b = 9;
                 /*
                 if (a + b > 10)
                    {
                        Console.WriteLine("The answer is greater than 10");
                    }

                    else
                    {
                        Console.WriteLine("The answer isn't greater than 10");
                    }
                  */

                    int c = 3;
                    if ((a + b + c > 10) && (a == b))
                    {
                        Console.WriteLine("The answer is greater than 10");
                        Console.WriteLine("And the first number is equal to the second");
                    }
                    else
                    {
                        Console.WriteLine("The answer is not greater than 10");
                        Console.WriteLine("Or the first number isn't equal to the second");
                    }

                    if ((a + b + c > 10) || (a == b))
                    {
                        Console.WriteLine("The answer is greater than 10");
                        Console.WriteLine("Or the first number is equal to the second");
                    }
                    else
                    {
                        Console.WriteLine("The answer is not greater than 10");
                        Console.WriteLine("And the first number isn't equal to the second");
                    }
            }
            void ExploreFor()
            {
                    /*
                    int counter = 0;
            
                    while (counter < 10)
                    {
                        Console.WriteLine($"Hello World! The counter is {counter}");
                        counter++;
                    }
           
                    do
                    {
                        Console.WriteLine($"Hello World! The counter is {counter}");
                        counter++;
                    } while (counter < 10);
                    */
                    for (int index = 157; index <2389735; index += 2738)
                    {
                        Console.WriteLine($"Hello World! The index is {index}");
                    }
            }

            void ExploreNestedLoop()
            {
                   for (int row = 1; row < 11; row++)
                   {
                        for (char column = 'a'; column < 'k'; column++)
                        {
                            Console.WriteLine($"The cell is ({row}, {column})");
                        }
                   }
            }

            int value3 = 0;
            for (int value = 1; value < 20; value++)
            {
                                if (value % 3 == 0)
                {
                    value3 = value + value3;
                    Console.WriteLine($"Current sum of integers divisable by 3 is {value3}.");
                }
            }
            



        }

    }
}
