using TesteServices.Services;

namespace TestesNaPratica
{
    public class CalculadoraServiceTests
    {
        #region Somar
        [Fact]
        public void Somar_NumerosPositivos_DeveRetornarResultadoCorreto()
        {
            var service = new Calculadora();

            var resultado = service.Somar(2, 3);

            Assert.Equal(5, resultado);
        }
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 5, 15)]
        [InlineData(-1, 1, 0)]
        [InlineData(-5, 10, 5)]
        [InlineData(10, -20, -10)]
        public void Somar_ValoresValidos_DeveRetornarResultadosCorretos(int a, int b, int esperado)
        {
            var service = new Calculadora();

            var resultado = service.Somar(a, b);

            Assert.Equal(esperado, resultado);
        }
        #endregion

        #region Divisao
        [Fact]
        public void Dividir_NumerosValidos_DeveRetornarADivisaoCorreta()
        {
            var service = new Calculadora();

            var resultado = service.Dividir(50, 5);

            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Dividir_DivisorZero_AExcecaoDeveSerDivisaoPorZeroNaoPermitida()
        {
            var service = new Calculadora();

            var exception = Assert.Throws<ArgumentException>(() => service.Dividir(1, 0));

            Assert.Equal("Divisão por zero não é permitida.", exception.Message);
        }
        #endregion
    }
}