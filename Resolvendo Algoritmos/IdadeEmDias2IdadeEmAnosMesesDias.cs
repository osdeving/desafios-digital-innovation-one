using System;

namespace Desafios.ResolvendoAlgoritmos
{
    class IdadeEmDias2IdadeEmAnosMesesDias
    {
        static void Main(string[] args)
        {
            var idadeEmdias = ObtemIdadeEmDias();
            
            var anos = idadeEmDias / 365;
            
            var diasQueSobraram = idadeEmDias % 365;

            var meses = diasQueSobraram / 30;

            var dias = diasQueSobraram % 30;

            MostraIdadeEmAnosMesesDias();
        }

        static int ObtemIdadeEmDias() => int.Parse(Console.ReadLine());
        
        static void MostraIdadeEmAnosMesesDias()
        {
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
