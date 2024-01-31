using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class KundeListe
    {

        private List<Kunde> _liste;

        public List<Kunde> Liste
        {
            get { return _liste; }
            set { _liste = value; }
        }

        public KundeListe()
        {
            _liste = new List<Kunde>();
        }

        public void Tilføj(Kunde kunde)
        {
            _liste.Add(kunde);
        }

        public List<Kunde> HentAlleKunder() 
        { 
            return _liste; 
        }

        public List<Kunde> HentFraNavn(string navn)
        {
            List<Kunde> resultatListe = new List<Kunde>();

            for (int i = 0; i < _liste.Count; i++)
            {
                if (_liste[i].Navn == navn)
                {
                    resultatListe.Add(_liste[i]);
                }
            }

            return resultatListe;
        }

        public Kunde Slet(Kunde kunde)
        {
            if (_liste.Contains(kunde))
            {
                _liste.Remove(kunde);
                return kunde;
            }
            return null;
        }

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _liste);

            return $"{{{nameof(Liste)}={pænTekst}}}";
        }

        /*  
          Dictionary<int, Kunde> _liste;

          // properties
          public Dictionary<int, Kunde> Katalog
          {
              get { return _liste; }
              set { _liste = value; }
          }

          // konstruktør
          public KundeListe()
          {
              _liste = new Dictionary<int, Kunde>();
          }




          public Kunde Tilføj(Kunde kunde)
          {
              _liste.Add(kunde.KundeNummer, kunde);

              return kunde;
          }

          public Kunde Slet(int kundenummer)
          {
              if (_liste.ContainsKey(kundenummer))
              {
                  Kunde slettetKunde = _liste[kundenummer];
                  _liste.Remove(kundenummer);
                  return slettetKunde;

              }
              else
              {
                  return null;
              }
          }

          public Kunde HentKunde(string Navn)
          {
              if (_liste.ContainsKey(navn))
              {
                  return _liste[navn];

              }
              else
              {
                  // opdaget en fejl
                  throw new KeyNotFoundException("Navn findes ikke");



                  //return null;
              }
          }




          public override string ToString()
          {
              String pænTekst = String.Join(", ", _liste.Values);

              return $"{{{nameof(Katalog)}={pænTekst}}}";
          }*/
    }
}

