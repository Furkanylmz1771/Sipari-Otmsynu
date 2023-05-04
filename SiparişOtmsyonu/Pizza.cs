using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PıızaOtosn
{
    public class Pizza
    {
        public string Adi { get; set; } 
        public decimal Fiyat { get; set;}
        public Ebat Ebati { get; set; }

        public KenarTıp KenarTip { get; set; }

        public List<string> Malzemeler { get; set; }    // String tipte liste

        public decimal Tutar
        {
            get
            {
                decimal tutar = 0;
                tutar = Fiyat * (decimal)Ebati.Carpan;
                tutar += KenarTip.EkFiyat;
                return tutar;
            }
         
        }

        public string Adı { get; internal set; }

        public override string ToString()
        {
            return Adi;     // ToString metodunu ezer geriye Adi bilgisini döndürür.
        }
    }
}
