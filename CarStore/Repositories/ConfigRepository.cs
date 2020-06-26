using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class ConfigRepository : IDisposable, IConfigRepository
    {

        private CarStoreContext db = new CarStoreContext();

        public Config Details(int? id)
        {
            Config config = db.Configs.Find(id);
            return config;
        }

        public IEnumerable<Config> Index(int? id)
        {
            IEnumerable<Config> result = db.Configs
                .Where(r => r.CarModelId == id);

            return result.ToList();
        }

        public string GetConfigName(int id) 
        {
            var config = Details(id);
            var configName = config.Name;
            return configName;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}