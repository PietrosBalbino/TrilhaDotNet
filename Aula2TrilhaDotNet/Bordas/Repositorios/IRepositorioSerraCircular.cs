using Aula2TrilhaDotNet.Entities;

namespace Aula2TrilhaDotNet.Repositorio {
    public interface IRepositorioSerraCircular  {
        public int Add(SerraCircular request);
        public void Remove(int id);
    }
}
