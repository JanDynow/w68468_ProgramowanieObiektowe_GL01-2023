using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interface
{
    interface IPersonRepository: IBaseRepository<IBookRepository, int>
    {
    }
}
