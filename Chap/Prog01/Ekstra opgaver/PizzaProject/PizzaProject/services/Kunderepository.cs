using PizzaProject.model;

namespace PizzaProject.services
{
    public class Kunderepository
    {
        // instans felt
        Dictionary<int, Kunde> _katalog;

        // properties
        public Dictionary<int, Kunde> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

        // konstruktør
        public Kunderepository(bool mockData = false)
        {
            _katalog = new Dictionary<int, Kunde>();


            if (mockData)
            {
                PopualteKundeRepository();
            }
        }

        private void PopualteKundeRepository()
        {
            _katalog.Clear();

            _katalog.Add(1, new Kunde(1, "Isak", "11223344"));
            _katalog.Add(2, new Kunde(2, "Mejer", "11223355"));
            _katalog.Add(3, new Kunde(3, "Jonas", "66223344"));
            _katalog.Add(4, new Kunde(4, "Kurt", "11773344"));
            _katalog.Add(5, new Kunde(5, "Jens", "11228844"));

        }



        /*
         * metoder
         */
        public Kunde Tilføj(Kunde kunde)
        {
            _katalog.Add(kunde.KundeNummer, kunde);

            return kunde;
        }

        public Kunde Slet(int kundenummer)
        {
            if (_katalog.ContainsKey(kundenummer))
            {
                Kunde slettetKunde = _katalog[kundenummer];
                _katalog.Remove(kundenummer);
                return slettetKunde;

            }
            else
            {
                return null;
            }
        }

        public Kunde HentKunde(int kundenummer)
        {
            if (_katalog.ContainsKey(kundenummer))
            {
                return _katalog[kundenummer];

            }
            else
            {
                // opdaget en fejl
                throw new KeyNotFoundException("kundenummer findes ikke");



                //return null;
            }
        }

        public List<Kunde> HentAlleKunder()
        {
            return _katalog.Values.ToList();
        }


        public Kunde HentKundeUdFraTlf(string tlf)
        {
            Kunde resKunde = null;

            foreach (Kunde k in _katalog.Values)
            {
                if (k.Tlf == tlf)
                {
                    return k;
                }
            }

            return resKunde;
        }

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _katalog.Values);

            return $"{{{nameof(Katalog)}={pænTekst}}}";
        }
    }
}
