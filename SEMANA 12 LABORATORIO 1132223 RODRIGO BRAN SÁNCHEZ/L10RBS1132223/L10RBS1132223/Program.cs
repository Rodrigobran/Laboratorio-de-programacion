using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Objeto de la clase Circulo
        Circulo objCirculo = new Circulo(radio);

        // Variables para almacenar los resultados
        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        // Llama al método CalcularGeometria para obtener los resultados
        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        // Muestra la información
        Console.WriteLine("Información del círculo:");
        Console.WriteLine("Radio: " + objCirculo.radio);
        Console.WriteLine("Perímetro: " + perimetro);
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Volumen de la esfera con el mismo radio: " + volumen);
    }
}

class Circulo
{
    public double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    private double ObtenerPerimetro()
    {
        return 2 * Math.PI * radio;
    }

    private double ObtenerArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    private double ObtenerVolumen()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    {
        unPerimetro = ObtenerPerimetro();
        unArea = ObtenerArea();
        unVolumen = ObtenerVolumen();
    }
}
