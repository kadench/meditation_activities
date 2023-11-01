using System;

// Main class Program runs the basic methods for the entire program.
class Program {
        static void Main(string[] args) {
        // repeat running program until user quits. 
        
        // Set bool to false and run the program until true.
        bool khContinueProgram = true;
        do {
            khMenu();
            string khUsersMenuChoice = khMenuChoice();
            khCallActivity(khUsersMenuChoice);
            khContinueProgram = khProgramEndMessage();
           } while(khContinueProgram == true);
            
        }

        // Displays a menu for the user
        static void khMenu()
        {
                Console.WriteLine("Welcome to the meditation activity!");
                Console.WriteLine("");
                Console.WriteLine(" Available Activities ");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Reflection Activity");
                Console.WriteLine("2. Breathing Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("----------------------");
        }

        // Gets the user's chosen activity.
        static string khMenuChoice() {
                Console.Write("Choose an activity: ");
                string khActivity = Console.ReadLine();
                        return khActivity.ToLower(); 
        }
        
        // Uses the user's input to trigger a certain activity.
        static void khCallActivity(string khMenuChoice) {
                
                // Create lists for accepted triggers for each activity
                string[] khReflectionActivityStrings =  {"reflection activity", "reflection", "r", "1"};
                string[] khBreathingActivityStrings =  {"breathing activity", "breathing", "b", "2"};
                string[] khListingActivityStrings =  {"listing activity", "listing", "l", "3"};

                // Trigger the specified activity if the input matches a string from one of the lists.
                if (khReflectionActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 1;
                        Activity _ = new Activity(khIntMenuChoice); // Not giving the activity a variable name as it is not called in the program class.
                }

                else if (khBreathingActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 2;
                        Activity _ = new Activity(khIntMenuChoice); // Not giving the activity a variable name as it is not called in the program class.

                }

                else if (khListingActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 3;
                        Activity _ = new Activity(khIntMenuChoice); // Not giving the activity a variable name as it is not called in the program class.

                }
                
                else {
                        Console.WriteLine($"\"{khMenuChoice}\" does not match any of the above activities. Try again.");
                        Console.Write("Press the enter key to continue: ");
                        Console.ReadLine();
                }
                         
                }
        
        // Runs the program ending
        static bool khProgramEndMessage() {
                // Asks the user if they want to do another activity until they answer y or n.
                do {
                Console.Write("Do you want to do another activity? (y/n): ");
                string khUserAnswer = Console.ReadLine();

                if (khUserAnswer.ToLower() == "y") {
                        return true;
                }
                else if (khUserAnswer.ToLower() == "n") {
                        return false;
                }
                else {
                        Console.WriteLine($"\"{khUserAnswer}\" is not a valid response. Try again.");
                        Console.Write("Press the enter key to continue: ");
                        Console.ReadLine();
                }
                  } while(true);
            }
        }
