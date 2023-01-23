// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая цифра трехзначного числа = ");
Console.WriteLine(centerNumber(number));

int centerNumber ( int a) {
   int result = ((a/10) % 10);
    return result;
}
