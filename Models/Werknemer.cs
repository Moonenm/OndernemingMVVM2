using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.Models
{
    public class Werknemer
    {
        public int Id { get; set; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string Functie { get; set; }

        public DateTime Geboortedatum { get; set; } = DateTime.Now;

        public DateTime InDienst { get; set; } = new DateTime(1990, 1, 1);

        public string Avatar { get; set; }

        public string VolledigeNaam => $"{Voornaam} {Achternaam}";

    }
}
