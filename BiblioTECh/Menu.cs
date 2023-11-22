using System;

namespace BiblioTECh
{
    public class Menu
    {
        EntradaDados entradaDados;
        CadUser cad;
        int entrada;
        bool verificador = true;

        public Menu()
        {
            menu();
        }

        public void menu()
        {
            do
            {
                cad = new CadUser();
                entradaDados = new EntradaDados();
                Console.WriteLine("Informe a Opcao desejada:");
                Console.WriteLine("1- Registrar usuario;");
                Console.WriteLine("2- Mostrar usuarios;");
                Console.WriteLine("3- Remover usuarios;");
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");

                switch (entrada)
                {
                    case 1:
                        RegUser();
                        break;

                    case 2:
                        Console.Clear();
                        cad.ExibirCadastros();
                        break;
                    case 3:
                        Console.Clear();
                        RemovUser();
                        break;
                    case 4: //REGISTRA USER FICTICIOS PARA TESTES
                        Console.Clear();
                        cad.Temp();
                        break;
                    default:
                        Console.Clear();
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
            }
        }
        public void RemovUser()
        {
            Console.Clear();
            bool val = cad.ValidarRem();
            if (val == true)
            {
                Console.WriteLine("\nRemover Usuario");
                string auxnome = entradaDados.LeString("Informe o nome do usuario que deve ser removido: ");
                cad.Removedor(auxnome);
            }
           
        }
    }
}
