using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Quantos numeros estarão na operação ??");
        int quantidade = int.Parse(Console.ReadLine());
        int[] numeros = PutNumbers(quantidade);

        ApresentarOperacoes();

        int opUser = int.Parse(Console.ReadLine());
        RealizarOperacao(numeros, opUser);

        
    }

    public static void ApresentarOperacoes()
    {
        Console.WriteLine("Qual operação quer realizar? \n\n Multiplicação - 1 \n Soma - 2 \n Divisão - 3 \n Subtração - 4");
    }

    private static void PrintarResultado(double result)
    {
        System.Console.WriteLine("O resultado da operação é: " + result);
    }

    public static double RealizarOperacao(int[] numeros, int op)
    {
        try
        {

            double result = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if(i == 0){
                    result = numeros[i];
                    continue;
                }
                //result = numeros[i];
                result = new Multiplicacao().RealizarCalculo(numeros[i], result, op);
            }
            PrintarResultado(result);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public static int[] PutNumbers(int quantidade)
    {
        var numeros = new int[quantidade];
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"digite o {i + 1}º numero pra gente!");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        return numeros;
    }

}
