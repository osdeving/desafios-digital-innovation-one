using System;

namespace Desafios.ResolvendoAlgoritmos
{
    class ProgramaPrincipal
    {
        static void Main(string[] args) => PizzariaEvento.MostraSeEventoVaiAcontecer();
    }
    class PizzariaEvento
    {
        static public void MostraSeEventoVaiAcontecer()
        {
            var PessoasEDatas = ObtemPessoasEDatas();

            var pessoasInteressadas = PessoasEDatas.PessoasInteressadas;
            var datasSugeridas = PessoasEDatas.DatasSugeridas;


            string anuncioFinalDoEvento = "Pizza antes de FdA";


            for (int i = 0; i < datasSugeridas; i++)
            {
                var tokens = Console.ReadLine().Split(" ");
                string dataSugerida = tokens[0];

                bool todosQuiseramComparecer = true;

                for (int j = 1; j <= pessoasInteressadas; j++)
                {
                    if (int.Parse(tokens[j]) != 1)
                    {
                        todosQuiseramComparecer = false;
                        break;
                    }
                }

                if (todosQuiseramComparecer)
                {
                    if (anuncioFinalDoEvento == "Pizza antes de FdA")
                        anuncioFinalDoEvento = dataSugerida;
                }
            }

            Console.WriteLine($"{anuncioFinalDoEvento}");
        }


        static (int PessoasInteressadas, int DatasSugeridas) ObtemPessoasEDatas()
        {
            string[] tokens = Console.ReadLine().Split(" ");
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            return (PessoasInteressadas: convertedItems[0], DatasSugeridas: convertedItems[1]);
        }
    }

}