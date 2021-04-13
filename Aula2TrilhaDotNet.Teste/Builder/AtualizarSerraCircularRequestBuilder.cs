using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2TrilhaDotNet.Teste.Builder {
    class AtualizarSerraCircularRequestBuilder {

        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarSerraCircularRequest _atualizarSerraCircularRequest;

        public AtualizarSerraCircularRequestBuilder() {
            
            _atualizarSerraCircularRequest = new AtualizarSerraCircularRequest();
            _atualizarSerraCircularRequest.nome = _faker.Random.String(10);
        }

        public AtualizarSerraCircularRequestBuilder NameLength( int tamanho) {
            _atualizarSerraCircularRequest.nome = _faker.Random.String(tamanho);
            return this;
        }

        public AtualizarSerraCircularRequest Builder() {
            return _atualizarSerraCircularRequest;
        }
    }
}
