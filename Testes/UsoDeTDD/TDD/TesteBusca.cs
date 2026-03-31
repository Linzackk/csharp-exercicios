using Moq;
using UsoDeTDD;

namespace TDD
{
    public class TesteBusca
    {
        [Fact]
        public void BuscarUsuario_DeveRetornarUsuario_QuandoIdFor1()
        {
            var mock = new Mock<IUsuarioRepository>();

            mock.Setup(x => x.BuscarPorId(1))
                .Returns(new Usuario { Id = 1, Nome = "Teste" });

            var service = new UsuarioService(mock.Object);

            var resultado = service.ObterUsuario(1);

            Assert.Equal(1, resultado.Id);
            Assert.Equal("Teste", resultado.Nome);
        }

        [Fact]
        public void BuscarUsuario_DeveLancarExcecao_QuandoUsuarioNaoExistir()
        {
            var mock = new Mock<IUsuarioRepository>();

            mock.Setup(x => x.BuscarPorId(2))
                .Returns((Usuario?)null);

            var service = new UsuarioService(mock.Object);

            Assert.Throws<Exception>(() => service.ObterUsuario(2));
        }
    }
}