using Aula2TrilhaDotNet.DTO.SerraCircular.RemoverSerraCircular;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2TrilhaDotNet.Teste.Builder {
    class RemoverSerraCircularRequestBuilder {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly RemoverSerraCircularRequest _removerSerraCircularRequest;

        public RemoverSerraCircularRequestBuilder() {

            _removerSerraCircularRequest = new RemoverSerraCircularRequest();
            _removerSerraCircularRequest.id = _faker.Random.Int(1,100);
        }
                
        public RemoverSerraCircularRequest Builder() {
            return _removerSerraCircularRequest;
        }
    }
}
