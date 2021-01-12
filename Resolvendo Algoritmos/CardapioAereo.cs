using System;

namespace Desafios.ResolvendoAlgoritmos
{
    class CardapioAereo
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            var numeroDePizza = convertedItems[0];
            var numeroDeSalada = convertedItems[1];
            var numeroDeMassa = convertedItems[2];

            tokens = Console.ReadLine().Split(" ");
            convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            var quantidadeDePedidosPizza = convertedItems[0];
            var quantidadeDePedidosSalada = convertedItems[1];
            var quantidadeDePedidosMassa = convertedItems[2];

            var totalPizza = (quantidadeDePedidosPizza - numeroDePizza);
            if (totalPizza < 0) totalPizza = 0;

            var totalSalada = (quantidadeDePedidosSalada - numeroDeSalada);
            if (totalSalada < 0) totalSalada = 0;

            var totalMassa = (quantidadeDePedidosMassa - numeroDeMassa);
            if (totalMassa < 0) totalMassa = 0;

            var total = totalSalada + totalPizza + totalMassa;

            Console.WriteLine($"{total}");
        }
    }
}