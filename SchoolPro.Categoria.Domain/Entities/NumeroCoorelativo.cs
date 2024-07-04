﻿using SchooolPro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPro.Modules.Domain.Entities
{
    public class NumeroCoorelativo : AuditEntiry<int>
    {
        [Column("idNumeroCorrelativo")]
        public override int Id { get; set; }
    }
}
