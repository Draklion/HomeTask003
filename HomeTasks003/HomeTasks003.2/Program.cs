try
{
  Console.WriteLine("Задание 2. Программа, которая по заданому номеру четверти, показывает диапазон возможных координат точек в этой четверти.");

  Console.Write("Введите номер четверти: ");
  int quarterNumber = Int32.Parse(Console.ReadLine());
  if (quarterNumber > 0 && quarterNumber <= 4)
  {
    switch (quarterNumber)
    {
      case 1:
        Console.WriteLine("Диапазон первой четверти по X и Y от 1 до N");
        break;
      case 2:
        Console.WriteLine("Диапазон второй четверти по X от -1 до -N, по Y от 1 до N");
        break;
      case 3:
        Console.WriteLine("Диапазон третье четверти по X от -1 до -N, по Y от -1 до -N");
        break;
      case 4:
        Console.WriteLine("Диапазон четвертой четверти по X  от 1 до N, по Y от -1 до -N");
        break;
    }
  }
  else
    Console.WriteLine("Вы ввели неверный номер четверти.");
}

catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}