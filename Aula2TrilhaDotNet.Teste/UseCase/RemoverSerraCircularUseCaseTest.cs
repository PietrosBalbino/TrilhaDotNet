using Aula2TrilhaDotNet.DTO.SerraCircular.RemoverSerraCircular;
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
    public class RemoverSerraCircularUseCaseTest {

        private readonly Mock<IRepositorioSerraCircular> _repositorioSerraCircular;
        private readonly RemoverSerraCircularUseCase _removerSerraCircularUseCase;

        public RemoverSerraCircularUseCaseTest() {
            _repositorioSerraCircular = new Mock<IRepositorioSerraCircular>();            
            _removerSerraCircularUseCase = new RemoverSerraCircularUseCase(_repositorioSerraCircular.Object);
        }

        [Fact]
        public void SerraCircular_Remover_QuandoRetornarSucesso() {
            var response = new RemoverSerraCircularResponse();
            var request = new RemoverSerraCircularRequestBuilder().Builder();
           response.msg = "Removido com sucesso";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Remove(request.id)); ;

            var resulte = _removerSerraCircularUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);
        }

        [Fact]
        public void SerraCircular_QuandoRepositorioExcecao() {
            var response = new RemoverSerraCircularResponse();
            var request = new RemoverSerraCircularRequestBuilder().Builder();
            response.msg = "Não foi possível remover a Serra Circular";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Remove(request.id)).Throws(new Exception());

            var resulte = _removerSerraCircularUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);
        }
    }
}
