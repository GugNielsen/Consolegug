using System;
using System.Linq;

namespace BrigandoEAnimando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é ano do seu nascimento " + nome);
            DateTime nascimento = DateTime.Parse(Console.ReadLine());


            // para calcular idade  tem ser assim 
            TimeSpan vidaBurta = DateTime.Now - nascimento;
            int idade = (int)(vidaBurta.Days / 365.25);

            Console.Clear();

            Console.WriteLine("Sua idade é " + idade);

            // vai selecionar de letra a letra para fazer a senha 
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            Console.WriteLine("Sua Senha é " + result);

            


            Console.ReadKey();
        }
    }
}
