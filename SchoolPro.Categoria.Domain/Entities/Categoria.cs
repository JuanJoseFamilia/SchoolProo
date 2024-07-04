

using SchooolPro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPro.Modules.Domain.Entities
{
    public class Categoria :  AuditEntiry<int>
    {
        [Column("idCategoria")]
        public override int Id { get; set; }
    }
}
