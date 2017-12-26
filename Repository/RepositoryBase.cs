using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace Repository
{
    public class RepositoryBase<TT> : IRepository<TT> where TT : class
    {
        private static KuzeyYeliContext context;
        //Singleton Pattern : Uygulamanın tek context üzerinden veri akışını destekler
        public static KuzeyYeliContext Context
        {
            get
            {
                //context = context ?? new KuzeyYeliContext(); //turnedIF ya da 
                if (context == null) // :)
                    context = new KuzeyYeliContext();
                
                return context;
            }
            set { context = value; }
        }

        public bool Ekle(TT entity)
        {
            Context.Set<TT>().Add(entity);
            try
            {
                return Context.SaveChanges() > 0; //kaydederken bool değeri 1 yapar
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Guncelle(TT entity)
        {
            try
            {
              return  Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TT> Listele()
        {
            return Context.Set<TT>().ToList();
        }

        public bool Sil(TT entiy)
        {
            Context.Set<TT>().Remove(entiy);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
                
        }
    }
}
