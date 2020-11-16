using WDG.Core.Business;
using WDG.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace WDG.Business.Abstract
{
    public interface IkurDataServices: IGenericServices<kurData>
    {
        void webVeriYukle();
    }
}
