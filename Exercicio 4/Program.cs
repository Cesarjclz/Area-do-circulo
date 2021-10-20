using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double pi = 3.1415;
            double area;
            double raio;
          
            Console.WriteLine("Qual o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
           
            area = pi * (Math.Pow(raio, 2));
            Console.WriteLine("A area do circulo é: {0}  ", area);
           















        }
    }
}
