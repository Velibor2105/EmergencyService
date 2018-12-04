using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    interface IEntity<T>
    {
        T Id { get; set; }
    }
}
