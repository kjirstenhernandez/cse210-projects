class Activity{
    protected string _activityName;
    protected int _duration;
    protected string _description;
    protected string _instructions;
    protected DateTime _startTime;
    protected DateTime _endTime;

    public void GetOpeningMessage(){
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine(_description + "\n");
        Console.WriteLine(_instructions);
    }

    public void EstablishDuration(){  
        Console.Write("How long do you want to perform this activity (in seconds?): ");
        string userResponse = Console.ReadLine();
        _duration = Convert.ToInt32(userResponse);
    }
    
    public void GetReady(int waitTime){
        Console.Write("Get Ready... ");
        this.ShowSpinner(6);
        Console.WriteLine();
    }
    
    public void ShowSpinner(int time){
    // Displays spinner animation
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        
        int i = 0; 

        while (DateTime.Now < endTime){
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count){
                i = 0;
            }
        }
    }
    public void ShowCountdown(int time){
    //  Displays Countdown Timer 
        for (int i = time; i> 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }}

    public void InitializeActivity(string type){
    /* Sets the type of preparation ("Get Ready" w/ spinner, or Countdown Timer) and establishes
    the start time so that the duration of the activity doesn't begin too soon. I didn't like that the duration clock started when
    someone might still be considering their question in Activity 2 or 3, leaving them no time for response.  */

        if (type == "GetReady"){
            this.GetReady(7);
        }

        else if (type == "Countdown"){
            Console.Write("You may begin in: ");
            this.ShowCountdown(5);
        }
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);}

    public void GetEndingMessage(){
        Console.WriteLine($"Congratulations! You have just completed {_duration} seconds of a {_activityName} activity!");
        Console.Write("You will now be redirected back to the main menu in: ");
        this.ShowCountdown(5);

    }
}