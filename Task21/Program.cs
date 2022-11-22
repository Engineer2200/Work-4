Console.WriteLine("Введите координаты точки x от A");
int Ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки y от A");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки z от A");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки x от B");
int Bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки y от B");
int By = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки z от B");
int Bz = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2) + Math.Pow(Bz - Az,2));

Console.WriteLine(length);