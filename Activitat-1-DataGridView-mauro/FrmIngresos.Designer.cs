namespace Activitat_1_DataGridView_mauro
{
    partial class FrmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pantallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbIngresos = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.lblAlta = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAGREGAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripBORRAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripEDITAR = new System.Windows.Forms.ToolStripButton();
            this.checkBoxAlta = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbIngresos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(156, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(597, 74);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Ingresos de Pacientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1627, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pantallasToolStripMenuItem
            // 
            this.pantallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.pantallasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallasToolStripMenuItem.Name = "pantallasToolStripMenuItem";
            this.pantallasToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.pantallasToolStripMenuItem.Text = "Pantallas";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.menuToolStripMenuItem.Text = "Volver a Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 68;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 629);
            this.dataGridView1.TabIndex = 7;
            // 
            // gbIngresos
            // 
            this.gbIngresos.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbIngresos.Controls.Add(this.checkBoxAlta);
            this.gbIngresos.Controls.Add(this.btnEditar);
            this.gbIngresos.Controls.Add(this.btnBorrar);
            this.gbIngresos.Controls.Add(this.btnAgregar);
            this.gbIngresos.Controls.Add(this.txtHabitacion);
            this.gbIngresos.Controls.Add(this.txtEspecialidad);
            this.gbIngresos.Controls.Add(this.lblHabitacion);
            this.gbIngresos.Controls.Add(this.lblEspecialidad);
            this.gbIngresos.Controls.Add(this.txtMotivo);
            this.gbIngresos.Controls.Add(this.lblMotivo);
            this.gbIngresos.Controls.Add(this.dtpAlta);
            this.gbIngresos.Controls.Add(this.lblAlta);
            this.gbIngresos.Controls.Add(this.dtpIngreso);
            this.gbIngresos.Controls.Add(this.lblFecha);
            this.gbIngresos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresos.Location = new System.Drawing.Point(1135, 185);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.Size = new System.Drawing.Size(468, 629);
            this.gbIngresos.TabIndex = 0;
            this.gbIngresos.TabStop = false;
            this.gbIngresos.Text = "Añadir Ingresos";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(22, 506);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(3);
            this.btnEditar.Size = new System.Drawing.Size(303, 100);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar Ingreso";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Image = global::Activitat_1_DataGridView_mauro.Properties.Resources.trash_can_115312__1_;
            this.btnBorrar.Location = new System.Drawing.Point(333, 506);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 100);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(22, 506);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.btnAgregar.Size = new System.Drawing.Size(303, 100);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Ingreso";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(22, 444);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(421, 34);
            this.txtHabitacion.TabIndex = 10;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(22, 357);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(421, 34);
            this.txtEspecialidad.TabIndex = 8;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(17, 413);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(139, 28);
            this.lblHabitacion.TabIndex = 9;
            this.lblHabitacion.Text = "Nº Habitacion";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(17, 326);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(122, 28);
            this.lblEspecialidad.TabIndex = 7;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(22, 270);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(421, 34);
            this.txtMotivo.TabIndex = 6;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(17, 239);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(180, 28);
            this.lblMotivo.TabIndex = 5;
            this.lblMotivo.Text = "Motivo de Ingreso";
            // 
            // dtpAlta
            // 
            this.dtpAlta.Checked = false;
            this.dtpAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlta.Location = new System.Drawing.Point(22, 183);
            this.dtpAlta.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpAlta.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.Size = new System.Drawing.Size(175, 34);
            this.dtpAlta.TabIndex = 4;
            this.dtpAlta.Value = new System.DateTime(2025, 11, 5, 20, 3, 20, 0);
            this.dtpAlta.ValueChanged += new System.EventHandler(this.dtpAlta_ValueChanged);
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(17, 152);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(134, 28);
            this.lblAlta.TabIndex = 3;
            this.lblAlta.Text = "Fecha de Alta";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(22, 96);
            this.dtpIngreso.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpIngreso.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(175, 34);
            this.dtpIngreso.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(17, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(139, 28);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha Ingreso";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAGREGAR,
            this.toolStripBORRAR,
            this.toolStripEDITAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1627, 38);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAGREGAR
            // 
            this.toolStripAGREGAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAGREGAR.Image")));
            this.toolStripAGREGAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAGREGAR.Name = "toolStripAGREGAR";
            this.toolStripAGREGAR.Size = new System.Drawing.Size(34, 33);
            this.toolStripAGREGAR.Text = "Agregar";
            this.toolStripAGREGAR.Click += new System.EventHandler(this.toolStripAGREGAR_Click);
            // 
            // toolStripBORRAR
            // 
            this.toolStripBORRAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBORRAR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBORRAR.Image")));
            this.toolStripBORRAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBORRAR.Name = "toolStripBORRAR";
            this.toolStripBORRAR.Size = new System.Drawing.Size(34, 33);
            this.toolStripBORRAR.Text = "Borrar";
            this.toolStripBORRAR.Click += new System.EventHandler(this.toolStripBORRAR_Click);
            // 
            // toolStripEDITAR
            // 
            this.toolStripEDITAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEDITAR.Image")));
            this.toolStripEDITAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEDITAR.Name = "toolStripEDITAR";
            this.toolStripEDITAR.Size = new System.Drawing.Size(34, 33);
            this.toolStripEDITAR.Text = "Editar";
            this.toolStripEDITAR.Click += new System.EventHandler(this.toolStripEDITAR_Click);
            // 
            // checkBoxAlta
            // 
            this.checkBoxAlta.AutoSize = true;
            this.checkBoxAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxAlta.Location = new System.Drawing.Point(225, 187);
            this.checkBoxAlta.Name = "checkBoxAlta";
            this.checkBoxAlta.Size = new System.Drawing.Size(107, 32);
            this.checkBoxAlta.TabIndex = 16;
            this.checkBoxAlta.Text = "Dar alta";
            this.checkBoxAlta.UseVisualStyleBackColor = true;
            this.checkBoxAlta.CheckedChanged += new System.EventHandler(this.checkBoxAlta_CheckedChanged);
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 848);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbIngresos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresos";
            this.Text = "FrmIngresos";
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbIngresos.ResumeLayout(false);
            this.gbIngresos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pantallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbIngresos;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAGREGAR;
        private System.Windows.Forms.ToolStripButton toolStripBORRAR;
        private System.Windows.Forms.ToolStripButton toolStripEDITAR;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox checkBoxAlta;
    }
}