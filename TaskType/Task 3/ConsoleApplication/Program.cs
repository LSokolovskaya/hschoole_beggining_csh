{
    Console.WriteLine("1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’, если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’");

    Console.WriteLine("Введите число: ");
    int nomer = Convert.ToInt32(Console.ReadLine());
    string communication;
    if (nomer > 0)
    {
        communication = "Положительное";
    }
    else if (nomer < 0)
    {
        communication = "Отрицательно";
    }
    else
    {
        communication = "Ноль";
    }
    Console.WriteLine(communication);
}

{
    Console.WriteLine("2. Вы вводите значение с клавиатуры. Если значение четное, то вывести true, впротивном случае false");

    Console.WriteLine("Введите число: ");
    int nomer = Convert.ToInt32(Console.ReadLine());
    string communication;
    if (nomer % 2 == 0)
    {
        communication = "true";
    }
    else
    {
        communication = "false";
    }
    Console.WriteLine(communication);
}

{
    Console.WriteLine("3. Пользователь вводит с клавиатуры число. Найдите корень введенного числа(если же результат – число с плавающей точкой, то округлить до 2 знаков после запятой).");

    Console.WriteLine("Введите число: ");
    double nomer = Convert.ToDouble(Console.ReadLine());
    double answer = Math.Round(Math.Sqrt(nomer), 2);
    Console.WriteLine(answer);
}

{
    Console.WriteLine("4. Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без остатка на b. Если это так - выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и остаток от деления");

    Console.WriteLine("Введите первое число: ");
    int nomer1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int nomer2 = Convert.ToInt32(Console.ReadLine());
    int answer;
    if (nomer1 % nomer2 == 0)
    {
        answer = nomer1 / nomer2;
        Console.WriteLine("Делитcя");
    }
    else
    {
        answer = nomer1 % nomer2;
        Console.WriteLine($"Делитcя с остатком: {answer}");
    }
}

{
    Console.WriteLine("5. Пользователь вводит с клавиатуры число. Найдите корень введенного числа (если же результат – число с плавающей точкой, то округлить то целых)");

    Console.WriteLine("Введите число: ");
    int nomer = Convert.ToInt32(Console.ReadLine());
    double answer = Math.Round(Math.Sqrt(nomer), 0);
    Console.WriteLine(answer);
}

{
    Console.WriteLine("6. Даны три числа a, b, c. Напишите программу, которая находит корни квадратного уравнения ax2 + bx + c = 0 Если уравнение имеет два корня, то следует вывести их в порядке возрастания.");

    Console.WriteLine("Введите первое число: ");
    double nomerA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double nomerB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double nomerC = Convert.ToInt32(Console.ReadLine());
    double nomerDiskriminant = nomerB * nomerB - 4 * nomerA * nomerC;
    if (nomerDiskriminant > 0)
    {
        double resoult1 = (-nomerB + Math.Sqrt(nomerDiskriminant)) / (2 * nomerA);
        double resoult2 = (-nomerB - Math.Sqrt(nomerDiskriminant)) / (2 * nomerA);
        Console.WriteLine(resoult1 > resoult2 ? ($" Корни: {resoult2}, {resoult1}") : ($" Корни: {resoult1}, {resoult2}")); //тернарный
                                                                                                                            //     Console.WriteLine($" Корени: {resoult1}, {resoult2}");
    }
    else if (nomerDiskriminant < 0)
    {
        Console.WriteLine(" Корней нет ");
    }
    else
    {
        double resoult = -nomerB / (2 * nomerA);
        Console.WriteLine($" Корень: {resoult}");
    }
}
Console.WriteLine("7. Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо вывести на экран словами введенную сумму и в конце написать название валюты с правильным окончанием. Например: 7431 – семь тысяч четыреста тридцать один доллар, 2149 – две тысячи сто сорок девять долларов, 15 – пятнадцать долларов, 3 – три доллара.");
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string result = $"{number} - ";
int number1 = number / 1000;
if (number1 == 1)
{
    Console.Write("Тысяча");
}
else if (number1 == 2)
{
    Console.Write("Две тысячи");
}
else if (number1 == 3)
{
    Console.Write("Три тысячи");
}
else if (number1 == 4)
{
    Console.Write("Четыре тысячи");
}
else if (number1 == 5)
{
    Console.Write("Пять тысяч");
}
else if (number1 == 6)
{
    Console.Write("Шесть тысяч");
}
else if (number1 == 7)
{
    Console.Write("Семь тысяч");
}
else if (number1 == 8)
{
    Console.Write("Восемь тысяч");
}
else if (number1 == 9)
{
    Console.Write("Девять тысяч");
}

