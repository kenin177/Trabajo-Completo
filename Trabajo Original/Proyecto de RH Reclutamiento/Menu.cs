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
    public partial class FrmMenu : Form
    {
        AspirantesBL _aspirantesBL;
        TituloBL _tituloBL;
        AreaBL _areaBL;
        PuestoBL _puestoBL;
        NivelInglesBL _nivelInglesBL;

        public FrmMenu()
        {
            InitializeComponent();
            _aspirantesBL = new AspirantesBL();
            _tituloBL = new TituloBL();
            _areaBL = new AreaBL();
            _puestoBL = new PuestoBL();
            _nivelInglesBL = new NivelInglesBL();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rrporteDeAspirantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formArea = new Area();
            formArea.MdiParent = this;

            formArea.cargarDatos(_areaBL);
            formArea.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPuesto = new Puesto();
            formPuesto.MdiParent = this;

            formPuesto.cargarDatos(_puestoBL);
            formPuesto.Show();

        }

        private void aspiranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAspirante = new Aspirantes();
            formAspirante.MdiParent = this;

            formAspirante.cargarDatos(_aspirantesBL, _tituloBL, _areaBL, _nivelInglesBL);
            formAspirante.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu.ActiveForm.Close();
        }

        private void acercaDeRecursosHumanosReclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAyuda frm = new FrmAyuda();
            frm.Show();
        }

        private void proximamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
