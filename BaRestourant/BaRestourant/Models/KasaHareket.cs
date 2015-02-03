using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaRestourant.Models
{
    public class KasaHareket :ModelBase
    {

        public DateTime Time { get; set; }

        public decimal GirenPara { get; set; }

    }
}
