class Activity {
    protected string _khActivityName;
    protected string _khDescription;
    private int _khDuration;
    private List<string> _khAnimation = new List<string>{"|", "/", "-", "\\"};

    // Assigns activity information
    public Activity(string khChosenActivity) {
        _khActivityName = khChosenActivity;
        if (_khActivityName == "reflection") {
            _khDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_khActivityName == "breathing") {
            _khDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else {
            _khDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }
    
    // Writes the starting message of the activity
    private void khStartingMessage(string _khActivityName) {
        Console.WriteLine($"You chose to do the {_khActivityName} Activity");
        Console.WriteLine("");
        Console.WriteLine($"{_khDescription}");
        
        bool khDurationTrue = false;
        do {
        Console.Write("What is the duration you'd like the activity at?: ");
        try {
            int khDuration = int.Parse(Console.ReadLine());
            khDurationTrue = true;
            _khDuration = khDuration;
        }
        catch {
            Console.WriteLine("The input is not a number. Try again.");
        }
        } while(khDurationTrue == false);
    }

    // Sets the animation of the list
    static void khCreateAnimation(List<string> _khAnimation, int time) {
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
 
        int i = 0;
 
        while (DateTime.Now < endTime)
        {
            string s = _khAnimation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            i++;
 
            if (i >= _khAnimation.Count)
            {
                i = 0;
            }
        }
 
    }


    }

    private void khRunActivity() {
        khStartingMessage();
        DateTime khStartDate = 
    }

}
