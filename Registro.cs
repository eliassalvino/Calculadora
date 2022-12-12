

namespace Calculadora;
public class Registro
{

	List <string> operacoes = new List<string> ();

	public Registro()
	{
		operacoes = new List<string> ();
	}

		
	public void GravarHistórico(List <string> a)
	{
		operacoes.AddRange (a);

        StreamWriter sw = new StreamWriter(@"C:\arquivos\Registro.txt");

		operacoes.ForEach(i => sw.WriteLine(i));
		sw.Close();
    }

	public void HistoricoOperacoes()
	{
        string nameArquivo = @"C:\arquivos\Registro.txt";

        using (StreamReader arquivo = File.OpenText(nameArquivo))
        {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }


}
