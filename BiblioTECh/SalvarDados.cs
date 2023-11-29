using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BiblioTECh
{

    public class SalvarDados
    {
        static string arquivo = "Users.txt";
        static CadUser cadastro = new CadUser();

        public SalvarDados()
        {
        }

        public void GravarDados()
        {
            Usuario[] dados = cadastro.Cadastros;
            
            StreamWriter sw = File.CreateText(arquivo);

            for (int i = 0; i < cadastro.Tamanho(); i++)
            {
                if (dados[i] != null)
                {
                    sw.WriteLine(dados[i]);
                }
            }
            sw.Close();
        }
        public void Lerdados()
        {
            Usuario[] dados = cadastro.Cadastros;
            StreamReader sr = File.OpenText(arquivo);
        }
    }
}
