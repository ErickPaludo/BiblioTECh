using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class Pessoa
    {
        protected string nome;
        protected Endereco endereco;

        public Pessoa(string nome, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep) 
        {
            this.nome = nome;
            endereco = new Endereco(rua, numero,complemento, bairro, cidade, uf, cep);
        }
        public string Nome { get { return nome; } set { value = nome; } }
        public Endereco Endereco { get { return endereco; } set { value = endereco; } }
        public override string ToString()
        {
            return $" Nome: {Nome}\n";
        }
    }
}
