// 1.Найти максимальное число из 2 введенных (2 способа)
// Первый способ
{
    Console.WriteLine("Введите первое число:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Max(number1, number2));
}
//Второй способ
{
    Console.WriteLine("Введите первое число:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number2);
    }
}

// 2.Выявить является ли введенное число четным
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = number % 2;
    string result = number == 0 ? " число чётное" : " число нечётное";
    Console.WriteLine(result);
}


// 3. Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// вывести день для введенного числа.

{
    Console.WriteLine("Введите число от 1 до 7 :");
    int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
    string? day = dayOfTheWeek switch
    {
        0 or > 7 or < 0 => "Неверно введено число",
        1 => "понедельник",
        2 => "вторник",
        3 => "среда",
        4 => "четверг",
        5 => "пятница",
        6 => "суббота",
        7 => "воскресенье"
    };
    System.Console.WriteLine(day);
}

// 4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false (Char.IsDigit(str2, position))





// Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом 
// числе цифр, а также положительное оно или отрицательное. Например, "Число " + 
// num + " однозначное положительное". (Length)
{
    Console.WriteLine("Введите число ");
    string? text = Console.ReadLine();
    if (int.TryParse(text, out int value))
    {
        int length = text?.Length ?? default;
        Console.Write($"Число {value} - {length} символов ");
        if (value > 0)
        {
            Console.Write("Однозначно положительное ");
        }
        else
        {
            Console.Write("Однозначно отрицательное ");
        }
    }
}


// 6.Найти квадратный корень числа. Если же число без плавающей точки, то просто
// вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел
// 7. Два автомобиля едут друг к другу с постоянными скоростями V1 и V2 км/ч.
// Определите, через какое время автомобили встретятся, если расстояние между
// ними равно S км. Добавить проверку на ввод только чисел
// 8. Пользователь вводит номер месяц. Необходимо вывести пору года по номеру
// месяца (2 способа)

// 9.Пользователь вводит число: 1, 2, 3 или 4.Если это значение ‘2', то вывести в
// консоль 'зима близко', ‘3' – зима, ‘4' – всё' . Решите задачу через switch-case.
// 10. Пользователь вводит одно число. Необходимо вывести обратное ему (число
// является обратным при 1/x). Если при этом введённое с клавиатуры число – ноль,
// то вывести «Обратного числа не существует».
// 11. Напишите программу, которая находит полное число метров по заданному числу
// сантиметров. Добавить проверку на ввод только чисел
// 345 -> 3
// 100 -> 1
// 12. Напишите программу, в которой рассчитывается сумма и произведение цифр
// положительного трёхзначного числа
// 123 -> Сумма цифр = 6 Произведение цифр = 6
// 13. Пользователь вводит четырехзначное число. Напишите код, который будет
// выявлять является ли каждое составляющее числа четным либо нечетным.
// Добавить проверку на ввод только чисел
// 1234 -> 1 – неч 2 – чет 3 – неч 4 - чет

// 14. Пользователь вводит 2 числа от 0 до 10. Сложите переменные так, чтобы в
// результате получилось выражение: “I’m хх". Проверки на ввод только чисел.
// Проверки на ввод чисел до 10. Если первое число – 0, то опустить его
{
    Console.WriteLine("Введите первое число");
    string? number1 = Console.ReadLine();
    Console.WriteLine("Введите первое число");
    string? number2 = Console.ReadLine();
    if (int.TryParse(number1, out int number3) && int.TryParse(number2, out int number4))
    {
        if (number3 >= 0 && number3 >= 0 && number4 >= 0 && number4 <= 10)
        {
            Console.WriteLine($"I’m {number4}");
        }
        else
        {
            Console.WriteLine($"I’m {number3}{number4}");
        }
    }
    else
        {
            Console.WriteLine("Ваше число меньше нуля или больше десяти");
        }
}

// 15. Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// вывести длину строки
{
    Console.WriteLine("Задача номер 15.");
    Console.WriteLine("Введите строку ");
    string? text = Console.ReadLine();
    if (!int.TryParse(text, out _))
    {
        if (!string.IsNullOrEmpty(text))
        {
            Console.WriteLine($"Длинна строки {text.Length}");
        }
        else
        {
            Console.WriteLine("пустота");
        }
    }
    else
    {
        Console.WriteLine("ввели число");
    }
}
// 16. Пользователь вводит строку. Вывести первый символ строки (индексы)
{
    string? value1 = Console.ReadLine();
    Console.WriteLine(value1[0]);
}
// 17.Пользователь вводит строку.Необходимо сделать проверку, что это не число и
// вывести текущую строку в большом регистре
// 18. Пользователь вводит строку.Необходимо повторить ее трижды
// 19. Ввести строку. Проверить является ли это число или текст.Если число, то
// выяснить, четное или нет.Если это текст и равен “hschool”, вывести true. В
// противном случае false
string? funfy = Console.ReadLine();
int funfynumber;
if (int.TryParse(funfy, out funfynumber))
{
    if (funfynumber % 2 == 0)
    {
        Console.WriteLine("Число Чёткое");
    }
    else { Console.WriteLine("Число НЕЧёткое"); }
}
else
{
    if (funfy == "hschool")
    { Console.WriteLine(true); }
    else { Console.WriteLine(false); }
}