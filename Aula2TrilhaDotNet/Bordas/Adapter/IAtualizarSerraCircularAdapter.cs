using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Aula2TrilhaDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Bordas.Adapter {
    public interface IAtualizarSerraCircularAdapter {

        public SerraCircular converterRequesteParaSerraCircularAtualizar (AtualizarSerraCircularRequest request);
    }
}
