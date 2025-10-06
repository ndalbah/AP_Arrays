using System;
namespace prjConCsArrays
{
    public static class project
    {
        public static void pro()
        {
            Int16 choice, add;
            Single vals;
            string yn;

            Console.WriteLine("\t\tNUMERIC CALCULATOR");
            Console.WriteLine("\tMain Menu Operators Choice");
            Console.WriteLine("\t--------------------------\n");
            Console.WriteLine("1 - ADDITION");
            Console.WriteLine("2 - DIVISION");
            Console.WriteLine("3 - MULTIPLICATION");
            Console.WriteLine("4 - SUBSTRACTION");
            Console.WriteLine("5 - QUIT\n");
            Console.Write("Make your choice (1 - 5) : ");
            choice = Convert.ToInt16(Console.ReadLine());
            do
            {
                if (choice == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tADDITION OPERATION");
                        Console.WriteLine("\t\t------------------\n");
                        Console.Write("Enter the number of values to add : ");
                        add = Convert.ToInt16(Console.ReadLine());
                        Single sum = 0;
                        for (Int16 i = 0; i < add; i++)
                        {
                            Console.Write("\tEnter value " + (i + 1) + " : ");
                            vals = Convert.ToSingle(Console.ReadLine());
                            sum += vals;
                        }
                        Console.WriteLine("\t\t\t------");
                        Console.WriteLine("\tThe Result is " + sum + "\n");
                        Console.WriteLine("Do you want to do another addition ? (y/n) : ");
                        yn = Console.ReadLine();
                    } while (yn == "y");

                }
                else if (choice == 2)
                {
                    Console.WriteLine("division");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Multiplication");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("substraction");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("quit");
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tNUMERIC CALCULATOR");
                        Console.WriteLine("\tMain Menu Operators Choice");
                        Console.WriteLine("\t--------------------------\n");
                        Console.WriteLine("1 - ADDITION");
                        Console.WriteLine("2 - DIVISION");
                        Console.WriteLine("3 - MULTIPLICATION");
                        Console.WriteLine("4 - SUBSTRACTION");
                        Console.WriteLine("5 - QUIT\n");
                        Console.Write("Make your choice: ");
                        choice = Convert.ToInt16(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("addition");
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("division");
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("Multiplication");
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("substraction");
                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine("quit");
                        }

                    } while (!(choice == 1 || choice == 2 || choice == 3 || choice == 3 || choice == 4 || choice == 5));
                }


            } while (!(choice == 5));

        }
    }
}
