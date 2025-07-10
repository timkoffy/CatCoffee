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
        switch (selectedCat)
        {
            case "1":
                var smarty = new SmartyCat("Смарти", "Мяу");
                smarty.Print();
                break;
            
            case "2":
                var liny = new LinyCat("Лини", "Мурр");
                liny.Print();
                break;
            
            case "3":
                var blacky = new BlackyCat("Блэки", "Мяу мяу мяу");
                blacky.Print();
                break;
            
            default:
                Cosmetics.AnimatingString(new[] {"Некорректно указано число"});
                break;
        }
    }
}