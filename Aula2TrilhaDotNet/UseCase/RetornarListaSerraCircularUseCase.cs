using Aula2TrilhaDotNet.DTO.SerraCircular.RetornarListaSerraCircular;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class RetornarListaSerraCircularUseCase : IRetornarListaSerraCircularUseCase {

        private readonly IRepositorioSerraCircular _RepositorioSerraCircular;

        public RetornarListaSerraCircularUseCase(IRepositorioSerraCircular repositorioSerraCircular) {
            _RepositorioSerraCircular = repositorioSerraCircular;
        }

        public RetornarListaSerraCircularResponse Executar() {

            var response = new RetornarListaSerraCircularResponse();
            try {
                response.listaSerraCircular = _RepositorioSerraCircular.Listar();
                response.msg = "Lista de Serra Circular retornada com sucesso";
                return response;

            } catch  {

                response.msg = "Não foi possível retornar a lista de Serra Circular";
                return response;
            }
           
            
           
            
        }

        
        
    }
}
