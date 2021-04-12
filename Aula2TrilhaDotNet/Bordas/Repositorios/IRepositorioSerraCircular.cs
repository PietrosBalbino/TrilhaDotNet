using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Aula2TrilhaDotNet.Entities;
using System.Collections.Generic;

namespace Aula2TrilhaDotNet.Repositorio {
    public interface IRepositorioSerraCircular  {
        public int Add(SerraCircular request);
        public void Remove(int id);
        public void Update(SerraCircular request);
        public List<SerraCircular> Listar();
    }
}
