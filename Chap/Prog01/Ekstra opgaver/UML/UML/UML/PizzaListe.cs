using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UML.Pizza;

namespace UML
{
    public class PizzaListe
    {
       

        Dictionary<int, Pizza> _liste;

        public Dictionary<int, Pizza> Liste 
        { 
            get {  return _liste; } 
            set { _liste = value; }
        }

        public PizzaListe()
        {
            _liste = new Dictionary<int, Pizza>();
        }

        public Pizza Tilføj(Pizza pizza)
        {
            _liste.Add(pizza.PizzaNummer, pizza);

            return pizza;
        }

        public Pizza Slet(int pizzaNummer)
        {
            if (_liste.ContainsKey(pizzaNummer))
            {
                Pizza slettetPizza = _liste[pizzaNummer];
                _liste.Remove(pizzaNummer);
                return slettetPizza;
            }
            else
            {
                return null;
            }
        }

        public Pizza HentPizzaUdFraNummer(int pizzaNummer)
        {
            Pizza resPizza = null;

            foreach (Pizza p in _liste.Values)
            {
                if (p.PizzaNummer == pizzaNummer)
                {
                    return p;
                }
            }
            
            return resPizza;
        }

      

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _liste.Values);

            return $"{{{nameof(Liste)}={pænTekst}}}";
        }

      
    }
}

