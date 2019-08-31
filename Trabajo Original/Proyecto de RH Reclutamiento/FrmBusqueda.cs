using Proyecto_de_RH_Reclutamiento.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_RH_Reclutamiento
{
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();

        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            
            CargarDatos();

        }

        private void CargarDatos()
        {

            var ListaDeAspirantes = new AspirantesBL();
            var empleadosactivos = ListaDeAspirantes.ObtenerEmpleadosActivos();


            dataGridView1.DataSource = empleadosactivos;          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listaDeAspirantesDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBusqueda_Load_1(object sender, EventArgs e)
        {

        }
    }
}
