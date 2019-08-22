﻿using Proyecto_de_RH_Reclutamiento.BL;
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
    public partial class Aspirantes : Form
    {
        public Aspirantes()
        {
            InitializeComponent();

        }
        public void cargarDatos(AspirantesBL aspirantesBL, TituloBL tituloBL, AreaBL areaBL)
        {

            listaDeAspirantesBindingSource.DataSource = aspirantesBL.ListaDeAspirantes;
            listaDeTitulosBindingSource.DataSource = tituloBL.ListaDeTitulos;
            listaDeAreasBindingSource.DataSource = areaBL.ListaDeAreas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}