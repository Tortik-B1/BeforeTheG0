// первое задание
int number = 10;
if(number > 0){
    Console.WriteLine("Число положительное");
}
else if(number == 0){
    Console.WriteLine("Число равно нулю");
}
else {
    Console.WriteLine("Число отрицательное");
}

// второе задание
Console.Write("Введите свой возраст: ");
int age = int.Parse(Console.ReadLine());
if(age >= 18){
    Console.WriteLine("Вы совершеннолетний");
}
else if(age < 18){
    Console.WriteLine("Вы несовершеннолетний");
}

// третье задание
int num = 7;
if(num % 2 == 0){
    Console.WriteLine("Число чётное");
}
else{
    Console.WriteLine("Число нечётное");
}

// четвертое задание
int a = 5;
int b = -2;
if(a > 0 && b > 0){
    Console.WriteLine("Оба числа положительные");
}
else if(a > 0 || b > 0){
    Console.WriteLine("Оба числа положительные");
}
if(a < 0){
    Console.WriteLine("а не положительное");
}

// пятое задание
Console.Write("Введите свою оценку: ");
int grade = int.Parse(Console.ReadLine());
if(grade < 3){
    Console.WriteLine("неудовлетворительно");
}
else if(grade == 3){
    Console.WriteLine("удовлетворительно");
}
else if(grade == 4){
    Console.WriteLine("хорошо");
}
else if(grade == 5){
    Console.WriteLine("отлично");
}
