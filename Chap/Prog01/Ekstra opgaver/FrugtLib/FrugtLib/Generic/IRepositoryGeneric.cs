using FrugtLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Generic
{
    public interface IRepositoryGeneric<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T t);
        T Delete(int id);
        T Update(int id, T t);
    }
}
