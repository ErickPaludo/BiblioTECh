using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class CadUser
    {
        EntradaDados entradaDados = new EntradaDados();
        private const int TAM = 10;
        static Usuario[] cadastros = new Usuario[TAM];
        static int pos = 0;
        private SalvarDados salvar = new SalvarDados();
        public Usuario[] Cadastros
        {
            get { return cadastros; }
            set { cadastros = value; }
        }
        public int Pos { get { return pos; } set { pos = value; } }
        public int Tamanho()
        {
            return TAM;
        }
        public void Temp() //REGISTRA USER FICTICIOS PARA TESTES
        {
            cadastros[0] = new Usuario("bot1", "Rua Aberlino", 123, "Apt 400", "Atiradores", "Jopiville", "SC", "4566548-99", "456886", "Ciencias da computacao");
            pos++;
            cadastros[1] = new Usuario("bot2", "Rua Belmiro", 456, "Apt 201", "Centro", "VilleVille", "SC", "7890123-45", "789012", "Engenharia Civil");
            pos++;
            cadastros[2] = new Usuario("bot3", "Rua Carlos", 789, "Casa 15", "Jardim Botanico", "Floresville", "SP", "1234567-89", "123456", "Medicina");
            pos++;
            cadastros[3] = new Usuario("bot4", "Rua Diego", 101, "Apt 502", "Praia do Sol", "SolCity", "RJ", "2345678-90", "234567", "Administração");
            pos++;
            cadastros[4] = new Usuario("bot5", "Rua Edna", 112, "Casa 3", "Vila Feliz", "Alegreville", "RS", "3456789-01", "345678", "Psicologia");
            pos++;
            cadastros[5] = new Usuario("bot6", "Rua Fernando", 234, "Apt 1201", "Centro", "VilleVille", "SC", "4567890-12", "456789", "Economia");
            pos++;
            cadastros[6] = new Usuario("bot7", "Rua Gabriela", 567, "Casa 7", "Jardim das Flores", "Floralândia", "SP", "5678901-23", "567890", "Arquitetura");
            pos++;
            cadastros[7] = new Usuario("bot8", "Rua Hugo", 789, "Apt 303", "Praia do Sol", "SolCity", "RJ", "6789012-34", "678901", "Biologia");
            pos++;
            cadastros[8] = new Usuario("bot9", "Rua Isabel", 890, "Casa 10", "Vila Tranquila", "CalmCity", "MG", "7890123-45", "789012", "Direito");
            pos++;
            cadastros[9] = new Usuario("bot10", "Rua João", 111, "Apt 705", "Centro", "VilleVille", "SC", "8901234-56", "890123", "História");
            pos++;
            salvar.GravarDados();
        }
        public bool ValidarEspaco()
        {
            if (pos < TAM)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sem espaco para novos cadastros!");
                return false;
            }
        }
        public void Registrador(string auxnome, string auxendereco, int auxnumero, string auxcomplemento, string auxbairro, string auxcidade, string auxestado, string auxcep, string auxmatricula, string auxcurso)
        {
            cadastros[pos] = new Usuario(auxnome, auxendereco, auxnumero, auxcomplemento, auxbairro, auxcidade, auxestado, auxcep, auxmatricula, auxcurso);
            Console.Clear();
            Console.WriteLine($"Usuario {cadastros[pos].Nome} foi registrado com sucesso");
            pos++;
        }
        public void Removedor()
        {
            if (NoNull() == true)
            {
                Console.WriteLine("Nome de Usuarios:");
                Console.WriteLine("---------------");
                for (int i = 0; i < TAM; i++)
                {
                    if (cadastros[i] != null)
                    {
                        Console.WriteLine($"{i + 1}.Nome:{cadastros[i].Nome} |Matricula: {cadastros[i].Matricula}");
                    }
                }
                string matricula = entradaDados.LeString("Informe a MATRICULA do usuario que deve ser removido: ");
                bool validador = false;
                for (int i = 0; i < TAM; i++)
                {
                    if (cadastros[i] != null)
                    {
                        if (cadastros[i].Matricula == matricula) // revisar da linha 87 ate 107
                        {
                            string auxnome = cadastros[i].Nome;
                            Console.Write($"Removendo Usuario {cadastros[i].Nome}\n");
                            for (int j = i + 1; i < TAM; j++) 
                            {
                                validador = true;
                                if (i != TAM - 1)
                                {
                                    cadastros[i] = cadastros[j];
                                    i++;
                                }
                                else
                                {
                                    cadastros[i] = null;
                                    i++;
                                    pos--;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine($"Usuario {auxnome}|{matricula} foi Removido com Sucesso!"); // revisar da linha 107 ate 87
                        }
                        salvar.GravarDados();
                    }
                }

                if (validador == false)
                {
                    Console.WriteLine("Usuario nao identificado, tente novamente!");
                }
            }
        }
        public void ExibirCadastros()
        {
            if (pos == 0)
            {
                Console.WriteLine($"Sem usuarios cadastrados ({pos}/{TAM})");
            }
            else
            {
                Console.WriteLine($"Total de Usuarios cadastrados ({pos}/{TAM})");
            }
        }
        public void Filtro(int posicao)
        {
            posicao--;
            if (posicao < TAM && posicao > 0 && cadastros[posicao] != null)
            {
                Console.WriteLine($"Usuario {cadastros[posicao].Nome} se emcontra nessa posicao");
            }
            else
            {
                Console.WriteLine("Usuario nao foi encontrado!");
            }

        }
        public bool NoNull()
        {
            if (cadastros[0] == null)
            {
                Console.WriteLine("Nenhum usuario cadastrado!");
                return false;
            }
            else { return true; }
        }
    }
}