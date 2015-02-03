using BaRestourant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaRestourant.Service
{
    public class MongoProvider
    {

        #region Sets

        private MongoRepository<Masa> _masa;

        private MongoRepository<Urun> _urun;

        private MongoRepository<Adisyon> _adisyon;
        private MongoRepository<AdisyonDetay> _adisyonDetay;

        private MongoRepository<KasaHareket> _kasaHaraket;


        #endregion

        #region Gets

        public MongoRepository<AdisyonDetay> AdisyonDetay
        {
            get
            {
                return _adisyonDetay ?? (_adisyonDetay = new MongoRepository<AdisyonDetay>());
            }
        }

        public MongoRepository<Masa> Masa
        {
            get
            {
                return _masa ?? (_masa = new MongoRepository<Masa>());
            }
        }

        public MongoRepository<Urun> Urun
        {
            get
            {
                return _urun ?? (_urun = new MongoRepository<Urun>());
            }
        }

        public MongoRepository<Adisyon> Adisyon
        {
            get
            {
                return _adisyon ?? (_adisyon = new MongoRepository<Adisyon>());
            }
        }

        public MongoRepository<KasaHareket> KasaHaraket
        {
            get
            {
                return _kasaHaraket??(_kasaHaraket = new MongoRepository<KasaHareket>());
            }
        }


        #endregion

    }
}
