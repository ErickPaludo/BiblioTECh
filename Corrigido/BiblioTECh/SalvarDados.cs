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
        public Usuario[] salvando;

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
            int contador = 0;
            string line = "";
            string auxnome = "";
            string auxendereco = "";
            int auxnumero = 0;
            string auxcomplemento = "";
            string auxbairro = "";
            string auxcidade = "";
            string auxestado = "";
            string auxcep = "";
            string auxmatricula = "";
            string auxcurso = "";
            StreamReader sr = new StreamReader(arquivo);
            char[] limite = { ';' };
            while ((line = sr.ReadLine()) != null)
            {
                string[] linesplit = line.Split(limite);
                auxnome = linesplit[0];
                auxendereco = linesplit[1];
                auxnumero = int.Parse(linesplit[2]);
                auxcomplemento = linesplit[3];
                auxbairro = linesplit[4];
                auxcidade = linesplit[5];
                auxestado = linesplit[6];
                auxcep = linesplit[7];
                auxmatricula = linesplit[8];
                auxcurso = linesplit[9];
                cadastro.Registrador(auxnome, auxendereco, auxnumero, auxcomplemento, auxbairro, auxcidade, auxestado, auxcep, auxmatricula, auxcurso);
                contador++;
                cadastro.Pos = contador;
            }
            Console.Clear();
            sr.Close();
        }
    }
}
