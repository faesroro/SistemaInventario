using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Especificaciones
{
    public class PagedList<T> : List<T>
    {
        public MetaData MetaData { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize) // Por ejemplo 1.5 lo transforma a 2
            };
            AddRange(items); // Agrega los elementos de la coleccion al final de la lista
            
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> entidad, int pageNumber, int pageSize) 
        {
            var count = entidad.Count();
            var item = entidad.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(item, count, pageNumber, pageSize);
        }
    }
}
