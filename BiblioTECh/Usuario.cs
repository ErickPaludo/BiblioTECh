using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BiblioTECh
{
    public class Usuario : Pessoa
    {
        private string matricula;
        private string curso;

        public Usuario(string nome, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep, string matricula, string curso)
        : base(nome, rua, numero, complemento, bairro, cidade, uf, cep)
        {
            this.matricula = matricula;
            this.curso = curso;
        }

        public string Matricula { get { return matricula; } set { matricula = value; } }
        public string Curso { get { return curso; } set { curso = value; } }
        public override string ToString()
        {
            return $"{Nome};{endereco.Rua};{endereco.Numero};{endereco.Complemento};{endereco.Bairro};{endereco.Cidade};{endereco.Uf};{endereco.Cep};{matricula};{curso}";
        }
    }
}
