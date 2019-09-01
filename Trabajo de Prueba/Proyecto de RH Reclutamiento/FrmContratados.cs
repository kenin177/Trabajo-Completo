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
    public partial class FrmContratados : Form
    {
        AspirantesBL _aspirantesBL;
        FacturaBL _facturaBL;
        PuestoBL _puestoBL;
        AreaBL _areaBL;
         
        public FrmContratados()
        {
            InitializeComponent();

            _aspirantesBL = new AspirantesBL();
            _facturaBL = new FacturaBL();
            _puestoBL = new PuestoBL();
            _areaBL = new AreaBL();

            listaDeAspirantesBindingSource.DataSource = _aspirantesBL.ListaDeAspirantes;
            listaDeContratadosbindingSource.DataSource = _aspirantesBL.ListaDeContratados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmContratados_Load(object sender, EventArgs e)
        {
           
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var aspirante = (Modelos.Aspirantes)listaDeAspirantesBindingSource.Current;

            _aspirantesBL.AgregarEmpContratado(aspirante);
            listaDeAspirantesBindingSource.ResetBindings(false);

        }

        private void listaDeAspirantesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaDeAspirantesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aspirantes = (Modelos.Aspirantes)listaDeAspirantesBindingSource.Current;
            _aspirantesBL.RemoverAspirante(aspirantes);

            listaDeAspirantesBindingSource.ResetBindings(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmFactura = new FrmFactura();
            
            frmFactura.cargarDatos(_facturaBL, _aspirantesBL, _puestoBL, _areaBL);
            frmFactura.Show();

        }
    }
}
