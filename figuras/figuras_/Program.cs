using System;

namespace figuras_
{

class Program
    {
        static void Main(string[] args)
        {
            Rectangulo miRectangulo = new Rectangulo();

            Console.WriteLine("Ingrese la base del rectangulo:");

            miRectangulo.base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectangulo:");

            miRectangulo.altura = int.Parse(Console.ReadLine());

            Console.WriteLine(miRectangulo.calculoArea());

        }
        
        class Rectangulo
        {
            public int base1;

            public int altura;

            int area;


            public int calculoArea()
            {
                return area = base1 * altura;
            }

        }
}
}