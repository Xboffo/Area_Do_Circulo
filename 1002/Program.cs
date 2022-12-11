using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double area, raio,n;
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);    
            n = 3.14159;
            area = n * (Math.Pow (raio, 2));

            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}