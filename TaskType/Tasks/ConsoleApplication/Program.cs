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
{// 9. Ввести две строки, если две строки числа то ввести арифметический оператор, b в зависисмоти от 
 // арфметического оператора произвести то действие в проитивных случаях произвести вывод сообщений.
 //  Сделать проверку на null оператора (if-else, switch, сокращенный switch)
    string? number1 = (Console.ReadLine());
    string? number2 = (Console.ReadLine());
    if (int.TryParse(number1, out int value1) && int.TryParse(number2, out int value2))
    {
        Console.WriteLine("Введите арифметический оператор +,-,*,/,%");
        string? shift = Console.ReadLine();
        if (shift?.Equals("+") ?? false)
        {
            Console.WriteLine(value1 + value2);
        }
        else if (shift?.Equals("-") ?? false)
        {
            Console.WriteLine(value1 - value2);
        }
        else if (shift?.Equals("*") ?? false)
        {
            Console.WriteLine(value1 * value2);
        }
        else if (shift?.Equals("/") ?? false)
        {
            Console.WriteLine(value1 / value2);
        }
        else if (shift?.Equals("%") ?? false)
        {
            Console.WriteLine(value1 % value2);
        }
    }
    else
    {
        Console.WriteLine($"{number1} {number2}");
    }

}

{// 10. Ввести две строки и произвести сложение данных строк всеми известными способами
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int number3 = Convert.ToInt32(Console.ReadLine());
    number1 = number1 + number2;
    number3 = number1 + number2;
    number1 += number2;
}

{// 11. Ввести строку до 5 символов, если строка число то вывести для каждой цифры в числе
 //  кратно оно двум либо нет, то есть 6352 => 6 кратно двум, 3 не кратно двум, 5  не кратно двум,
 //  2  кратно двум (if-else, тернаный оператор)
    Console.WriteLine("Введите строку до 5 цифр ");
    string? input1 = Convert.ToString(Console.ReadLine());
    string thousand = "";
    string hundred = "";
    string desatki = "";
    string chislo = "";
    if (!(input1 == null) && int.TryParse(input1, out int number))
    {
        if (number > 999) { thousand = (number / 1000) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 99) { hundred = ((number % 1000) / 100) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 9) { desatki = ((number % 100) / 10) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 0) { chislo = (number % 10) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        Console.WriteLine($"Проверка на кратность двум: {thousand} {hundred} {desatki} {chislo}");
    }
    else 
    Console.WriteLine("Не удача");
}

{// 12. Ввести две строки, произвести проверку на пустоту, если строки имеют символы то если
 //  первая строка больше второй вывести сумму длин строк, в противном случае разность 2 от первой
 //  (if-else, тернаный оператор, *.Length, string.IsNullorEmpty)
    string? number1 = Console.ReadLine();
    string? number2 = Console.ReadLine();
    if (!String.IsNullOrEmpty(number1) && !String.IsNullOrEmpty(number2))
    {
        if (number1.Length > number2.Length)
        { Console.WriteLine(number1.Length + number2.Length); }
        else
        { Console.WriteLine(number2.Length - number1.Length); }
    }
    else
    {
        Console.WriteLine();
    }
}


{
    int number = 5;
object item = number;
System.Console.WriteLine(item.GetType());
string text = "text";
item = text;
System.Console.WriteLine(item.GetType());
char symbol = '?';
item = symbol;
System.Console.WriteLine(item.GetType());
bool value = true;
item = value;
System.Console.WriteLine(item.GetType());
}

{
    object item1 = 5.0;
//подходит если вы уверены на 100%, что item это число
double number1 = Convert.ToDouble(item1); 
object item2 = 4;
//происходит проверка на тип данных, если к такому типу данных привести 
//возможно возвращаем число, в противном случае значение по умолчанию
int number2 = item2 is int number ? number : default;
}

//2 object, если 2 стринг - сумму длинн их, если 2 инта - сумму интов, если нет сообщение - всё плохо))))
// {
//     object obj1 = "fghj";
//     object obj2 = "fghj";
//     if(obj1 is string string1 && obj2 is string string2)
//     {
//         System.Console.WriteLine(string1.Length + string2.Length);
//     }
//     else if(obj1 is int && obj2 is int int2)
//     {
//         System.Console.WriteLine(int1+int2);
//     }
//     else
//     {
//         System.Console.WriteLine("все плохо");
//     }
// }

{
    object item2 = "5";
int number2;

if (item2 is int number )
{
    number2 = number;
}
else
{
    number2 = default;
}
System.Console.WriteLine(number2);
}

{
    var random = new Random();
    random.Next(3, 4);
}