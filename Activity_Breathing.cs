// Purpose: Runs the breathing activity.
// Authorship: By Kaden Hansen Copyright © 11/4/23,
// Sources:
// https://stackoverflow.com/questions/5945533/how-to-execute-the-loop-for-specific-time | Implemented the time duration in the loop for each activity.
// https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0 | Implement Thread.Sleep
// https://learn.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-7.0 | Learning how to make title case text
// https://chat.openai.com/c/4ef1f98f-186c-4023-ad60-748d883d03a6 | Formatting and other solution help.
// https://byui-cse.github.io/cse210-course-2023/unit04/develop.html | Used to structure the class and how it should look.
// https://github.com/LisaCJHeinhold | Used Lisa's code for help on parts.
// https://github.com/eeshurtliff | Got help with the animation and calls to different classes.
class BreathingActivity : Activity
{

    private List<string> _khSevenNumberList = new List<string>{"7", "6", "5", "4", "3", "2", "1"};
    private List<string> _khFourNumberList = new List<string>{"4", "3", "2", "1"};

    // Breathing Constructor
    public BreathingActivity(string khActivityName) : base(khActivityName) {}

    // Allows the user to choose their breathing setting.
    private int Kh4or7() {
    bool khUserInputValid = false;
    int khChosenSetting = 0;

    while (!khUserInputValid)
    {
        Thread.Sleep(1000);
        Console.WriteLine("1. Breathe in/out for four seconds, four times | 2. Breathe in/out for seven seconds, seven times.");
        Console.Write("Which breathing exercise do you want to do?: ");
        string khBreathingExerciseUserChoice = Console.ReadLine();

        if (khBreathingExerciseUserChoice == "1")
        {
            khUserInputValid = true;
            khChosenSetting = 4; 
        }
        else if (khBreathingExerciseUserChoice == "2")
        {
            khUserInputValid = true;
            khChosenSetting = 7;
        }
        else
        {
            Console.WriteLine($"\"{khBreathingExerciseUserChoice}\" does not match any valid response.");
            Console.Write("Press the enter key to try again: ");
            Console.ReadLine();
        }
    }

    return khChosenSetting;
    }
    
    // Starts the breathing activity    
    public void KhStartActivity()
{
    KhStartingMessage(_khActivityName);
    int khBreathingDuration = Kh4or7();
    
    for (int i = 1; i <= 4; i++) {
        // Continue the loop until 4 breaths are completed
            Console.Clear();
            Console.WriteLine("Follow the breathing exercise:");
            Thread.Sleep(1000);
            Console.Write("Breathe in: ");
            if (khBreathingDuration == 4) {
                KhCreateAnimation(_khFourNumberList, khBreathingDuration, 12);
            }
            else {
                KhCreateAnimation(_khSevenNumberList, khBreathingDuration, 12);
            }
            int khCurrentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write("Pause.       ");
            Thread.Sleep(2000);
            khCurrentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, khCurrentLineCursor);

            Console.Write("Breathe out: ");
            if (khBreathingDuration == 4) {
                KhCreateAnimation(_khFourNumberList, khBreathingDuration, 13);
            }
            else {
                KhCreateAnimation(_khSevenNumberList, khBreathingDuration, 13);
            }
            khCurrentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write("Pause.       ");
            Thread.Sleep(2000);
            khCurrentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, khCurrentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, khCurrentLineCursor);
        }

    Console.WriteLine("That's it! You have completed the breathing exercise.");
}

}
