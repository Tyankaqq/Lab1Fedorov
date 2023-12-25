try
{
    Console.Write("Введите часы: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Введите минуты: ");
    int minutes = int.Parse(Console.ReadLine());

    Console.Write("Введите секунды: ");
    int seconds = int.Parse(Console.ReadLine());

    Console.Write("Введите номер поезда: ");
    int trainNumber = int.Parse(Console.ReadLine());

    Console.Write("Введите направление: ");
    string direction = Console.ReadLine();

    Console.Write("Введите часы отправления поезда: ");
    int departureHours = int.Parse(Console.ReadLine());

    Console.Write("Введите минуты отправления поезда: ");
    int departureMinutes = int.Parse(Console.ReadLine());

    Console.Write("Введите секунды отправления поезда: ");
    int departureSeconds = int.Parse(Console.ReadLine());

    TrainSchedule trainSchedule = new TrainSchedule(trainNumber, direction, departureHours, departureMinutes, departureSeconds);
    Console.WriteLine();
    Console.WriteLine($"Количество секунд до отправления поезда: {trainSchedule.MinutesUntilDeparture(new Time(hours, minutes, seconds))} минут");
    Console.WriteLine();

    Console.WriteLine("Увеличение времени на 5 секунд");
    trainSchedule.AddSeconds(5);
    trainSchedule.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Time
{
    private int hours;
    private int minutes;
    private int seconds;

    public Time()
    {
    }

    public Time(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public int Hours
    {
        get => hours;
        set => hours = value;
    }

    public int Minutes
    {
        get => minutes;
        set => minutes = value;
    }

    public int Seconds
    {
        get => seconds;
        set => seconds = value;
    }

    public int TotalSeconds()
    {
        return hours * 3600 + minutes * 60 + seconds;
    }

    public void AddSeconds(int secondsToAdd)
    {
        int totalSeconds = TotalSeconds() + secondsToAdd;

        hours = totalSeconds / 3600;
        minutes = (totalSeconds % 3600) / 60;
        seconds = totalSeconds % 60;
    }

    public void Print()
    {
        Console.WriteLine($"Часы: {hours}, Минуты: {minutes}, Секунды: {seconds}");
    }
}

class TrainSchedule : Time
{
    private int trainNumber;
    private string direction;

    public TrainSchedule(int trainNumber, string direction, int hours, int minutes, int seconds)
        : base(hours, minutes, seconds)
    {
        this.trainNumber = trainNumber;
        this.direction = direction;
    }

    public int TrainNumber
    {
        get => trainNumber;
        set => trainNumber = value;
    }

    public string Direction
    {
        get => direction;
        set => direction = value;
    }

    public int MinutesUntilDeparture(Time currentTime)
    {
        int departureTimeInSeconds = TotalSeconds();
        int currentTimeInSeconds = currentTime.TotalSeconds();

        int minutesUntilDeparture = (departureTimeInSeconds - currentTimeInSeconds) / 60;

        return minutesUntilDeparture;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Номер поезда: {trainNumber}, Направление: {direction}");
    }
}


