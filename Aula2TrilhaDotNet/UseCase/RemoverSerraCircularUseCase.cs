using Aula2TrilhaDotNet.DTO.SerraCircular.RemoverSerraCircular;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class RemoverSerraCircularUseCase : IRemoverSerraCircularUseCase {

        private readonly IRepositorioSerraCircular _RepositorioSerraCircular;

        public RemoverSerraCircularUseCase(IRepositorioSerraCircular repositorioSerraCircular) {
            _RepositorioSerraCircular = repositorioSerraCircular;
        }

        public RemoverSerraCircularResponse Executar(RemoverSerraCircularRequest request) {
            var response = new RemoverSerraCircularResponse();

            try {

                _RepositorioSerraCircular.Remove(request.id);
                response.msg = "Removido com sucesso";
                return response;

            } catch {
                response.msg = "Não foi possível remover a Serra Circular";
                return response;
                //throw new System.Exception(e.Message);

            }
            
        }
    }
}
