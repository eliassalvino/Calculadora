namespace Calculadora;
public class Operadores
{
    public List<string> Escolha(int a)
    {
        string resultado;
        List<string> lista = new List<string>();
        switch (a)
        {
            case 1:
                Console.WriteLine("\nInforme os numeros para a SOMA: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("+");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("====");
                Console.WriteLine(Soma(num1, num2));
                resultado = $"{num1} + {num2} = {Soma(num1, num2)}";
                lista.Add(resultado);
                return lista;
            case 2:
                Console.WriteLine("\nInforme os numeros para a SUBTRACAO: ");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("-");
                int num4 = int.Parse(Console.ReadLine());

                Console.WriteLine("====");
                Console.WriteLine(Subtracao(num3, num4));
                resultado = $"{num3} - {num4} = {Subtracao(num3, num4)}";
                lista.Add(resultado);
                return lista;
            case 3:
                Console.WriteLine("\nInforme os numeros para a MULTIPLICACAO: ");
                int num5 = int.Parse(Console.ReadLine());
                Console.WriteLine("*");
                int num6 = int.Parse(Console.ReadLine());

                Console.WriteLine("====");
                Console.WriteLine(Multiplicacao(num5, num6));
                resultado = $"{num5} * {num6} = {Multiplicacao(num5, num6)}";
                lista.Add(resultado);
                return lista;
           case 4:
                Console.WriteLine("\nInforme os numeros para a DIVISAO: ");
                int num7 = int.Parse(Console.ReadLine());
                Console.WriteLine("/");
                int num8 = int.Parse(Console.ReadLine());

                Console.WriteLine("====");
                Console.WriteLine(Divisao(num7, num8));
                resultado = $"{num7} / {num8} = {Soma(num7, num8)}";
                lista.Add(resultado);
                return lista;
            default:
                return new List<string>();
        }
    }
	private int Soma(int a, int b)
	{
        return (a + b);
	}
    private int Subtracao(int a, int b)
    {
        return (a - b);
    }
    private int Multiplicacao(int a, int b)
    {
        return (a * b);
    }
    private float Divisao(int a, int b)
    {
        float divisaoFeita;
        if (b == 0)
        {
            Console.WriteLine("Impossivel dividir por zero (0).");
            return 0.0f;
        }
        else
        {
            divisaoFeita = (a / b);
            return divisaoFeita;
        }
    }
}
