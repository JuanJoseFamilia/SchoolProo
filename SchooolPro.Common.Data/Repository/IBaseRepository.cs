
using System.Linq.Expressions;


namespace SchoolPro.Common.Data.Repository
{
    /// <summary>
    /// interfas base para los repositorios de datos
    /// </summary>
    /// <typeparam name="TEntity">Entidad Con la que se va a trabajar</typeparam>
    /// <typeparam name="TType">Id por la que se va a buscar</typeparam>
    public interface IBaseRepository<TEntity, TType>where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> GetAll();
        TEntity GetEntityBy(TType Id);
        bool Exists(Expression<Func<TEntity, bool>> filter);
    }
}
