// esse projeto serve de teste para criar uma busca recursiva de exames compostos.
// recentemente no trabalho estou com o objetivo de desenvolver uma nova funcionalidade em um sistema de agendamentos de exames
// exames compostos são um grupo de exames, como por exemplo "Colesterol Total", que possui dentro dele exames simples como hdl e ldl
// como um exame composto pode ter n exames, que também podem ser compostos, preciso validar se um exame simples já foi marcado em algum outro exame. 

using System;

namespace Busca_Recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func();
            List<Exame> examesAdicionados = new List<Exame>();

            // examesAdicionados.Add(func.GetColesterolTotalFT());
            // bool resultado = VerificaExameJaAdicionado(examesAdicionados, func.GetColesteroltotal());

            examesAdicionados.Add(func.GetColesteroltotal());
            List<Exame> resultado = GetExamesJaAdicionados(examesAdicionados, func.GetColesterolTotalFT());

            foreach (Exame exame in resultado)
            {
                Console.WriteLine(exame.Name);
            }
        }

        public static List<Exame> GetExamesJaAdicionados(List<Exame> exames, Exame exame)
        {
            List<Exame> examesDuplicados = new List<Exame>();

            if (exame.Servicos.Count == 0) 
            {
                if (VerificaExameJaAdicionado(exames, exame))
                {
                    examesDuplicados.Add(exame);
                }
            }
            else 
            {
                foreach (var servico in exame.Servicos)
                {
                    examesDuplicados.AddRange(GetExamesJaAdicionados(exames, servico));
                }
            }

            return examesDuplicados;
        }

        public static bool VerificaExameJaAdicionado(List<Exame> exames, Exame exame)
        {
            foreach (Exame item in exames)
            {
                if (item.Name.Equals(exame.Name, StringComparison.OrdinalIgnoreCase)) return true;

                if (item.Servicos.Count > 0)
                {
                    if (VerificaExameJaAdicionado(item.Servicos, exame)) return true;
                }
            }
            return false;
        }
    }
}
