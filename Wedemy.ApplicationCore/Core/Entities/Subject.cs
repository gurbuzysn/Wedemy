using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedemy.Application.Core.Common.Base;

namespace Wedemy.Application.Core.Entities
{
    public class Subject : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public Guid SubCategoryId { get; set; }



        public virtual SubCategory SubCategory { get; set; } = null!;
    }
}
