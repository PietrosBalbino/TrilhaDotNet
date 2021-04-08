using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Aula2TrilhaDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Bordas.Adapter {
    public interface IAdicionarSerraCircularAdapter {
        public SerraCircular converterRequesteParaSerraCircular(AdicionarSerraCircularRequest request);
    }
}
