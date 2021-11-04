using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Interfaces
{
    public interface IBase<T>
    {
        void Create(T t);
        List<T> GetAll(Predicate<T> predicate);
    }
}
