using Aula2TrilhaDotNet.DTO.SerraCircular.RemoverSerraCircular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public interface IRemoverSerraCircularUseCase {
        RemoverSerraCircularResponse Executar(RemoverSerraCircularRequest request);
    }
}
