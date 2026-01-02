using Lab01.Classes;

namespace Lab01;

class Program
{
    static void Main(string[] args)
    {
        MusInstrument[] instruments = new MusInstrument[4];
        
        instruments[0] = new Violin("Скрипка", "Італія", 1550);
        instruments[1] = new Trombone("Тромбон", "Італія", 1500, "Bb");
        instruments[2] = new Ukulele("Укулеле", "Гаваї", 1880, "Дерево(клен)");
        instruments[3] = new Cello("Віолончель", "Італія", 1550);
        
        Console.WriteLine("Serhii Bolkhovskyi");

        // Приклад конструтора копіювання і оновлення властивовсті Name
        Violin violin2 = new Violin((Violin)instruments[0]);
        violin2.Name = "Скрипка Страдіварі";
        Console.WriteLine(violin2.Name);
        Console.WriteLine("=====");
        
        Console.WriteLine("Назва і Рік інструмента:");
        foreach (var instrument in instruments)
        {
            Console.WriteLine($"{instrument.Name} - {instrument.Year}");
        }
        Console.WriteLine("=====");
        
        Console.WriteLine("Інформація про всі інструменти: ");
        foreach (var instrument in instruments)
        {
            instrument.ShowInfo();
        }
    }
}