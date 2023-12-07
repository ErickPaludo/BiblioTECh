using System;
using System.Collections.Generic;

namespace BiblioTECh
{
    public class Emprestimo
    {
        private int identificacao; // identificação do empréstimo (código do empréstimo)
        private Usuario usuario; // Usuário da biblioteca que realizou o empréstimo
        private ItemBiblioteca item; //Item da biblioteca que foi emprestado
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        public static List<Emprestimo> emprestimos = new List<Emprestimo>();

        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public ItemBiblioteca Item
        {
            get { return item; }
            set { item = value; }
        }

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }

        public DateTime DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }

        public Emprestimo() { }

        public Emprestimo(int identificacao, Usuario usuario, ItemBiblioteca item, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.identificacao = identificacao;
            this.usuario = usuario;
            this.item = item;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }

        public void Emprestar(Usuario usr, ItemBiblioteca item, int prazo)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Identificacao = emprestimos.Count + 1;
            emprestimo.Usuario = usr;
            emprestimo.Item = item;
            emprestimo.DataEmprestimo = DateTime.Now;
            emprestimo.DataDevolucao = emprestimo.DataEmprestimo.AddDays(prazo);
            emprestimos.Add(emprestimo);
            foreach(Emprestimo e in emprestimos)
            {
                Console.WriteLine($"Identificação: {emprestimo.Identificacao}");
                Console.WriteLine($"Usuário: {emprestimo.Usuario.Nome}"); 
                Console.WriteLine($"Item: {emprestimo.Item}");
                Console.WriteLine($"Data de Empréstimo: {emprestimo.DataEmprestimo}");
                Console.WriteLine($"Data de Devolução: {emprestimo.DataDevolucao}");
                Console.WriteLine("------------------------------");
            }
        }

        public void Retornar()
        {
            // Implement return logic here
        }
    }
}
