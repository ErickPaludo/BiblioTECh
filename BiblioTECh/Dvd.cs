using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    internal class Dvd : ItemBiblioteca, IEmprestavel
    {
        private string assunto;
        private int duracao;

        public string Assunto { get; set; }
        public int Duracao { get; set; }
        public Dvd(string assunto, int duracao, int identificacao, string titulo, string situacao) : base(identificacao, titulo, situacao)
        {
            this.assunto = assunto;
            this.duracao = duracao;
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
            return $"Titulo: {Titulo}\nAssunto: {assunto}\nDuracao: {duracao}\nIdentificacao: {Identificacao}\nSituacao: {Situacao}\n ----------";
        }
        public override string ToString()
        {
            return $"{assunto};{duracao}";
        }
    }
}
