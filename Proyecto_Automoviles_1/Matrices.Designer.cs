namespace Proyecto_Automoviles_1
{
    partial class Matrices
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.descendente = new System.Windows.Forms.RadioButton();
            this.ascendente = new System.Windows.Forms.RadioButton();
            this.buscador = new System.Windows.Forms.TextBox();
            this.rmodelo = new System.Windows.Forms.RadioButton();
            this.rprecio = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCombustible = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMatrices = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.dgVehiculo = new System.Windows.Forms.DataGridView();
            this.IDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AÑO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Buscar por:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Coral;
            this.btnOrdenar.Location = new System.Drawing.Point(225, 280);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 58;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // descendente
            // 
            this.descendente.AutoSize = true;
            this.descendente.BackColor = System.Drawing.Color.DarkSalmon;
            this.descendente.Location = new System.Drawing.Point(225, 254);
            this.descendente.Name = "descendente";
            this.descendente.Size = new System.Drawing.Size(89, 17);
            this.descendente.TabIndex = 57;
            this.descendente.TabStop = true;
            this.descendente.Text = "Descendente";
            this.descendente.UseVisualStyleBackColor = false;
            this.descendente.CheckedChanged += new System.EventHandler(this.descendente_CheckedChanged);
            // 
            // ascendente
            // 
            this.ascendente.AutoSize = true;
            this.ascendente.BackColor = System.Drawing.Color.DarkSalmon;
            this.ascendente.Location = new System.Drawing.Point(225, 225);
            this.ascendente.Name = "ascendente";
            this.ascendente.Size = new System.Drawing.Size(82, 17);
            this.ascendente.TabIndex = 56;
            this.ascendente.TabStop = true;
            this.ascendente.Text = "Ascendente";
            this.ascendente.UseVisualStyleBackColor = false;
            this.ascendente.CheckedChanged += new System.EventHandler(this.ascendente_CheckedChanged);
            // 
            // buscador
            // 
            this.buscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscador.ForeColor = System.Drawing.Color.Blue;
            this.buscador.Location = new System.Drawing.Point(225, 103);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(100, 20);
            this.buscador.TabIndex = 55;
            this.buscador.TextChanged += new System.EventHandler(this.buscador_TextChanged);
            // 
            // rmodelo
            // 
            this.rmodelo.AutoSize = true;
            this.rmodelo.BackColor = System.Drawing.Color.MediumOrchid;
            this.rmodelo.Location = new System.Drawing.Point(225, 72);
            this.rmodelo.Name = "rmodelo";
            this.rmodelo.Size = new System.Drawing.Size(60, 17);
            this.rmodelo.TabIndex = 54;
            this.rmodelo.TabStop = true;
            this.rmodelo.Text = "Modelo";
            this.rmodelo.UseVisualStyleBackColor = false;
            this.rmodelo.CheckedChanged += new System.EventHandler(this.rmodelo_CheckedChanged);
            // 
            // rprecio
            // 
            this.rprecio.AutoSize = true;
            this.rprecio.BackColor = System.Drawing.Color.SpringGreen;
            this.rprecio.Location = new System.Drawing.Point(225, 48);
            this.rprecio.Name = "rprecio";
            this.rprecio.Size = new System.Drawing.Size(55, 17);
            this.rprecio.TabIndex = 53;
            this.rprecio.TabStop = true;
            this.rprecio.Text = "Precio";
            this.rprecio.UseVisualStyleBackColor = false;
            this.rprecio.CheckedChanged += new System.EventHandler(this.rprecio_CheckedChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(591, 180);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 52;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Precio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Info;
            this.btnModificar.Location = new System.Drawing.Point(356, 130);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminar.Location = new System.Drawing.Point(356, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(225, 138);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 48;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.Location = new System.Drawing.Point(356, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCombustible
            // 
            this.txtCombustible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCombustible.FormattingEnabled = true;
            this.txtCombustible.Items.AddRange(new object[] {
            "",
            "Gasolina",
            "Petroleo",
            "Energia Electrica",
            "Desconocido"});
            this.txtCombustible.Location = new System.Drawing.Point(621, 140);
            this.txtCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(140, 21);
            this.txtCombustible.TabIndex = 45;
            this.txtCombustible.SelectedIndexChanged += new System.EventHandler(this.txtCombustible_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Combustible Utilizado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Año:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Marca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Modelo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(591, 96);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(116, 20);
            this.txtyear.TabIndex = 40;
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(591, 51);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(116, 20);
            this.txtMarca.TabIndex = 39;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(591, 9);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(116, 20);
            this.txtModelo.TabIndex = 38;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(204, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(62, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(204, 450);
            this.sidebar.TabIndex = 37;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Proyecto_Automoviles_1.Properties.Resources.menu__3_;
            this.menuButton.Location = new System.Drawing.Point(3, 28);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(37, 31);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMatrices);
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnMatrices
            // 
            this.btnMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrices.ForeColor = System.Drawing.Color.White;
            this.btnMatrices.Image = global::Proyecto_Automoviles_1.Properties.Resources.table;
            this.btnMatrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatrices.Location = new System.Drawing.Point(-2, -14);
            this.btnMatrices.Name = "btnMatrices";
            this.btnMatrices.Size = new System.Drawing.Size(203, 74);
            this.btnMatrices.TabIndex = 2;
            this.btnMatrices.Text = "               Matrices";
            this.btnMatrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatrices.UseVisualStyleBackColor = true;
            this.btnMatrices.Click += new System.EventHandler(this.btnMatrices_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 44);
            this.panel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Proyecto_Automoviles_1.Properties.Resources.list;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, -12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "               Listas Enlazadas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 44);
            this.panel5.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Proyecto_Automoviles_1.Properties.Resources.battery__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-2, -11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "               Pilas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(3, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 44);
            this.panel6.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Proyecto_Automoviles_1.Properties.Resources.bottle;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, -15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "               Colas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // dgVehiculo
            // 
            this.dgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDs,
            this.MODELO,
            this.MARCA,
            this.AÑO,
            this.COMBUSTIBLE,
            this.PRECIO});
            this.dgVehiculo.Location = new System.Drawing.Point(333, 267);
            this.dgVehiculo.Name = "dgVehiculo";
            this.dgVehiculo.Size = new System.Drawing.Size(464, 171);
            this.dgVehiculo.TabIndex = 60;
            this.dgVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehiculo_CellClick);
            // 
            // IDs
            // 
            this.IDs.HeaderText = "IDs";
            this.IDs.Name = "IDs";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // AÑO
            // 
            this.AÑO.HeaderText = "AÑO";
            this.AÑO.Name = "AÑO";
            // 
            // COMBUSTIBLE
            // 
            this.COMBUSTIBLE.HeaderText = "COMBUSTIBLE";
            this.COMBUSTIBLE.Name = "COMBUSTIBLE";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVehiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.descendente);
            this.Controls.Add(this.ascendente);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.rmodelo);
            this.Controls.Add(this.rprecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.sidebar);
            this.Name = "Matrices";
            this.Text = "Matrices";
            this.Load += new System.EventHandler(this.Matrices_Load_1);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton descendente;
        private System.Windows.Forms.RadioButton ascendente;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.RadioButton rmodelo;
        private System.Windows.Forms.RadioButton rprecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox txtCombustible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMatrices;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.DataGridView dgVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AÑO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
    }
}