try
{
  Console.WriteLine("Задание 5. Программа, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.");

  Console.WriteLine("Введите число от 1 до N: ");
  int number = Int32.Parse(Console.ReadLine());

  if (number < 1)
    Console.WriteLine("Вы ввели значение меньше 1.");
  else
  {
    Console.Write($"Таблица кубов от 1 до {number}: ");
    for (int i = 1; i <= number; i++)
    {
      Console.Write(Math.Pow(i, 3));
      if (i != number)
        Console.Write(", ");
    }
  }
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}