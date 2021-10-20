using System;

namespace sedova2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вариант параметра 1,2 или 3");
                int n = int.Parse(Console.ReadLine());
                double a = 0, b = 0, z=0, y;
                switch (n)
                {
                    case 1: a = 1.5; b = 6.4; z = Math.Log(Math.Abs(b * x * x * x + 1.5)); break;
                    case 2: a = 1.9; b = 8.6; z = Math.Log(Math.Abs(b * x * x * x + 3)); break;
                    case 3: a = 0.6; b = 2.4; z = Math.Log(Math.Abs(b * x * x * x + 1.8)); break;
                }
                if (a * a * a < x && x <= b) y = Math.Log(Math.Abs(b * z * x)) + z * Math.Pow(a, 2.5);
                else if (x>b) y = a*x*x+b*Math.Pow(z,a)+ Math.Pow(Math.Sin(z*x),2);
                else y = Math.Cos(a*x+b)+Math.Log(Math.Abs(z*x));
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

