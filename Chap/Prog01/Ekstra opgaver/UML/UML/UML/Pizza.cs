using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Pizza
    {
     
            
            private int _pizzaNummer;
            private string _navn;
            private double _pris; 
            private string _beskrivelse;


          
            public int PizzaNummer
            {
                get { return _pizzaNummer; }
                set { _pizzaNummer = value; }
            }

            public string Navn
            {
                get { return _navn; }
                set { _navn = value; }
            }

            public double Pris
            {
                get { return _pris; }
                set
                {
                    if (!(value >= 0))
                    {
                        throw new ArgumentException("Pris skal være nul eller positiv men var " + value);
                    }

                    _pris = value;
                }
            }
            public string Beskrivelse
            {
                get { return _beskrivelse; }
                set { _beskrivelse = value; }
            }



            /*
             * Constructor - kaldes kun een gang - når objektet laves
             */

            public Pizza() // default
            {
                _pizzaNummer = 0;
                _navn = "";
                _pris = 0;
                _beskrivelse = "";
            }

            public Pizza(int pizzaNummer, string navn, double pris, string beskrivelse)
            {
                _pizzaNummer = pizzaNummer;
                _navn = navn;
                _pris = pris;
                _beskrivelse = beskrivelse;
            }




            /*
             * metoder
             */

            public double PrisMedMoms()
            {
                double prisMedMoms = _pris * 1.25;
                return prisMedMoms;
            }



            public override string ToString()
            {
                return $"{{{nameof(PizzaNummer)}={PizzaNummer}, {nameof(Navn)}={Navn}, {nameof(Pris)}={Pris.ToString()}, {nameof(Beskrivelse)}={Beskrivelse}}}";
            }
        }
    }

