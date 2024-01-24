namespace Prog120_W24_L4_012324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CompletedCode.Run();
            StarterCode();


        } // Main

        public static void StarterCode()
        {

            Console.Clear(); // Clear the console for a cleaner menu

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display a range of numbers");
            Console.WriteLine("2. Sum a range of numbers");
            Console.WriteLine("3. Get the average of a range of numbers");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            string stringChoice = Console.ReadLine();
 

            if (stringChoice == "1")
            {
                Console.WriteLine("This code will display a range of numbers");
                // Write code to display a range of numbers here
            }
            else if (stringChoice == "2")
            {
                Console.WriteLine("This code will display the sum of a range of numbers.");
                // Write code to calculate a sum of a range of numbers here
            }
            else if (stringChoice == "3")
            {
                Console.WriteLine("This code will display the average of a sum of numbers");
                // Write code to calculate an average of a sum of numbers here
            }
            else if (stringChoice == "4")
            {
                // Exit
                Console.WriteLine("Exiting program...");
                // Write code to exit console here

            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            }

        } // StarterCode

    } // class

} // namespace
