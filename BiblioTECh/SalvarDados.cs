using System;
using System.IO;

namespace BiblioTECh
{
    public class SalvarDados
    {
        public SalvarDados() { }

        public void Salvar(CadUser cadastro, string arquivo)
        {
            Usuario dados = null;
            string linha;

            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    for (int i = 0; i < cadastro.Tamanho(); i++)
                    {
                        dados = cadastro.GetUser(i);
                        linha = $"{dados.Nome};{dados.Rua};{dados.Numero};{dados.Complemento};{dados.Bairro};{dados.Cidade};{dados.Uf};{dados.Cep};{dados.Matricula};{dados.Curso}";
                        sw.WriteLine(linha);
                    }

                    sw.Flush();  // Certifica-se de que todos os dados são gravados no arquivo
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar os dados no arquivo: " + ex.Message);
            }
        }
    }
}
