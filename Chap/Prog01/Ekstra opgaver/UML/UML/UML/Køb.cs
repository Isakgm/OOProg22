using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Køb
    {
        
        private Pizza _pizza;
        private Kunde _kunde;
        

      
        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }

       


        public Køb()
        {
            _pizza = null;
            _kunde = null;

        }

        public Køb(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }
        /*
        public double CalculateTotalPrice()
        {
            var totalPrice = 0;
            foreach (var pizza in pizzaListe)
            {
                totalPrice += pizza.Pris;
            }
            return totalPrice;
        }
        */


        public override string ToString()
        {
            return $"{{{nameof(Pizza)}={Pizza}, {nameof(Kunde)}={Kunde}}}";
        }
    }
}

