using System;
using System.Collections.Generic;

namespace BiblioTECh
{
    public class Emprestimo
    {
        private int identificacao; // identificação do empréstimo (código do empréstimo)
        private Usuario usuario; // Usuário da biblioteca que realizou o empréstimo
        private ItemBiblioteca itembiblioteca; //Item da biblioteca que foi emprestado
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
            get { return itembiblioteca; }
            set { itembiblioteca = value; }
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
            this.itembiblioteca = item;
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
        }

        public void VerificarUserDisp()
        {
            foreach (Emprestimo e in emprestimos)
            {
                if (e.itembiblioteca.Situacao == "Disponivel")
                {
                    Console.WriteLine($"Nome: {e.Usuario.Nome} | {e.Usuario.Matricula}");
                }
            }
        }
        public void Retornar(int id)
        {
            foreach (Emprestimo e in emprestimos)
            {
                if (e.Item.Identificacao == id)
                {
                    e.Item.Situacao = "Disponivel";
                    emprestimos.Remove(e);
                    break;
                }
            }
        }
        public void Exibir()
        {
            string ident;
            foreach (Emprestimo e in emprestimos)
            {
                e.Item.Situacao = "Emprestado";
                Console.WriteLine($"Usuário: {e.Usuario.Nome}");
                Console.WriteLine($"Identificação: {e.Item.Identificacao}");
                Console.WriteLine($"Situacao: {e.Item.Situacao}");
                Console.WriteLine($"Item: {e.Item.Titulo}");
                Console.WriteLine($"Data de Empréstimo: {e.DataEmprestimo}");
                Console.WriteLine($"Data para Devolução: {e.DataDevolucao}");
                Console.WriteLine("------------------------------");
            }
        }
        public bool NoNull()
        {
            if (emprestimos.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhum Item cadastrado!");
                return false;
            }
            else { return true; }
        }

    }
}

