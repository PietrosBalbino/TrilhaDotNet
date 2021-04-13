using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class AtulaizarSerraCircularUseCase : IAtulaizarSerraCircularUseCase {

        private readonly IRepositorioSerraCircular _repositorioSerraCircular;
        private readonly IAtualizarSerraCircularAdapter _adapter;

        public AtulaizarSerraCircularUseCase(IRepositorioSerraCircular repositorioSerraCircular, 
            IAtualizarSerraCircularAdapter adapter) {
            _repositorioSerraCircular = repositorioSerraCircular;
            _adapter = adapter;
        }

        public AtualizarSerraCircularResponse Executar(AtualizarSerraCircularRequest request) {

            var response = new AtualizarSerraCircularResponse();
            var serraCircularAtualizar = _adapter.converterRequesteParaSerraCircularAtualizar(request);
            try {

                if (request.nome.Length > 20) {
                    response.msg = "Erro ao adicionar Serra Circular - Não pode ter mais de 20 caracteres ";
                    return response;
                }
               
                _repositorioSerraCircular.Update(serraCircularAtualizar);

                response.msg = $"Serra Circular ID: {request.id} atualizada!!";
                return response;

            } catch  {

                response.msg = "Erro ao atualizar a Serra Circular";
                return response;
            }
            
            
        }
    }
}
