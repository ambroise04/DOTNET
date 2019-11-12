using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Domain
{
    public class Commande
    {
        public Fournisseur Fournisseur { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
    }
}
