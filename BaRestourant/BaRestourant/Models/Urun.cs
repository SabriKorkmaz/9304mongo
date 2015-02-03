using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaRestourant.Models
{
    public class Urun : ModelBase
    {

        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return this.Ad;
        }

    }
}
