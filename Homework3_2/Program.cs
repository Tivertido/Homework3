// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x точки A: ");
int ax = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки A: ");
int ay = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки A: ");
int az = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bx = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int by = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bz = Convert.ToInt32(Console.ReadLine()!);

double distance; // переменная для расстояния
        
        // Находим расстояние между точками
        distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
        
        // Выводим результат
        Console.WriteLine("Расстояние между точками ({0},{1},{2}) и ({3},{4},{5}) равно {6:F2}", ax, ay, az, bx, by, bz, distance);