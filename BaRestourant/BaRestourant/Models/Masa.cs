using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace BaRestourant.Models
{
    public class Masa : ModelBase
    {
        public string Ad { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }

        public bool MasaDolumu { get; set; }

    }
}
