using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interface
{
    interface Ientity<T>
    {
        T Id { get; set; }
    }
}
