using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO : class
    {
        [OperationContract]
        List<DTO> Listele();
        [OperationContract]
        bool Ekle(DTO dto);
        [OperationContract]
        bool Guncelle(DTO dto);
        [OperationContract]
        bool Sil(DTO dto);
    }
}
