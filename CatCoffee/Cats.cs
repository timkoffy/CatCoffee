namespace CatCoffee;

class Cat
{
    public string Name { get; }
    public string TextHello { get; }
    public Cat(string name, string textHello)
    {
        Name = name;
        TextHello = textHello;
    }
    
    public void Print()
    {
        Cosmetics.AnimatingString(new[] 
        {
            $"{Name}",
            $"- {TextHello}\n",
            "Погладить? (да/нет)\n" 
        });
        
        string IsPet = Console.ReadLine();
        switch (IsPet)
        {
            case "да":
                Pet(Name);
                break;
            case "нет":
                Console.Clear();
                Cosmetics.AnimatingString(new[] { "* Вас выгоняют из заведения *" });
                break;
            default:
                Console.Clear();
                Cosmetics.AnimatingString(new[] { "Пожалуйста, введите 'да' или 'нет'." });
                break;
        }
    }

    public virtual void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}...");
    }
    
    protected void DoPetAnimation(string message)
    {
        Console.Clear();
        Cosmetics.AnimatingString(new[] { message });
        Console.ReadKey();
    }
}

class SmartyCat : Cat
{
    public SmartyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она начинает читать философскую лекцию...");
    }
}

class LinyCat : Cat
{
    public LinyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она ложится спать к вам на колени...");
    }
}

class BlackyCat : Cat
{
    public BlackyCat(string name, string textHello) : base(name, textHello) { }
    
    public override void Pet(string name)
    {
        DoPetAnimation($"Вы гладите {name}, и она запрыгивает вам на лицо...");
    }
}





