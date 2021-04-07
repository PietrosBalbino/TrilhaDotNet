using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Entities {
    public class SerraCircular {

        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int rotacao { get; set; }
        public int tamanho_disco { get; set; }
        public double consumo { get; set; }
        public double preco { get; set; }

    }
}
