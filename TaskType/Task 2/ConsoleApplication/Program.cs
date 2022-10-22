// // Даны переменные a = 10 и b = 3. Найдите остаток от деления a на b.
int p = 10;
int m = 3;
int result = p % m;
Console.WriteLine($"Остаток от деления a на b : {result}");

// Пользователь вводит с клавиатуры 2 числа: основание степени и показатель степени. Необходимо возвести число во введенную степень;
Console.Write("Введите значение основания: ");
var varible = Console.ReadLine();
int bounding = Convert.ToInt32(varible);
Console.Write("Введите значение степени: ");
varible = Console.ReadLine();
int exponent = Convert.ToInt32(varible);
Console.WriteLine($"Ответ:"+ Math.Pow(bounding,exponent));

// Напишите программу, которая считывает длины двух катетов в прямоугольном треугольнике и выводит его площадь. Используйте формулу;
Console.Write("Первый катет: ");
int katet1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второй катет: ");
int katet2 = Convert.ToInt32(Console.ReadLine());

// double square = 0.5*katet1*katet2;  
double square = 0.5*katet1*katet2;
Console.WriteLine($"Площадь треугольника равна:  {square}");

// У известного американского писателя Рэя Бредбери есть роман «451 градус по
// Фаренгейту». Напишите скрипт, который определяет, какой температуре по
// шкале Цельсия соответствует указанное значение по шкале Фаренгейта.
// Используйте формулу: 
int Fahrenheit = 451;
int celsius = (Fahrenheit- 32) / 9 * 5;
Console.WriteLine($"451°F = {celsius}°C");

// Даны переменные a и b. Проверьте, что a делится без остатка на b. Если это так -
// выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и
// само значение деления
Console.Write("Введите число а: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int k = Convert.ToInt32(Console.ReadLine());
int remainder = i%k;
int remainder1 = i/k;
if(remainder > 0){Console.WriteLine($"Делится с остатком {remainder}");}
else{Console.WriteLine($"Делится {remainder1}");}

// Вы вводите 2 числа a и b. Вам необходимо решить пример (2(а-b)-4(b-a))/2
Console.Write("Введите число а: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int n = Convert.ToInt32(Console.ReadLine());
int answer = (2*(l-n)-4*(n-l))/2;
Console.WriteLine($"Ответ: {answer}");

// На вход программе подается число n – количество собачьих лет. Напишите
// программу, которая вычисляет возраст собаки в человеческих годах.
// В течение первых двух лет собачий год равен 10.5 человеческим годам. После
// этого каждый год собаки равен 4 человеческим годам 
Console.WriteLine("Сколько собаке лет? ");
int year = Convert.ToInt32(Console.ReadLine());
if (year<=2) 
{double age = year*10.5;
Console.Write($"Если бы собака была человеком, то ей бы уже было {age} лет");}
else {Console.WriteLine($"Если бы собака была человеком, то ей бы уже было {2*10.5+(n-2)*4} лет");};

// Найдите квадратный корень из 245. Предварительно изучите System.Math и в
// отдельности Math.Sqrt
Console.WriteLine("√245 = " + Math.Sqrt(245));

// Даны числа 4, -2, 5, 19, -130, 0, 10. Найдите минимальное и максимальное число.
// Предварительно изучите модуль Math и в отдельности Math.Min и Math.Max
int a = 4;
int b = -2;
int c = 5;
int d = 19;
int e = -130;
int f = 0;
int g = 10;
int maximum = Math.Max(a,Math.Max(b,Math.Max(c,Math.Max(d,Math.Max(e,Math.Max(f,g)))))); 
Console.WriteLine($"Самое большое число: {maximum}");
int minimum = Math.Min(a,Math.Min(b,Math.Min(c,Math.Min(d,Math.Min(e,Math.Min(f,g)))))); 
Console.WriteLine($"Самое маленькое число: {minimum}");

// Напишите программу, вычисляющую объём куба и площадь его полной
// поверхности, по введённому значению длины ребра. Используйте формулы:
Console.Write("Длина ребра: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int sguare = 6*lenght*lenght;
Console.WriteLine($"Площадь куба: {sguare}");
int volume = lenght*lenght;
Console.WriteLine($"Объем куба: {volume} ");

// Напишите программу, в которой вычисляется сумма, разность и произведение
// // двух целых чисел, введенных с клавиатуры.
Console.WriteLine("Введите число a");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма = {first+second}");
Console.WriteLine($"Разность = {first-second}");
Console.WriteLine($"Произведение = {first*second}");

// Напишите программу для пересчёта величины временного интервала, заданного
// в минутах, в величину, выраженную в часах и минутах:
// Пример:
// 150 => 2 час 30 минут
// 50 => 0 час 50 минут
// 240 => 4 час 0 минут
Console.WriteLine("Сколько прошло минут?:");
int minute = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Это будет {minute/60} ч {minute%60} мин");
