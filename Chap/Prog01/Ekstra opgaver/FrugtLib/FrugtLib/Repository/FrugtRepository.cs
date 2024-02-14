using FrugtLib.Generic;
using FrugtLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Repository
{
    public class FrugtRepository : IRepositoryGeneric<Frugt>
    {

        private List<Frugt> _frugter = new List<Frugt>();

        public List<Frugt> Frugter 
        {  
           get { return _frugter; } 
           set { _frugter = value; }
        }


        public Frugt Add(Frugt frugt)
        {
            _frugter.Add(frugt);
            return frugt;
        }

        public Frugt Delete(int id)
        {
            Frugt f = _frugter.Find( f => f.Id == id );

            if ( f != null )
            {
                _frugter.Remove( f );
            }
            return f;
        }

        public List<Frugt> GetAll()
        {
            return _frugter;
        }

        public Frugt GetById(int id)
        {
            Frugt f = _frugter.FirstOrDefault(f => f.Id == id);

            if (f != null)
            {
                return f;
            }
            else
            {
                // Opdaget en fejl
                throw new KeyNotFoundException($"Frugt {id} findes ikke");
            }

        }

        public Frugt Update(int id, Frugt frugt)
        {
            Frugt f = _frugter.FirstOrDefault(f => f.Id == id);

            if (f != null)
            {
                f.Id = frugt.Id;
                f.Name = frugt.Name;
                f.Weight = frugt.Weight;
                f.Price = frugt.Price;
            }
            return f;
        }

        public override string ToString()
        {
            String _tekst = "";
            foreach (Frugt f in Frugter)
            {
                _tekst += $"{f} \n\t";
            }
            return $"Frugter in register: {_tekst}";
        }

        //Man kan ikke lave objekter i en abstrakt klasse
        //Man kan godt lave instantsfelter i en abstrakt klasse
        //Man kan godt skrive tostring i en abtrakt klasse, men det vil ikke give mening, da du nok bare vil gøre det til en abstrakt metode
        //Man kan godt lave konstanter i en abtrakt klasse
    }
}
