Console.WriteLine("Введите координату X точки A: ");
 int Ax = Convert.ToInt32(Console.ReadeLine());
Console.WriteLine("Введите координату Y точки A: ");
int Ay = Convert.ToInt32(Console.ReadeLine());
Console.WriteLine("Введите координату Z точки A: ");
int Az = Convert.ToInt32(Console.ReadeLine());

Console.WriteLine("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadeLine());
Console.WriteLine("Введите координату Y точки B: ");
int Bx = Convert.ToInt32(Console.ReadeLine());
Console.WriteLine("Введите координату Z точки B: ");
int Bx = Convert.ToInt32(Console.ReadeLine());

double distance = Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2));
Console.WriteLine(distance);
