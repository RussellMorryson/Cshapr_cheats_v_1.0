
// class main

/*Есть два способа записи информации
Указание на каждый стол, что долго
Table table1 = new Table(1, 4); // Номер стола 1 количество мест 4
Table table2 = new Table(2, 6); // Номер стола 2 количество мест 6
Table table2 = new Table(3, 8); // Номер стола 3 количество мест 8
*/

// Второй - создание массива столов
bool isOpen = true;
Table [] tables = { new Table(1, 4), new Table (2, 6), new Table(3, 8)};
while(isOpen)
{
    Console.WriteLine("Администрирование кафе");
    Console.WriteLine();
    for (int i = 0; i < tables.Length; i++)
    {
        tables[i].ShowInfo();
    }

    Console.Write("Введите номер стола: ");
    int wishTable = Convert.ToInt32(Console.ReadLine())-1;
    Console.Write("Введите количество мест: ");
    int desiredPlaces = Convert.ToInt32(Console.ReadLine());

    bool ifReservationCompleted = tables[wishTable].Reserve(desiredPlaces);
    if (ifReservationCompleted)
    {
        System.Console.WriteLine("Бронь прошла успешно!");
    }
    else
    {
        System.Console.WriteLine("Бронь не прошла! Недостаточно мест!");
    }

    Console.ReadKey();
    Console.Clear();
}


class Table
{
    public int Number;
    public int MaxPlaces;
    public int FreePlaces;

// Сформируем контруктор
    public Table (int number, int maxplaces)
    {
        Number = number;
        MaxPlaces = maxplaces;
        FreePlaces = maxplaces;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Стол {Number}. Cвободно мест: {FreePlaces} из {MaxPlaces}");
    }

    public bool Reserve (int places)
    {
        if (FreePlaces >= places)
        {
            FreePlaces -= places;
            return true;
        }
        else 
        {
            return false;
        }
    }
}
