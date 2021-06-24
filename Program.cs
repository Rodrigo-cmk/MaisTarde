using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime agora = DateTime.Now;
            TimeSpan SeisHorasEMeia = new TimeSpan(6, 30, 0);
            
            DateTime Resultado = agora + SeisHorasEMeia;

            Console.WriteLine($" {Resultado}");
        }
    }
}
