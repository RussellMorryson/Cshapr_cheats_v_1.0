



Car ferrari = new Car();
ferrari.Name = "s40";
ferrari.HorsePower = 300;
ferrari.Age = 30;
ferrari.Maxspeed = 350.0f;

ferrari.PrintPasport();
ferrari.BecomeOlder(5, 50);
ferrari.PrintPasport();

// Формирование класса и методов
class Car
{
    public string Name;
    public int HorsePower;
    public int Age;
    public float Maxspeed;
    public int Year = 4;
    public void PrintPasport()
    {
        Console.WriteLine($"{Name}, {HorsePower}, {Age}, {Maxspeed}");
    }
    public void BecomeOlder(int Years, int runAwayHorses)
    {
        Age += this.Year + Year; // Указатель this применяется для указания на переменную использующуюся в классе
        HorsePower -= runAwayHorses;
    }
}


