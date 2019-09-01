namespace Proyecto_de_RH_Reclutamiento
{
    partial class FrmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label cantAspirantesLabel;
            System.Windows.Forms.Label compañiaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            this.listadeFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeFacturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listadeFacturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.cantAspirantesTextBox = new System.Windows.Forms.TextBox();
            this.compañiaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            activoLabel = new System.Windows.Forms.Label();
            cantAspirantesLabel = new System.Windows.Forms.Label();
            compañiaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeFacturasBindingNavigator)).BeginInit();
            this.listadeFacturasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeFacturasBindingSource
            // 
            this.listadeFacturasBindingSource.DataSource = typeof(Proyecto_de_RH_Reclutamiento.Modelos.Factura);
            // 
            // listadeFacturasBindingNavigator
            // 
            this.listadeFacturasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listadeFacturasBindingNavigator.BindingSource = this.listadeFacturasBindingSource;
            this.listadeFacturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeFacturasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeFacturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listadeFacturasBindingNavigatorSaveItem});
            this.listadeFacturasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeFacturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeFacturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeFacturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeFacturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeFacturasBindingNavigator.Name = "listadeFacturasBindingNavigator";
            this.listadeFacturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeFacturasBindingNavigator.Size = new System.Drawing.Size(1091, 25);
            this.listadeFacturasBindingNavigator.TabIndex = 0;
            this.listadeFacturasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listadeFacturasBindingNavigatorSaveItem
            // 
            this.listadeFacturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeFacturasBindingNavigatorSaveItem.Enabled = false;
            this.listadeFacturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeFacturasBindingNavigatorSaveItem.Image")));
            this.listadeFacturasBindingNavigatorSaveItem.Name = "listadeFacturasBindingNavigatorSaveItem";
            this.listadeFacturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeFacturasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(26, 122);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listadeFacturasBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(116, 117);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.Text = "checkBox1";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cantAspirantesLabel
            // 
            cantAspirantesLabel.AutoSize = true;
            cantAspirantesLabel.Location = new System.Drawing.Point(773, 388);
            cantAspirantesLabel.Name = "cantAspirantesLabel";
            cantAspirantesLabel.Size = new System.Drawing.Size(84, 13);
            cantAspirantesLabel.TabIndex = 3;
            cantAspirantesLabel.Text = "Cant Aspirantes:";
            // 
            // cantAspirantesTextBox
            // 
            this.cantAspirantesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "CantAspirantes", true));
            this.cantAspirantesTextBox.Location = new System.Drawing.Point(863, 385);
            this.cantAspirantesTextBox.Name = "cantAspirantesTextBox";
            this.cantAspirantesTextBox.Size = new System.Drawing.Size(200, 20);
            this.cantAspirantesTextBox.TabIndex = 4;
            // 
            // compañiaLabel
            // 
            compañiaLabel.AutoSize = true;
            compañiaLabel.Location = new System.Drawing.Point(26, 67);
            compañiaLabel.Name = "compañiaLabel";
            compañiaLabel.Size = new System.Drawing.Size(57, 13);
            compañiaLabel.TabIndex = 5;
            compañiaLabel.Text = "Compañia:";
            // 
            // compañiaTextBox
            // 
            this.compañiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "Compañia", true));
            this.compañiaTextBox.Location = new System.Drawing.Point(116, 64);
            this.compañiaTextBox.Name = "compañiaTextBox";
            this.compañiaTextBox.Size = new System.Drawing.Size(200, 20);
            this.compañiaTextBox.TabIndex = 6;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(26, 94);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listadeFacturasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(116, 90);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(116, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(773, 414);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(53, 13);
            impuestoLabel.TabIndex = 11;
            impuestoLabel.Text = "Impuesto:";
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "Impuesto", true));
            this.impuestoTextBox.Location = new System.Drawing.Point(863, 411);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.impuestoTextBox.TabIndex = 12;
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(773, 440);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 13;
            subTotalLabel.Text = "Sub Total:";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "SubTotal", true));
            this.subTotalTextBox.Location = new System.Drawing.Point(863, 437);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subTotalTextBox.TabIndex = 14;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(773, 466);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeFacturasBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(863, 463);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 16;
            // 
            // facturaDetalleBindingSource
            // 
            this.facturaDetalleBindingSource.DataMember = "FacturaDetalle";
            this.facturaDetalleBindingSource.DataSource = this.listadeFacturasBindingSource;
            // 
            // facturaDetalleDataGridView
            // 
            this.facturaDetalleDataGridView.AutoGenerateColumns = false;
            this.facturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.facturaDetalleDataGridView.DataSource = this.facturaDetalleBindingSource;
            this.facturaDetalleDataGridView.Location = new System.Drawing.Point(12, 147);
            this.facturaDetalleDataGridView.Name = "facturaDetalleDataGridView";
            this.facturaDetalleDataGridView.Size = new System.Drawing.Size(1051, 220);
            this.facturaDetalleDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AspiranteId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AspiranteId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aspirante";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aspirante";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PuestoId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PuestoId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Puesto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantDeSal";
            this.dataGridViewTextBoxColumn7.HeaderText = "CantDeSal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Comision";
            this.dataGridViewTextBoxColumn9.HeaderText = "Comision";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn10.HeaderText = "Total";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 513);
            this.Controls.Add(this.facturaDetalleDataGridView);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(cantAspirantesLabel);
            this.Controls.Add(this.cantAspirantesTextBox);
            this.Controls.Add(compañiaLabel);
            this.Controls.Add(this.compañiaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.listadeFacturasBindingNavigator);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            ((System.ComponentModel.ISupportInitialize)(this.listadeFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeFacturasBindingNavigator)).EndInit();
            this.listadeFacturasBindingNavigator.ResumeLayout(false);
            this.listadeFacturasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeFacturasBindingSource;
        private System.Windows.Forms.BindingNavigator listadeFacturasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listadeFacturasBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox cantAspirantesTextBox;
        private System.Windows.Forms.TextBox compañiaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource facturaDetalleBindingSource;
        private System.Windows.Forms.DataGridView facturaDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}