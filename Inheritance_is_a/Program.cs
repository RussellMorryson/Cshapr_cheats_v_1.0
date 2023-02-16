
// main
//====================================================
Knight war1 = new Knight(100, 2, 10);
Barbarian war2 = new Barbarian(100, 1, 7, 2);

war1.TakeDamage(500);
war2.TakeDamage(250);


System.Console.WriteLine("Рыцарь: ");
war1.ShowInfo();

System.Console.WriteLine("Варвар: ");
war2.ShowInfo();
//====================================================

// Основной базовый класс, в котором описаны однотипные переменные
class Warrior
{
    // protected применен для того, чтобы наследование классами происходило, но 
    // изменение параметров переменной извне не произошло
    // Таким образом переменная защищена от изменения в блоке Main но наследуется классами
    protected int Health;
    protected int Armor;
    protected int Damage;
    public Warrior(int health, int armor, int damage)
    {
        Health = health;
        Armor = armor;
        Damage = damage;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }
    public void ShowInfo() // Вывод размера злоровья
    {
        System.Console.WriteLine(Health);
    }
}

// Блок кода рыцаря
class Knight : Warrior // Двоеочием обозначается наследование переменных из основного класса
{
    // Поскольку в классе Warrior есть конструктор, то тут тоже необходимо его создать
    // Поскольку мы наследуем значения переменных от класса Warrior, то вызвать конструктор Warrior
    public Knight(int health, int armor, int damage) : base(health, armor, damage) { }
    public void Prey() // Уникальная способность
    {
        Armor += 2;
    }
}

class Barbarian : Warrior // Двоеочием обозначается наследование переменных из основного класса
{
    // Поскольку в классе Warrior есть конструктор, то тут тоже необходимо его создать
    // Поскольку мы наследуем значения переменных от класса Warrior, то вызвать конструктор Warrior
    public Barbarian(int health, int armor, int damage, int attackspeed) : base(health, armor, damage * attackspeed) { }
    // Фактическое количество переменных может быть большим, но 
    // сама суть состоит в том, чтобы сослаться на конструктор основного класса 
    // сократив таким образом время и размер кода

    public void Shout() // Уникальная способность
    {
        Armor -= 2;
        Health += 10;
    }
}