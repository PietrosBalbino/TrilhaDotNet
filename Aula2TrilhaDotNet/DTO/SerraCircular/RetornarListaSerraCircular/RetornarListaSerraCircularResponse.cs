using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aula2TrilhaDotNet.DTO.SerraCircular.RetornarListaSerraCircular {
    public class RetornarListaSerraCircularResponse {
        public List<Aula2TrilhaDotNet.Entities.SerraCircular> listaSerraCircular { get; set; }
        public string msg { get; set; }
    }
}
