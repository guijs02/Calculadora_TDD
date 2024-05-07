using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace test;

public class CalculatorTest
{

    //user defini quantos numeros ira fazer a operação...
    //armazenar no array e pra cada numero realizar a operação
    [Theory]
    [InlineData(new int[]{1,2,3,4}, 24)]
    [InlineData(new int[]{2,3,1}, 6)]
    [InlineData(new int[]{5,8,3,2}, 240)]
    [InlineData(new int[]{4,2,9,30}, 2160)]
    public void TestarMultiplicacao_ResultadoCorreto(int[] nums, int expected)
    {
        int op = RetornarTipoOperacao(ETipoOperacao.Mutiplicacao);
        var result = Program.RealizarOperacao(nums, op);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[]{1,2,3,4}, 10)]
    [InlineData(new int[]{2,3,1}, 6)]
    [InlineData(new int[]{5,8,3,2}, 18)]
    public void TestarSomar_ResultadoCorreto(int[] nums, int expected)
    {
        int op = RetornarTipoOperacao(ETipoOperacao.Soma);

        var result = Program.RealizarOperacao(nums, op);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[]{1,2,3,4}, -8)]
    [InlineData(new int[]{2,3,1}, -2)]
    [InlineData(new int[]{25,8,3,2}, 12)]
    public void TestarSubtracao_ResultadoCorreto(int[] nums, int expected)
    {
        int op = RetornarTipoOperacao(ETipoOperacao.Subtracao);

        var result = Program.RealizarOperacao(nums, op);

        Assert.Equal(expected, result);
    }
    

    [Theory]
    [InlineData(new int[]{1,2,3,4}, 0.04)]
    [InlineData(new int[]{556,24,3}, 7.72)]
    [InlineData(new int[]{89,11,5}, 1.62)]
    public void TestarDivisao_ResultadoCorreto(int[] nums, double expected)
    {
        int op = RetornarTipoOperacao(ETipoOperacao.Divisao);

        var result = Program.RealizarOperacao(nums, op);

        Assert.Equal(expected, result);
    }

    
    [Fact]
    public void TestarOpcaoIncorreta()
    {
        int op = 22;

        Assert.Throws<InvalidOperationException>(() => Program.RealizarOperacao(new int [2], op));
    }



    int RetornarTipoOperacao(ETipoOperacao eTipoOperacao) => (int)eTipoOperacao;

}