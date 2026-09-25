PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader() {
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №6");
    Console.WriteLine("0_0");
}

void PrintFooter() {
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("X_X");
}

PrintStudentCard("Иванов Иван", "ИСП-221", 2);
PrintStudentCard("Смирнова Анна", "ИСП-222", 2);

void PrintStudentCard(string name, string group, int course) {
    Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
}

PrintPurchase("Ноутбук", 65000, true);
PrintPurchase("Мышь", 1200, false);

void PrintPurchase(string itemName, double price, bool hasDiscount) {
    string discountLabel = hasDiscount ? " (со скидкой)" : "";
    Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
}

int sum = Add(15, 27);
Console.WriteLine($"Сумма: {sum}");

double area = CalculateRectangleArea(3.5, 4.2);
Console.WriteLine($"Площадь прямоугольника: {area}");

bool isAdult = IsAdult(20);
Console.WriteLine($"Совершеннолетний: {isAdult}");

int Add(int a, int b) {
    return a + b;
}

double CalculateRectangleArea(double width, double height) {
    return width * height;
}

bool IsAdult(int age) {
    return age >= 18;
}

Console.WriteLine();
Console.WriteLine($"5 + 10 = {Add(5, 10)}");
Console.WriteLine($"Площадь 2x2 больше площади 1x5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");