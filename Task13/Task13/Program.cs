/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
Пример
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Write("Введите число: ");
string number =  Console.ReadLine();
if (int.Parse(number) < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char[] num = number.ToCharArray();
    Console.Write($"Третья цифра числа {number}: ");
    Console.WriteLine(num[2]);
}