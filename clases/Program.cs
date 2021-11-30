using System;

namespace clases
{
    internal class Program
    {
        public class Circle
        {
            private double radius;
            private double PI = 3.14159;
            public Circle(double radius)
            {
                this.radius = radius;
            }
    
            public double getArea()
            {
                return PI * radius * radius;
            }
        }
        
        public class Rect
        {
            private double lado;
            private double ancho;
            
            public Rect(double lado, double ancho)
            {
                this.lado = lado;
                this.ancho = ancho;
            }
    
            public double getArea()
            {
                return lado*ancho;
            }
        }
        
        public class Tri
        {
            private double bas;
            private double altura;
            
            public Tri(double bas, double altura)
            {
                this.bas = bas;
                this.altura = altura;
            }
    
            public double getArea()
            {
                return bas*altura/2;
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo");
            var area = Console.ReadLine();
            Circle circulo = new Circle(double.Parse(area));
            Console.WriteLine("El area del circulo es: ");
            Console.WriteLine(circulo.getArea());
            
            Console.WriteLine("Ingrese el lado del rectangulo");
            var lado = Console.ReadLine();
            Console.WriteLine("Ingrese el ancho del rectangulo");
            var ancho = Console.ReadLine();
            Rect rectan = new Rect(double.Parse(lado),double.Parse(ancho));
            Console.WriteLine("El area del rectangulo es: ");
            Console.WriteLine(rectan.getArea());

            Console.WriteLine("Ingrese la base del triangulo");
            var bas = Console.ReadLine();
            Console.WriteLine("Ingrese la altura del triangulo");
            var alt = Console.ReadLine();
            Tri trian = new Tri(double.Parse(bas),double.Parse(alt));
            Console.WriteLine("El area del triangulo es: ");
            Console.WriteLine(trian.getArea());
        }
    }
}