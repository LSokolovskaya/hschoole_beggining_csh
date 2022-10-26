// 1. Объявить оперменные и поменять в их значения три раза (string, int, bool, double)
{
    {
        string value;
        value = "m";
        value += "t";
        value += "w";
        value += "t";
        value += "f";
        value += "s";
        value += "s";

    }
    {
        int value;
        value = 3;
        value += 5;
        value -= 12;
        value++;
        ++value;
    }
    {
        bool value = false;
        value = !value;
        value = value & value;
        value = value | value;
    }
    {
        double value = 1.2;
        value += 12;
        value -= 2;
        value++;
        ++value;
    }
}
// 2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decemel)
{
    byte value = 5;
    int value1 = value;
    long value2 = value1;
    float value3 = value2;
    double value4 = value3;
}

// 3. Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)
{
    byte value = 1;
    int value1 = (int)value;
    long value2 = (long)value1;
    float value3 = (float)value2;
    double value4 = (double)value3;
    decimal value5 = (decimal)value4;
}

// 4. Ввести два числа, произвести арифметические над числами и записать результат в первое число (+, -, /, *, %)
{
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    number1 = number1 + number2;
    number1 = number1 - number2;
    number1 = number1 / number2;
    number1 = number1 * number2;
    number1 = number1 % number2;
    Console.WriteLine(number1);
}
// 5. Ввести число и увеличить его на 1 всеми доступными способами
{
    int number = Convert.ToInt32(Console.ReadLine());
    number += 1;
    number = number + 1;
    number++;
    ++number;
}
// 6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести сообщение,
//  что введено не число.
{//sposob1
    var value = Console.ReadLine();
    int number;
    {
        if (int.TryParse(value, out number))
        {
            Console.WriteLine(number % 5);
        }
        else
        {
            Console.WriteLine("Введено не число");
        }
    }
}
{//sposob2
    string? value = Console.ReadLine();
    int number;
    bool number1 = int.TryParse(value, out number);
    string result = number1 == true ? $"{number % 5}" : "Введено не число";
    Console.WriteLine($"{result}");
}
// 7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение какие строки
//  не являются числом
{
    string? value1 = Console.ReadLine();
    string? value2 = Console.ReadLine();
    int number1;
    int number2;
    if (int.TryParse(value1, out number1) && int.TryParse(value2, out number2))
    {
        Console.WriteLine(value1 + value2);
    }
    else if (int.TryParse(value1, out number1))
    {
        Console.WriteLine("Первое значение не число");
    }
    else if (int.TryParse(value2, out number2))
    {
        Console.WriteLine("Второе значение не число");
    }
}
// 8. Ввести два числа, если 1 число больше 2, то произвести деление 1 на 2, если 2 больше 1 вывести разность 
// между 2 и 1, в противном 
// случае вернуть 0.0 и результат увеличить на 10 (if-else, тернаный оператор)
{//if-else
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine(number1 / number2);
    }
    else if (number1 < number2)
    {
        Console.WriteLine(number2 - number1);
    }
    else
    {
        Console.WriteLine(number1 + 10);
        Console.WriteLine(number2 + 10);
    }
}
{//тернарный оператор
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int result1 = number1 > number2 ? number1 / number2 : number1 = number1 + 10;
    int result2 = number2 > number1 ? number2 - number1 : number2 = number2 + 10;
    Console.WriteLine(result1);
    Console.WriteLine(result2);
}
// 9. Ввести две строки, если две строки числа то ввести арифметический оператор, b в зависисмоти от 
// арфметического оператора произвести то действие в проитивных случаях произвести вывод сообщений.
//  Сделать проверку на null оператора (if-else, switch, сокращенный switch)


{// 10. Ввести две строки и произвести сложение данных строк всеми известными способами
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int number3 = Convert.ToInt32(Console.ReadLine());
    number1 = number1 + number2;
    number3 = number1 + number2;
    number1 += number2;
    number1 += number2;
}

{// 11. Ввести строку до 5 символов, если строка число то вывести для кажкой цифры в числе
//  кратно оно двум либо нет, то есть 6352 => 6 крастно двум, 3 не кратно двум, 5  не кратно двум,
//  2  кратно двум (if-else, тернаный оператор)

}

{// 12. Ввести две строки, произвести проверку на пустоту, если строки имеют символы то если
//  первая строка больше второй вывести сумму длин строк, в противном случае разность 2 от первой
//  (if-else, тернаный оператор, *.Length, string.IsNullorEmpty)

}