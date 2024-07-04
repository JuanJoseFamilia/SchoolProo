

using SchoolPro.Modules.Domain.Entities;
using SchoolPro.Modules.Domain.Interfaces;
using System.Linq.Expressions;

namespace Schoolpro.Modules.Persistence.Repositories
{
    public class CategoriaRepositorie : ICategoriaRepository
    {
        public void Delete(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Categoria, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetCategoriaByidCategoria(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public Categoria GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