number = number % 1000;
number1 = number / 100;
if (number1 == 1)
{
    Console.Write(" сто");
}
else if (number1 == 2)
{
    Console.Write(" двести");
}
else if (number1 == 3)
{
    Console.Write(" триста");
}
else if (number1 == 4)
{
    Console.Write(" четыреста");
}
else if (number1 == 5)
{
    Console.Write(" пятьсот");
}
else if (number1 == 6)
{
    Console.Write(" шестьсот");
}
else if (number1 == 7)
{
    Console.Write(" семьсот");
}
else if (number1 == 8)
{
    Console.Write(" восемьсот");
}
else if (number1 == 9)
{
    Console.Write(" девятьсот");
}
number = number % 100;
if (number <= 19 && number >= 11)
{
    if (number == 11)
    {
        Console.Write(" одиннадцать");
    }
    else if (number == 12)
    {
        Console.Write(" двенадцать");
    }
    else if (number == 13)
    {
        Console.Write(" тринадцать");
    }
    else if (number == 14)
    {
        Console.Write(" четырнадцать");
    }
    else if (number == 15)
    {
        Console.Write(" пятнадцать");
    }
    else if (number == 16)
    {
        Console.Write(" шастнадцать");
    }
    else if (number == 17)
    {
        Console.Write(" семнадцать");
    }
    else if (number == 18)
    {
        Console.Write(" восемнадцать");
    }
    else if (number == 19)
    {
        Console.Write(" девятнадцать");
    }
}
else
{
    number1 = number / 10;
    if (number1 == 1)
    {
        Console.Write(" десять");
    }
    else if (number1 == 2)
    {
        Console.Write(" двадцать");
    }
    else if (number1 == 3)
    {
        Console.Write(" тридцать");
    }
    else if (number1 == 4)
    {
        Console.Write(" сорок");
    }
    else if (number1 == 5)
    {
        Console.Write(" пятьдесят");
    }
    else if (number1 == 6)
    {
        Console.Write(" шестьдесят");
    }
    else if (number1 == 7)
    {
        Console.Write(" семьдесят");
    }
    else if (number1 == 8)
    {
        Console.Write(" восемьдесят");
    }
    else if (number1 == 9)
    {
        Console.Write(" девяносто");
    }
    number = number % 10;
    int edynyca = number / 1;
    if (edynyca == 1)
    {
        Console.Write(" один");
    }
    else if (edynyca == 2)
    {
        Console.Write(" два");
    }
    else if (edynyca == 3)
    {
        Console.Write(" три");
    }
    else if (edynyca == 4)
    {
        Console.Write(" четыре");
    }
    else if (edynyca == 5)
    {
        Console.Write(" пять");
    }
    else if (edynyca == 6)
    {
        Console.Write(" шесть");
    }
    else if (edynyca == 7)
    {
        Console.Write(" семь");
    }
    else if (edynyca == 8)
    {
        Console.Write(" восемь");
    }
    else if (edynyca == 9)
    {
        Console.Write(" девять");
    }
}

{
    Console.WriteLine("Пользователь вводит порядковый номер пальца руки. Необходимо показать его название на экран.");
    Console.WriteLine("Посмотрите на свои руки с лицевой стороны и укажите номер пальца (счет ведется справа налево) чтобы узнать как называется палец и укажите его номер");
    int palec = Convert.ToInt32(Console.ReadLine());
    if (palec == 1)
    {
        Console.WriteLine("большой палец");
    }
    else if (palec == 2)
    {
        Console.WriteLine("указательный палец");
    }
    else if (palec == 3)
    {
        Console.WriteLine("средний палец");
    }
    else if (palec == 4)
    {
        Console.WriteLine("безымянный палец");
    }
    else if (palec == 5)
    {
        Console.WriteLine("мезинец");
    }
    else if (palec == 6)
    {
        Console.WriteLine("мезинец");
    }
    else if (palec == 7)
    {
        Console.WriteLine("безымянный палец");
    }
    else if (palec == 8)
    {
        Console.WriteLine("средний палец");
    }
    else if (palec == 9)
    {
        Console.WriteLine("указательный палец");
    }
    else if (palec == 10)
    {
        Console.WriteLine("большой палец");
    }
}

