namespace Lab01.Classes;

public class Cello : MusInstrument
{
    public int NumOfStrings { get; set; }
    public string BowType { get; set; }
    
    // Конструктор за замовчуванням
    public Cello() : base()
    {
        NumOfStrings = 4;
        BowType = "Струнно-смичковий";
    }
    
    // Конструктор за параметрами 1
    public Cello(string name, string origin, int year) : base(name, origin, year)
    {
        NumOfStrings = 4;
        BowType = "Струнно-смичковий";
    }
    
    // Конструктор за параметрами 2
    public Cello(string name, string origin, int year, int numOfStrings, string bowType) : base(name, origin, year)
    {
        NumOfStrings = numOfStrings;
        BowType = bowType;
    }
    
    // Конструктор копіювання
    public Cello(Cello cello) : base(cello)
    {
        NumOfStrings = cello.NumOfStrings;
        BowType = cello.BowType;
    }
    
    public override void Sound()
    {
        Console.WriteLine($"{Name} видає видає глибокий, теплий звук.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту - {Name}.");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} - це {BowType} музичний інструмент, який має {NumOfStrings} струни.");
    }
    
    public override void History()
    {
        Console.WriteLine($"{Name} виникла у {Origin} у XVI столітті (близько {Year} року).Найвідоміші виконавці — Йо-Йо Ма та Пабло Казальс");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Коротка довідка: {Name}");
        Show();
        Sound();
        Desc();
        History();
        Console.WriteLine("======");
    }
}