using Aula2TrilhaDotNet.DTO.SerraCircular.RetornarListaSerraCircular;
using Aula2TrilhaDotNet.Entities;
using Aula2TrilhaDotNet.Repositorio;
using Aula2TrilhaDotNet.Teste.Builder;
using Aula2TrilhaDotNet.UseCase;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Aula2TrilhaDotNet.Teste.UseCase {
    public class RetornarListaSerraCircularUseCaseTest {

        private readonly Mock<IRepositorioSerraCircular> _repositorioSerraCircular;
        private readonly RetornarListaSerraCircularUseCase _retornarListaSerraCircularUseCase;

        public RetornarListaSerraCircularUseCaseTest() {
            _repositorioSerraCircular = new Mock<IRepositorioSerraCircular>();
            _retornarListaSerraCircularUseCase = new RetornarListaSerraCircularUseCase(_repositorioSerraCircular.Object);
        }

        [Fact]
        public void SerraCircular_Retornar_Lista_QuandoRetornarSucesso() {
            var response = new RetornarListaSerraCircularResponse();
            var serraCircular = new SerraCircular();
            response.msg = "Lista de Serra Circular retornada com sucesso";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Listar()); ;

            var resulte = _retornarListaSerraCircularUseCase.Executar();
            response.Should().BeEquivalentTo(resulte);
        }

        [Fact]
        public void SerraCircular_Remover_QuandoRepositorioExcecao() {
            var response = new RetornarListaSerraCircularResponse();
            var serraCircular = new SerraCircular();
            response.msg = "Não foi possível retornar a lista de Serra Circular";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Listar()).Throws(new Exception()); ;

            var resulte = _retornarListaSerraCircularUseCase.Executar();
            response.Should().BeEquivalentTo(resulte);
        }
    }
}
