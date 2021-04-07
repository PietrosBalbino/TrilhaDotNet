using Aula2TrilhaDotNet.Context;
using Aula2TrilhaDotNet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Services {
    public class SerraCircularService : ISerraCircularService {


        private readonly LocalDbContext _local;

        public SerraCircularService(LocalDbContext local) {
            _local = local;
        }

        public bool AdicionarSerraCircular(SerraCircular serraCircular) {
            _local.serra_circular.Add(serraCircular);//nome do local, da tabela e do objeto
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarSerraCircular(SerraCircular novaSerraCircular) {
            _local.serra_circular.Attach(novaSerraCircular);
            _local.Entry(novaSerraCircular).State = EntityState.Modified;
            _local.SaveChanges();
            return true; ;
        }

        public bool DeletarSerraCircular(int id) {
            var objApagar = _local.serra_circular.Where(d => d.id == id).FirstOrDefault();///recuperando e passando para variável 
            _local.serra_circular.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<SerraCircular> RetonarListaSerraCircular() {
            return _local.serra_circular.ToList();
        }

        public SerraCircular RetornarSerraCircularPorId(int id) {
            return _local.serra_circular.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
