try
{
  Console.WriteLine("Задание 6. Программа, которая принимает на вход число и проверяет является ли оно палиндромом.");

  Console.WriteLine("Введите число: ");

  string number1 = Console.ReadLine();

  if (Int32.Parse(number1) > 0)
  {
    //string[] number2 = new string[number1.Length];
    var number2 = new List<string>(); // прищлось использовать список, поскольку после завершения цикла 
                                      //number2[i] был идентичным number1[i], но в теле цикла массив number2[i] был зеркальным. Может что-то делал не так.

    for (int i = number1.Length - 1; i >= 0; i--)
    {
      //number2[i] = number1[i].ToString();
      number2.Add(number1[i].ToString());
    }

    number2.ToArray();

    int count = 0;

    for (int i = 0; i < number1.Length; i++)
    {
      //if (number1[i] == number2[i]) - пришлось перевести , поскольку прямое сравнение элементов массива не дает никакого результата

      if (number1[i].ToString() == number2[i].ToString())
        count++;
    }

    Console.Write(count == number1.Length ? $"Введенное чило {number1} является палиндромом." : $"Введенное чило {number1} неявляется палиндромом.");
  }
  else Console.WriteLine("Введите положительное значение.");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}