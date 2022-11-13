// 1.Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false. Добавить проверки для строк. Удалить лишние пробелы
{
    Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        bool result = text.ToLower().Trim() == "hschool";
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Вы ввели пустую строку");
    }
}
// 2.Ввести строку. Проверить является ли это число или строка. Если число, то выяснить, четное или нет. Если это строка то преобразовать строку в массив, где каждый символ – один элемент массива
// ‘hschool’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]
{
    Console.WriteLine("Введите строку");// стринг джоин
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (double.TryParse(text, out double number))
        {
            Console.WriteLine(number % 2 == 0 ? "четное" : "нечетное");
        }
        else
        {
            char[] result = text.ToCharArray();
            Console.WriteLine(result.Length);
        }
    }
}

// 3.Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’, ‘developer’]
{
    string text = "Full StaCK DevELoper";
    System.Console.WriteLine(text.ToLower());
    var value = text.ToLower().Split(' ');
    System.Console.WriteLine(value[0]); // full
    System.Console.WriteLine(value[1]); //stack
    System.Console.WriteLine(value[2]); //developer
}

//4.Ввести строку. Проверить на isNaN. Если число, то ошибка ввода. Если это строка то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы
{
    string text = Console.ReadLine();
    string.IsNullOrEmpty(" ");///
    if (int.TryParse(text, out int number))
    {
        System.Console.WriteLine("Ошибка ввода");
    }
    else
    {
        System.Console.WriteLine(text.Trim().Length);
    }
}

// 5. ‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"
{
    string text = "HTML JavaScript PHP";
    text = text.ToUpper();
    System.Console.WriteLine(text.Replace(" ", "-"));
}
// 6.Ввести строку. Проверить является ли это число или строка. Если число, то ошибка ввода. Если это строка то первый символ поставить в верхний регистр. Убрать лишние пробелы
{
    string? text = Console.ReadLine();
    text = text?.Trim();
    if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out _))
    {
        System.Console.WriteLine(string.Concat(Convert.ToString(text[0]).ToUpper(), text.Remove(0, 1)));
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}

// 7.На вход программе подаётся строка. Замените все @ на '!' с помощью глобального поиска и замены (2 способа)
{
    {
        System.Console.WriteLine("введите строку");
        string? text = Console.ReadLine();
        if (!string.IsNullOrEmpty(text))
        {
            Console.WriteLine(text.Replace('@', '!'));
        }
        else
        {
            System.Console.WriteLine("ошибка ввода");
        }
    }
}
// 8.Дана строка 'aaa bbb ccc'. Вырежите из нее слово 'bbb'
{
    string text = "aaa bbb ccc";// index of
    System.Console.WriteLine(text.IndexOf("bbb"));
}
// 9.На вход программе подается переменная text, в котрой лежит дата в формате 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx/xx/xxxx’. (reverse)
{
    Console.WriteLine("Введите дату xxxx-xx-xx");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string[] result = text.Split("-");
        Console.WriteLine(string.Join("/", result[1], result[2], result[0]));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 10. Дана строка из 3 слов разделенных пробелом:
// • Найдите количество символов в этой строке.
// • Вырежите из нее 2 и 3 слова.
// • Найдите индекс 2 подстроки


// 11. Пользователь вводит дату в формате ‘х-х-х'. Замените все дефисы на '!'
{
    Console.WriteLine("Введите дату x-x-x");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string[] result = text.Split("-");
        Console.WriteLine(string.Join("!", result[0], result[1], result[2]));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}
// 12. Пользователь вводит дату в формате 'xxxx-xx-xx'. Преобразуйте эту дату в формат
// 'xx.xx.xxxx'.
{
    Console.WriteLine("Введите дату x-x-x");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string[] result = text.Split("-");
        Console.WriteLine(string.Join(".", result[1], result[2], result[0]));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}
// 13. Дан массив ['я', 'учу', 'javascript', '!']. С помощью метода join преобразуйте массив в
// строку 'я+учу+javascript+!'.
{
    string[] array = new[] { "я", "учу", "javascript", "!" };
    System.Console.WriteLine(string.Join("+", array));
}

// 14. Дан массив. Вывести каждый одельный элемент в консоль (for)
{
    Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string[] array = text.Split(" ");
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 15. На вход программе подается строка текста, состоящая из слов, разделенных
// ровно одним пробелом. Напишите программу, которая подсчитывает количество
// слов в ней
{
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        text = text.Trim();
        string[] result = text.Split(' ');
        Console.WriteLine(result.Length);
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}
// 16. Пользователь вводит строку. Необходимо посчитать количество гласных (for)
{
    System.Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        text = text.ToLower();
        string letters = "eyuioa";
        int result = 0;
        char[] array = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            if (letters.Contains(array[i]))
            {
                result += 1;
            }
        }
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}

// 17. Пользователь вводит строку. Необходимо посчитать количество согласных (for)
{
    System.Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        text = text.ToLower();
        string letters = "qwrtpsdfghjklzxcvbnm";
        int result = 0;
        char[] array = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            if (letters.Contains(array[i]))
            {
                result += 1;
            }

        }
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}

