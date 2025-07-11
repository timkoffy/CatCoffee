namespace CatCoffee;

class BlackyCat : Cat
{
    public BlackyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она запрыгивает вам на лицо...");
    }
}