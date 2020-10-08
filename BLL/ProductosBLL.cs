using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using maximo_P1_A2.Data;
using maximo_P1_A2.Models;
using Microsoft.EntityFrameworkCore;

namespace maximo_P1_A2.BLL
{
   public class ProductosBLL
    {
        
        public static bool Guardar(Productos producto)
        {
            if(!Existe(producto.id))
                return Insertar(producto);
            else
                return Modificar(producto);
        }

        private static bool Existe(int id)
        {
            bool existencia;
            Contexto contexto = new Contexto();

            try
            {
                existencia = contexto.Productos.Any(p => p.id == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return existencia;
        }

        private static bool Insertar(Productos producto)
        {
            bool guardado;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Productos.Add(producto);
                guardado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return guardado;
        }

         private static bool Modificar(Productos producto)
        {
            bool modificado;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return modificado;
        }

        public static bool Eliminar(int id)
        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            try
            {      
                var eliminar = contexto.Productos.Find(id);

                if(eliminar != null)
                {
                    contexto.Entry(eliminar).State = EntityState.Deleted;
                    eliminado = (contexto.SaveChanges() > 0);
                }
                
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return eliminado;
        }

        public static Productos Buscar(int id)
        {
            Productos producto = new Productos();
            Contexto contexto = new Contexto();

            try
            {
                producto = contexto.Productos.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos,bool>>producto)
        {
            Contexto contexto = new Contexto();
            List<Productos> Lista = new List<Productos>();

            try
            {
                Lista = contexto.Productos.Where(producto).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        
    }
}