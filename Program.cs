class Program
{
    const double fut = 3.28084;

    static void Main()
    {
        PrintHeader();
        PrintHeader();
        Console.WriteLine("Основная часть программы");
        PrintFooter();

        PrintStudentCard("Иванов Иван", "ИСП-221", 2);
        PrintStudentCard("Смирнова Анна", "ИСП-222", 2);

        PrintPurchase("Ноутбук", 65000, true);
        PrintPurchase("Мышь", 1200, false);

        int sum = Add(15, 27);
        Console.WriteLine($"Сумма: {sum}");

        double area = CalculateRectangleArea(3.5, 4.2);
        Console.WriteLine($"Площадь прямоугольника: {area}");

        bool isAdult = IsAdult(20);
        Console.WriteLine($"Совершеннолетний: {isAdult}");

        Console.WriteLine();
        Console.WriteLine($"5 + 10 = {Add(5, 10)}");
        Console.WriteLine($"Площадь 2x2 больше площади 1x5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");

        Console.WriteLine();
        Console.WriteLine(Add(2, 2));
        Console.WriteLine(Add(2.5, 2.5));
        Console.WriteLine(Add(2, 2, 3));

        Console.WriteLine();
        Console.WriteLine("Методы вызывают методы");
        PrintNumberInfo(7);
        PrintNumberInfo(10);
        PrintNumberInfo(15);

        Console.WriteLine();
        Console.WriteLine("Методы + цикл");
        for (int i = 1; i <= 5; i++) {
            PrintNumberInfo(i);
        }

        //NumberToolkit

        PrintSeparator();
        Console.Write("first: ");
        bool isFirst = int.TryParse(Console.ReadLine(), out int first);
        Console.Write("second: ");
        bool isSecond = int.TryParse(Console.ReadLine(), out int second);
        Console.Write("three: ");
        bool isThree = int.TryParse(Console.ReadLine(), out int three);

        if (!isFirst || !isSecond || !isThree)
        {
            Console.WriteLine("NOT INT");
            return;
        }

        Console.WriteLine($"{first} prime: {isPrime(first)}");
        Console.WriteLine($"{second} prime: {isPrime(second)}");
        Console.WriteLine($"{three} prime: {isPrime(three)}");

        PrintSeparator();

        Console.WriteLine($"Max 3: {FindMax(first, second, three)}");
        Console.WriteLine($"Max 2: {FindMax(first, second)}");

        PrintSeparator();

        Console.WriteLine($"srednee: {CalculateAverage(first, second, three):F2}");

        PrintSeparator();

        Console.WriteLine($"{MetersToFeet(7):F2}");
        Console.WriteLine($"{MetersToFeet(3.2):F2}");
        Console.WriteLine($"{CelsiusToFahrenheit(0)}");
        Console.WriteLine($"{CelsiusToFahrenheit(30)}");

        //PasswordChecker
        PrintSeparator();
        Console.Write("password: ");
        string passw = Console.ReadLine();
        Console.WriteLine($"is valid: {IsPasswordValid(passw)}");
    }

    static void PrintSeparator()
    {
        Console.WriteLine();
    }

    static void PrintHeader() {
        Console.WriteLine("^_^");
        Console.WriteLine("Лабораторная работа №6");
        Console.WriteLine("0_0");
    }

    static void PrintFooter() {
        Console.WriteLine(">_<");
        Console.WriteLine("   Конец программы");
        Console.WriteLine("X_X");
    }

    static void PrintStudentCard(string name, string group, int course) {
        Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
    }

    static void PrintPurchase(string itemName, double price, bool hasDiscount) {
        string discountLabel = hasDiscount ? " (со скидкой)" : "";
        Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
    }

    static int Add(int a, int b) {
        return a + b;
    }

    static double Add(double a, double b) {
        return a + b;
    }

    static int Add(int a, int b, int c) {
        return a + b + c;
    }

    static double CalculateRectangleArea(double width, double height) {
        return width * height;
    }

    static bool IsAdult(int age) {
        return age >= 18;
    }
    
    static bool IsEven(int number) {
        return number % 2 == 0;
    }

    static void PrintNumberInfo(int number) {
        string parity = IsEven(number) ? "чётное" : "нечётное";
        Console.WriteLine($"{number} — {parity} число");
    }

    static bool isPrime(int num)
    {
        if (num < 2) return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }

        return true;
    }

    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        return max;
    }

    static int FindMax(int a, int b)
    {
        int max = a;

        if (b > max) max = b;

        return max;
    }

    static double CalculateAverage(int a, int b, int c)
    {
        return (double)(a + b + c) / 3;
    }

    static double MetersToFeet(double metrs)
    {
        return metrs * fut;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static bool HasMinLength(string passw, int min)
    {
        if (passw.Length >= min) return true;
        return false;
    }

    static bool HasDigit(string passw)
    {
        foreach (char pass in passw)
        {
            if (char.IsDigit(pass)) return true;
        }

        return false;
    }

    static bool HasUpperCase(string passw)
    {
        foreach (char pass in passw)
        {
            if (char.IsUpper(pass)) return true;
        }

        return false;
    }

    static bool IsPasswordValid(string passw)
    {
        if (!HasMinLength(passw, 8))
        {
            Console.WriteLine($"min length: {HasMinLength(passw, 8)}");
            return false;
        }
        if (!HasDigit(passw))
        {
            Console.WriteLine($"has digit: {HasDigit(passw)}");
            return false;
        }
        if (!HasUpperCase(passw))
        {
            Console.WriteLine($"has upper: {HasUpperCase(passw)}");
            return false;
        }

        return true;
    }
}