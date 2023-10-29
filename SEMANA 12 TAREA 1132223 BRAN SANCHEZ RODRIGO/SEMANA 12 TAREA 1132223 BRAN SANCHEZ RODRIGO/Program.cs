using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_12_TAREA_1132223_BRAN_SANCHEZ_RODRIGO
{
    using System;

    class Program
    {
        static void Main()
        {
            TrianguloRectangulo objTriangulo;
            Console.WriteLine("Tarea semana 2. Ingrese los datos sobre un triángulo.");
            Console.WriteLine("Ingrese la longitud del cateto A en metros: ");
            double catetoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del ángulo opuesto de A en grados: ");
            double anguloOpuestoA = Convert.ToDouble(Console.ReadLine());
            objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

            Console.WriteLine("Resultados:");
            Console.WriteLine("Valor de cateto A: " + objTriangulo.ObtenerCatetoA() + " m");
            Console.WriteLine("Valor de cateto B: " + objTriangulo.ObtenerCatetoB() + " m");
            Console.WriteLine("Valor de hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " m");
            Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
            Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
            Console.WriteLine("Valor de área: " + objTriangulo.ObtenerArea() + " m^2");
        }
    }

    public class TrianguloRectangulo
    {
        // Atributos
        private double catetoA { get; set; }
        private double anguloOpuestoA { get; set; }

        public TrianguloRectangulo()
        {
            catetoA = 0;
            anguloOpuestoA = 0;
        }

       
        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        // Función para obtener el cateto A
        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        // Función para obtener el cateto B
        public double ObtenerCatetoB()
        {
            double catetoB = catetoA / Math.Tan(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(catetoB, 3);
        }

        // Función para obtener la hipotenusa
        public double ObtenerHipotenusa()
        {
            double catetoB = ObtenerCatetoB();
            double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
            return Math.Round(hipotenusa, 3);
        }

        // Función para obtener el ángulo opuesto a A
        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        // Función para obtener el ángulo opuesto a B
        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        // Función para obtener el área
        public double ObtenerArea()
        {
            double catetoB = ObtenerCatetoB();
            double area = 0.5 * catetoA * catetoB;
            return Math.Round(area, 3);
        }
    }
}

