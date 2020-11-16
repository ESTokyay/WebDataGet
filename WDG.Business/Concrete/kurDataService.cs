using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using WDG.Business.Abstract;
using WDG.DataAccess.Abstract;
using WDG.Entities.Concrete;

namespace WDG.Business.Concrete
{
    public class kurDataService : IkurDataServices
    {
        private readonly IkurDataDal _kurDataDal;
        public kurDataService(IkurDataDal kurDataDal)
        {
            _kurDataDal = kurDataDal;
        }
        public void Add(kurData entity)
        {
            _kurDataDal.Add(entity);
        }

        public void Delete(kurData entity)
        {
            _kurDataDal.Delete(entity);
        }

        public kurData Get(Expression<Func<kurData, bool>> filter = null)
        {
            return _kurDataDal.Get(filter);
        }

        public List<kurData> GetList(Expression<Func<kurData, bool>> filter = null)
        {
            return _kurDataDal.GetList(filter);
        }

        public void Update(kurData entity)
        {
            _kurDataDal.Update(entity);
        }

        public void webVeriYukle()
        {
            string kur = new string("https://www.tcmb.gov.tr/kurlar/today.xml");
            var xmldoc = new XmlDocument();
            xmldoc.Load(kur);

            

            XmlNodeList getValue = xmldoc.SelectNodes("/Tarih_Date/Currency");
                                       
                foreach (XmlNode node in getValue)
                {
                    string dovizKodu = node.Attributes.GetNamedItem("Kod").Value+"/TRY";
                    string birim = node["Unit"].InnerText;
                    string dovizCinsi = node["Isim"].InnerText;
                    string dovizAlis = node["ForexBuying"].InnerText;
                    string dovizSatis = node["ForexSelling"].InnerText;
                    string efektifAlis = node["BanknoteBuying"].InnerText;
                    string efektifSatis = node["BanknoteSelling"].InnerText;

                    _kurDataDal.Add(new kurData
                    {
                        DovizKodu=dovizKodu,
                        Birim = birim,
                        DovizAlis = dovizAlis,
                        DovizCinsi = dovizCinsi,
                        EfektifAlis = efektifAlis,
                        EfektifSatis = efektifSatis,
                        DovizSatis = dovizSatis
                    });
                }
            
        }
    }
}
