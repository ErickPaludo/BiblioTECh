using System;

namespace BiblioTECh
{
    public class CadUser
    {
        private const int TAM = 10;
        private Usuario[] cadastros;
        private int pos = 0;

        public CadUser()
        {
            // Inicialize o array no construtor
            cadastros = new Usuario[TAM];
        }

        public int Tamanho()
        {
            return pos;
        }

        public void Insere(Usuario item)
        {
            if (pos < TAM)
            {
                cadastros[pos] = item;
                pos++;
            }
        }

        public Usuario GetUser(int posicao)
        {
            Usuario item = null;
            if (posicao >= 0 && posicao < pos)
            {
                item = cadastros[posicao]; // Corrigido para usar posicao
            }
            return item;
        }

        public void CadView()
        {
            if (cadastros != null)
            {
                for (int i = 0; i < pos; i++) // Corrigido para usar pos
                {
                    if (cadastros[i] != null)
                    {
                        Console.WriteLine(cadastros[i]);
                    }
                }
            }
        }
    }
}
