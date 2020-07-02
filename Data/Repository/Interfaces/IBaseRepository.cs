using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        IList<T> Listar(); 
    }
}
