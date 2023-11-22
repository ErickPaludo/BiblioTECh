using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class EntradaDados
    {
        public int LeInteiro(string mensagem) //Entrada de dados com consistência - executa até ser digitado um inteiro. Mensagem de entrada inválida
        {
            string aux;
            int n = 0;
            bool ok = false;
            do
            {
                Console.Write(mensagem);
                aux = Console.ReadLine();
                if (aux == string.Empty)
                {
                    Console.WriteLine("Favor informar os dados!");
                }
                else if (int.TryParse(aux, out n))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Número inválido! Tente Novamente!");
                }
            } while (ok == false);
            return n;
        }

        public double LeDouble(string mensagem) //Entrada de dados com consistência - executa até ser digitado um inteiro. Mensagem de entrada inválida
        {
            string aux;
            double n = 0.0;
            bool ok = false;
            do
            {
                Console.Write(mensagem);
                aux = Console.ReadLine();
                if (aux == string.Empty)
                {
                    Console.WriteLine("Favor informar os dados!");
                }
                else if (double.TryParse(aux, out n))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Número inválido! Tente Novamente!");
                }
            } while (ok == false);
            return n;
        }
        public char LeChar(string mensagem) //Entrada de dados com consistência - executa até ser digitado um inteiro. Mensagem de entrada inválida
        {
            string aux;
            char c = ' ';
            bool ok = false;
            do
            {
                Console.Write(mensagem);
                aux = Console.ReadLine();
                if (aux == string.Empty)
                {
                    Console.WriteLine("Favor informar os dados!");
                }
                else if (char.TryParse(aux, out c))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Caracter inválido! Tente Novamente!");
                }
            } while (ok == false);
            return c;
        }
        public string LeString(string mensagem) //Entrada de dados com consistência - executa até ser digitado um inteiro. Mensagem de entrada inválida
        {
            string aux;
            bool ok = false;
            do
            {
                Console.Write(mensagem);
                aux = Console.ReadLine();
                if (aux == string.Empty)
                {
                    Console.WriteLine("Favor informar os dados!");
                }
                else
                {
                    ok = true;
                }

            } while (ok == false);
            return aux;
        }
    }
}
