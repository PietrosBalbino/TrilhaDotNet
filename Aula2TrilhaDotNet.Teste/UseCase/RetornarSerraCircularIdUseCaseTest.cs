using Aula2TrilhaDotNet.DTO.SerraCircular.RotrnanarSerraCircularId;
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
    public class RetornarSerraCircularIdUseCaseTest {

        private readonly Mock<IRepositorioSerraCircular> _repositorioSerraCircular;
        private readonly RetornarSerraCircularIdUseCase _idUseCase;

        public RetornarSerraCircularIdUseCaseTest() {

            _repositorioSerraCircular = new Mock<IRepositorioSerraCircular>();
            _idUseCase = new RetornarSerraCircularIdUseCase(
                _repositorioSerraCircular.Object);
        }

        [Fact]
        public void SerraCircular_Retonar_QuandoRetornarSucesso() {
            var serraCircular = new SerraCircular();
            var request = new RetornarSerraCircularIdRequestBuilder().Builder();
            var response = new RetornarSerraCircularIdResponse();
            response.serra_circular_response = serraCircular;
            response.msg = "Serra Circular retornada com sucesso!";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Read(request.id)).Returns(serraCircular);

            var resulte = _idUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);

        }
        [Fact]
        public void SerraCircular_Retonar_SerraCircularNull() {
            var serraCircular = new SerraCircular();
            var request = new RetornarSerraCircularIdRequest();
            var response = new RetornarSerraCircularIdResponse();
            request.id = 1;
            response.msg = "Erro ao retornar Serra Circular";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Read(serraCircular.id)).Returns(serraCircular);

            var resulte = _idUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);

        }

        [Fact]
        public void SerraCircular_Retonar_QuandoRetornarExcecao() {
            var serraCircular = new SerraCircular();
            var request = new RetornarSerraCircularIdRequestBuilder().Builder();
            var response = new RetornarSerraCircularIdResponse();
           
            response.msg = "Erro ao retornar Serra Circular";

            _repositorioSerraCircular.Setup(repositorio => repositorio.Read(request.id)).Throws(new Exception());

            var resulte = _idUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);

        }
    }
}
    

