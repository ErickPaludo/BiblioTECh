using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    internal class CadUser
    {
        private const int TAM = 10;
        static Usuario[] cadastros = new Usuario[TAM];
        static int pos = 0;

        public void Registrador(string auxnome, string auxendereco, int auxnumero, string auxcomplemento, string auxbairro, string auxcidade, string auxestado, string auxcep, string auxmatricula, string auxcurso)
        {
            if (pos < TAM)
            {
                cadastros[pos] = new Usuario(auxnome, auxendereco, auxnumero, auxcomplemento, auxbairro, auxcidade, auxestado, auxcep, auxmatricula, auxcurso);
                pos++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Limite de cadastros atingido.");
            }

        }
        public void ExibirCadastros()
        {
            if (cadastros[0] == null)
            {
                Console.WriteLine("Sem usuarios cadastrados");
            }
            else
            {
                Console.WriteLine("Dados Usuario:");
                Console.WriteLine("---------------");
                for (int i = 0; i <= pos; i++)
                {
                    if (cadastros[i] != null)
                    {
                        Console.WriteLine($"{cadastros[i]}");
                        Console.WriteLine("---------------");
                    }
                }
            }
        }
    }
}