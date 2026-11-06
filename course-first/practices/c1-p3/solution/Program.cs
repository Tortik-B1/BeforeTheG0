// Первое задание
int a = 12;
int b = 5;

int sum = a+b;
int dif = a-b;
int prod = a*b;
int div = a/b;
int mod = a%b;

Console.WriteLine($"сумма: {sum}");
Console.WriteLine($"разность: {dif}");
Console.WriteLine($"произведение: {prod}");
Console.WriteLine($"деление: {div}");
Console.WriteLine($"остаток: {mod}");

// Второе задание
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
Console.WriteLine($"Привет, {username}!");

// Третье задание
Console.Write("Введите первое число: ");
int d = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = int.Parse(Console.ReadLine());
int summ = d+c;
Console.WriteLine($"Их сумма: {summ}");

// Четвертое задание
Console.Write("Введите длину: ");
int l = int.Parse(Console.ReadLine());
Console.Write("Введите ширину: ");
int w = int.Parse(Console.ReadLine());
int s = l*w;
Console.WriteLine($"площадь: {s}");

// Пятое задание
Console.Write("Введите температуру в градусах цельсия: ");
int t0 = int.Parse(Console.ReadLine());
int t1 = t0*9/5+32;
Console.WriteLine($"Температура по Фаренгейту: {t1}");

// Шестое задание
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = double.Parse(Console.ReadLine());
double average = (num1 + num2 + num3) / 3.0;
Console.WriteLine($"Среднее арифметическое трёх чисел: {average}");

// Седьмое задание
Console.WriteLine("--- Задание 7. Калькулятор ---");
Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double y = double.Parse(Console.ReadLine()!);
double sumResult = x + y;
double difResult = x - y;
double prodResult = x * y;
double divResult = x / y;
Console.WriteLine($"Сумма: {sumResult}");
Console.WriteLine($"Разность: {difResult}");
Console.WriteLine($"Произведение: {prodResult}");
Console.WriteLine($"Частное: {divResult}");
