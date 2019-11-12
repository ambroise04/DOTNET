using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS.BusinessLogic
{
    public class Fournisseur
    {
        public Fournisseur()
        {
            Sandwiches = new List<Sandwich>();
        }

        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public Langue LanguageChoice { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
        public List<Pain> Pains { get; set; }

        public string ToString(Langue langue)
        {
            var sand = string.Join("\n", Sandwiches.Select(x =>  x.ToString(langue)));
            return sand;
        }
    }
}