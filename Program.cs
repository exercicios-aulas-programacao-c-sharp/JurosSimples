using System;
/*
[console: JurosSimples] Calcule o montante final de um investimento a juros simples.

j = c . i . t

m = c + j

Juros simples (j)

Capital [c] (R$).......: 1200,00
Taxa de juros [i] (%)..: 2
Tempo [t] (meses)......: 15

Juros (R$).....: 360,00
Montante (R$)..: 1560,00
*/
namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal j, c, i, m;
            int t;

            Console.WriteLine("Juros simples (j)\n");

            Console.Write("Capital [c] (R$).......: ");
            c = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Taxa de juros [i] (%)..: ");
            i = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tempo [t] (meses)......: ");
            t = Convert.ToInt32(Console.ReadLine());

            j = c * (i / 100) * t;
            m = c + j;

            Console.WriteLine();
            Console.WriteLine($"Juros (R$).....: {j:N2}");
            Console.WriteLine($"Montante (R$)..: {m:N2}");

        }
    }
}
