public class Subtracao : IOperacao
{
    public int Resultado { get; set; }

    public double RealizarCalculo(int numero, double result, int tipoOperacao)
    {
        if(tipoOperacao == (int)ETipoOperacao.Subtracao){
            result -= numero;
            return result;
        }
        return new Soma().RealizarCalculo(numero, result, tipoOperacao);
    }
}
