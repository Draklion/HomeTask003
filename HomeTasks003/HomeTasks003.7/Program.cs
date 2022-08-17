try
{
  Console.WriteLine("Задание 3. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D.");

  int[] firstPoint = new int[3];
  int[] secondPoint = new int[3];
  Console.WriteLine("Введите кооринаты точки А(X,Y,Z):");
  for (int i = 0; i < firstPoint.Length; i++)
    firstPoint[i] = Int32.Parse(Console.ReadLine());
  Console.WriteLine("Введите кооринаты точки В(X,Y,Z):");
  for (int i = 0; i < secondPoint.Length; i++)
    secondPoint[i] = Int32.Parse(Console.ReadLine());

  Console.WriteLine($"Расстояние между точками А и В: {Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) + Math.Pow(secondPoint[1] - firstPoint[1], 2) + Math.Pow(secondPoint[2] - firstPoint[2], 2))}");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}