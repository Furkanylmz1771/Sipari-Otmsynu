using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PıızaOtosn
{
    public class Ebat 
    {
        public Ebat(string v, object value)
        {
        }

        public string Adı { get; set; }
        public double Carpan { get; set; }

        public override string ToString()
        {
            return string.Format("{0}--{1}", Adı, Carpan);
        }
    }
}
