

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

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите часы: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Введите минуты: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());

            Time time = new Time(hours, minutes, seconds);
            Console.WriteLine();
            Console.WriteLine($"Количество секунд в указанном времени: {time.TotalSeconds()}");
            Console.WriteLine();

            Console.WriteLine("Увеличение времени на 5 секунд");
            time.AddSeconds(5);
            time.Print();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
