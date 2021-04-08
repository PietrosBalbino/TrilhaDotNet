using Aula2TrilhaDotNet.Context;
using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Repositorio {
    public class RepositorioSerraCircular : IRepositorioSerraCircular {

        private readonly LocalDbContext _local;

        public RepositorioSerraCircular(LocalDbContext local) {
            _local = local;
        }

        public void Add(AdicionarSerraCircularRequest request) {
            _local.Add(request);
            _local.SaveChanges();

        }
    }
}
