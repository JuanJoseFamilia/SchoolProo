


using SchoolPro.Common.Data.Repository;


namespace SchoolPro.Modules.Domain.Interfaces
{
    public interface ICategoriaRepository :IBaseRepository<Domain.Entities.Categoria,int> 
    {
        List<Domain.Entities.Categoria> GetCategoriaByidCategoria(int idCategoria);
    }
}
