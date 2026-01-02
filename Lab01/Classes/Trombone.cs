namespace Lab01.Classes;

public class Trombone : MusInstrument
{
    public string _tonality;
    public string Tonality
    {
        get => _tonality;
        set
        {
            if (value == "Bb" || value == "C")
            {
                _tonality = value;
            }
            else
            {
                throw new ArgumentException("Тональність тромбона може бути: Bb, або C.");
            }
        }
    }
    
    private string Mechanism { get; set; }

    // Констуктор за замовчуванням
    public Trombone() : base()
    {
        Tonality = "Bb";
        Mechanism = "Slide";
    }
    
    // конструктор з параметрами 1
    public Trombone(string name, string origin, int year) : base(name, origin, year)
    {
        Tonality = "Bb";
        Mechanism = "Slide";
    }
    
    // конструктор з параметрами 2
    public Trombone(string name, string origin, int year, string tonality) : base(name, origin, year)
    {
        Tonality = tonality;
        Mechanism = "Slide";
    }
    
    // конструктор копіювання
    public Trombone(Trombone trombone) : base(trombone)
    {
        Tonality = trombone.Tonality;
        Mechanism = trombone.Mechanism;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} видає твердий, насиченний, низький до середнього звук. Іноді могутній або мʼякий залежно від гри");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту - {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} - мідний духовий інструмент з {Mechanism} механізмом, зазвичай у тональоність Bb або C, діапазон понад 2 октави");
    }

    public override void History()
    {
        Console.WriteLine($"{Name} виник у {Origin} близько {Year} року як розвиток саксгорна та ранніх духових інструментів. Найвідоміші виконавці — Віктор Емануель Клементе та Йозеф Альберт");
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