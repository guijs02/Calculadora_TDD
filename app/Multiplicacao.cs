public class Multiplicacao : IOperacao
{
    public int Resultado { get; set; }

    public double RealizarCalculo(int numero, double result, int tipoOperacao)
    {
        if(tipoOperacao == (int)ETipoOperacao.Mutiplicacao){
            result *= numero;
            return result;
        }
        return new Subtracao().RealizarCalculo(numero, result, tipoOperacao);
    }
}
