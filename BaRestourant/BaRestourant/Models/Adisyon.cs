using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace BaRestourant.Models
{
    public class Adisyon : ModelBase
    {
        public ObjectId MasaId { get; set; }

        public bool Aktifmi { get; set; }

        public DateTime Tarih { get; set; }

        public decimal ToplamTutar { get; set; }


    }
}
