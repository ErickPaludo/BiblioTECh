using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Acervo
    {
        static List<ItemBiblioteca> inserir = new List<ItemBiblioteca>();
        EntradaDados entradaDados = new EntradaDados();
        public void Insere(ItemBiblioteca estoque)
        {
            inserir.Add(estoque);
            Console.Clear();
            Console.WriteLine("Item adicionado!");
        }
        public void Remover()
        {
            var livro = inserir.OfType<Livro>();
            var periodico = inserir.OfType<Periodico>();
            var dvd = inserir.OfType<Dvd>();
            if (NoNull() == true)
            {
                bool ver = false;
                foreach (Livro e in livro) { Console.Write($"[{e.Identificacao}] "); }
                foreach (Periodico e in periodico) { Console.Write($"[{e.Identificacao}] "); }
                foreach (Dvd e in dvd) { Console.Write($"[{e.Identificacao}] "); }
                int apague = entradaDados.LeInteiro("\nInforme o codigo do item que devera ser apagado: ");
                Console.Clear();
                foreach (Livro e in livro)
                {
                    if (e.Identificacao == apague)
                    {
                        inserir.Remove(e);
                        ver = true;
                        Console.WriteLine($"O item {e.Titulo} foi excluido com sucesso!");
                        break;
                    }
                }

                foreach (Periodico e in periodico)
                {
                    if (e.Identificacao == apague)
                    {
                        inserir.Remove(e);
                        ver = true;
                        Console.WriteLine($"O item {e.Titulo} foi excluido com sucesso!");
                        break;
                    }
                }


                foreach (Dvd e in dvd)
                {
                    if (e.Identificacao == apague)
                    {
                        inserir.Remove(e);
                        ver = true;
                        Console.WriteLine($"O item {e.Titulo} foi excluido com sucesso!");
                        break;
                    }
                }

                if (ver == false)
                {
                    Console.Clear();
                    Console.WriteLine("Codgigo nao identificado!");
                }
            }
        }
        public void Mostrar()
        {
            if (NoNull() == true)
                Console.WriteLine("Itens cadastrados no sistema:\n------------");
            {
                foreach (ItemBiblioteca e in inserir)
                {
                    Console.WriteLine(e.Guardar());
                }
            }
        }
        public void MostrarDisp()
        {

            if (NoNull() == true)
                Console.WriteLine("Itens cadastrados no sistema:\n------------");
            
            {
                foreach (ItemBiblioteca e in inserir)
                {
                    if (e.Situacao == "Disponivel")
                    {
                        Console.WriteLine(e.Guardar());
                    }
                }
            }

        }
        public void MostrarEspaco()
        {
            if (NoNull() == true)
            {
                Console.Clear();
                Console.WriteLine($"Atualmente seu estoque conta com {inserir.Count()} iten(s)!");
            }
        }
        public void Filtro(int posicao)
        {

            bool validador = false;
            Console.Clear();
            for (int i = 0; i < inserir.Count; i++)
            {
                if (posicao == i)
                {
                    ItemBiblioteca e = inserir[i];
                    Console.WriteLine($"Na posicao {i + 1} esta salvo o item:\n{e.Guardar()}");
                    validador = true;
                }
            }
            if (validador == false)
            {
                Console.WriteLine($"Nao ha nenhum item guardado na posicao {posicao + 1}");
            }

        }
        public bool ItemTrue(int item)
        {
            var livro = inserir.OfType<Livro>();
            var periodico = inserir.OfType<Periodico>();
            var dvd = inserir.OfType<Dvd>();
            bool val = false;
            foreach (Livro e in livro)
            {
                if (item == e.Identificacao)
                {
                    val = true;
                }
            }
            foreach (Periodico e in periodico)
            {
                if (item == e.Identificacao)
                {
                    val = true;
                    e.Situacao = "Emprestado";
                }
            }
            foreach (Dvd e in dvd)
            {
                if (item == e.Identificacao)
                {
                    val = true;
                    e.Situacao = "Emprestado";
                }
            }
            if (val == true)
            {
                return val;
            }
            else
            {

                Console.Clear();
                Console.WriteLine("O item nao foi encontrado");
                return val;
            }
        }
        public ItemBiblioteca Item(int item)
        {
            var livro = inserir.OfType<Livro>();
            var periodico = inserir.OfType<Periodico>();
            var dvd = inserir.OfType<Dvd>();
            ItemBiblioteca itemBiblioteca = null;
            foreach (Livro e in livro)
            {
                if (item == e.Identificacao && e.Situacao == "Disponivel")
                {
                    itemBiblioteca = e;
                }
            }
            foreach (Periodico e in periodico)
            {
                if (item == e.Identificacao && e.Situacao == "Disponivel")
                {
                    itemBiblioteca = e;
                }
            }
            foreach (Dvd e in dvd)
            {
                if (item == e.Identificacao && e.Situacao == "Disponivel")
                {
                    itemBiblioteca = e;
                }
            }
            return itemBiblioteca;
        }
        public int Prazo(int nome)
        {
            int prazo = 0;
            var livro = inserir.OfType<Livro>();
            var periodico = inserir.OfType<Periodico>();
            var dvd = inserir.OfType<Dvd>();
            foreach (Livro e in livro)
            {
                if (nome == e.Identificacao)
                {
                    prazo = 7;
                }
            }
            foreach (Periodico e in periodico)
            {
                if (nome == e.Identificacao)
                {
                    prazo = 4;
                }
            }
            foreach (Dvd e in dvd)
            {
                if (nome == e.Identificacao)
                {
                    prazo = 2;
                }
            }
            return prazo;
        }

        public bool NoNull()
        {
            if (inserir.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhum Item cadastrado!");
                return false;
            }
            else { return true; }
        }

    }
}
