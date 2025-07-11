namespace CatCoffee;

class SmartyCat : Cat
{
    public SmartyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она начинает читать философскую лекцию...");
    }
}
