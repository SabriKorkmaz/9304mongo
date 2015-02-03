using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace BaRestourant.Models
{
    public class AdisyonDetay :ModelBase
    {

        public ObjectId UrunId { get; set; }

        public ObjectId AdisyonId { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
