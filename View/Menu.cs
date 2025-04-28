using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Menu
{

    public static bool MainMenu()
    {
        DigiController controller = new DigiController();




        Console.Clear();
        Console.WriteLine("Welcome to a pretty raw database for the digimon from the game Digimon cyber sleuth.");
        Console.WriteLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Display all digimon in numeric order, with all stats.");
        Console.WriteLine("2. Display all digimon by who has the highest stat, ascending or descending, you choose the stat.");
        Console.WriteLine("3. Display the best digimon by stat, you choose how many to display.");
        Console.WriteLine("4. Exit.");

        switch (Console.ReadLine())
        {
            case "1":
                controller.DisplayAllDigisAndInfo();
                Console.WriteLine("All digimon shown, press any key to go back to main menu");
                Console.ReadKey();
                return true;

            case "2":
                AscOrDesc();
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadKey();
                return true;

            case "3":
                return true;

            case "4":
                return false;
            default:
                Console.WriteLine("Error: wrong input. Press Enter to try again.");
                Console.ReadLine();
                return true;
        }

    }

    public static string AscOrDesc()
    {
        string aOrDChoice = "";
        bool aOrDLoop = true;
        DigiController controller = new DigiController();
        do
        {

            Console.Clear();
            Console.WriteLine("Ascending or Descending? write 'asc' or 'desc'");
            aOrDChoice = Console.ReadLine().ToLower().Trim().Replace(" ", "");
            if (aOrDChoice == "asc")
            {
                string statChoice = StatChoice();
                controller.DisplayDigisBystatsAscending(statChoice);
                return aOrDChoice;
            }
            else if (aOrDChoice == "desc")
            {
                string statChoice = StatChoice();
                controller.DisplayDigisBystatsDescending(statChoice);
                return aOrDChoice;
            }
        } while (aOrDLoop);
        return aOrDChoice;
    }
    public static string StatChoice()
    {
        bool statLoop = true;

        string input = "";
        do
        {

            Console.WriteLine("What stat do you want to sort by, 'atk', 'hp', 'def', 'int' 'sp', or 'spd'");

            input = Console.ReadLine().ToLower().Trim().Replace(" ", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty.");
                statLoop = true;

            }
            else if (input == "atk" || input == "hp" || input == "def" || input == "int" || input == "sp" || input == "spd")
            {
                statLoop = false;
            }
            else
            {
                Console.WriteLine("Input was incorrect.");
                statLoop = true;
            }

        } while (statLoop);
        return input;
    }
}