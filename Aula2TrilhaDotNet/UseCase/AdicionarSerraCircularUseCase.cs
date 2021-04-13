using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Aula2TrilhaDotNet.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.UseCase {
    public class AdicionarSerraCircularUseCase : IAdicionarSerraCircularUseCase {

        private readonly IRepositorioSerraCircular _RepositorioSerraCircular;
        private readonly IAdicionarSerraCircularAdapter _adapter;

        public AdicionarSerraCircularUseCase(IRepositorioSerraCircular repositorioSerraCircular, IAdicionarSerraCircularAdapter adapter) {

            _RepositorioSerraCircular = repositorioSerraCircular;
            _adapter = adapter;
        }

        public AdicionarSerraCircularResponse Executar(AdicionarSerraCircularRequest request) {

            var response = new AdicionarSerraCircularResponse();
            var serraCircularAdicionar = _adapter.converterRequesteParaSerraCircular(request);

            try {
                if (request.nome.Length > 20) {

                    response.msg = "Erro ao adicionar Serra Circular - Não pode ter mais de 20 caracteres ";
                    return response;

                }
       
                _RepositorioSerraCircular.Add(serraCircularAdicionar);
                response.msg = "Serra Circular adicionada com sucesso!!";
                response.id = serraCircularAdicionar.id;
                return response;

            } catch  {
                response.msg = "Erro ao adicionar a Serra Circular";
                return response;
            }

           

        }
    }
}
