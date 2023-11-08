// Purpose: The program class, or a class that will run all the other given classes.
// Authorship: By Kaden Hansen Copyright © 11/4/23,
// Sources:
// https://stackoverflow.com/questions/5945533/how-to-execute-the-loop-for-specific-time | Implemented the time duration in the loop for each activity.
// https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0 | Implement Thread.Sleep
// https://learn.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-7.0 | Learning how to make title case text
// https://chat.openai.com/c/4ef1f98f-186c-4023-ad60-748d883d03a6 | Formatting and other solution help.
// https://byui-cse.github.io/cse210-course-2023/unit04/develop.html | Used to structure the class and how it should look.
// https://github.com/LisaCJHeinhold | Used Lisa's code for help on parts.
// https://github.com/eeshurtliff | Got help with the animation and calls to different classes.

// Main class Program runs the basic methods for the entire program.
class Program {

        // Displays a menu for the user
        static void khMenu()
        {
                Console.Clear();
                // Welcome the user to the program
                Console.WriteLine("Welcome to the Meditation Activity Program (MAP) Menu!");
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
        static bool khCallActivity(string khMenuChoice) {
                
                // Create lists for accepted triggers for each activity
                string[] khReflectionActivityStrings =  {"reflection activity", "reflection", "r", "1"};
                string[] khBreathingActivityStrings =  {"breathing activity", "breathing", "b", "2"};
                string[] khListingActivityStrings =  {"listing activity", "listing", "l", "3"};

                // Trigger the specified activity if the input matches a string from one of the lists.
                if (khReflectionActivityStrings.Contains(khMenuChoice)) {
                        string khActivityChoice = "reflection";
                        ReflectionActivity khNewActivity = new ReflectionActivity(khActivityChoice);
                        khNewActivity.KhBeforeActivity();
                        khNewActivity.KhStartActivity();
                        return true;
                }

                else if (khBreathingActivityStrings.Contains(khMenuChoice)) {
                        string khActivityChoice = "breathing";
                        BreathingActivity khNewActivity = new BreathingActivity(khActivityChoice); 
                        khNewActivity.KhBeforeActivity();
                        khNewActivity.KhStartActivity();
                        return true;

                }

                else if (khListingActivityStrings.Contains(khMenuChoice)) {
                        string khActivityChoice = "listing";
                        ListingActivity khNewActivity = new ListingActivity(khActivityChoice);
                        khNewActivity.KhBeforeActivity();
                        khNewActivity.KhStartActivity();
                        return true;

                }
                
                else {
                        Console.WriteLine($"\"{khMenuChoice}\" does not match any of the above activities. Try again.");
                        Console.Write("Press the enter key to continue: ");
                        Console.ReadLine();
                        return false;
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
        
        // Runs the main program
        static void Main(string[] args) {
        // Set bool to false and run the program until true.
        bool khContinueProgram = true;
        
        // repeat running program until user quits. 
        do {
            khMenu();
            string khUsersMenuChoice = khMenuChoice();
            bool khValidAnswer = khCallActivity(khUsersMenuChoice);
            if (khValidAnswer == true) {
            khContinueProgram = khProgramEndMessage();
            }
           } while(khContinueProgram == true);
            
        }
        }
