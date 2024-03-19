namespace OperacoesMatematicas
{
    public class Operacoes
    {
        private readonly ICalculadora _calculadora;
        public Operacoes(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        public int RealizarSoma(int num1, int num2)
        {
            return _calculadora.Somar(num1, num2);
        }
    }
}
