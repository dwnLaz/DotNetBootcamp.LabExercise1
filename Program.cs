using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            while (true)
            {
                Console.Write("\nEnter Length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                decimal area = length * width;
                decimal perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Area: {0}\nPerimeter: {1}", area, perimeter);

                while (true)
                {
                    Console.Write("Continue? (y/n): ");
                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        Number1();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("\nThank you!");
                        Console.Write("Back to Main Menu?\n(y to continue/any key to exit): ");
                        choice = Console.ReadLine();
                        if (choice == "y" || choice == "Y")
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(-1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice!\nPlease Enter a valid choice");
                        System.Threading.Thread.Sleep(1000);
                        continue;
                    }
                }
            }
        }

        static void Number2()
        {
            while (true)
            {
                Console.Write("\nEnter numerical Grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade >= 88 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else if (grade >= 80 && grade <= 87)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade >= 67 && grade <= 79)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade >= 60 && grade <= 66)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else if (grade < 60 && grade >= 0)
                {
                    Console.WriteLine("Letter grade: F");
                }
                else
                {
                    Console.WriteLine("Please Input a valid grade! (Grade: 0 - 100)");
                    Console.Write("Continue? (y to continue/any key to exit): ");
                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nThank you!");
                        Console.Write("Back to Main Menu?\n(y to continue/any key to exit): ");
                        choice = Console.ReadLine();
                        if (choice == "y" || choice == "Y")
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(-1);
                        }
                    }
                }

                while (true)
                {
                    Console.Write("Continue? (y/n): ");
                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        Number2();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("\nThank you!");
                        Console.Write("Back to Main Menu?\n(y to continue/any key to exit): ");
                        choice = Console.ReadLine();
                        if (choice == "y" || choice == "Y")
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(-1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice!\nPlease Enter a valid choice");
                        System.Threading.Thread.Sleep(1000);
                        continue;
                    }
                }
            }
        }

        static void Number3()
        {
            while (true)
            {
                Console.Write("\nEnter a file size (MB): ");
                decimal fileSizeInMegabytes = Convert.ToDecimal(Console.ReadLine());
                decimal fileSizeInKilobytes = 1024 * fileSizeInMegabytes;
                //decimal convertedValue = fileSizeInKilobytes / Convert.ToDecimal(5.2);
                decimal inSecondsValue = (fileSizeInKilobytes / 5.2M) % 60;
                decimal inMinutesValue = (fileSizeInKilobytes / (5.2M * 60)) % 60;
                decimal inHoursValue = fileSizeInKilobytes / (5.2M * 3600);


                Console.WriteLine("A \"56k\" modem will take {0} hours {1} minutes {2} seconds\n",
                Math.Floor(inHoursValue), Math.Floor(inMinutesValue), Math.Floor(inSecondsValue));

                //TimeSpan time = TimeSpan.FromSeconds((double)convertedValue);
                //string computedTime = string.Format(" A \"56k\" modem will take {0} hours {1} minutes {2} seconds\n",
                //time.Hours, time.Minutes, time.Seconds);
                //Console.WriteLine(computedTime);

                while (true)
                {
                    Console.Write("Continue? (y/n): ");
                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        Number3();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("\nThank you!");
                        Console.Write("Back to Main Menu?\n(y to continue/any key to exit): ");
                        choice = Console.ReadLine();
                        if (choice == "y" || choice == "Y")
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(-1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice!\nPlease Enter a valid choice");
                        System.Threading.Thread.Sleep(1000);
                        continue;
                    }
                }
            }
        }

        static void Number4()
        {
            Console.Write("Enter square size: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < squareSize; i++)
            {
                Console.Write("*");
                for (int j = 1; j < squareSize; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Write("\nBack to Main Menu?\n(y to continue/any key to exit): ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(-1);
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select Execise");
                Console.WriteLine("[1] - Exercise No. 1");
                Console.WriteLine("[2] - Exercise No. 2");
                Console.WriteLine("[3] - Exercise No. 3");
                Console.WriteLine("[4] - Exercise No. 4");
                Console.WriteLine("[5] - Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\nWelcome to the Area and Perimeter Calculator");
                        Number1();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\nWelcome to the Letter Grade Calculator");
                        Number2();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\nWelcome to the Download Time Estimator");
                        Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem.");
                        Number3();
                        break;
                    case "4":
                        Console.Clear();
                        Number4();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Thank you");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice!\nReturning to Menu...");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
