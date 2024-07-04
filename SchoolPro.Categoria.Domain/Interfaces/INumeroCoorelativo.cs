

using SchoolPro.Common.Data.Repository;

namespace SchoolPro.Modules.Domain.Interfaces
{
    public interface INumeroCoorelativo :IBaseRepository<Domain.Entities.NumeroCoorelativo,int>
    {
        List<Domain.Entities.NumeroCoorelativo> GetNumeroCoorelativoByidNumeroCoorelativo(int idNumeroCorrelativo);
    }
}
