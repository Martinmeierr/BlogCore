using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable       
    {
        ICategoriaRepositoy Categoria { get; }

        void Save();
    }
}
