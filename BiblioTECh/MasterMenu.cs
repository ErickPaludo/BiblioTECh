using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    internal class MasterMenu
    {
        EntradaDados entradaDados = new EntradaDados();
        MenuUsers menuuser;
        MenuAcervo menuacervo;
        MenuEmprestimos menuemprestimos;
       

        public MasterMenu()
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
                Console.WriteLine("1- Menu de usuarios;\n2- Menu para Acervo;\n3- Menu Emprestimos;\n4- Sair");

                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");
                Console.Clear();
                switch (entrada)
                {
                    case 1:
                        menuuser = new MenuUsers();
                        break;
                    case 2:
                        menuacervo = new MenuAcervo();
                        break;
                    case 3:
                        menuemprestimos = new MenuEmprestimos();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == true);
        }
    }
}
