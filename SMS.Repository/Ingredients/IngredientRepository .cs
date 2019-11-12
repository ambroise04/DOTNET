using Repository;
using SMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Repository.Ingredients
{
    public class IngredientRepository : IRepository<Ingredient, int>
    {
        public IngredientRepository()
        {
            lock (this)
            {
                MesIngredients = new Ingredient[15];
            }
        }

        private Ingredient[] MesIngredients;
        public void Delete(Ingredient entityToDelete)
        {
            var index = MesIngredients.ToList().IndexOf(MesIngredients.AsParallel()
                                               .Where(i => i.Id.Equals(entityToDelete.Id))
                                               .FirstOrDefault());
            MesIngredients[index] = null;
            MesIngredients = MesIngredients.Where(i => i != null).ToArray<Ingredient>();
        }

        public void Delete(int id)
        {
            var index = MesIngredients.ToList().IndexOf(MesIngredients.AsParallel()
                                               .Where(i => i.Id.Equals(id))
                                               .FirstOrDefault());
            MesIngredients[index] = null;
            MesIngredients = MesIngredients.Where(i => i != null).ToArray<Ingredient>();
        }

        public IEnumerable<Ingredient> Get()
        {
            return MesIngredients.Where(i => i != null).ToArray<Ingredient>();
        }

        public Ingredient GetByID(int id)
        {
            return MesIngredients.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Insert(Ingredient entity)
        {
            var taille = MesIngredients.Where(i => i != null).Count();
            if (taille >= 15)
            {
                throw new Exception("Le tableau est déjà plein !!!");
            }
            MesIngredients[taille] = entity;
        }

        public void Update(Ingredient entitytToUpdate)
        {
            var index = MesIngredients.ToList().IndexOf(MesIngredients.AsParallel()
                                               .Where(i => i.Id.Equals(entitytToUpdate.Id))
                                               .FirstOrDefault());
            MesIngredients[index] = entitytToUpdate;
        }
    }
}
