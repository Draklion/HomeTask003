try
{
  Console.WriteLine("Задание 3. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D.");

  int[] firstPoint = new int[2];
  int[] secondPoint = new int[2];
  Console.WriteLine("Введите кооринаты точки А(X,Y):");
  for (int i = 0; i < firstPoint.Length; i++)
    firstPoint[i] = Int32.Parse(Console.ReadLine());
  Console.WriteLine("Введите кооринаты точки В(X,Y):");
  for (int i = 0; i < secondPoint.Length; i++)
    secondPoint[i] = Int32.Parse(Console.ReadLine());

  Console.WriteLine(Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) + Math.Pow(secondPoint[1] - firstPoint[1], 2)));
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}