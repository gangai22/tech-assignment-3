// Author:Tichaona Gangaidzo 
// Date: 9/20/2021
// Tech Assignment #3: Use of iterative statements while getting input from user

namespace tech_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the kilometer input and the mile as integers
            int kilometer, kilometer_input;
            decimal mile_equiv;
            kilometer = 0;
            // Ask user for input 
            Console.WriteLine("Helllo, please enter a kilometer value ranging between 10 and 25");

            kilometer_input = covert.ToInt32(Console.ReadLine());

            try
            {
                // This variable gathers information form the user input
                string input = Console.ReadLine();
                // This variable will be used to perform the iteravtive statements and is an integer

                int Kilometer_input = int.Parse(input);

                if((kilometer_input >=10 ) && (kilometer_input<=25)) 
                {
                    Console.WriteLine("The kilometer value is: " + kilometer_input);
                    Console.WriteLine("kilometer    Miles");

                    //The Kilometer to miles converstion caluculation
                    do
                    {
                        mile_equiv = kilometer * 0.621371;
                        Console.WriteLine(Kilometer_input + "   "  mile_equiv);

                        // Increseing kilometers by the increment 
                        kilometer = kilometer + Kilometer_input;

                    } while (kilometer <= 200);
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);

                }
            }// End of try
            catch
            {
                Console.WriteLine("Helllo, please enter a kilometer value ranging between 10-25 and try again... ");
                Console.WriteLine("Press any key to exit the program and try again... ");
                Console.ReadKey(true);

            }// End of catch




        }
    }
}
