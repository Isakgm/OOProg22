using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Kunde
    {
        private int _kundeNummer;
        private string _navn;
        private string _tlf;

        public int KundeNummer
        {
            get { return _kundeNummer; }
            set { _kundeNummer = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        
        public Kunde()
        {
            _kundeNummer = 0;
            _navn = "";
            _tlf = "";
        }
        public Kunde(int nr, string navn, string tlf)
        {
            _kundeNummer = nr;
            _navn = navn;
            _tlf = tlf;
        }

       

        public override string ToString()
        {
            return $"{{{nameof(KundeNummer)}={KundeNummer}, {nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}

