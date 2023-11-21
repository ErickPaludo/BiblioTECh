using System;
using System.Security.Cryptography.X509Certificates;

namespace BiblioTECh
{
    public class Menu
    {
        private EntradaDados entradaDados;
        private Usuario pessoa;
        private CadUser cad;
        private SalvarDados salvar;
        int entrada;


        public Menu()
        {
            menu();
        }

        public void menu()
        {
            bool verificador = false;
            do
            {
                cad = new CadUser();
                entradaDados = new EntradaDados();
                Console.WriteLine("Informe a Opcao desejada:");
                Console.WriteLine("1- Registrar usuario;");
                Console.WriteLine("2- Exibir usuarios");
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");

                switch (entrada)
                {
                    case 1:
                        RegUser();
                        break;
                    case 2:
                        Console.WriteLine("teste2");
                        cad.CadView();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == false);
        }
        public void RegUser()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Usuario");
            string auxnome = entradaDados.LeString("Informe o nome do usuario: ");
            string auxendereco = entradaDados.LeString("Informe o seu endereco: ");
            int auxnumero = entradaDados.LeInteiro("Informe o numero da residencia: ");
            string auxcomplemento = entradaDados.LeString("Complemento: ");
            string auxbairro = entradaDados.LeString("Informe o seu bairro: ");
            string auxcidade = entradaDados.LeString("Informe o sua cidade: ");
            string auxestado = entradaDados.LeString("Informe o seu estado: ");
            string auxcep = entradaDados.LeString("Informe o seu CEP: ");
            string auxmatricula = entradaDados.LeString("Informe o RGM do aluno: ");
            string auxcurso = entradaDados.LeString("Informe o seu curso: ");
            pessoa = new Usuario(auxnome, auxendereco, auxnumero, auxcomplemento, auxbairro, auxcidade, auxestado, auxcep, auxmatricula, auxcurso);
            cad.Insere(pessoa);
            salvar = new SalvarDados();
            salvar.Salvar(cad, "alunos.txt");

        }
    }
}
