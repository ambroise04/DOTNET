using Repository;
using SMS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.BusinessLogic.UseCases.Participant
{
    public partial class Participant
    {
        IRepository<Fournisseur, int> repository;

        public Participant(IRepository<Fournisseur, int> repository)
        {
            this.repository = repository;
        }

        public List<Sandwich> AfficherMenu()
        {
            return null;
        }
    }
}
