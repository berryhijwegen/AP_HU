using System;

namespace Vierkant
{
    class main
    {
        static void Main(string[] args)
        {
            Vierkant vierkant = new Vierkant();
            Console.WriteLine("Hoe groot?");
            int userInputInt = -1;
            String userInput = "";
            Boolean validInput = false;
            while(!validInput){
                try {
                    userInput = Console.ReadLine();
                    userInputInt = Int32.Parse(userInput);
                    validInput = true;
                }
                catch (FormatException){
                    Console.WriteLine($"Voer een nummer in! '{userInput}' is geen nummer!");
                }
            }
            
            vierkant.maakVierkant(userInputInt);
        }
    }
}
