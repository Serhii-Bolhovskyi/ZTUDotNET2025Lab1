namespace Lab01.Classes;

public class Ukulele : MusInstrument
{
    public int NumOfStrings { get; set; }
    public string Material { get; set; }

    // Конструктор за замовчуванням
    public Ukulele() : base()
    {
        NumOfStrings = 4;
        Material = "Дерево";
    }

    // Конструктор за параметрами 1
    public Ukulele(string name, string origin, int year) : base(name, origin, year)
    {
        NumOfStrings = 4;
        Material = "Дерево";
    }
    
    // Конструктор за параметрами 2
    public Ukulele(string name, string origin, int year, string material) : base(name, origin, year)
    {
        NumOfStrings = 4;
        Material = material;
    }
    
    // Конструктор копіювання
    public Ukulele(Ukulele uk) : base(uk)
    {
        NumOfStrings = uk.NumOfStrings;
        Material = uk.Material;
    }
    
    public override void Sound()
    {
        Console.WriteLine($"{Name} має високий, яскравий, дзвінкий звук.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту - {Name}.");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} - це струнний щипковий інструмент, який має {NumOfStrings} струни, найчастіше виготовленйи з {Material}.");
    }
    
    public override void History()
    {
        Console.WriteLine($"{Name} явилася на {Origin} близько {Year} року, походить від португальських маленьких гітарок. Відомі виконавці — Джейк Шимабукуро та Ізабель Лівінгстон.");
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