using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioContratos
{
    public interface ITablaPruebaRepositorio : IDisposable
    {
        IEnumerable<TablaPrueba> ListarPorCodigo(int codigo);
    }
}
