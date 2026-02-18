using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sistemagerenciamentofinanças.utils
{
    public static class inputs
    {
        public static decimal LerDecimal(string mensagem)
        {
            decimal resultado;

            while (true) 
            {
                Console.Write(mensagem); 
                string entrada = Console.ReadLine();

               
                if (decimal.TryParse(entrada, out resultado))
                {
                    return resultado;
                }

                
                Console.WriteLine("Error  valor inválido Digite apenas números (ex: 50,00)");
            }
        }
        public static int LerInteiro(string mensagem)
        {
            int resultado;
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out resultado))
                {
                    return resultado;
                }
                Console.WriteLine("Error Digite um número inteiro válido");
            }
        }
        public static string LerString(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada))
                {
                    return entrada;
                }
                Console.WriteLine("Error  Este campo não pode ficar vazio");
            }
        }
    }
}
