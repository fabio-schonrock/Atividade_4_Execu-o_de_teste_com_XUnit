namespace atividade_imc_xunit
{
    public class IMC
    {
        public double peso;
        public double altura;
        public double imc;
        public string categoria;

        public void Calcular_IMC()
        {
            imc = peso / Math.Pow(altura, 2);
            imc = Math.Round(imc, 2);
        }

        public void Classificar_IMC()
        {
            if (imc < 18.5)
                categoria = "Abaixo do peso";
            else if (imc < 25)
                categoria = "Peso normal";
            else if (imc < 30)
                categoria = "Sobrepeso";
            else if (imc < 35)
                categoria = "Obesidade Grau I";
            else if (imc < 40)
                categoria = "Obesidade Grau II";
            else
                categoria = "Obesidade Grau III";
        }
    }
}
