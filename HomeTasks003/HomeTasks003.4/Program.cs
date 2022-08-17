try
{
  Console.WriteLine("Задание 4. Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.");

  Console.WriteLine("Введите число: ");
  int number = Int32.Parse(Console.ReadLine());
  Console.Write($"Таблица квадратовот 1 до {number}: ");
  for (int i = 1; i <= number; i++)
  {
    Console.Write(Math.Pow(i, 2));
    if (i != number)
      Console.Write(", ");
  }
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}