

Car ferrari = new Car("s40", 300, 30, 350.0f );
Car chevrolet = new Car();

ferrari.PrintPasport();
chevrolet.PrintPasport();
// Формирование класса и методов
class Car
{
    public string Name;
    public int HorsePower;
    public int Age;
    public float Maxspeed;

// Сформирован конструктор, в кторый можно отправить переменные
    public Car(string name, int horsePower, int age, float maxSpeed)
    {
        Name = name;
        HorsePower = horsePower;
        Age = age;
        Maxspeed = maxSpeed;
    }
    
    // Перегрузка метода Car
    // это необходимо в случае если значения не направленны в конструктор, 
    //то будут выведены стандартные значения null
    public Car () 
    {
        Name = "Null";
        HorsePower = 0;
        Age = 0;
        Maxspeed = 0.0f;
    }
    public void PrintPasport()
    {
        Console.WriteLine($"{Name}, {HorsePower}, {Age}, {Maxspeed}");
    }
}


