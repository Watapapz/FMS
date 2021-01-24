using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FMS.Core.Currencies
{
    [Table("AppCurrencies")]
    public class Currency : FullAuditedEntity<int>, IMustHaveTenant
    {

        public const int MaxLengthSymbol = 4;
        public const int MaxLengthName = 128;

        [Required]
        [MaxLength(MaxLengthSymbol)]
        public string Symbol { get; set; }

        [Required]
        [MaxLength(MaxLengthName)]
        public string Name { get; set; }

        public int TenantId { get; set; }
    }
}
