using System;

namespace Desafios.ResolvendoAlgoritmos
{
    class HoraDaCorrida
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            
            var numeroDeVoltas = convertedItems[0];
            var quantidadeDePlacasNaPista = convertedItems[1];
            var dezPorcento = (numeroDeVoltas * quantidadeDePlacasNaPista) * 0.1;

            for (int i = 1; i < 10; i++)
            {
                Console.Write(Math.Ceiling(dezPorcento * i).ToString("0"));
                                
                if(i != 9) Console.Write(" ");
            }
        }
    }
}