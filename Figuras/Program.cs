using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class FigurasGeometricas
    {
        // Función para calcular el área de un triángulo rectángulo
        public static double AreaTrianguloRectangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        // Función para calcular el perímetro de un triángulo rectángulo
        public static double PerimetroTrianguloRectangulo(double baseTriangulo, double altura, double hipotenusa)
        {
            return baseTriangulo + altura + hipotenusa;
        }

        // Función para calcular el área de un cuadrado
        public static double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        // Función para calcular el perímetro de un cuadrado
        public static double PerimetroCuadrado(double lado)
        {
            return 4 * lado;
        }

        // Función para calcular el área de un círculo
        public static double AreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        // Función para calcular el perímetro (circunferencia) de un círculo
        public static double PerimetroCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

        // Función para calcular el área de un polígono regular
        public static double AreaPoligonoRegular(double lado, int numeroLados, double apotema)
        {
            return (PerimetroPoligonoRegular(lado, numeroLados) * apotema) / 2;
        }

        // Función para calcular el perímetro de un polígono regular
        public static double PerimetroPoligonoRegular(double lado, int numeroLados)
        {
            return lado * numeroLados;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una figura:");
            Console.WriteLine("1. Triángulo Rectángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Círculo");
            Console.WriteLine("4. Polígono Regular");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Triángulo Rectángulo
                    Console.WriteLine("Ingrese la base del triángulo rectángulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo rectángulo:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hipotenusa del triángulo rectángulo:");
                    double hipotenusa = double.Parse(Console.ReadLine());

                    Console.WriteLine("Área del triángulo rectángulo: " + FigurasGeometricas.AreaTrianguloRectangulo(baseTriangulo, altura));
                    Console.WriteLine("Perímetro del triángulo rectángulo: " + FigurasGeometricas.PerimetroTrianguloRectangulo(baseTriangulo, altura, hipotenusa));
                    break;

                case 2:
                    // Cuadrado
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = double.Parse(Console.ReadLine());

                    Console.WriteLine("Área del cuadrado: " + FigurasGeometricas.AreaCuadrado(ladoCuadrado));
                    Console.WriteLine("Perímetro del cuadrado: " + FigurasGeometricas.PerimetroCuadrado(ladoCuadrado));
                    break;

                case 3:
                    // Círculo
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Área del círculo: " + FigurasGeometricas.AreaCirculo(radio));
                    Console.WriteLine("Perímetro (circunferencia) del círculo: " + FigurasGeometricas.PerimetroCirculo(radio));
                    break;

                case 4:
                    // Polígono Regular
                    Console.WriteLine("Ingrese el número de lados del polígono:");
                    int numeroLados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la longitud de un lado:");
                    double ladoPoligono = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el apotema del polígono:");
                    double apotema = double.Parse(Console.ReadLine());

                    Console.WriteLine("Área del polígono regular: " + FigurasGeometricas.AreaPoligonoRegular(ladoPoligono, numeroLados, apotema));
                    Console.WriteLine("Perímetro del polígono regular: " + FigurasGeometricas.PerimetroPoligonoRegular(ladoPoligono, numeroLados));
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}