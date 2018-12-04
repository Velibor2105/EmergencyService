using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exstensions
{
    public static class IEntityExtensions
    {
        public static bool IsObjectNull<T>(this IEntity<T> entity)
        {
            return entity == null;
        }

        public static bool IsEmptyObject<T>(this IEntity<T> entity)
        {
            return entity.Id.Equals(Guid.Empty);
        }
    }
}
