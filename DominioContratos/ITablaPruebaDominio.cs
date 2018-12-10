using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioContratos
{
    public interface ITablaPruebaDominio : IDisposable
    {
        IEnumerable<TablaPrueba> ListarPorCodigo(int codigo);
    }
}
