using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedemy.Application.Core.Common.Interfaces;
using Wedemy.Application.Core.Enums;

namespace Wedemy.Application.Core.Common.Base
{
    public abstract class BaseEntity : ICreatableEntity, IUpdatableEntity
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
