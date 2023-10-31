class Program
{
    static void Main()
    {

        double[] notas = new double[8];


        double promedio = 0;
        double notaMasAlta = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Ingresar la nota del laboratorio(si es decimal colocar coma en lugar de punto: semana " + (i + 1) + ": ");
            if (double.TryParse(Console.ReadLine(), out notas[i]))
            {
                promedio += notas[i];

                if (notas[i] > notaMasAlta)
                {
                    notaMasAlta = notas[i];
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Por favor, ingrese un número.");
                i--;
            }
        }
        promedio /= notas.Length;
        Console.WriteLine("Promedio " + promedio);
        Console.WriteLine("Nota más alta: " + notaMasAlta);

        {
            Console.WriteLine("Segunda parte");

            string palabra;
            string letra;
            int cont = 0;

            Console.WriteLine("Escriba una palabra para su análisis");
            palabra = Console.ReadLine();

            Console.WriteLine("Escriba una letra para su análisis");
            letra = Console.ReadLine();

            string[] vector_palabra = new string[palabra.Length];

            for (int i = 0; i < palabra.Length; i++)
            {
                vector_palabra[i] = palabra[i].ToString();
            }

            for (int i = 0; i < vector_palabra.Length; i++)
            {
                if (vector_palabra[i].Equals(letra))
                {
                    cont++;
                }
            }

            Console.WriteLine("Número de letras: " + cont);

            if (cont > 0)
            {
                Console.WriteLine("La letra se encontró.");
            }
            else
            {
                Console.WriteLine("La letra no se encontró.");
            }
        }
    }


}




