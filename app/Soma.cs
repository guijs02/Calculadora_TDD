public class Soma : IOperacao
{
    public int Resultado { get; set; }

    public double RealizarCalculo(int numero, double result, int tipoOperacao)
    {
        if(tipoOperacao == (int)ETipoOperacao.Soma){
            result += numero;
            return result;
        }
        return new Divisao().RealizarCalculo(numero, result, tipoOperacao);
    }
}
