using Entidades;
using RepositorioContratos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class TablaPruebaRepositorio : ITablaPruebaRepositorio
    {
        string cadenaConexion = "Data Source = Tyrion;Initial Catalog = PRUEBA01; Integrated Security = true";

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TablaPrueba> ListarPorCodigo(int codigo)
        {
            List<TablaPrueba> oLista = new List<TablaPrueba>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarTablaPrueba", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("x_codprueba",SqlDbType.Int);
                cmd.Parameters["x_codprueba"].Value = codigo;


                SqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TablaPrueba oTablaPrueba = new TablaPrueba()
                    {
                        Codigo = reader.GetInt32(reader.GetOrdinal("x_codpru")),
                        Descripcion = reader.GetString(reader.GetOrdinal("x_despru")),
                        Estado = reader.GetBoolean(reader.GetOrdinal("x_estpru"))
                    };

                    oLista.Add(oTablaPrueba);
                }
                con.Close();
            }
            return oLista;
        }


    }
}
