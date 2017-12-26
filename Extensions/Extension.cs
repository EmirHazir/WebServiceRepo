using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    //extension metodlar static olmalıdır bu metodları barındıran sınıflar da static olamlıdır
    public static class Extension
    {
        //Ben burada artık C# daki object tipinin içinde <T> tipi alan bir Changer metodu olsun diyorum
        public static T Changer<T>(this object source)
        {
            //SOURCE da DTO, <T> de İSE ENTITY KATMANINDAKI CLASSLAR GELIR


            //T tipinde bir generic objeyi newlemek istiyorum ve geriye de yine T tipinde bir object göndersin istiyorum
            T hedef = Activator.CreateInstance<T>();

            //kaynak ise gelen tipi algılarayak tipi alıyorum.
            Type kaynak = source.GetType();

            //GetProperties kaynak içindeki propertileri PropertyInfo dizisi olarak geri döndürür.
            PropertyInfo[] kaynakProps = kaynak.GetProperties();

            PropertyInfo[] hedefProps = typeof(T).GetProperties();
            //bu kaynakPropsta dönerek
            foreach (PropertyInfo item in kaynakProps)
            {
                //obje tipinde gelen valuya dolu gelen source u atıyorum
                object value = item.GetValue(source);
                PropertyInfo hp = hedefProps.FirstOrDefault(x => x.Name == item.Name);
                if (hp != null)
                {
                    hp.SetValue(hedef, value);
                }
            }
            return hedef;
            //Extension metodlarının sağlıklı çalışması için DTO ve Entity classlarındaki propertilerin tipleri ve isimleri aynı olmalıdır
        }
    }
}
