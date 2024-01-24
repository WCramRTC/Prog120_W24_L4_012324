Certainly, here's the same menu implemented with `GOTO` statements as you requested:

```csharp
using System;

class Program
{
    static void Main()
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

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
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
            for (int i = start; i <= end; i++)
            {
                sum += i;
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
            for (int i = start; i <= end; i++)
            {
                average += i;
                count++;
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
    }
}
```

This version of the menu uses `GOTO` statements as requested to loop through options until the user chooses to exit. However, please keep in mind that using `GOTO` is generally not recommended in modern programming due to its potential for making code less readable and maintainable.