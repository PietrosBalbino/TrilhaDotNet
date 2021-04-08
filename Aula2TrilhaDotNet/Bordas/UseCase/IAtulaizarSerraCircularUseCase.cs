using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public interface IAtulaizarSerraCircularUseCase {

        AtualizarSerraCircularResponse Executar(AtualizarSerraCircularRequest request);
    }
}
