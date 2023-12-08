namespace Proyecto_Automoviles_1
{
    partial class ListasEnlazadas
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
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMatrices = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.dgvehiculolista = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAscender = new System.Windows.Forms.Button();
            this.btnDescender = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvehiculolista)).BeginInit();
            this.SuspendLayout();
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(204, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(62, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(204, 450);
            this.sidebar.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Menu";
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 46);
            this.panel3.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 369);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 32);
            this.panel7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.Image = global::Proyecto_Automoviles_1.Properties.Resources.on_off_button__1_;
            this.button1.Location = new System.Drawing.Point(3, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 43);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Ticks);
            // 
            // dgvehiculolista
            // 
            this.dgvehiculolista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvehiculolista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Modelo,
            this.Marca,
            this.Combustible,
            this.Precio,
            this.Año});
            this.dgvehiculolista.Location = new System.Drawing.Point(209, 258);
            this.dgvehiculolista.Name = "dgvehiculolista";
            this.dgvehiculolista.Size = new System.Drawing.Size(594, 150);
            this.dgvehiculolista.TabIndex = 51;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Combustible
            // 
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(688, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 50;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(510, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Precio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(510, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 47;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(510, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(510, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 44;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Info;
            this.btnModificar.Location = new System.Drawing.Point(691, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(713, 217);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Refresh";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.Location = new System.Drawing.Point(222, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Combustible Utilizado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Modelo";
            // 
            // btnAscender
            // 
            this.btnAscender.BackColor = System.Drawing.Color.Coral;
            this.btnAscender.Location = new System.Drawing.Point(222, 137);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(75, 23);
            this.btnAscender.TabIndex = 52;
            this.btnAscender.Text = "Ascendente";
            this.btnAscender.UseVisualStyleBackColor = false;
            this.btnAscender.Click += new System.EventHandler(this.btnAscender_Click);
            // 
            // btnDescender
            // 
            this.btnDescender.BackColor = System.Drawing.Color.Coral;
            this.btnDescender.Location = new System.Drawing.Point(222, 187);
            this.btnDescender.Name = "btnDescender";
            this.btnDescender.Size = new System.Drawing.Size(75, 23);
            this.btnDescender.TabIndex = 53;
            this.btnDescender.Text = "Descender";
            this.btnDescender.UseVisualStyleBackColor = false;
            this.btnDescender.Click += new System.EventHandler(this.btnDescender_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Id:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Location = new System.Drawing.Point(691, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListasEnlazadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDescender);
            this.Controls.Add(this.btnAscender);
            this.Controls.Add(this.dgvehiculolista);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListasEnlazadas";
            this.Text = "ListasEnlazadas";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvehiculolista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvehiculolista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDescender;
        private System.Windows.Forms.Button btnAscender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
    }
}