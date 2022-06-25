using System;

namespace Area_del_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Escribe la base del triángulo");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Escribe la altura del triángulo");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * (alturaTriangulo / 2));
        Console.WriteLine("El área del triángulo es: {0}", areaTriangulo);

        }
    }
}
