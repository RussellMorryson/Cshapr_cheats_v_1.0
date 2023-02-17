//Инкапсуляция
//сокрытия данных и состояния от неправильного внешнего воздействия


Renderer renderer = new Renderer();
Player player = new Player(55, 10);

//[1] renderer.Draw(player.X, player.Y); // можно использовать если переменные открыты (public)
//[2] renderer.Draw(player.GetPositionX(), player.GetPositionY()); // применяется если доступ private
renderer.Draw(player.X, player.Y); // [3] вариант




class Renderer
{
    public void Draw(int x, int y, char character = '@')
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(x, y);
        Console.Write(character);
        Console.ReadKey(true);
    }
}



class Player
{
    //Необходимо изменить тип доступа, чтобы программа не сломалась от ввода отрицательных чисел
    //[1] public int X; // не эффективно
    private int _x; // эффективно

    //[1] public int Y; // не эффективно
    private int _y; // эффективно

    // Конструктор
    public Player(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // [2] Поскольку переменные имеют доступ private, то необходимо написать методы получения значений
    /*
    public int GetPositionX () {
        return _x;
    }
    public int GetPositionY () {
        return _y;
    }
    */
    
    // [3] Применение свойств
    public int X
    {
        get // получыет входящую информацию
        {
            return _x;
        }
        private set // устанавливает свойства для входящей информации
        // private не разрешено изменение свойств извне
        {
            _x = value;
            // value это значение, которое поставится вместо _х если
            // кто-то захочет присвоить иное значение для _х
        }
    }

    public int Y // аналогичная сокращенная запись по Y
    
    {
        get
        {
            return _y;
        }
        private set
        {
            _y = value;
        }
    }
    // Аналогией является автореализуемое свойство:
    /*
    class Player {
        public int X (get; private set;)
        public int Y (get; private set;)
        public Player (int x, int y)
        {
            X = x;
            Y = y;
        }        
    }
    // В данном случае доступ к изменению свойств переменных также недоступен извне
    // Мы защитили переменные от неправильного внешнего воздействия
    */
}

