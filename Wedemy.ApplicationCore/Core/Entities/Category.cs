using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedemy.Application.Core.Common.Base;

namespace Wedemy.Application.Core.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; } = null!;



        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
