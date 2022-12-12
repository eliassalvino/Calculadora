namespace Calculadora;

public class Program
{
    public static void Main(string[] args)
    {
        MenuCalculadora menuCalculadora = new MenuCalculadora();
        Operadores operadores = new Operadores();
        Registro registro = new Registro();
        int opcaomenu = 0;
        
        do
        {
            opcaomenu = (menuCalculadora.Menu());
            if (opcaomenu >= 1 && opcaomenu <= 4)
            {
                Console.WriteLine("\nOpcao escolhida " + opcaomenu + ".");
                
                //Aqui chamamos a função Escolha da Classe Operadores que irá receber os valores e calcular|Depois retorna o resultado
                // e adiciona na lista Operacoes Feitas, que será gravada posteriormente em um arquivo.txt
                registro.GravarHistórico(operadores.Escolha(opcaomenu));
                Console.ReadLine();

            }
            else if(opcaomenu == 5){
                Console.WriteLine("Aqui faremos a exibicao de todas as operacoes feitas, gravadas em um arquivo.");
                registro.HistoricoOperacoes();
                Console.ReadLine();
            }
        } while (opcaomenu != 6);

        //SAIDA DO (DO..WHILE) PARA FECHAR O PROGRAMA
        Console.WriteLine("Voce escolheu sair.");
        Console.ReadLine();

    } 
}




