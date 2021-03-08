using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Scala.ClassesPart2.Core
{
    public class PersoonService
    {
        public List<Persoon> Personen { get; private set; }
        public PersoonService()
        {
            Personen = new List<Persoon>();
            DoSeeding();

        }
        private void DoSeeding()
        {
            try
            {
                Personen.Add(new Persoon("Janssens", "Wim", new DateTime(1995, 12, 24), true));
                Personen.Add(new Persoon("Willems", "Jan", new DateTime(1985, 5, 1), true));
                Personen.Add(new Persoon("Pieters", "Mia", new DateTime(1999, 12, 3), false));
                Personen.Add(new Persoon("Abeels", "Wilma", new DateTime(2003, 7, 23), false));
                Personen.Add(new Persoon("Taer", "Guy", new DateTime(1990, 1, 1), true));
            }
            catch
            { }
        }
        public void OrderList()
        {
            Personen = Personen.OrderBy(o => o.Naam).ThenBy(o => o.Voornaam).ToList();
        }
        public void VoegPersoonToe(Persoon persoon)
        {
            Personen.Add(persoon);
            OrderList();
        }
        public void VerwijderPersoon(Persoon persoon)
        {
            Personen.Remove(persoon);
            OrderList();
        }
    }
}
