﻿using CarStore.Models;
using CarStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class CarModelRepository : IDisposable, ICarModelRepository
    {

        private CarStoreContext db = new CarStoreContext();
        ICarSortService _sort;
        public CarModelRepository(ICarSortService s) 
        {
            _sort = s;
        }

        public CarModel Details(int? id)
        {
            CarModel carModel = db.CarModels.Find(id);
            return carModel;
        }

        public IEnumerable<CarModel> Index()
        {
            return _sort.Sort();
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