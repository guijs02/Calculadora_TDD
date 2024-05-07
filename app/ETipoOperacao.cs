using System.ComponentModel.DataAnnotations;

public enum ETipoOperacao
{
    [Display(Name = "Multiplicação")]
    Mutiplicacao = 1,
    [Display(Name = "Soma")]
    Soma = 2,
    [Display(Name = "Divisão")]
    Divisao = 3,
    [Display(Name = "Subtração")]
    Subtracao = 4,
}
