using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> Listele();
        bool Ekle(T entity);
        bool Guncelle(T entity);
        bool Sil(T entiy);
    }
}
