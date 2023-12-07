using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTECh
{
    public class MenuEmprestimos
    {
        EntradaDados entradaDados = new EntradaDados();
        MasterMenu voltar;
        Acervo acervo = new Acervo();
        CadUser cad = new CadUser();
        Emprestimo emprestimo = new Emprestimo();
        Usuario usuario;
        ItemBiblioteca item;

        public MenuEmprestimos()
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
                Console.WriteLine("1-Realizar emprestimo;");
                Console.WriteLine("2-Devolver um empréstimo;");
                Console.WriteLine("3-Mostrar Tudo que esta no estoque:"); //TEMP
                Console.WriteLine("4-Voltar");
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");
                Console.Clear();
                switch (entrada)
                {
                    case 1:
                        Emprestar();
                        break;
                    case 2:
                        Devolver();
                        break;
                    case 3:
                        emprestimo.Exibir();
                        break;
                    case 4:
                        voltar = new MasterMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == true);
        }
        public void Emprestar()
        {
            if (cad.NoNull() == true && acervo.NoNull())
            {
                cad.Exibir();
                string auxentrada = entradaDados.LeString("Insira o RGM do aluno: ");
                if (cad.UserTrue(auxentrada) == true)
                {
                    if (acervo.NoNull() == true)
                    {
                        acervo.MostrarDisp();
                        int auxentradaitem = entradaDados.LeInteiro("Insira o codigo do produto: ");
                        if (acervo.ItemTrue(auxentradaitem) == true)
                        {
                            emprestimo.Emprestar(cad.Usu(auxentrada), acervo.Item(auxentradaitem), acervo.Prazo(auxentradaitem));
                        }
                    }
                }
            }
        }
        public void Devolver()
        {
            if (emprestimo.NoNull() == true)
            {
                emprestimo.Exibir();
                int aux = entradaDados.LeInteiro("Qual item deve ser devolvido? ");
                emprestimo.Retornar(aux);
            }
        }
    }
}
