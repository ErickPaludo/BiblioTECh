using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Periodico : ItemBiblioteca,IEmprestavel
    {
       private string periodicidade;
       private int numero;
       private int ano;
        public string Periodicidade { get { return periodicidade; } set { periodicidade = value; } }
        public int Numero { get { return numero;} set { numero = value; } }
        public int Ano { get { return ano;} set { ano = value; } }
        public Periodico(string periodicidade, int numero, int ano,int identificacao, string titulo, string situacao):base(identificacao,titulo, situacao)
        {
            this.periodicidade = periodicidade;
            this.numero = numero;
            this.ano = ano;
        }
        public bool Atrasado()
        {
            return false;
        }
        public bool Bloqueado()
        {
            return false;
        }
        public bool Disponivel()
        {
            return false;
        }
        public bool Emprestado()
        {
            return false;
        }
        public override string Guardar()
        {
            return $"Titulo: {Titulo}\nEdicao: {numero}\nAno: {ano}\nIdentificacao: {Identificacao}\nSituacao: {Situacao}\n ----------";
        }
        public override string ToString()
        {
            return $"{periodicidade};{numero};{ano}";
        }
    }
}
