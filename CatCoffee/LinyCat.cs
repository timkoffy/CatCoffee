namespace CatCoffee;

class LinyCat : Cat
{
    public LinyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она ложится спать к вам на колени...");
    }
}