using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UrunRepository : RepositoryBase<Urunler>
    {
        // Artık bu class RepositoryBase<Urunler> içindeki metodları verdiğimiz Urunler class ına göre işleyip çalıştıracak.

        // Ben burada ürünler ile ilgili başka bir filtreleme de kullanabilirim aynı zamanda!

        //RepositoryBase Clasının asıl amacı temel Crud işlemlerinin tek bir yerden yönetilmesi

    }
}
