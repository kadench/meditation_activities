// Purpose: Runs the Listing Activity
// Authorship: By Kaden Hansen Copyright © 11/4/23,
// Sources:
// https://stackoverflow.com/questions/5945533/how-to-execute-the-loop-for-specific-time | Implemented the time duration in the loop for each activity.
// https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0 | Implement Thread.Sleep
// https://learn.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-7.0 | Learning how to make title case text
// https://chat.openai.com/c/4ef1f98f-186c-4023-ad60-748d883d03a6 | Formatting and other solution help.
// https://byui-cse.github.io/cse210-course-2023/unit04/develop.html | Used to structure the class and how it should look.
// https://github.com/LisaCJHeinhold | Used Lisa's code for help on parts.
// https://github.com/eeshurtliff | Got help with the animation and calls to different classes.

class ListingActivity : Activity {

    private List<string> _khPrompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    private List<string> _khPonderCountdown = new List<string>{};
    private string _khPrompt;

    private int _khThoughtsThrough = 0;

    // ReflectionActivity Constructor
    public ListingActivity(string khActivityName) : base(khActivityName) {
        for (int i = 30; i >= 1; i--)
        {
            _khPonderCountdown.Add($"{i}");
        }
        
        // Gets the prompt for the current session
        int khRandomPromptIndex = KhGetRandomIndexFromList(_khPrompts);
        KhSetRandomPrompt(khRandomPromptIndex);
    }

    private void KhSetRandomPrompt(int khRandomIndex) {
        string khRandomString = _khPrompts[khRandomIndex];
        _khPrompt = khRandomString;
    }

    public void KhStartActivity() {
        KhStartingMessage(_khActivityName);
        Console.Clear();
        Console.WriteLine("Please think about the following prompt for 30 seconds. You will be asked questions about it later:");
        Thread.Sleep(1000);
        Console.WriteLine(_khPrompt);
        Console.Write("Time left: ");
        KhCreateAnimation(_khPonderCountdown, 30, 11);
        Console.Write("0");
        Console.WriteLine();
        var khStartTime = DateTime.UtcNow;
    
        Console.WriteLine($"Please write all of the responses from the 30 second prompt you can think of in the next {_khDuration / 60} minute(s):");
        // Do the activity for the set duration but let them finish whatever question they're on.
        while (DateTime.UtcNow - khStartTime < TimeSpan.FromSeconds(_khDuration)) {
            Console.Write("> ");
            _khThoughtsThrough += 1;
            Console.ReadLine();
            // Checks if time is up before going onto the next question.
            if (DateTime.UtcNow - khStartTime >= TimeSpan.FromSeconds(_khDuration)) {
                break;
            }

        // Only say you've done it if the user answers one question. Otherwise the choice might've been a mistake.
        if (_khThoughtsThrough > 0) {
            Thread.Sleep(1000);
            Console.WriteLine($"Time's up! You thought of {_khThoughtsThrough} different thing(s) in {_khDuration / 60} minute(s)! Well done!");
            Thread.Sleep(1000);
            Console.Write($"Take some time to reflect over your answers or write them down. They will not be saved! (Press enter when you're ready to end.): ");
            Console.ReadLine();
            break;
        }
 

    break;
    }
    }
}