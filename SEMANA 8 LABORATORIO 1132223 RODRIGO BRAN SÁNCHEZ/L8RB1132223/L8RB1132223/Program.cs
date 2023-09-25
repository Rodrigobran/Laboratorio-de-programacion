namespace L8RB1132223
    class Program
    {
            static void Main()
            {
                Console.Write("Laboratorio Semana No.08");
                Console.WriteLine("\nIngrese un número");

                int N = Convert.ToInt32(Console.ReadLine());

                int A = 0, B = 1, C = 0, i = 2;
                string resultado = "";
                // 

                if (N > 0)
                {
                    resultado = A.ToString();
                    if (N > 1)
                    {
                        resultado += B.ToString();

                        while (i < N)
                        {
                            C = A + B;
                    resultado += B.ToString();
                    A = B;
                    A = C;
                    i++;
                         }

                Console.WriteLine("Resultado" + resultado);
                    }
            else
            {
            Console.WriteLine("Resultado" + resultado);
            }
             }
        else
        {
            Console.WriteLine("Resultado" + resultado);
        }
    }
}






















        }

    }
        
    













