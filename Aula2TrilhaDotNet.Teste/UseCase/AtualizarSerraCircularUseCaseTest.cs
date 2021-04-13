using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
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
    public class AtualizarSerraCircularUseCaseTest {

        private readonly Mock<IRepositorioSerraCircular> _repositorioSerraCircular;
        private readonly Mock<IAtualizarSerraCircularAdapter> _atualizarSerraCircularAdapter;
        private readonly AtulaizarSerraCircularUseCase _atulaizarSerraCircularUseCase;

        public AtualizarSerraCircularUseCaseTest() {
            _repositorioSerraCircular = new Mock<IRepositorioSerraCircular>();
            _atualizarSerraCircularAdapter = new Mock<IAtualizarSerraCircularAdapter>();
            _atulaizarSerraCircularUseCase = new AtulaizarSerraCircularUseCase(
                _repositorioSerraCircular.Object,
                _atualizarSerraCircularAdapter.Object);
        }

        [Fact]
        public void SerraCircular_Atualizar_QuandoRetornarSucesso() {
            var response = new AtualizarSerraCircularResponse();
            var request = new AtualizarSerraCircularRequestBuilder().Builder();
            var serraCircular = new SerraCircular();
            response.msg = $"Serra Circular ID: { request.id} atualizada!!";

            _atualizarSerraCircularAdapter.Setup(adapter => adapter.converterRequesteParaSerraCircularAtualizar(request)).Returns(serraCircular);
            _repositorioSerraCircular.Setup(repositorio => repositorio.Update(serraCircular));

            var resulte = _atulaizarSerraCircularUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);
        }

        [Fact]
        public void SerraCircular_Atualizar_QuandoNomeMaiorVinte() {
            var response = new AtualizarSerraCircularResponse();
            var request = new AtualizarSerraCircularRequestBuilder().NameLength(21).Builder();
            var serraCircular = new SerraCircular();
            response.msg = "Erro ao adicionar Serra Circular - Não pode ter mais de 20 caracteres ";
                        
            var resulte = _atulaizarSerraCircularUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);
        }

        [Fact]
        public void SerraCircular_Atualizar_QuandoRepositorioExcecao() {
            var response = new AtualizarSerraCircularResponse();
            var request = new AtualizarSerraCircularRequestBuilder().NameLength(3).Builder();
            var serraCircular = new SerraCircular();
            response.msg = "Erro ao atualizar a Serra Circular";

            _atualizarSerraCircularAdapter.Setup(adapter => adapter.converterRequesteParaSerraCircularAtualizar(request)).Returns(serraCircular);
            _repositorioSerraCircular.Setup(repositorio => repositorio.Update(serraCircular)).Throws(new Exception());

            var resulte = _atulaizarSerraCircularUseCase.Executar(request);
            response.Should().BeEquivalentTo(resulte);
        }
    }
}
