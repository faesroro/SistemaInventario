using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepositorio(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public void Actualizar(Categoria categoria)
        {
            var CategoriaDB = _db.Categorias.FirstOrDefault(b => b.Id == categoria.Id);
            if (CategoriaDB != null) 
            {
                CategoriaDB.Nombre = categoria.Nombre;
                CategoriaDB.Descripcion = categoria.Descripcion;
                CategoriaDB.Estado = categoria.Estado;
                _db.SaveChanges();
            }
        }
    }
}
