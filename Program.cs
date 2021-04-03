using System;

namespace projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Lançamento projétil");
            Console.ResetColor();
            Console.WriteLine();

            
            Console.WriteLine("Entre coma velocidade, em m/s:");
            double Velocidade = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("Entre com o ângulo, em graus:");
            double Angulo = Convert.ToDouble(Console.ReadLine());

            
            double anguloEmradiano = Angulo * (Math.PI / 180);

           
            double alcance = (Math.Pow(Velocidade , 2) * Math.Sin(2 * anguloEmradiano)) / g;
            Console.WriteLine($"Alcanse: {alcance:N2} m ");
 
            
            double altura = Math.Pow((Velocidade * Math.Sin(Angulo)), 2) / (2 * g);
            Console.WriteLine($"Altura máxima:{altura:N2} m");


        }
    }
}
