using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Acervo
    {
        static List<IEstoque> inserir = new List<IEstoque>();
        EntradaDados entradaDados = new EntradaDados();

        public void Insere(IEstoque estoque)
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

                if(ver == false) 
                {
                    Console.Clear();
                    Console.WriteLine("Codgigo nao identificado!");
                }
            }
        }
        public void Mostrar()
        {
            if (NoNull() == true)
            { foreach (IEstoque e in inserir) { Console.WriteLine(e.Guardar()); } }
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
                    IEstoque e = inserir[i];
                    Console.WriteLine($"Na posicao {i + 1} esta salvo o item:\n{e.Guardar()}");
                    validador = true;
                }
            }
            if (validador == false)
            {
                Console.WriteLine($"Nao ha nenhum item guardado na posicao {posicao + 1}");
            }

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
