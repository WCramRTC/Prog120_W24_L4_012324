using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prog120_W24_L4_012324
{
    internal static class CompletedCode
    {
        public static void Run()
        {
        start:
            Console.Clear(); // Clear the console for a cleaner menu

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display a range of numbers");
            Console.WriteLine("2. Sum a range of numbers");
            Console.WriteLine("3. Get the average of a range of numbers");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto start; // Return to the start of the menu
            }

            if (choice == 1)
            {
                // Display a range of numbers
                Console.Write("Enter the start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter the end number: ");
                int end = int.Parse(Console.ReadLine());

                int current = start;
            display_numbers_loop:
                if (current <= end)
                {
                    Console.Write(current + " ");
                    current++;
                    goto display_numbers_loop;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                goto start; // Return to the start of the menu
            }
            else if (choice == 2)
            {
                // Sum a range of numbers
                Console.Write("Enter the start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter the end number: ");
                int end = int.Parse(Console.ReadLine());

                int sum = 0;
                int current = start;
            sum_numbers_loop:
                if (current <= end)
                {
                    sum += current;
                    current++;
                    goto sum_numbers_loop;
                }

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto start; // Return to the start of the menu
            }
            else if (choice == 3)
            {
                // Get the average of a range of numbers
                Console.Write("Enter the start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter the end number: ");
                int end = int.Parse(Console.ReadLine());

                double average = 0;
                int count = 0;
                int current = start;
            average_numbers_loop:
                if (current <= end)
                {
                    average += current;
                    count++;
                    current++;
                    goto average_numbers_loop;
                }

                average /= count;
                Console.WriteLine("Average: " + average);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto start; // Return to the start of the menu
            }
            else if (choice == 4)
            {
                // Exit
                Console.WriteLine("Exiting program...");
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto start; // Return to the start of the menu
            }

        } // main


    } // class

} // namespace