// 18. Пользователь вводит строку. Необходимо вывести все гласные отдельной
// строкой (for)
// fullstack => ua
{
    System.Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        text = text.ToLower();
        string letters = "eyuioa";
        string result = "";
        char[] array = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            if (letters.Contains(array[i]))
            {
                result += array[i];
            }

        }
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}

// 19. На вход программе подается строка. Преобразуйте первую букву каждого слова
// строки в верхний регистр (for)
{
    string? text = Console.ReadLine();
    string[] array = text?.Split(' ') ?? new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        string result = array[i];
        string resultToUpper = Convert.ToString(char.ToUpper(result[0]));
        resultToUpper += result.Remove(0, 1);
        System.Console.Write(resultToUpper);
    }
}

//Пример из презентации
// {
//     string text = "fgh ghj";
//     System.Console.WriteLine(text.Remove(0, 1));
// }

// int number = text?.GetHashCode() ?? int.MaxValue;
// //==  true
// int number = text != null ? text.GetHashCode() : int.MaxValue;

// 20.На вход программе подается строка, где каждое слово заканчивается “_”.
// Программа должна убрать “_” и первую букву каждого слова (помимо первого),
// преобразовать в верхний регистр (for)
{
    string? text = Console.ReadLine();
    string[] array = text?.Split("_") ?? new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        string result = array[i];
        string resultToUpper = Convert.ToString(char.ToUpper(result[0]));
        resultToUpper += result.Remove(0, 1);
        System.Console.Write(resultToUpper);
    }
}

// 21. На вход программе подается строка, состоящая из имени и фамилии человека,
// разделенных одним пробелом. Напишите программу, которая проверяет, что имя
// и фамилия начинаются с заглавной буквы.
// Chris Alan => true
// chris alan => false


// 22. На вход программе подается строка. Напишите программу, которая меняет
// регистр символов, другими словами замените все строчные символы заглавными
// и наоборот.
// Swap Case => sWAP cASE
{
    string? text = Console.ReadLine();
    text = text?.Trim();
    if (!string.IsNullOrEmpty(text))
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
            {
                result += char.ToUpper(text[i]).ToString();
            }
            else if (char.IsUpper(text[i]))
            {
                result += char.ToLower(text[i]).ToString();
            }
        }

        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}


// 23. На вход программе подается строка текста. Напишите программу, которая
// определяет является ли строка хорошей. Текст хороший, если содержит
// подстроку «хорош» во всевозможных регистрах.
// я очень хороший текст => true
{
    System.Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    text = text?.ToLower();
    string? result = Convert.ToString(text?.Contains("хорош"));
    Console.WriteLine($"{text} => {result}");
}

// Пример
// {
//     string text = "123456";
//     System.Console.WriteLine(text.IndexOf("8"));
// }

