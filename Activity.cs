class Activity {
    private string _khActivityName;
    private string _khDescription;
    private int _khDuration;
    protected List<string> _khPrompt;
    private List<string> _khAnimation;

    // Assigns activity information
    public void SetActivityInfo(string khChosenActivity) {
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
    static void khStartingMessage(string _khActivityName) {
        Console.WriteLine($"Starting the {_khActivityName} Activity");
    }





}