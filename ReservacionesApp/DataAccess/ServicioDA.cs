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

        public bool Aplica(Servicio servicio)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    using (var transact = _context.Database.BeginTransaction())
                    {

                                                
                        _context.Motociclista.AddRange(servicio.Motociclistas);
                        _context.SaveChanges();
                        

                        //if (_servicio == null)
                        //{
                        //    servicio.Total--;
                        //    var servicioAdd = _context.Servicio.Add(servicio).Entity;
                        //    _context.SaveChanges();

                        //    //List<Motociclista> motociclistas = new List<Motociclista>() {
                        //    //    new Motociclista(){
                        //    //        FechaAlta = DateTime.Now,
                        //    //        Nombre = "Ramdom",
                        //    //        Ocupado = true,
                        //    //        ServicioId = servicioAdd.ServicioId,                                    
                        //    //    }
                        //    //};

                        //    //_context.Motociclista.AddRange(motociclistas);
                        //    //_context.SaveChanges();
                        //}
                        //else {
                        //    if (servicio.UsuarioId == _servicio.UsuarioId)
                        //    {

                        //        _context.Servicio.Remove(_servicio);
                        //        _context.SaveChanges();
                        //    }
                        //    else {
                        //        _servicio.Total--;
                        //        _context.Servicio.Update(_servicio);
                        //        _context.SaveChanges();
                        //    }
                        //    //_servicio.Total = !_servicio.Ocupado ? _servicio.Total-1 : _servicio.Total+1;
                        //    //_servicio.Ocupado = !_servicio.Ocupado;
                        //    //List<Motociclista> motociclistas = new List<Motociclista>() {
                        //    //    new Motociclista(){
                        //    //        FechaAlta = DateTime.Now,
                        //    //        Nombre = "Ramdom",
                        //    //        Ocupado = true,
                        //    //        ServicioId = _servicio.ServicioId
                        //    //    }
                        //    //};

                        //    //_context.Motociclista.AddRange(motociclistas);
                        //    //_context.SaveChanges();

                        //}

                       

                        transact.Commit();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
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

        public Servicio GetByIdentificador(Guid Identificador)
        {
            return _dbcontext.Servicio.Where(x => x.Identificador == Identificador).FirstOrDefault();
        }

        public Servicio Remove(Servicio entity)
        {
            throw new NotImplementedException();
        }
    }
}
