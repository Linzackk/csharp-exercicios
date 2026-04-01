using Integracao.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Integracao.Tests
{
    public class UsuarioIntegrationTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly string _url = "/api/Usuarios";
        private readonly ITestOutputHelper _output;

        public UsuarioIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _client = factory.CreateClient();
            _output = output;
        }

        [Fact]
        public  async Task Deve_ProcurarUsuarioInexistente_Retornar404()
        {
            var response = await _client.GetAsync($"{_url}/0");
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Deve_Criar_E_Buscar_Usuario()
        {
            var novoUsuario = new
            {
                id = 0,
                nome = "Isaac",
                email = "Isaac@Isaac.com",
                telefone = "11999999999"
            };

            var postResponse = await _client.PostAsJsonAsync(_url, novoUsuario);

            postResponse.EnsureSuccessStatusCode();

            var usuarioCriado = await postResponse.Content.ReadFromJsonAsync<Usuario>();

            Assert.NotNull(usuarioCriado);
            Assert.Equal("Isaac", usuarioCriado.Nome);
            Assert.Equal("Isaac@Isaac.com", usuarioCriado.Email);
            Assert.Equal("11999999999", usuarioCriado.Telefone);


            var getResponse = await _client.GetAsync($"{_url}/{usuarioCriado.Id}");

            getResponse.EnsureSuccessStatusCode();

            var usuarioObtido = await getResponse.Content.ReadFromJsonAsync<Usuario>();

            Assert.NotNull(usuarioObtido);
            Assert.Equal(usuarioCriado.Id, usuarioObtido.Id);
            Assert.Equal(novoUsuario.nome, usuarioObtido.Nome);
        }

        [Fact]
        public async Task Deve_Criar_E_AtualizarUsuario()
        {
            var novoUsuario = new
            {
                id = 0,
                nome = "Isaac",
                email = "Isaac@Isaac.com",
                telefone = "11999999999"
            };

            var postResponse = await _client.PostAsJsonAsync(_url, novoUsuario);

            postResponse.EnsureSuccessStatusCode();

            var usuarioCriado = await postResponse.Content.ReadFromJsonAsync<Usuario>();

            Assert.NotNull(usuarioCriado);
            Assert.Equal("Isaac", usuarioCriado.Nome);
            Assert.Equal("Isaac@Isaac.com", usuarioCriado.Email);
            Assert.Equal("11999999999", usuarioCriado.Telefone);

            _output.WriteLine($"ID criado: {usuarioCriado.Id}");

            var patchInfos = new
            {
                nome = "Isaac Atualizado",
                telefone = "123"
            };

            _output.WriteLine($"ENVIANDO EM: {_url}/{usuarioCriado.Id}");

            var patchResponse = await _client.PatchAsJsonAsync($"{_url}/{usuarioCriado.Id}", patchInfos);

            _output.WriteLine($"STATUS DA SAIDA:  {patchResponse.StatusCode}");

            patchResponse.EnsureSuccessStatusCode();

            var usuarioAtualizado = await _client.GetAsync($"{_url}/{usuarioCriado.Id}");

            usuarioAtualizado.EnsureSuccessStatusCode();

            var usuarioObtido = await usuarioAtualizado.Content.ReadFromJsonAsync<Usuario>();

            Assert.NotNull(usuarioObtido);
            Assert.Equal("Isaac Atualizado", usuarioObtido.Nome);
            Assert.Equal("Isaac@Isaac.com", usuarioObtido.Email);
            Assert.Equal("123", usuarioObtido.Telefone);
        }

        [Fact]

        public async Task Deve_Criar_E_DeletarUsuario()
        {
            var novoUsuario = new
            {
                id = 0,
                nome = "Isaac",
                email = "Isaac@Isaac.com",
                telefone = "11999999999"
            };

            var postResponse = await _client.PostAsJsonAsync(_url, novoUsuario);

            postResponse.EnsureSuccessStatusCode();

            var usuarioCriado = await postResponse.Content.ReadFromJsonAsync<Usuario>();

            Assert.NotNull(usuarioCriado);
            Assert.Equal("Isaac", usuarioCriado.Nome);
            Assert.Equal("Isaac@Isaac.com", usuarioCriado.Email);
            Assert.Equal("11999999999", usuarioCriado.Telefone);

            var deleteResponse = await _client.DeleteAsync($"{_url}/{usuarioCriado.Id}");

            deleteResponse.EnsureSuccessStatusCode();
        }
    }
}
