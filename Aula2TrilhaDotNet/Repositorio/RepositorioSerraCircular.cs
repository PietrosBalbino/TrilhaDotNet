﻿using Aula2TrilhaDotNet.Context;
using Aula2TrilhaDotNet.Entities;
using System.Linq;

namespace Aula2TrilhaDotNet.Repositorio {
    public class RepositorioSerraCircular : IRepositorioSerraCircular {

        private readonly LocalDbContext _local;

        public RepositorioSerraCircular(LocalDbContext local) {
            _local = local;
        }

        public int Add(SerraCircular request) {
            _local.Add(request);
            _local.SaveChanges();
            return request.id;

        }

        public void Remove(int id) {
            var obj = _local.serra_circular.Where(d => d.id == id).FirstOrDefault();
            if (obj == null) {
                throw new System.Exception("A serra circular nao existe");
            }
            _local.serra_circular.Remove(obj);
            _local.SaveChanges();
        }
    }
}