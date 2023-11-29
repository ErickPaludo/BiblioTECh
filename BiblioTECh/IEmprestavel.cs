using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public interface IEmprestavel
    {
        public bool Disponivel();
        public bool Emprestado();
        public bool Bloqueado();
        public bool Atrasado();
        public string ToString();
    }
}
