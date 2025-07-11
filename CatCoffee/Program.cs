using CatCoffee;

public class Program
{
    public static void Main()
    {
        Cosmetics.AnimatingString(new[]
        {
            "Добро пожаловать в котокафе МурМяу",
            "Какую кошку хотите погладить?\n",
            "[1] Рыжая, [2] Бело-серая в полосочку, [3] Черненькая\n"
        });
        
        string selectedCat = Console.ReadLine();
        Console.Clear();
        Cat cat = null;
        switch (selectedCat)
        {
            case "1":
                cat = new SmartyCat("Смарти", "Мяу");
                break;
            case "2":
                cat = new LinyCat("Лини", "Мурр");
                break;
            case "3":
                cat = new BlackyCat("Блэки", "Мяу мяу мяу");
                break;
            default:
                Cosmetics.AnimatingString(new[] {"Некорректно указано число"});
                break;
        }
        cat.Print();
    }
}