using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace WCF
{
    [ServiceContract]
    public interface IUrunlerService : IService<UrunDTO>
    {
        //Iservice deki tüm metodlar buraya aktarıldı UrunDTO işlenecek
    }
}
