using FrugtLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Generic
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T: IModel
    {

        private List<T> _items = new List<T>();

        public List<T> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public T Add(T t)
        {
            _items.Add(t);
            return t;
        }

        public T Delete(int id)
        {
            T t = _items.Find(t => t.Id == id);

            if (t != null)
            {
                _items.Remove(t);
            }
            return t;
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            T t = _items.FirstOrDefault(t => t.Id == id);

            if (t != null)
            {
                return t;
            }
            else
            {
                // Opdaget en fejl
                throw new KeyNotFoundException($"Item {id} findes ikke");
            }
        }

        public T Update(int id, T t)
        {
            if (id != t.Id)
            {
                throw new ArgumentException($"Kan ikke updatere et id {id} med et andet {t.Id}");
            }
            T updateItem = GetById(id);
            int ix = _items.IndexOf(updateItem);
            _items[ix] = t;

            return t;
        }

        public override string ToString()
        {
            String _tekst = "";
            foreach (T t in Items)
            {
                _tekst += $"{t} \n\t";
            }
            return $"Items in register: {_tekst}";
        }
    }
}
