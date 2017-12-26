using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Repository;
using DTO;
using Entity.Models;


namespace WCF
{
    public class UrunlerService : ServiceBase<UrunRepository, Urunler, UrunDTO>
    {
        //Gövdeyi IUrunService den değil ServiceBase den verip içerisine Rep, Entity, DTO ları uygun biçimde veriyorum
    }
}
