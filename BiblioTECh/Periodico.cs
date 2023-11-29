using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Periodico : ItemBiblioteca
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
        public override string ToString()
        {
            return $"{periodicidade};{numero};{ano}";
        }
    }
}
