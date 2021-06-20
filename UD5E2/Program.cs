using System;

namespace UD5E2
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Introduce el limite";
            int limite = Convert.ToInt32(texto);
            texto = "Introduce un numero";
            int numero1 = Convert.ToInt32(texto);
            texto = "Introduce un numero";
            int numero2 = Convert.ToInt32(texto);

            Random generador = new Random();

            int aleatorio = generador.Next(numero1, numero2);

            for (int i = 0; i < limite; i++)
            {
                Console.WriteLine(generador.Next(numero1, numero2));
            }


        }
    }
}
