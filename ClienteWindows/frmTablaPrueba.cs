using Dominio;
using DominioContratos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class frmTablaPrueba : Form
    {
        List<TablaPrueba> oListaTablaPrueba = null;
        ITablaPruebaDominio oTablaPruebaDominio = null;


        public frmTablaPrueba()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmTablaPrueba_Load(object sender, EventArgs e)
        {
            ObtenerListaTablaPrueba();
        }

        private bool ObtenerListaTablaPrueba()
        {
            using (oTablaPruebaDominio = new TablaPruebaDominio())
            {
                oListaTablaPrueba = oTablaPruebaDominio.ListarPorCodigo(0).ToList();
            }

            if (oListaTablaPrueba.Count == 0)
            {
                MessageBox.Show("No se encontraron registros",, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void MostrarGrilla()
        {
            MostrarGrilla();
            dgvDatos.DataSource = null;
            ColumnaCodigo.DataPropertyName = "Codigo";
            ColumnaDescripcion.DataPropertyName = "Descripcion";
            ColumnaEstado.DataPropertyName = "Estado";
            dgvDatos.DataSource = oListaTablaPrueba;

            dgvDatos.Refresh();
        }
    }
}
