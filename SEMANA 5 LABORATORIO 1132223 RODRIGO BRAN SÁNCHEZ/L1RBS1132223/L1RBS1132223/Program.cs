class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola mundo");
        Console.WriteLine("soy Rodrigo");

        /* COMENTARIOS*/

        Console.Write("Hola mundo ");
        Console.Write("soy Rodrigo");
        /* Console.ReadKey();*/

            Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola mundo");
        Console.WriteLine("soy" + Nombre);
        /* COMENTARIOS*/
        Console.Write("Hola mundo ");
        Console.Write("soy" + Nombre);
        /* Console.ReadKey();*/

        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre2 = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        String Edad = Console.ReadLine();
        Console.WriteLine("Ingrese su carrera: ");
        string Carrera = Console.ReadLine() ;
        Console.WriteLine("Ingrese su carnè: ");
        string Carnè = Console.ReadLine();
        /* COMENTARIOS;*/
        Console.Write(" Nombre: " + Nombre2);
        Console.Write(" Edad: " + Edad);
        Console.Write(" Carrera: " + Carrera);
        Console.Write(" Carnè: " + Carnè);
        Console.WriteLine(" Soy " + Nombre2 + " Tengo " + Edad + " años y estudio la carrera de " + Carrera + " Mi nùmero de carnè es " + Carnè);
    }
}

