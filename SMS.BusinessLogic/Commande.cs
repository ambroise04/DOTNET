using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.BusinessLogic
{
    public class Commande
    {
        public event EventHandler MyEvent;
        public Fournisseur Fournisseur { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
    }
}
