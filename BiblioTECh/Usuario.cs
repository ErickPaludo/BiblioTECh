using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BiblioTECh
{
    public class Usuario:Pessoa
    {
        private string matricula;
        private string curso;
        public Usuario(string nome, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep, string matricula, string curso)
        : base(nome, rua, numero, complemento, bairro, cidade, uf, cep)
        {
            this.matricula = matricula;
            this.curso = curso;
        }
        public string Matricula { get { return matricula; } set { value = matricula; } }
        public string Curso { get { return curso; } set { value = curso; } }
        public override string ToString()
        {
            return $"Nome: {Nome}, Rua: {Rua}, Número: {Numero}, Complemento: {Complemento}, Bairro: {Bairro}, Cidade: {Cidade}, UF: {Uf}, CEP: {Cep}, Matrícula: {matricula}, Curso: {curso}";
        }
    }
}
