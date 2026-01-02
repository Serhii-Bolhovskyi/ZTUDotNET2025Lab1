namespace Lab01.Classes;

abstract public class MusInstrument
{
    public string Name { get; set; }
    public string Origin { get; set; }
    public int Year { get; set; }

    // Конструктор за замовчуванням
    public MusInstrument()
    {
        Name = "Невідомий музичний інструмент";
        Origin = "Країна походження невідома";
        Year = 0;
    }
    
    // Конструктор за параметрами
    public MusInstrument(string name, string origin, int year)
    {
        Name = name;
        Origin = origin;
        Year = year;
    }
    
    // Конструктор копіювання
    public MusInstrument(MusInstrument other)
    {
        Name = other.Name;
        Origin = other.Origin;
        Year = other.Year;
    }
    
    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
    public abstract void History();
    public abstract void ShowInfo();
}
