using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    public class CrewRepository : BaseRepository<CrewEntity>, IConcreteRepository<CrewEntity>
    {
        public CrewRepository(string connectionString): base(connectionString)
        {

        }

        public bool Delete(CrewEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<CrewEntity> Get()
        {
            throw new NotImplementedException();
        }

        public CrewEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public List<CrewEntity> GetDirectors (int IdMovie)
        {
            //version avec la procedure stocké sql
            string requete = @"exec [GetDirectorFromMovie] " + IdMovie;
            return base.Get(requete); 
        }

        public bool Insert(CrewEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(CrewEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
