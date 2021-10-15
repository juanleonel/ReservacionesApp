using Microsoft.EntityFrameworkCore;
using ReservacionesApp.Data;
using ReservacionesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Seed
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync()
        {

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                using (var transact = context.Database.BeginTransaction())
                {
                    try
                    {
                        var _servicios = context.Servicio.ToListAsync().Result;
                        var ids = _servicios.Select(x => x.ServicioId).ToList();

                        var Motociclistas = await context.Motociclista.Where(x => ids.Contains(x.ServicioId) ).ToListAsync();

                        context.Motociclista.RemoveRange(Motociclistas);
                        await context.SaveChangesAsync();
                        
                        
                        context.Servicio.RemoveRange(_servicios);
                        await context.SaveChangesAsync();
                                               

                        DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 00, 00, DateTimeKind.Local);
                        var endTime = startTime.AddHours(12);
                        List<Servicio> servicios = new List<Servicio>();
                        while (startTime <= endTime)
                        {
                            servicios.Add(new Servicio()
                            {
                                FechaAlta = DateTime.Now,
                                Identificador = Guid.NewGuid(),                             
                                Total = 8,
                                Hora = startTime.ToString("HH:mm"),                              
                            });

                            startTime = startTime.AddMinutes(30);
                        }

                        await context.Servicio.AddRangeAsync(servicios);
                        await context.SaveChangesAsync();
                        transact.Commit();
                    }
                    catch (Exception ex)
                    {
                        transact.Rollback();
                    }

                }
            }
        }
    }
}
