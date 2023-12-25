try
{
    Console.Write("Введите тип кабеля: ");
    string type = Console.ReadLine();

    Console.Write("Введите количество жил кабеля: ");
    int numberOfWires = int.Parse(Console.ReadLine());

    Console.Write("Введите диаметр кабеля: ");
    double diameter = double.Parse(Console.ReadLine());

    Console.Write("Есть ли оплетка (true/false): ");
    bool hasShielding = bool.Parse(Console.ReadLine());

    Cable cable = new Cable(type, numberOfWires, diameter);
    Console.WriteLine();
    Console.WriteLine("Информация о классе 1-го уровня (кабель):");
    cable.DisplayInfo();
    Console.WriteLine($"Качество (Q): {cable.CalculateQuality()}");
    Console.WriteLine();

    EnhancedCable enhancedCable = new EnhancedCable(type, numberOfWires, diameter, hasShielding);
    Console.WriteLine();
    Console.WriteLine("Информация о классе 2-го уровня (усовершенствованный кабель):");
    enhancedCable.DisplayInfo();
    Console.WriteLine($"Качество (Qp): {enhancedCable.CalculateQuality()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Cable
{
    protected string type;
    protected int numberOfWires;
    protected double diameter;

    public Cable(string type, int numberOfWires, double diameter)
    {
        this.type = type;
        this.numberOfWires = numberOfWires;
        this.diameter = diameter;
    }

    public virtual double CalculateQuality()
    {
        return diameter / numberOfWires; 
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Тип: {type}, Количество жил: {numberOfWires}, Диаметр: {diameter}");
    }
}


class EnhancedCable : Cable
{
    private bool hasShielding;

    public EnhancedCable(string type, int numberOfWires, double diameter, bool hasShielding)
        : base(type, numberOfWires, diameter)
    {
        this.hasShielding = hasShielding;
    }

    public override double CalculateQuality()
    {
        double quality = base.CalculateQuality(); 
        if (hasShielding)
            return 2 * quality; 
        else
            return 0.7 * quality; 
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Наличие оплетки: {hasShielding}");
    }
}


