namespace Lab01.Classes;

public class Violin : MusInstrument
{
    public int NumOfStrings { get; set; }
    public string BowType { get; set; }

    // Конструктор за замовчуванням
    public Violin() : base()
    {
        NumOfStrings = 4;
        BowType = "Струнно-смичковий";
    }
    
    // Конструктор за параметрами 1
    public Violin(string name, string origin, int year) : base(name, origin, year)
    {
        NumOfStrings = 4;
        BowType = "Струнно-смичковий";
    }
    
    // Конструктор за параметрами 2
    public Violin(string name, string origin, int year, int numOfStrings, string bowType) : base(name, origin, year)
    {
        NumOfStrings = numOfStrings;
        BowType = bowType;
    }
    
    // Конструктор копіювання
    public Violin(Violin violin) : base(violin)
    {
        NumOfStrings = violin.NumOfStrings;
        BowType = violin.BowType;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} видає високий, протяжний звук.");
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
        Console.WriteLine($"{Name} виникла у {Origin} у XVI столітті (близько {Year} року) " +
                          $"як розвиток ранніх смичкових інструментів епохи Відродження. " +
                          $"Найвідоміші її майстри - Антоніо Страдіварі та Ніколо Аматі.");
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