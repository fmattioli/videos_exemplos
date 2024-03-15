namespace OperacoesMatematicas.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Somar_QuandoInformadoDoisNumeros_DeveSomarCorretamente()
        {
            //Arrange
            int num1 = 10;
            int num2 = 20;

            //Act
            var resultado = _calculadora.Somar(num1, num2);

            //Assert
            Assert.Equal(30, resultado);
        }

        [Fact(DisplayName = "Qualquer nome relacionado ao teste")]
        public void Multiplicar_QuandoInformadoDoisNumeros_DeveMultiplicarCorretamente()
        {
            //Arrange
            int num1 = 5;
            int num2 = 10;

            //Act
            var resultado = _calculadora.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(50, resultado);
        }


        [Fact]
        public void Subtrair_QuandoInformadoDoisNumeros_DeveSubtrairCorretamente()
        {
            //Arrange
            int num1 = 50;
            int num2 = 40;

            //Act
            var resultado = _calculadora.Subtrair(num1, num2);

            //Assert
            Assert.Equal(15, resultado);
        }
    }
}
