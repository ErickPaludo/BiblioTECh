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
                Console.WriteLine("1- Menu de usuarios;");
                Console.WriteLine("2- Menu para Acervo;");
                Console.WriteLine("3- Sair");
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");

                switch (entrada)
                {
                    case 1:
                        Console.Clear();
                        menuuser = new MenuUsers();
                        break;
                    case 2:
                        Console.Clear();
                        menuacervo = new MenuAcervo();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == true);
        }
    }
}
