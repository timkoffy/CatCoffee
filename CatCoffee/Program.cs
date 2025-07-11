using CatCoffee;

public class Program
{
    public static void Main()
    {
        string selectedCat;
        void Start()
        {
            Cosmetics.AnimatingString(new[]
            {
                "Добро пожаловать в котокафе МурМяу",
                "Какую кошку хотите погладить?\n",
                "[1] Рыжая, [2] Бело-серая в полосочку, [3] Черненькая\n"
            });
            selectedCat = Console.ReadLine();
            Console.Clear();
            
            try
            {
                int selectedCatInt = int.Parse(selectedCat);

                Cat[] cats = new Cat[4];
                cats[1] = new SmartyCat("Смарти", "Мяу");
                cats[2] = new LinyCat("Лини", "Мурр");
                cats[3] = new BlackyCat("Блэки", "Мяу мяу мяу");

                cats[selectedCatInt].Print();
            }
            catch
            {
                Cosmetics.AnimatingString(new[] {"Пожалуйста, введите числа 1, 2 или 3."});
                Console.ReadKey();
                Console.Clear();
                Start();
            }
        }

        Start();
        
        
    }
}