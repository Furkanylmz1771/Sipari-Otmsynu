using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PıızaOtosn
{
    public class Siparis
    {

        public Pizza Pizza { get; set; }
        public int Adet { get; set; }

        public override string ToString()
        {
            string spr = "";
            spr += Pizza.Ebati.Adı + ",";   // Pizza içersinde ebat var mı
            spr += Pizza.Adı + ",";
            spr += Pizza.KenarTip.Adı + ",";

            foreach (string mlz in Pizza.Malzemeler)
            {
                spr += string.Format("{0},", mlz);      // Malzeme adı ,
            }

            spr = spr.Remove(spr.Length - 1, 1);      // Son elemandan bir geri git bir tane kadlır.  Sondaki , kaldırılır,

            spr += string.Format("{0}, x {1} = { 2}" , Adet,Pizza.Tutar, Adet);     // {Adet} x {Pizza.Tutar}
            return spr;
        }
    }
}
