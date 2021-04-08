using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular {
    public class AdicionarSerraCircularRequest {

        public string nome { get; set; }
        public string descricao { get; set; }
        public int rotacao { get; set; }
        public int tamanho_disco { get; set; }
        public double consumo { get; set; }
        public double preco { get; set; }

    }
}
