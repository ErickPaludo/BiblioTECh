using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Livro : ItemBiblioteca,IEmprestavel
    {
        private string autor;
        private string editora;
        private int paginas;
        public string Autor { get { return autor; } set { autor = value; } }
        public string Editora { get { return editora; } set { editora = value; } }
        public int Paginas { get { return paginas; } set { paginas = value; } }

        public Livro(string autor, string editora, int paginas, int identificacao, string titulo, string situacao) : base(identificacao,titulo,situacao)
        {
            this.autor = autor;
            this.editora = editora;
            this.paginas = paginas;
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
            return $"Titulo: {Titulo}\nEditora: {editora}\nPaginas: {paginas}\nIdentificacao: {Identificacao}\nSituacao: {Situacao}\n ----------";
        }
        public override string ToString()
        {
            return $"{autor};{editora};{paginas}";
        }
    }
}
