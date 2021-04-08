using Aula2TrilhaDotNet.DTO.SerraCircular.RotrnanarSerraCircularId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public interface IRetornarSerraCircularIdUseCase {
       RetornarSerraCircularIdResponse Executar(RetornarSerraCircularIdRequest request);
    }
}
