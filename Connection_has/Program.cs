// Система распределения задач

// блок Main
//============================================================
Performer worker1 = new Performer("Николай"); // Имя первого исполнителя
Performer worker2 = new Performer("Василий"); // Имя второго исполнителя
Performer worker3 = new Performer("Мария");   // Имя третьего исполнителя

string taskP1 = "Выкопать яму размером 2х2х2";
string taskP2 = "Убрать мусор на территории";
string taskP3 = "Выполнить разметку территории";
// Сформирован массив
Task [] tasks = {new Task (worker1, taskP1), new Task(worker2, taskP2), new Task(worker3, taskP3)};



Board module = new Board(tasks);
module.ShowAllTasks();
//============================================================

// БЛОК КЛАССОВ И МЕТОДОВ

// ИСПОЛНИТЕЛЬ
class Performer
{
    public string Name;
    public Performer(string name)
    {
        Name = name;
    }
}

// ДОСКА С ЗАДАЧАМИ
class Board
{
    public Task[] Tasks;
    public Board(Task[] tasks) // метод по инициализации входящего массива данных
    {
        Tasks = tasks;
    }

    public void ShowAllTasks() // метод по выводу массива
    {
        for (int i = 0; i < Tasks.Length; i++)
        {
            Tasks[i].ShowInfo();
        }
    }
}

// ЗАДАЧА
class Task
{
    public Performer Worker; //Обращение к имени в классе Performer
    // Далее необходимо обратиться к методу Name чтобы вставить конкретное имя исполнителя
    public string Description; // Формирование строковой переменной
    public Task(Performer worker, string description) // метод для получения входящих значений и их инициализации
    {
        Worker = worker;
        Description = description;
    }
    public void ShowInfo() // метод для вывода значений
    {
        Console.WriteLine($"Ответсвенный: {Worker.Name}.\nОписание задачи: {Description}.\n");
    }
}