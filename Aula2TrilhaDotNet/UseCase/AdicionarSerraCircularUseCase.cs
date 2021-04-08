using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class AdicionarSerraCircularUseCase : IAdicionarSerraCircularUseCase {

        private IRepositorioSerraCircular _RepositorioSerraCircular;
        public AdicionarSerraCircularResponse Executar(AdicionarSerraCircularRequest request) {
            _RepositorioSerraCircular.Add(request);
        }
    }
}
