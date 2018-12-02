using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Entidad creada para la tabla TablaPrueba
    /// </summary>
    [Serializable]
    public class TablaPrueba
    {
        public int Codigo { get; set; }         //x_codpru
        public string Descripcion { get; set; } //x_despru
        public bool Estado { get; set; }        //x_estpru

    }
}
