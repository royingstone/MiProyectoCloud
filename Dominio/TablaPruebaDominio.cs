using DominioContratos;
using Entidades;
using Repositorio;
using RepositorioContratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TablaPruebaDominio : ITablaPruebaDominio
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TablaPrueba> ListarPorCodigo(int codigo)
        {
            IEnumerable<TablaPrueba> oLista = null;
            using (ITablaPruebaRepositorio oRepositorio = new TablaPruebaRepositorio())
            {
                oLista = oRepositorio.ListarPorCodigo(codigo);
            }

            return oLista;
        }
    }
}
