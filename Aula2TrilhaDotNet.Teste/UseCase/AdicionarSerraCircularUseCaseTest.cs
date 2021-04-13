using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
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
    public class AdicionarSerraCircularUseCaseTest { //Entidade_o que vai testar_comportamento esperado

        private readonly Mock<IRepositorioSerraCircular> _repositorioSerraCircular;
        private readonly Mock<IAdicionarSerraCircularAdapter> _adicionarSerraCircularAdapter;
        private readonly AdicionarSerraCircularUseCase _useCase;

        public AdicionarSerraCircularUseCaseTest() {

            _repositorioSerraCircular = new Mock<IRepositorioSerraCircular>();
            _adicionarSerraCircularAdapter = new Mock<IAdicionarSerraCircularAdapter>();
            _useCase = new AdicionarSerraCircularUseCase(
                _repositorioSerraCircular.Object,
                _adicionarSerraCircularAdapter.Object);
        }
        [Fact]
        public void SerraCircular_Adicionar_QuandoRetornarSucesso() {
            //Arrange
                   //criar variáveis
            //Act
                //chamar função (Geralmente Executar)
            //Assert
                //As regras dos testes que vamos utilizar]

            //Arrange
            var request = new AdicionarSerraCircularRequestBuilder().Build();
            var response = new AdicionarSerraCircularResponse();
            var serraCircular = new SerraCircular();
            serraCircular.id = 1;
            response.id = serraCircular.id;
            response.msg = "Serra Circular adicionada com sucesso!!";
            _repositorioSerraCircular.Setup(repositorio => repositorio.Add(serraCircular)).Returns(serraCircular.id);
            //_repositorioSerraCircular.Setup(repositorio => repositorio.Add(serraCircular)).Throws(new System.Exception());//caminho que da erro -- catch
            _adicionarSerraCircularAdapter.Setup(adapter => adapter.converterRequesteParaSerraCircular(request)).Returns(serraCircular);

            //Act
            var resulte = _useCase.Executar(request);

            //Assert
            response.Should().BeEquivalentTo(resulte);

        }

        [Fact]
        public void SerraCircular_Adicionar_QuandoNomeMaiorQueVinte() {

            var request = new AdicionarSerraCircularRequestBuilder().withNameLength(25).Build();
            var response = new AdicionarSerraCircularResponse();            
            response.msg = "Erro ao adicionar Serra Circular - Não pode ter mais de 20 caracteres ";
                  
            var resulte = _useCase.Executar(request);

            response.Should().BeEquivalentTo(resulte);
        }

        [Fact]
        public void SerraCircular_Adicionar_QuandoRepositorioExcecao() {
           
            var request = new AdicionarSerraCircularRequestBuilder().Build();
            var response = new AdicionarSerraCircularResponse();
            var serraCircular = new SerraCircular();
            response.id = serraCircular.id;
            response.msg = "Erro ao adicionar a Serra Circular";
            _adicionarSerraCircularAdapter.Setup(adapter => adapter.converterRequesteParaSerraCircular(request)).Returns(serraCircular);
            _repositorioSerraCircular.Setup(repositorio => repositorio.Add(serraCircular)).Throws(new Exception());
            
            var resulte = _useCase.Executar(request);

            response.Should().BeEquivalentTo(resulte);

        }

    }
}
