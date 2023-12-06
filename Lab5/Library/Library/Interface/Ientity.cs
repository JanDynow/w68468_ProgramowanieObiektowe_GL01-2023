using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interface
{
    interface IEntity<T>
    {
        T Id { get; set; }
    }
}
