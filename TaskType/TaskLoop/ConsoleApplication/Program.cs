// {//задача 1
//     int number = 0;
// for (int i = 0; i <= 50; i++)
// {
//     Console.WriteLine(i)
// }
// int number = default;
// Console.WriteLine("while");
// while (number < 50);
// {
//     Console.WriteLine(++number);
// }
// }
// // 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
// int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
// for (int i = 0; i < array1.Length; i++)
// {
//     System.Console.WriteLine(array1[i]);
// }
// // while ()
// int index = 0;
// while (index < array1.Length)
// {
//     System.Console.WriteLine(array1[index++]);
// }

// foreach (int item in array1)
// {
//     System.Console.WriteLine(item);
// }

// //3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// // элементов этого массива.
// {
// int [] array = new int[4] { 2, 3, 4, 5 }
// int i = 0;
// int result = 1;
// while (i <= array.Length)
// {
// result *= array[i];
// i++
// }
// Console.WriteLine(result)
// // ----------------------
// result = 1
// for (int j = 0; j < array.Length; j++)
// {
//     result *= array [j]
// }
// Console.WriteLine(result)
// //------------------------
// foreach(int item in array)
// {
//     result *= item;
// }
// Console.WriteLine(result);
// }
// // 4. Выведите столбец чисел от 11 до 33 циклом while
// {
// for (int i = 11; i <= 33; i++)
// {
//     System.Console.WriteLine(i);
// }

// //--------------------
// int number;
// int i = 11;
// while(11<=i && i<=33)
// {
//     System.Console.WriteLine(i++);
// }
// }

// // 5. Выведите столбец четных чисел в промежутке от 0 до 100 (for)
// int[] array1 = new int[101];
// for (int i = 0; i <= array1.Length; i++)
// {
//     System.Console.WriteLine(i);
// }

// // 6. С помощью цикла while найдите сумму чисел от 1 до 100.


// // 7. Дан массив с элементами [1, 2, 3, 4, 5]. С помощью цикла for of найдите сумму
// // элементов этого массива
// int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
// int difference = 0
// for (int i = 0; i < array1.Length; i++)
// {
//     System.Console.WriteLine(difference += i);
// }

// // 8. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 3 циклом foreach in 

// // 9. Дан массив с элементами [1, 2, 2, 3, 4, 4, 3, 4, 5]. Выведите только уникальные
// // значения массива -> [1, 5] (for)
// {
//     int[] array = 0; new int[9] {1, 2, 2, 3, 4, 4, 3, 4, 5};
//     for (int i =0; i < array.Length && i % 5 == 0 || i % 7 ==0)
//     {
//         System.Console.WriteLine(i);
//     }
// }
// // 10. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 5 циклом while


// // 1. Дан массив с числами. Числа могут быть положительными и отрицательными.
// // Найдите сумму всех положительных элементов массива циклом foreach in

// // 10. Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. Выведите на экран только
// // те числа из массива, которые начинаются на цифру 1, 2 или 5 -> 10, 20, 50, 235
          
 
// // 13. Дан массив с элементами 1, 2, 3, 4, 5, 6, 7, 8, 9. С помощью цикла for создайте строку '-1-2-3-4-5-6-7-8-9-‘
// string[] array1 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// for (int i = 0; i < array1.Length; i++)
// {
// string.IsNullOrEmpty(", ")
// }

// // 14. Дано число 7, найдите все числа кратные 7 до 100
// int[] array1 = new int[100];
// for (int i = 0; i < array1.Length && i % 7 = 0; i++)
// {
//     System.Console.WriteLine(i);
// }

// // 15. Дано предложение и количество раз которое его надо повторить. Напишите
// // программу, которая повторяет данное предложение нужное количество раз.
// int 
// int[] array1 = new int[5];
// for (int i = 0; i < array1.Length; i++)

// // 16. Пользователь вводит число, явдяющееся количеством элементов будущего
// // массива и выбирает тип данных массива. Напишите код заполнения массива
// // выбранным типом данных.


// // 17. Пользователь вводит число, явдяющееся количеством элементов будущего
// // массива. Напишите код заполнения массива. Записать в массив только числа.


// // 18. Пользователь вводит многозначное число. Необходимо вставить двоеточие
// // между двумя нечетными числами. Работать с числом как с массивом. Использовать for
// // 55639217 -> 5:563:921:7.













//  System.Console.WriteLine("Введите строку");
// string text = Console.ReadLine();
// System.Console.WriteLine(text = "#" + text);

// На вход подается предложение из нескольких слов. Необходимо строку преобразовать в массив строк и вывести последний элемент массива. 
// Например: "I'm a full-stack developer" -> "developer" ({"i'm", "a", "full-stack", "developer"})
// System.Console.WriteLine("введите предложение");
// string text = Console.ReadLine();
// string[] array = text.Split(" ");
// System.Console.WriteLine(array[array.Length-1]);


// На вход подается строка. Необходимо вставить тире между словами
// Пример: "HTML JavaScript PHP C#" -> "HTML-JavaScript-PHP-C#"
// Подсказка: задачу можно решить в пару строк кода. Необходимо просто разделить по определенному сиволу строку на массив и собрать
string text = Console.ReadLine();
string[] array = text.Split(" ");
System.Console.WriteLine(string.Join("-", array));
