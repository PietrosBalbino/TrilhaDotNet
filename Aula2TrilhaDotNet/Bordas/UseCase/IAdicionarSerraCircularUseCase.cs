using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public interface IAdicionarSerraCircularUseCase {

        AdicionarSerraCircularResponse Executar(AdicionarSerraCircularRequest request);
    }


}