// Необходимо написать программу, которая проверяет пользователя на знание
// таблицы умножения. Пользователь сам вводит два целых однозначных числа.
// Программа задаёт вопрос: результат умножения первого числа на
// второе. Пользователь должен ввести ответ и увидеть на экране правильно он
// ответил или нет. Если нет – показать еще и правильный результат.
{
    Console.WriteLine("Введите первое число");
    int number11 = Convert.ToInt32(Console.ReadLine());
    if (number11 < 0)
    {
        Console.WriteLine("Это отрицательное число. Попробуйте еще раз, но только с положительным числом");
    }
    else if (number11 > 9)
    {
        Console.WriteLine("Это двухзначное число. Попробуйте еще раз, но только с однозначным числом");
    }
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 < 0)
    {
        Console.WriteLine("Это отрицательное число. Попробуйте еще раз, но только с положительным числом");
    }
    else if (number2 > 9)
    {
        Console.WriteLine("Это двухзначное число. Попробуйте еще раз, но только с однозначным числом");
    }
    Console.WriteLine("результат умножения одного числа на второе?");
    int resoult = Convert.ToInt32(Console.ReadLine());

    if (resoult < number11 * number2)
    {
        Console.WriteLine("Неверно, попробуйте еще раз");
    }
    else if (resoult > number11 * number2)
    {
        Console.WriteLine("Неверно, попробуйте еще раз");
    }
    else if (resoult == number11 * number2)
    {
        Console.WriteLine($"Верно, ответ: {resoult}");
    }
}

// Пользователь вводит два числа, если хотя бы одно число равно 0 то необходимо
// получить битовую инверсию числа не равного 0, если первое число больше 20,
// необходимо найти остаток от делания большего на меньшее, если второе меньше
// 0 найти модуль целой часть от деления первого числа на второе, если первое и
// второе числа чётные найти логическое битовое И для двух чисел, в противном
// случае логическое битовое ИЛИ. Для полученного результата произвести
// битовый сдвиг который укажет пользователь, если сдвиг четный, то сдвиг вправо,
// если нечетный влево. Полученный результат вывести на экран
{
    Console.WriteLine("Введите первое число");
    int number12 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number12 == 0 || number2 == 0)
    {
        //необходимо получить битовую инверсию числа не равного 0
        if (number12 == 0)
        {

        }
    }
    else if (number12 > 20) //если первое больше 20, то найти остаток от деления большего на меньшее
    {
        if (number12 > number2) //необходимо найти остаток от деления большего на меньшее
        {
            double result1 = number1 % number2;
            Console.WriteLine($"Остаток от деления большего числа на меньшее: {result} ");
        }
        else
        {
            double result1 = number2 % number1;
            Console.WriteLine($"Остаток от деления большего числа на меньшее: {result} ");
        }
    }
    else if (number2 < 0)//если второе меньше 0
    {
        // найти модуль целой часть от деления первого числа на второе
        int modul = Math.Abs(number12 / number2);
        Console.WriteLine($"Модуль целой части от деления первого числа на второе: {modul} ");
    }
    else if (number12 % 2 == 0 && number2 % 2 == 0) // если четные найти логическое битовое И, а если нечетные то ИЛИ
    {
        int number3 = number12 & number2;
        Console.WriteLine(Convert.ToString(number1, toBase: 2));
    }
    else
    {
        int number3 = number12 | number2;
        Console.WriteLine(Convert.ToString(number1, toBase: 2));
    }

    Console.WriteLine("Введите битовый сдвиг");
    int shift = Convert.ToInt32(Console.ReadLine());
    shift = number12 % 2;
    if (number4 = 0)
    {

    }
}
    


