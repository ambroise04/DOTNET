using Repository;
using SMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Repository.Fournisseurs
{
    public class FournisseurFakeRepository : IRepository<Fournisseur, int>
    {
        List<Fournisseur> LesFournisseurs;
        public FournisseurFakeRepository()
        {
            LesFournisseurs = new List<Fournisseur>();
        }

        public void Delete(Fournisseur entityToDelete)
        {
            LesFournisseurs.Remove(LesFournisseurs.FirstOrDefault(f => f.Id.Equals(entityToDelete.Id)));
        }

        public void Delete(int id)
        {
            LesFournisseurs.Remove(LesFournisseurs.FirstOrDefault(f => f.Id.Equals(id)));
        }

        public IEnumerable<Fournisseur> Get()
        {
            return LesFournisseurs;
        }

        public Fournisseur GetByID(int id)
        {
            return LesFournisseurs.FirstOrDefault(f => f.Id.Equals(id));
        }

        public void Insert(Fournisseur entity)
        {
            LesFournisseurs.Add(entity);
        }

        public void Update(Fournisseur entitytToUpdate)
        {
            var frs = LesFournisseurs.FirstOrDefault(f => f.Id.Equals(entitytToUpdate.Id));
            frs = entitytToUpdate;
        }
    }
}
