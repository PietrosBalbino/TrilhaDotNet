using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2TrilhaDotNet.Teste.Builder {
    public class AdicionarSerraCircularRequestBuilder {

        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarSerraCircularRequest _adicionarSerraCircular;

        public AdicionarSerraCircularRequestBuilder() {

            _adicionarSerraCircular = new AdicionarSerraCircularRequest();
            _adicionarSerraCircular.nome = _faker.Random.String(10);
            _adicionarSerraCircular.descricao = _faker.Random.String(10);
        }

        public AdicionarSerraCircularRequestBuilder withNameLength(int tamanho) {
            _adicionarSerraCircular.nome = _faker.Random.String(tamanho);
            return this;
        }

        public AdicionarSerraCircularRequest Build() {
            return _adicionarSerraCircular;
        }
    }
}
