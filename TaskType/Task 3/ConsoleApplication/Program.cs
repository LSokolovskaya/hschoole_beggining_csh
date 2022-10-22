{ Console.WriteLine("1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’, если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’");

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

{ Console.WriteLine("2. Вы вводите значение с клавиатуры. Если значение четное, то вывести true, впротивном случае false");

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

{Console.WriteLine("3. Пользователь вводит с клавиатуры число. Найдите корень введенного числа(если же результат – число с плавающей точкой, то округлить до 2 знаков после запятой).");

    Console.WriteLine("Введите число: ");
    double nomer = Convert.ToDouble(Console.ReadLine());
    double answer = Math.Round(Math.Sqrt(nomer), 2);
    Console.WriteLine(answer);
}

{Console.WriteLine("4. Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без остатка на b. Если это так - выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и остаток от деления");

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

{Console.WriteLine("5. Пользователь вводит с клавиатуры число. Найдите корень введенного числа (если же результат – число с плавающей точкой, то округлить то целых)");

    Console.WriteLine("Введите число: ");
    int nomer = Convert.ToInt32(Console.ReadLine());
    double answer = Math.Round(Math.Sqrt(nomer), 0);
    Console.WriteLine(answer);
}
// Console.WriteLine("6. Даны три числа a, b, c. Напишите программу, которая находит корни квадратного уравнения");
// ax
// 2 + bx + c = 0
// Если уравнение имеет два корня, то следует вывести их в порядке возрастания.
// 
    // Console.WriteLine("Введите первое число: ");
    // int nomer1 = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите второе число: ");
    // int nomer2 = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите третье число: ");
    // int nomer3 = Convert.ToInt32(Console.ReadLine());
   