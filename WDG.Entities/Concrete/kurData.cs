using WDG.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WDG.Entities.Concrete
{
    public class kurData : IEntity
    {
        [Key]
        public int kurID { get; set; }        
        public string DovizKodu { get; set; }
        public string Birim { get; set; }
        public string DovizCinsi { get; set; }
        public string DovizAlis { get; set; }
        public string DovizSatis { get; set; }
        public string EfektifAlis { get; set; }
        public string EfektifSatis { get; set; }

    }
}
