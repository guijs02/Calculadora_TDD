public class Divisao : IOperacao
{
    public int Resultado { get; set; }

    public double RealizarCalculo(int numero, double result, int tipoOperacao)
    {
        if(tipoOperacao == (int)ETipoOperacao.Divisao){
            result /= numero;
            return Math.Round(result, 2);
        }
        throw new InvalidOperationException("Opa, esta opção não está presente no menu! Por favor, insira uma opção válida!");
    }

    ///crie uma função
    

}
