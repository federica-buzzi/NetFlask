using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFlask.DAL.Repositories;
using NetFlask.Entities;

namespace NetFlask.Repositories
{
    public class MovieRepository : BaseRepository<MovieEntity>, IConcreteRepository<MovieEntity>
    {

        public MovieRepository(string connectionString): base (connectionString)
        {

        }

        public bool Delete(MovieEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MovieEntity> Get()
        {
            string requete = "Select * from V_Rating";
            return base.Get(requete); 
        }

        public MovieEntity GetOne(int PK)
        {
            string requete = "Select * from V_Rating WHERE IdMovie = @id";
            return base.GetOne(PK, requete);
        }

        public bool Insert(MovieEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(MovieEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
