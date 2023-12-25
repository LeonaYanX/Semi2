// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81
// Console.WriteLine("Введдите число");
// int num= Convert.ToInt32(Console.ReadLine());
// // int num2= int.Parse(Console.ReadLine());

// if(num>99 && num<1000)     //    && -и     || - или
// {
//     int num1 = num/100;
//     int num3 = num % 10;

//     int result = num1*10+num3;

//     Console.WriteLine(result);
// }

// sectask
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int num2 = num/10 %10;
// int num3 = num % 10;
// int result = 1;

// for (int i = 0; i < num3; i++)
// {
//     result = result * num2;
// }
// System.Console.WriteLine(result);

//зад3
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Console.WriteLine("Введдите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введдите число");
// int num2= Convert.ToInt32(Console.ReadLine());

// if(num1 % num2 == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine($"Нет, {num1 % num2}");
// }

//четв.зад
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
// 54678  6
// 45678908    9

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num>99)     //    && -и     || - или
// {
//     int result = num/100 %10;

//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }



