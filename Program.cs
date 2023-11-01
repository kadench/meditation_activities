using System;

// Main class Program runs the basic methods for the entire program.
class Program {
        static void Main(string[] args) {
            khMenu();
            string khUsersMenuChoice = khMenuChoice();
            khCallActivity(khUsersMenuChoice);
            
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
                string[] khReflectionActivityStrings =  {"reflection activity", "reflection", "r", "1"};
                string[] khBreathingActivityStrings =  {"breathing activity", "breathing", "b", "2"};
                string[] khListingActivityStrings =  {"listing activity", "listing", "l", "3"};
                if (khReflectionActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 1;
                        Activity khNewActivity = new Activity(khIntMenuChoice);
                }

                else if (khBreathingActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 2;
                        Activity khNewActivity = new Activity(khIntMenuChoice);

                }

                else if (khListingActivityStrings.Contains(khMenuChoice)) {
                        int khIntMenuChoice = 3;
                        Activity khNewActivity = new Activity(khIntMenuChoice);

                }
                         
        }
        }
