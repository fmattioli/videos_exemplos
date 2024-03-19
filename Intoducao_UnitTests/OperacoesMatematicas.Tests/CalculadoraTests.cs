using AutoFixture;

using FluentAssertions;

using Moq;

namespace OperacoesMatematicas.Tests
{
    public class CalculadoraTests
    {
        private readonly Fixture _fixture;
        private readonly Operacoes _operacoes;
        private readonly Mock<ICalculadora> _calculadoraMock = new Mock<ICalculadora>();

        public CalculadoraTests()
        {
            _operacoes = new Operacoes(_calculadoraMock.Object);
            _fixture = new Fixture();
        }

        [Fact]
        public void Somar_QuandoInformadoDoisNumeros_DeveSomarCorretamente_Chamando_O_Metodo_Somar()
        {
            //Arrange
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();

            _calculadoraMock
                .Setup(x => x.Somar(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(60);

            //Act
            var resultado = _operacoes.RealizarSoma(num1, num2);

            //Assert
            resultado
                .Should()
                .NotBe(0);

            resultado
                .Should()
                .BeGreaterThan(50);

            resultado
                .Should()
                .BeLessThanOrEqualTo(60);

            resultado
                .Should()
                .Be(60);

            _calculadoraMock.Verify(x => x.Somar(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(10));
        }
    }
}
