using ReservacionesApp.Data;
using ReservacionesApp.Entities;
using ReservacionesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.DataAccess
{
    public class ServicioDA : IServicio
    {
        private readonly IDbConnection _db;
        private readonly ApplicationDbContext _dbcontext;

        public ServicioDA(ApplicationDbContext dbcontext, IDbConnection db) {
            _dbcontext = dbcontext;
            _db = db;
        }
        public Servicio Add(Servicio entity)
        {
            try
            {
                _dbcontext.Servicio.Add(entity);
                _dbcontext.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }           
        }

        public Servicio Edit(Servicio entity)
        {
            try
            {
                _dbcontext.Set<Servicio>().Update(entity);
                _dbcontext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IQueryable<Servicio> GetALL()
        {
            return _dbcontext.Servicio.AsQueryable();
        }

        public Servicio GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Servicio Remove(Servicio entity)
        {
            throw new NotImplementedException();
        }
    }
}
