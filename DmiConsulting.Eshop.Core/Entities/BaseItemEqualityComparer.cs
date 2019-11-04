using System;
using System.Collections.Generic;
using System.Text;

namespace DmiConsulting.Eshop.Core.Entities
{
    class BaseItemEqualityComparer : IEqualityComparer<BaseEntity>
    {
        public bool Equals(BaseEntity x, BaseEntity y) => y != null && (x != null && x.Id == y.Id);

        public int GetHashCode(BaseEntity obj) => obj.Id.GetHashCode();
    }
}
