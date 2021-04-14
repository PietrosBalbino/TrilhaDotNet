using Aula2TrilhaDotNet.DTO.SerraCircular.RotrnanarSerraCircularId;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2TrilhaDotNet.Teste.Builder {
    class RetornarSerraCircularIdRequestBuilder {

        private readonly Faker _faker = new Faker("pt_BR");
        private readonly RetornarSerraCircularIdRequest _retornarSerraCircularIdRequest;

        public RetornarSerraCircularIdRequestBuilder() {

            _retornarSerraCircularIdRequest = new RetornarSerraCircularIdRequest();
            _retornarSerraCircularIdRequest.id = _faker.Random.Int(1, 100);
        }
        public RetornarSerraCircularIdRequest Builder() {
            return _retornarSerraCircularIdRequest;
        }

    }
}
