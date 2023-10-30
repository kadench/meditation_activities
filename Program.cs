using System;

class Program {
        static void Main(string[] args) {
            Menu();
            MenuChoice();
        }

        // Displays a menu for the user
        static void Menu()
        {
                print("Welcome to the meditation activity!");
                print("");
                print(" Available Activities ");
                print("----------------------");
                print("1. Reflection Activity");
                print("2. Breathing Activity");
                print("3. Listing Activity");
                print("----------------------");
        }

        // Calls the correct Activity through the number chosen
        static Activity MenuChoice() {
                string khActivity = inputstr("Choose an activity: ");
                        Activity khChosenActivity = new Activity(khActivity);
                        return khChosenActivity; 
        }

        // Changes Console.WriteLine to print for simplicity reasons
        static void print(string khStringToPrint) {
                Console.WriteLine(khStringToPrint);
        }
        
        // Changes Console.ReadLine to inputstr for simplicity reasons
        static string inputstr(string khStringToPrint) {
                Console.Write(khStringToPrint);
                string khReadLine = Console.ReadLine();
                return khReadLine;
        }
}