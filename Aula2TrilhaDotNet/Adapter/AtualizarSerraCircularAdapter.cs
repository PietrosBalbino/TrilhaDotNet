using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Aula2TrilhaDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Adapter {
    public class AtualizarSerraCircularAdapter : IAtualizarSerraCircularAdapter {
        public SerraCircular converterRequesteParaSerraCircularAtualizar(AtualizarSerraCircularRequest request) {
            var atualizaSerraCircular = new SerraCircular();
            atualizaSerraCircular.id = request.id;
            atualizaSerraCircular.nome = request.nome;
            atualizaSerraCircular.preco = request.preco;
            atualizaSerraCircular.rotacao = request.rotacao;
            atualizaSerraCircular.consumo = request.consumo;
            atualizaSerraCircular.descricao = request.descricao;
            atualizaSerraCircular.tamanho_disco = request.tamanho_disco;

            return atualizaSerraCircular;
        }
    }
}
