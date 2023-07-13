public abstract class Activity {
    private string _date;
    private int _length;
    protected string _activityType;

    public Activity(int length){
        CreateDate();
        _length = length;
    }

    public  void CreateDate(){
        string day = DateTime.Now.Date.Day.ToString();
        string month = DateTime.Now.Date.Month.ToString();
        string year = DateTime.Now.Date.Year.ToString();

        switch (month){
            case "1":
                month = "Jan";
                break;
            case "2":
                month = "Feb";
                break;
            case "3":
                month = "Mar";
                break;
            case "4":
                month = "Apr";
                break;
            case "5":
                month = "May";
                break;
            case "6":
                month = "Jun";
                break;
            case "7":
                month = "Jul";
                break;
            case "8":
                month = "Aug";
                break;
            case "9":
                month = "Sep";
                break;
            case "10":
                month = "Oct";
                break;
            case "11":
                month = "Nov";
                break;
            case "12":
                month = "Dec";
                break;
        }
        _date = $"{day} {month} {year}";
    }
    public string GetSummary(double distance, double speed, double pace){
        return $"{_date} {_activityType} ({_length} min): Distance {distance} miles, Speed:{speed} mph, Pace: {pace} min per mile";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public int GetLength(){
        return _length;
    }

}