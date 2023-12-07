using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
   public abstract class ItemBiblioteca
    {
        private int identificacao;
        private string titulo;
        private string situacao;

        public int Identificacao {  get { return identificacao; } set { identificacao = value; } }
        public string Titulo { get {  return titulo; } set {  titulo = value; } }
        public string Situacao { get { return situacao; } set {  situacao = value; } }

        public ItemBiblioteca(int identificacao, string titulo, string situacao)
        {
            this.identificacao = identificacao;
            this.titulo = titulo;
            this.situacao = situacao;
        }
        public abstract string Guardar();
        public override string ToString()
        {
            return $"{identificacao};{titulo};{situacao}";
        }
    }
}
