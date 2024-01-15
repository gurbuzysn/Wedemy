using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedemy.Application.Core.Common.Interfaces;
using Wedemy.Application.Core.Enums;

namespace Wedemy.Application.Core.Common.Base
{
    public abstract class AuditableEntity : BaseEntity, ISoftDeletableEntity
    {
        public Guid DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
