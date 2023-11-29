using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    internal class Dvd : ItemBiblioteca
    {
        private string assunto;
        private int duracao;

        public string Assunto { get; set; }
        public int Duracao { get; set; }
        public Dvd(string assunto, int duracao,int identificacao, string titulo, string situacao) : base(identificacao,titulo,situacao)
        {
            this.assunto = assunto;
            this.duracao = duracao;
        }
        public override string ToString()
        {
            return $"{assunto};{duracao}";
        }
    }
}
