using Aula2TrilhaDotNet.DTO.SerraCircular.RetornarListaSerraCircular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public interface IRetornarListaSerraCircularUseCase {
        RetornarListaSerraCircularResponse Executar();
    }
}
