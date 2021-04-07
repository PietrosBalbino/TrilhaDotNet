using Aula2TrilhaDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Services {
    public interface ISerraCircularService {

        bool AdicionarSerraCircular(SerraCircular serraCircular);
        List<SerraCircular> RetonarListaSerraCircular();
        SerraCircular RetornarSerraCircularPorId(int id);
        bool AtualizarSerraCircular (SerraCircular novaSerraCircular);
        bool DeletarSerraCircular(int id);
    }
}
