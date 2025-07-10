namespace CatCoffee;

public class Cosmetics
{
    public static void AnimatingString(string[] inputString)
    {
        foreach (var str in inputString)
        {
            foreach (var symbol in str)
            {
                Console.Write(symbol);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
    }
}