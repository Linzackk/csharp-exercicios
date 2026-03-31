using Xunit;
using Moq;
using Mock;

namespace TestesEmMock
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void ObterUsuario_DeveRetornarUsuario_QuandoIdExistir()
        {
            var mock = new Mock<IUsuarioRepository>();

            mock.Setup(x => x.BuscarPorId(1))
                .Returns(new Usuario { Id = 1, Nome = "Isaac" });

            var service = new UsuarioService(mock.Object);

            var resultado = service.ObterUsuario(1);

            Assert.NotNull(resultado);
            Assert.Equal(1, resultado.Id);
            Assert.Equal("Isaac", resultado.Nome);
        }

        [Fact]
        public void ObterUsuario_DeveLancarExcecao_QuandoUsuarioNaoExistir()
        {
            var mock = new Mock<IUsuarioRepository>();

            mock.Setup(x => x.BuscarPorId(1))
                .Returns((Usuario?)null);

            var service = new UsuarioService(mock.Object);

            Assert.Throws<Exception>(() => service.ObterUsuario(1));
        }

        [Fact]
        public void ObterUsuario_DeveChamarRepository_ComIdCorreto()
        {
            var mock = new Mock<IUsuarioRepository>();

            mock.Setup(x => x.BuscarPorId(1))
                .Returns(new Usuario { Id = 1, Nome = "Isaac" });

            var service = new UsuarioService(mock.Object);

            service.ObterUsuario(1);

            mock.Verify(x => x.BuscarPorId(1), Times.Once);
        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(5, false)]
        [InlineData(3, true)]
        public void ObterUsuario_MultiplosCenarios(int id, bool existe)
        {
            var mock = new Mock<IUsuarioRepository>();

            if (existe) 
            {
                mock.Setup(x => x.BuscarPorId(id))
                    .Returns(new Usuario { Id = id, Nome = "Teste" });
            }
            else
            {
                mock.Setup(x => x.BuscarPorId(id))
                    .Returns((Usuario?)null);
            }

            var service = new UsuarioService(mock.Object);

            if (existe)
            {
                var resultado = service.ObterUsuario(id);
                Assert.NotNull(resultado);
                Assert.Equal(id, resultado.Id);
            }
            else
            {
                Assert.Throws<Exception>(() => service.ObterUsuario(id));
            }
        }
    }
}