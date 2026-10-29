namespace atividade_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        const double imcPrevisto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();

        Assert.Equal(imcPrevisto, i.imc);
    }

    [Theory]
    [InlineData(50, 1.70, "Abaixo do peso")]
    [InlineData(60, 1.70, "Peso normal")]
    [InlineData(75, 1.70, "Sobrepeso")]
    [InlineData(90, 1.70, "Obesidade Grau I")]
    [InlineData(110, 1.70, "Obesidade Grau II")]
    [InlineData(130, 1.70, "Obesidade Grau III")]
    public void Teste_Categoria_IMC(double peso, double altura, string categoriaEsperada)
    {
        IMC i = new IMC
        {
            peso = peso,
            altura = altura
        };

        i.Calcular_IMC();
        i.Classificar_IMC();

        Assert.Equal(categoriaEsperada, i.categoria);
    }
}
