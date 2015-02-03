using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace BaRestourant.Types
{
    public class AdisyonDetayType
    {

        public ObjectId Id { get; set; }

        public string UrunAdi { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }

        public override string ToString()
        {
            return this.UrunAdi+"("+this.Adet+")"+" "+this.ToplamTutar;
        }

    }
}