// Пример
//     string text = "123456";
// System.Console.WriteLine(text.Contains("8"));

// 24.На вход программе подается строка. Напишите программу, которая подсчитывает
// количество буквенных символов в нижнем регистре.
// abcABCD12345 => 3
{
    string? text = Console.ReadLine();
    text = text?.Trim();
    if (!string.IsNullOrEmpty(text))
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
            {
                int number = 0;
                number += 1;
                result += text[i];
            }
        }
        System.Console.WriteLine(result.Length);
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}


// 25. На вход программе подается строка из букв А, Г, Ц, Т. Напишите программу,
// которая подсчитывает сколько букв
// АааГГЦЦцТТтттА => А – 4 Г – 2 Ц – 3 Т – 5

{
    string? text = Console.ReadLine();
    text = text?.Trim();
    text = text?.ToUpper();
    string result1 = "";
    string result2 = "";
    string result3 = "";
    string result4 = "";
    if (!string.IsNullOrEmpty(text))
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'А')
            {
                int number = 0;
                number += 1;
                result1 += text[i];
            }
            else if (text[i] == 'Г')
            {
                int number = 0;
                number += 1;
                result2 += text[i];
            }
            else if (text[i] == 'Ц')
            {
                int number = 0;
                number += 1;
                result3 += text[i];
            }
            else if (text[i] == 'Т')
            {
                int number = 0;
                number += 1;
                result4 += text[i];
            }
        }
        System.Console.WriteLine($"{text} => A - {result1.Length}  Г - {result2.Length}  Ц - {result3.Length}  Т - {result4.Length}");
    }
    else
    {
        System.Console.WriteLine("null");
    }
}

{
    System.Console.WriteLine("Введите строку");
    string? text = Convert.ToString(Console.ReadLine());
    text = text?.ToLower();
    int result1 = 0;
    int result2 = 0;
    int result3 = 0;
    int result4 = 0;
    if (!string.IsNullOrEmpty(text))
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'а')
            {
                result1 += 1;
            }
            if (text[i] == 'г')
            {
                result2 += 1;
            }
            if (text[i] == 'ц')
            {
                result3 += 1;
            }
            if (text[i] == 'т')
            {
                result4 += 1;
            }
        }
        System.Console.WriteLine($"{text} => A - {result1}  Г - {result2}  Ц - {result3}  Т - {result4}");
    }
    else
    {
        System.Console.WriteLine("null");
    }
}


// 26. На вход программе подается строка текста. Напишите программу, которая
// проверяет, что строка заканчивается подстрокой .com или .ru. Если
// заканчивается, то вывести true, в противном случае false
{
    string? text = Console.ReadLine();
    if (text.EndsWith(".com"))
    {
        System.Console.WriteLine(text.EndsWith(".com"));
    }
    else if (text.EndsWith(".ru"))
    {
        System.Console.WriteLine(text.EndsWith(".ru"));
    }
    else
    {
        System.Console.WriteLine("Ошибка ввода");
    }
}

// 27. На вход подается url. Если он начинается с http, содержит хотя бы один “/” и
// заканчивается подстрокой .com или .ru, то вывести true, в противном случае false
{
    string? text = Console.ReadLine();
    if (text.StartsWith("http"))
    {
        if (Convert.ToBoolean(text.IndexOf("/") > 0))
        {
            if (text.EndsWith(".com"))
            {
                System.Console.WriteLine(text.EndsWith(".com"));
            }
            else if (text.EndsWith(".ru"))
            {
                System.Console.WriteLine(text.EndsWith(".ru"));
            }
            else
            {
                System.Console.WriteLine("Ошибка ввода");
            }
        }
        else
        {
            System.Console.WriteLine("false");
        }
    }
    else
    {
        System.Console.WriteLine("false");
    }
}








// int[] array = new int[] {12, 13 };
// string text = "value";
//  char text1 = text[1];
//  System.Console.WriteLine(text1);



//  char sym = 'a';
// if ('a' == sym) {}


