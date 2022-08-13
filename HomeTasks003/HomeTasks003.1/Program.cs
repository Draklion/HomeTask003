try
{
  Console.WriteLine("Задание 1. Программа, которая принимает на вход координаты точки (X и Y), причем X !=0 и Y!=0 и выдает номер четверти плоскости, в которой находится эта точка.");

  int[] point = new int[2];
  Console.Write("Введите значение X: ");
  point[0] = Int32.Parse(Console.ReadLine());
  Console.Write("Введите значение Y: ");
  point[1] = Int32.Parse(Console.ReadLine());

  Console.WriteLine(point[0] != 0 && point[1] != 0 ?
                    point[0] > 0 && point[1] > 0 ? "Точка находится в I четверти" :
                    point[0] < 0 && point[1] > 0 ? "Точка находится во II четверти" :
                    point[0] < 0 && point[1] < 0 ? "Точка находится в III четверти" :
                                                    "Точка находится в IV четверти" : "Точка лежит на оси.");
}

catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}