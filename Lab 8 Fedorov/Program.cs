//Средний уровень 3 вариант

try
{
    Console.Write("Введите количество пользовательских сеансов: ");
    int n = int.Parse(Console.ReadLine());
    UserSession[] userSessions = new UserSession[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите логин пользователя: ");
        userSessions[i].Username = Console.ReadLine();

        Console.Write("Введите дату выхода в on-line в формате (ДД-ММ-ГГГГ): ");
        userSessions[i].OnlineDate = ParseStringToDateOnly(Console.ReadLine());

        Console.Write("Введите время начала сеанса on-line: ");
        userSessions[i].StartTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Введите время завершения сеанса on-line: ");
        userSessions[i].EndTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Введите объем принятой информации (Кб): ");
        userSessions[i].ReceivedData = long.Parse(Console.ReadLine());

        Console.Write("Введите объем отправленной информации (Кб): ");
        userSessions[i].SentData = long.Parse(Console.ReadLine());
    }

    Console.WriteLine();

    foreach (var session in userSessions)
    {
        Console.WriteLine($"Логин пользователя: {session.Username}");
        Console.WriteLine($"Длительность сеанса: {GetSessionDuration(session.StartTime, session.EndTime)} мин");
        Console.WriteLine($"Объем потребленного трафика: {GetTotalTraffic(session.ReceivedData, session.SentData)} Мб");

        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

DateOnly ParseStringToDateOnly(string date)
{
    try
    {
        if (DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
            out DateTime parsedDate))
        {
            return DateOnly.FromDateTime(parsedDate);
        }
        else
        {
            throw new Exception("Некорректный формат даты.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

int GetSessionDuration(DateTime startTime, DateTime endTime)
{
    return (int)(endTime - startTime).TotalMinutes;
}

double GetTotalTraffic(long receivedData, long sentData)
{
    return (receivedData + sentData) / 1024.0; 
}

struct UserSession
{
    public string Username;
    public DateOnly OnlineDate;
    public DateTime StartTime;
    public DateTime EndTime;
    public long ReceivedData; 
    public long SentData; 
}
