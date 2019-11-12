using Repository;
using SMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Repository.Sandwhich
{
    public class SandwichFakeRepository : IRepository<Sandwich, int>
    {
        private List<Sandwich> MaListe { get; set; }

        public SandwichFakeRepository()
        {
            MaListe = new List<Sandwich>();
        }

        public void Delete(Sandwich entityToDelete)
        {
            MaListe.Remove(entityToDelete);
        }

        public void Delete(int id)
        {
            MaListe.Remove(MaListe.Where(s => s.Name.Equals(id)).FirstOrDefault());
        }

        public IEnumerable<Sandwich> Get()
        {
            return MaListe;
        }

        public Sandwich GetByID(int id)
        {
           return MaListe.Where(s => s.Name.Equals(id)).FirstOrDefault();
        }

        public void Insert(Sandwich entity)
        {
            MaListe.Add(entity);
        }

        public void Update(Sandwich entitytToUpdate)
        {
            MaListe.Remove(MaListe.FirstOrDefault(s => s.Id.Equals(entitytToUpdate.Id)));
        }
    }
}
