using System.Globalization;
using Microsoft.VisualBasic;

class ReflectionActivity : Activity {
    private List<string> _khPrompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
    private List<string> _khQuestions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    private int _khQuestionsThrough;
    
    // Constructor for ReflectionActivity
    public ReflectionActivity(string khActivityName) : base(khActivityName) {
        _khQuestionsThrough = 0;
    }
    
    // Gets a random index from a specific list.
    private int KhGetRandomIndexFromList(List<string> khSpecificList) {
        Random khRandom = new Random();
        int khRandomIndex = khRandom.Next(khSpecificList.Count);
        return khRandomIndex;
    }

    // Selects a random string from the prompts list.
    private string KhChooseRandomPrompt(int khRandomIndex) {
        string khRandomString = _khPrompts[khRandomIndex];
        return khRandomString;
    }

    // Gets the prompt for the current session
    private string KhGetPrompt() {
        int khRandomPromptIndex = KhGetRandomIndexFromList(_khPrompts);
        string khRandomPrompt = KhChooseRandomPrompt(khRandomPromptIndex);
        return khRandomPrompt;
    }

    // Goes through the activity
    public void StartActivity() {
    KhStartingMessage(_khActivityName);
        Thread.Sleep(1000);
    string khPrompt = KhGetPrompt();
    var khStartTime = DateTime.UtcNow;
    
    // Do the activity for the set duration but let them finish whatever question they're on.
    while (DateTime.UtcNow - khStartTime < TimeSpan.FromSeconds(_khDuration)) {
        Console.Clear();
        Console.WriteLine("Please think about the following prompt. You will be asked questions about it later:");
        Thread.Sleep(1000);
        Console.WriteLine(khPrompt);
        Thread.Sleep(1000);
        Console.Write("Press enter when ready to answer the questions for this prompt: ");
        Console.ReadLine();

        for (int i = 0; i < _khQuestions.Count; i++) {
            
            // Checks if time is up before going onto the next question.
            if (DateTime.UtcNow - khStartTime >= TimeSpan.FromSeconds(_khDuration)) {
                break;
            }

            // Waits and asks the next question
            Thread.Sleep(1000);
            Console.Write($"{_khQuestions[i]}: ");
            Console.ReadLine();
            _khQuestionsThrough += 1;
            KhCreateAnimation(_khAnimation, 2);
        }
    }
    // Only say you've done it if the user answers one question. Otherwise the choice might've been a mistake.
    if (_khQuestionsThrough > 0) {
        Thread.Sleep(1000);
        Console.WriteLine($"Time's up! You answered {_khQuestionsThrough} questions out of 9! Well done!");
        Thread.Sleep(1000);
        Console.Write($"Take some time to reflect over your answers or write them down. They will not be saved! (Press enter when you're ready to end.): ");
        Console.ReadLine();
    }
    
}
}