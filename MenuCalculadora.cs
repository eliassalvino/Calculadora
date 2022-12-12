namespace Calculadora;
public class MenuCalculadora
{
	public int Menu()
	{
        int opcao = 0;
        string convertido;
        bool verifica = false;
        do
        {
            Console.Clear();
            Console.WriteLine("====CALCULADORA====");
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao\n5 - Mostrar operacoes feitas\n6 - Sair");
            char escolha = char.Parse(Console.ReadLine());
            

            if (char.IsDigit(escolha))
            {
                convertido = char.ToString(escolha);
                opcao = int.Parse(convertido);
               
                if (opcao >=1 && opcao <= 6)
                {
                    verifica = true;
                }
            }
        } while (verifica == false);

        return opcao;
    }
}

