// Purpose: Be a base class for all child activities that will use the activity's methods,
// Authorship: By Kaden Hansen Copyright © 11/4/23,
// Sources:
// https://stackoverflow.com/questions/5945533/how-to-execute-the-loop-for-specific-time | Implemented the time duration in the loop for each activity.
// https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0 | Implement Thread.Sleep
// https://learn.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-7.0 | Learning how to make title case text
// https://chat.openai.com/c/4ef1f98f-186c-4023-ad60-748d883d03a6 | Formatting and other solution help.
// https://byui-cse.github.io/cse210-course-2023/unit04/develop.html | Used to structure the class and how it should look.
// https://github.com/LisaCJHeinhold | Used Lisa's code for help on parts.
// https://github.com/eeshurtliff | Got help with the animation and calls to different classes.

using System.Globalization;

class Activity {
    protected string _khActivityName;
    protected string _khDescription;
    protected int _khDuration;
    protected List<string> _khAnimation = new List<string>{"|", "/", "-", "\\"};

    // Assigns activity information
    public Activity(string khActivityName) {
        // Makes the activity name title case.
        TextInfo khTitleCaseWord = new CultureInfo("en-US",false).TextInfo;
        _khActivityName = khTitleCaseWord.ToTitleCase(khActivityName);

        // Assigns the right desc. from the title name
        if (_khActivityName == "Reflection") {
            _khDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_khActivityName == "Breathing") {
            _khDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else {
            _khDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }
    
    // Gets a random index from a specific list.
    protected int KhGetRandomIndexFromList(List<string> khSpecificList) {
        Random khRandom = new Random();
        int khRandomIndex = khRandom.Next(khSpecificList.Count);
        return khRandomIndex;
    }



    // Writes the starting message of the activity
    protected void KhStartingMessage(string _khActivityName) {

        Thread.Sleep(100);
        Console.WriteLine($"You chose to do the {_khActivityName} Activity:");
        Thread.Sleep(1000);
        Console.WriteLine($"{_khDescription}");
        string UserContinue = KhContinueWithActivity();
        
        bool khDurationTrue = false;
        if (UserContinue == "y") {
            do {
            Console.Clear();
            Console.WriteLine($"{_khActivityName} Activity Setup:");
            Thread.Sleep(1000);
            Console.Write("How much time do you want to spend on this activity in minutes?: ");
            try {
                int khDuration = int.Parse(Console.ReadLine());
                // Changes the given minutes to seconds
                khDuration *= 60;
                khDurationTrue = true;
                _khDuration = khDuration;
            }
            catch {
                Thread.Sleep(1000);
                Console.WriteLine("The input is not a number.");
                Thread.Sleep(1000);
                Console.Write("Press the enter key to try again: ");
                Console.ReadLine();
                Console.Clear();
        }
        } while(khDurationTrue == false);
        }
    }

    // Makes sure the user wants to do the selected activity
    protected string KhContinueWithActivity(){
        bool KhContinueWithActivityBool = false;
        string khActivityContinueUserChoice = "";
        do {
            Thread.Sleep(1000);
            Console.Write("Do you want to do this activity? (y/n): ");
            khActivityContinueUserChoice = Console.ReadLine();
        if (khActivityContinueUserChoice.ToLower() == "y") {
            KhContinueWithActivityBool = true;
        }
        else if (khActivityContinueUserChoice.ToLower() == "n") {
            KhContinueWithActivityBool = true;
        }
        else {
            Thread.Sleep(50);
            Console.WriteLine("The input is not a \"y\" or \"n\" response.");
            Thread.Sleep(1000);
            Console.Write("Press the enter key to try again: ");
            Console.ReadLine();
            Console.Clear();
            KhContinueWithActivityBool = false;
        }
        } while(KhContinueWithActivityBool == false);
        return khActivityContinueUserChoice;
    }

    // Sets up the animation list animation.
    protected void KhCreateAnimation(List<string> _khAnimation, int time, int khWordLength) {
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
 
        int i = 0;
 
        while (DateTime.Now < endTime)
        {
            string khAnimationItem = _khAnimation[i];
            Console.Write(khAnimationItem);
            Thread.Sleep(1000);
            int khCurrentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(khWordLength, khCurrentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(khWordLength, khCurrentLineCursor);
            
            i++;
 
            if (i >= _khAnimation.Count)
            {
                i = 0;
            }
        }
 
    }

}
    
    // Writes the information before the activity starts.
    public void KhBeforeActivity() {
        Console.WriteLine();
        Console.Write("Please Wait ");
        KhCreateAnimation(_khAnimation, 3, 12);
        Console.Clear();
}

}