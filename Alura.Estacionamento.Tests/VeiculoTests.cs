using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTests
    {
        [Fact]
        public void AcelerarTest()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact]
        public void FrearTest()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}