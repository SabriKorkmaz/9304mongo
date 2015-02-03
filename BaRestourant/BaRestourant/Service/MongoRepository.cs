using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using BaRestourant.Models;
using MongoDB.Driver.GridFS;
using MongoDB.Bson;

namespace BaRestourant.Service
{
    public class MongoRepository<T> where T : ModelBase
    {
        private MongoClient _client;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection _collection;
        public MongoRepository()
        {

            _client = new MongoClient();
            _server = _client.GetServer();
            _database = _server.GetDatabase("restaurantdb");
            _collection = _database.GetCollection<T>(GenericName);
        }

        private string GenericName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public T Find(ObjectId id)
        {

            var query = Query<T>.EQ(x => x.Id, id);
            return _collection.AsQueryable<T>().FirstOrDefault(x => x.Id == id);
        }

        public T FirstOrDefault(Expression<Func<T,bool>> filter)
        {
            return _collection.AsQueryable<T>().FirstOrDefault(filter);
        }

        public void Insert(T entity)
        {
            _collection.Insert(entity);
        }

        public void Remove(ObjectId id)
        {
            var query = Query<T>.EQ(x => x.Id, id);
            _collection.Remove(query);
        }

        public void Update(UpdateBuilder<T> builder, ObjectId id)
        {
            var query = Query<T>.EQ(x => x.Id, id);
            _collection.Update(query, builder);
        }

        public List<T> Get()
        {
            return _collection.AsQueryable<T>().ToList();
        }
        public List<T> Get(Expression<Func<T, bool>> filter)
        {
            return _collection.AsQueryable<T>().Where(filter).ToList();
        }
        public List<Ttype>Get<Ttype>(Expression<Func<T,bool>> filter,Expression<Func<T,Ttype>> selector)
        {
            return _collection.AsQueryable<T>().Where(filter).Select(selector).ToList();
        }


        public bool Any(Expression<Func<T, bool>> filter)
        {
            return _collection.AsQueryable<T>().Any(filter);
        }
    }
}
