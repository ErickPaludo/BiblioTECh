using System;

namespace BiblioTECh
{
    public class MenuUsers
    {

        EntradaDados entradaDados = new EntradaDados();
        MasterMenu voltar;
        CadUser cad = new CadUser();
        private SalvarDados salvar = new SalvarDados();

        public MenuUsers()
        {
            menu();
        }

        public void menu()
        {
            int entrada;
            bool verificador = true;
            do
            {
                Console.WriteLine("Informe a Opcao desejada:");
                Console.WriteLine("1- Registrar usuario;");
                Console.WriteLine("2- Remover usuarios;");
                Console.WriteLine("3- Status de espaco;");
                Console.WriteLine("4- Verificar usuario por posicao;");
                Console.WriteLine("5- Mostrar todos os usuarios;");
                Console.WriteLine("6- Voltar");
                //LEMBRAR DE APAGAR OPCAO 456
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");
                Console.Clear();
                switch (entrada)
                {
                    case 1:
                        RegUser();
                        break;
                    case 2:
                        cad.Removedor();
                        break;
                    case 3:
                        cad.ExibirCadastros();
                        break;
                    case 4:
                        FiltrarPosi();
                        break;
                    case 5:
                        Console.WriteLine("Usuarios cadastrados: ");
                        cad.Exibir();
                        break;
                    case 6:
                        voltar = new MasterMenu();
                        break;
                    case 456:
                        cad.Temp();
                        break;
                    default:
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == true);

        }
        public void RegUser()
        {
            Console.Clear();
            if (cad.ValidarEspaco() == true)
            {
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
                cad.Registrador(auxnome, auxendereco, auxnumero, auxcomplemento, auxbairro, auxcidade, auxestado, auxcep, auxmatricula, auxcurso);
                salvar.GravarDados();
            }
        }
        public void FiltrarPosi()
        {
            if (cad.NoNull() == true)
            {
                Console.WriteLine("Cadastro de Usuario");
                int auxpos = entradaDados.LeInteiro("Verificar usuario na posicao: ");
                cad.Filtro(auxpos);
            }
        }
    }
}
