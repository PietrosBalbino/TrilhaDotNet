using Aula2TrilhaDotNet.DTO.SerraCircular.RotrnanarSerraCircularId;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class RetornarSerraCircularIdUseCase : IRetornarSerraCircularIdUseCase {

        private readonly IRepositorioSerraCircular _repositorioSerraCircular;
        
        public RetornarSerraCircularIdUseCase(IRepositorioSerraCircular repositorioSerraCircular) {
            _repositorioSerraCircular = repositorioSerraCircular;            
        }
        public RetornarSerraCircularIdResponse Executar(RetornarSerraCircularIdRequest request) {

            var response = new RetornarSerraCircularIdResponse();
            try {
                response.serra_circular_response = _repositorioSerraCircular.Read(request.id);

                if (response.serra_circular_response == null) {
                    response.msg = "Erro ao retornar Serra Circular";
                    return response;
                }
               
                response.msg = "Serra Circular retornada com sucesso!";
                return response;               

            } catch {
                response.msg = "Erro ao retornar Serra Circular";
                return response;
            }            
            
        }
    }
}
