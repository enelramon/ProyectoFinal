using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Proyecto_Final.Entidades;
using Proyecto_Final.DAL;

namespace Proyecto_Final.BLL
{
    public class GenericBLL
    {
        public static bool Guardar<T>(T entidad) where T : class
        {
            bool flag = false;
            try
            {
                ContextoGenerico<T> db = new ContextoGenerico<T>();

                db.Entidad.Add(entidad);
                if (entidad.GetType() == typeof(Facturas))
                {
                    foreach (FacturaDetalles detalle in (entidad as Facturas).Detalles)
                    {
                        CambiarEstado(detalle);
                        db.Detalle.Add(detalle);
                    }
                }
            
                db.SaveChanges();
                db.Dispose();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        private static void CambiarEstado(FacturaDetalles detalle)
        {
            Paquetes p = Buscar<Paquetes>(detalle.PaqueteId);
            p.Estado = "Facturado";
            Modificar<Paquetes>(p);
        }

        public static bool Modificar<T>(T entidad) where T : class
        {
            bool flag = false;
            try
            {
                ContextoGenerico<T> db = new ContextoGenerico<T>();

                db.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
                if (entidad.GetType() == typeof(Facturas))
                {
                    foreach (FacturaDetalles detalle in (entidad as Facturas).Detalles)
                        db.Entry(detalle).State = System.Data.Entity.EntityState.Modified;
                }
                    
                db.SaveChanges();
                db.Dispose();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        public static bool Eliminar<T>(int id) where T : class
        {
            bool flag = false;
            T entidad = null;
            try
            {
                ContextoGenerico<T> db = new ContextoGenerico<T>();
                entidad = db.Entidad.Find(id);

                if (entidad is Facturas)
                    db.Detalle.RemoveRange(db.Detalle.Where(x => x.FacturaId == id));
                
                db.Entidad.Remove(entidad);
                db.SaveChanges();
                db.Dispose();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        public static T Buscar<T>(int id) where T : class
        {
            T entidad = null;
            try
            {
                ContextoGenerico<T> db = new ContextoGenerico<T>();
                entidad = db.Entidad.Find(id);
                if (entidad != null)
                {
                    if (entidad.GetType() == typeof(Facturas))
                        (entidad as Facturas).Detalles = db.Detalle.Where(x => x.FacturaId == id).ToList();
                }
                
                //db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entidad;
        }

        public static List<T> GetList<T>(Expression<Func<T, bool>> filter) where T : class
        {
            List<T> list = null;

            try
            {
                ContextoGenerico<T> db = new ContextoGenerico<T>();
                list = db.Entidad.Where(filter).ToList();
                //db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
