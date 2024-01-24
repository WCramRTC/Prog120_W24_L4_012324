namespace Prog120_W24_L4_012324
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StarterCode();

        } // Main

        public static void StarterCode()
        {
            // Label to loop to
        start:
            Console.Clear(); // Clear the console for a cleaner menu

            
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display a range of numbers");
            Console.WriteLine("2. Sum a range of numbers");
            Console.WriteLine("3. Get the average of a range of numbers");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            string stringChoice = Console.ReadLine();
 
            // 
            if (stringChoice == "1")
            {
                DisplayRangeOfNumber();
                Console.ReadKey();

            }
            else if (stringChoice == "2")
            {
                Console.WriteLine("This code will display the sum of a range of numbers.");
                // Write code to calculate a sum of a range of numbers here
                SumOfNumbers();
                Console.ReadKey();

            }
            else if (stringChoice == "3")
            {
                Console.WriteLine("This code will display the average of a sum of numbers");
                // Write code to calculate an average of a sum of numbers here

                Average();
                Console.ReadKey();

            }
            else if (stringChoice == "4")
            {
                // Exit
                Console.WriteLine("Exiting program...");
                // Write code to exit console here
                goto exit;

            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            }
            goto start;
            exit;            

            

        } // StarterCode

        public static void Average()
        {
            //StarterCode();

            // 5 6 7

            // Expect
            // 1
            // 2
            // 3
            // 4
            // 5

            // ---------------
            // They enter a number to start
            Console.Write("Enter a starting number: ");
            string startingNumber = Console.ReadLine();
            int userNumber = int.Parse(startingNumber);

            Console.Write("Enter a ending number: ");
            string endingNumber = Console.ReadLine();
            int userEndingNumber = int.Parse(endingNumber);

            int starting = userNumber;
            int end = userEndingNumber;
            int numberOfElements = end - starting + 1;
            int sum = 0;

        // goto and label
        loop:
            // Repeating the code inside the loop over and over again
            // Output

            // Display starting number to console
            Console.WriteLine(starting);
            // Increment starting number by 1

            sum += starting;

            starting++;

            // If the number is LESS THAN 5
            if (starting <= end)
            {
                // goto name semicolon
                goto loop;
            }

            double average = sum / (double)numberOfElements;

            Console.WriteLine($"The sum of your numbers are {sum}");
            Console.WriteLine($"The average of your numbers is {average}");


        }

        public static void SumOfNumbers()
        {

            // 5 6 7

            // Expect
            // 1
            // 2
            // 3
            // 4
            // 5

            // ---------------
            // They enter a number to start
            Console.Write("Enter a starting number: ");
            string startingNumber = Console.ReadLine();
            int userNumber = int.Parse(startingNumber);

            Console.Write("Enter a ending number: ");
            string endingNumber = Console.ReadLine();
            int userEndingNumber = int.Parse(endingNumber);

            int starting = userNumber;
            int end = userEndingNumber;
            int sum = 0;

        // goto and label
        loop:
            // Repeating the code inside the loop over and over again
            // Output

            // Display starting number to console
            Console.WriteLine(starting);
            // Increment starting number by 1

            sum += starting;

            starting++;


            // If the number is LESS THAN 5
            if (starting <= end)
            {
                // goto name semicolon
                goto loop;
            }

            Console.WriteLine($"The sum of your numbers are {sum}");

        }

        public static void DisplayRangeOfNumber()
        {
            Console.WriteLine("This code will display a range of numbers");
            // They enter a number to start
            Console.Write("Enter a starting number: ");
            string startingNumber = Console.ReadLine();
            int userNumber = int.Parse(startingNumber);

            Console.Write("Enter a ending number: ");
            string endingNumber = Console.ReadLine();
            int userEndingNumber = int.Parse(endingNumber);


            int count = userNumber;
            int end = userEndingNumber;


        // ------


        //    count = count + 1;

        start:

            Console.WriteLine(count);
            count++;

            // Comparison Operators
            // <, >, <=, >=

            if (count <= end)
            {
                goto start;
            }
        } // End of DisplayRangeOfNumbers

        public static void GotoNotes()
        {
            // CompletedCode.Run();
            // StarterCode();

            // Loop
            // Keywords
            // Goto 
            // Label


            //------

            // If the label is BEFORE the goto, it's loop code
            // If the label is AFTER the goto, it skips code

            // Example of how to skip lines
            // Do not use
            // Use a condition instead
            //Console.WriteLine("First Line");

            //goto skipline;

            // if(false) {
            //Console.WriteLine("Middle Line");
            //  }


            //skipline:

            //Console.WriteLine("Last Line");
        }

    } // class

} // namespace
