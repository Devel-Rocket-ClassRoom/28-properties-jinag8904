using System;

// 1.
{
    Player player = new();
    player.Health = 100;
    player.Health = -999;
}
Console.WriteLine();

// 2.
{
    Player2.SetHealth(100);
    Console.WriteLine(Player2.GetHealth());
}
Console.WriteLine();

// 3.
{
    Person3 person = new();
    person.Name = "홍길동";
    Console.WriteLine(person.Name);
}
Console.WriteLine();

// 4.
{
    Developer developer = new Developer();
    developer.Name = "김개발";
    developer.Age = 25;
    Console.WriteLine($"{developer.Name}, {developer.Age}세");
}
Console.WriteLine();

// 5.
{
    Player5 player = new();
    Console.WriteLine($"이름: {player.Name}\n레벨: {player.Level}\n최대 체력: {player.MaxHealth}");
}
Console.WriteLine();

// 6.
{
    Car car = new();
    car.Name = "소나타";
    car.Color = "검정";
    Console.WriteLine($"{car.Name}, {car.Color}");
}
Console.WriteLine();

// 7.
{
    Product product = new();
    Console.WriteLine(product.Manufacturer);
}
Console.WriteLine();

// 8.
{
    Console.WriteLine(Page.Message);
    Page.UpdateMessage("업데이트된 메시지");
    Console.WriteLine(Page.Message);
}
Console.WriteLine();

// 9.
{
    SecureData.Validate("1234");
}
Console.WriteLine();

// 10.
{
    Circle.Radius = 5;
    Console.WriteLine($"반지름: {Circle.Radius}\n넓이: {Circle.Area:F5}\n둘레: {Circle.Circumference:F4}");
}
Console.WriteLine();

// 11.
{
    Counter.Increase(11);
    Console.WriteLine(Counter.Count);
}
Console.WriteLine();

// 12.
{
    Player12.Health = 150;
    Console.WriteLine(Player12.Health);
    Player12.Health = -50;
    Console.WriteLine(Player12.Health);
}
Console.WriteLine();

// 13.
{
    Person.BirthYear = 2000;
    Console.WriteLine($"{Person.Name}님의 나이: {Person.Age}세");
}
Console.WriteLine();

// 14.
{
    Course course = new();
    course.Id = 1;
    course.Title = "C# 기초";

    Console.WriteLine($"{course.Id} - {course.Title}");
}
Console.WriteLine();

// 15.
{
    Course15[] courses =
    {
        new Course15{ Id = 1, Title = "C# 기초"},
        new Course15{ Id = 2, Title = "C# 중급" },
        new Course15{ Id = 3, Title = "Unity 입문" }
    };

    foreach (Course15 course in courses)
    {
        Console.WriteLine($"{course.Id}. {course.Title}");
    }
}
Console.WriteLine();

// 16.
{
    Customer customer = new Customer
    {
        Id = 1,
        Name = "김철수",
        Email = "Kim@example.com",
        City = "서울"
    };

    Console.WriteLine($"고객 #{customer.Id}\n이름: {customer.Name}\n이메일: {customer.Email}\n도시: {customer.City}");
}
Console.WriteLine();

// 17.
{
    Console.WriteLine($"게임: {GameSettings.GameTitle}");
    Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
    Console.WriteLine($"사운드: {GameSettings.IsSoundEnabled}");
    GameSettings.MaxPlayers = 8;
    Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");
}
Console.WriteLine();

// 18.
{
    Monster monster = new("고블린");

    Console.WriteLine($"이름: {monster.Name}");
    Console.WriteLine($"레벨: {monster.Level}");
    Console.WriteLine($"체력: {monster.Health}");
    Console.WriteLine($"공격력: {monster.Attack}");
    Console.WriteLine($"방어력: {monster.Defense}");
    Console.WriteLine($"생존: {monster.IsAlive}");

    monster.TakeDamage(50);

    Console.WriteLine($"50 대미지 후 체력: {monster.Health}");
}
Console.WriteLine();

// 18.
class Monster
{
    private int _health;

    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            if (_health < 0) _health = 0;
            else if (_health > 100) _health = 100;
        }
    }

    public int Level { get; set; } = 5;
    public int Attack { get; set; } = 15;


    public string Name { get; }

    public bool IsAlive => _health > 0;
    public int Defense => Level * 2;

    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage - Defense;
    }
}

// 17.
class GameSettings
{
    static public string GameTitle { get; set; } = "My Game";
    static public int MaxPlayers { get; set; } = 4;
    static public bool IsSoundEnabled { get; set; } = true;
}

// 16.
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}

// 15.
class Course15
{
    public int Id { get; set; }
    public string Title { get; set; }
}

// 14.
class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}

// 13.
class Person
{
    static private int _birthYear;

    static public string Name { get; set; } = "홍길동";
    static public int BirthYear
    {
        set
        {
            if (value >= 1900)
            {
                _birthYear = value;
            }
        }
    }

    static public int Age
    {
        get { return DateTime.Now.Year - _birthYear; }
    }
}

// 12.
class Player12
{
    static private int _health;

    static public int Health {
        get { return _health; }
        set
        {
            _health = value;
            if (_health > 100) _health = 100;
            else if (_health < 0) _health = 0;
        }
    }
}

// 11.
class Counter
{
    static private int _count = 0;

    static public int Count
    {
        get => _count;
        set => _count = value;
    }

    static public void Increase(int count)
    {
        _count += count;
    }
}

// 10.
class Circle
{
    static public double Radius { get; set; }
    static public double Area => Radius * Radius * Math.PI;
    static public double Circumference => 2 * Radius * Math.PI;
}

// 9.
class SecureData
{
    static public string Password { get; } = "1234";

    static public void Validate(string pw)
    {
        Console.WriteLine(pw == Password);
    }
}

// 8.
class Page
{
    static public string Message { get; private set; } = "읽기 전용 메시지";

    static public void UpdateMessage(string message)
    {
        Message = message;
    }
}

// 7.
class Product
{
    public string Manufacturer { get; } = "한국전자";
}

// 6.
class Car
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Color { get; set; }
}

// 5.
class Player5
{
    public string Name { get; set; } = "플레이어";
    public int Level { get; set; } = 1;
    public int MaxHealth { get; set; } = 100;
}

// 4.
class Developer
{
    public string Name { get; set; }
    public int Age {  get; set; }
}

// 3.
class Person3
{
    private string _name;

    public string Name { get; set; }
}

// 2.
class Player2
{
    static private int _health;

    static public void SetHealth(int health)
    {
        if (_health < 0) _health = 0;
        else if (_health > 100) _health = 100;

        _health = health;
    }

    static public int GetHealth()
    {
        return _health;
    }
}

// 1.
class Player
{
    public int Health;
}