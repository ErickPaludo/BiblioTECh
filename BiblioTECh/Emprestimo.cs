using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Emprestimo
    {
        private int identificacao; // identificação do empréstimo (código do empréstimo)
        private Usuario usuario; // Usuário da biblioteca que realizou o empréstimo
        private ItemBiblioteca item; //Item da biblioteca que foi emprestado
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        public int Identificacao { get; set; }
        public Usuario Usuario { get; set; }
        public ItemBiblioteca Item { get; set; }
        private DateTime DataEmprestimo { get; set; }
        private DateTime DataDevolucao { get; set; }

        public Emprestimo(int identificacao, Usuario usuario, ItemBiblioteca item, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.identificacao = identificacao;
            this.usuario = usuario;
            this.item = item;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }
        public void Emprestar(Usuario usr, ItemBiblioteca item, int prazo) { }
        public void Retornar() { }
    }
}
