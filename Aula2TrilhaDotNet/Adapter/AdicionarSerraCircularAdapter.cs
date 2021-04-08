using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Aula2TrilhaDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Adapter {
    public class AdicionarSerraCircularAdapter : IAdicionarSerraCircularAdapter {
        public SerraCircular converterRequesteParaSerraCircular(AdicionarSerraCircularRequest request) {

            var novaSerraCircular = new SerraCircular();

            novaSerraCircular.nome = request.nome;
            novaSerraCircular.preco = request.preco;
            novaSerraCircular.rotacao = request.rotacao;
            novaSerraCircular.consumo = request.consumo;
            novaSerraCircular.descricao = request.descricao;
            novaSerraCircular.tamanho_disco = request.tamanho_disco;

            return novaSerraCircular;            
        }
    }
}
