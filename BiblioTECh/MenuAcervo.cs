using System;
using System.Security.Cryptography.X509Certificates;

namespace BiblioTECh
{
    public class MenuAcervo
    {
        EntradaDados entradaDados = new EntradaDados();
        MasterMenu voltar;
        Acervo acervo = new Acervo();

        public MenuAcervo()
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
                Console.WriteLine("1- Adicionar um item no acervo da biblioteca;");
                Console.WriteLine("2- Remover item do acervo da biblioteca;");
                Console.WriteLine("3- Itens no sistema;");
                Console.WriteLine("4- Filtrar por posicao;");
                Console.WriteLine("6- Mostrar Tudo que esta no estoque:"); //TEMP
                Console.WriteLine("5- Voltar"); 
                entrada = entradaDados.LeInteiro("Selecione uma opcao: ");

                switch (entrada)
                {
                    case 1:
                        Console.Clear();
                        Adicionar();
                        break;
                    case 2:
                        Console.Clear();
                        acervo.Remover();
                        break;
                    case 3:
                        acervo.MostrarEspaco();
                        break;
                    case 4:
                        Console.Clear();
                        FiltroPosi();
                        break;
                    case 5:
                        Console.Clear();
                        voltar = new MasterMenu();
                        break;
                    case 6:
                        Console.Clear();
                        acervo.Mostrar();
                        break;
                    case 300:
                        acervo.Insere(new Livro("Ilana Casoy", "Darkside", 355, 666, "Arquivos Serial Killers: Edicao Brasil Definitiva", ""));
                        acervo.Insere(new Dvd("Inserindo lista", 24, 123, "Mamonas Assasinas", ""));
                        acervo.Insere(new Periodico("Mensal", 84, 24, 69, "Playboy", ""));
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("opcao incorreta");
                        break;
                }
            } while (verificador == true);
        }
        public void Adicionar() 
        {
            int entrada;
            int auxident;
            string auxtitulo;
            string auxsituacao = "nada ainda";
            entradaDados = new EntradaDados();
            Console.WriteLine("Informe a Opcao desejada:\n1- Adicionar Livro;\n2- Adicionar Periodico;\n3- Adicionar DVD;");
            entrada = entradaDados.LeInteiro("Selecione uma opcao: ");

            switch (entrada)
            {
                case 1:
                    Console.WriteLine("Adicionar Livro");
                    auxident = entradaDados.LeInteiro("Insira a identificacao do item: ");
                    auxtitulo = entradaDados.LeString("Insira o Titulo do Item: ");
                    string auxautor = entradaDados.LeString("Insira o nome do Autor do livro: ");
                    string auxeditora = entradaDados.LeString("Insira o nome da Editora do Livro: ");
                    int auxpag = entradaDados.LeInteiro("Insira o numero de paginas: ");
                    acervo.Insere(new Livro(auxautor, auxeditora, auxpag, auxident, auxtitulo, auxsituacao));
                    break;
                case 2:
                    Console.WriteLine("Adicionar Periodico");
                    auxident = entradaDados.LeInteiro("Insira a identificacao do item: ");
                    auxtitulo = entradaDados.LeString("Insira o Titulo do Item: ");
                    string auxperiodicidade = entradaDados.LeString("Insira o periodo: ");
                    int auxnumero = entradaDados.LeInteiro("Insira o numero da edicao: ");
                    int auxano = entradaDados.LeInteiro("Insira o ano de publicacao: ");
                    acervo.Insere(new Periodico(auxperiodicidade,auxnumero,auxano, auxident, auxtitulo, auxsituacao));
                    break;
                case 3:
                    Console.WriteLine("Adicionar DVD");
                    auxident = entradaDados.LeInteiro("Insira a identificacao do item: ");
                    auxtitulo = entradaDados.LeString("Insira o Titulo do Item: ");
                    string auxassunto = entradaDados.LeString("Insira o assunto do DVD: ");
                    int auxduracao = entradaDados.LeInteiro("Insira duraacao do DVD em minutos: ");
                    acervo.Insere(new Dvd(auxassunto, auxduracao,auxident, auxtitulo,auxsituacao));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("opcao incorreta");
                    break;
            }
        }
        public void FiltroPosi()
        {
            if (acervo.NoNull() == true)
            {
                Console.WriteLine("Filtro Posicao!");
                int entrada = entradaDados.LeInteiro("Insira a posicao em que deseja filtrar o item: ");
                acervo.Filtro(entrada - 1);
            }
        }
    }
}
