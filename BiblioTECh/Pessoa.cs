using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Pessoa:Endereco
    {
        private string nome;
        public Pessoa(string nome, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep): base(rua, numero, complemento, bairro, cidade, uf, cep)
        {
            this.nome = nome;
        }
        public string Nome {  get { return nome; } set { value = nome; } }
        public override string ToString()
        {
            return Cep.ToString();
        }
    }
}
