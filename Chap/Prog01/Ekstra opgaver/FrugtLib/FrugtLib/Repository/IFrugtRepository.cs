using FrugtLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Repository
{
    public interface IFrugtRepository
    {
        List<Frugt> GetAll();
        Frugt GetById(int id);
        Frugt Add(Frugt frugt);
        Frugt Delete(int id);
        Frugt Update(int id, Frugt frugt);

        //Man kan ikke lave objekter
        //Man kan ikke have instantsfelter
        //Man kan ikke kode en metode tostring, da den ikke kan have en krop
        //Man kan godt have konstanter
    }
}
