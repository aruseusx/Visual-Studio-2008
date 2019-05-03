namespace SharpPrueba2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu Menu_Principal;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu_Principal = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Activo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RFID_Asociado = new System.Windows.Forms.Label();
            this.RFID_Encontrado = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Distancia_Radial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Resultados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Atrás";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // Activo
            // 
            this.Activo.Location = new System.Drawing.Point(7, 8);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(76, 21);
            this.Activo.Text = "Activo";
            this.Activo.ParentChanged += new System.EventHandler(this.Activo_ParentChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RFID_Asociado
            // 
            this.RFID_Asociado.Location = new System.Drawing.Point(7, 78);
            this.RFID_Asociado.Name = "RFID_Asociado";
            this.RFID_Asociado.Size = new System.Drawing.Size(76, 33);
            this.RFID_Asociado.Text = "RFID Asociado";
            this.RFID_Asociado.ParentChanged += new System.EventHandler(this.RFID_Asociado_ParentChanged);
            // 
            // RFID_Encontrado
            // 
            this.RFID_Encontrado.Location = new System.Drawing.Point(7, 115);
            this.RFID_Encontrado.Name = "RFID_Encontrado";
            this.RFID_Encontrado.Size = new System.Drawing.Size(76, 33);
            this.RFID_Encontrado.Text = "¿RFID Fue Encontrado?";
            this.RFID_Encontrado.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(98, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(119, 21);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Distancia_Radial
            // 
            this.Distancia_Radial.Location = new System.Drawing.Point(7, 155);
            this.Distancia_Radial.Name = "Distancia_Radial";
            this.Distancia_Radial.Size = new System.Drawing.Size(76, 33);
            this.Distancia_Radial.Text = "Distancia Radial";
            this.Distancia_Radial.ParentChanged += new System.EventHandler(this.Distancia_Radial_ParentChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar Activo";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultados
            // 
            this.Resultados.BackColor = System.Drawing.Color.Transparent;
            this.Resultados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Resultados.Location = new System.Drawing.Point(7, 58);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(100, 20);
            this.Resultados.Text = "Resultados:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "RFID Cercano";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(119, 21);
            this.textBox3.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(119, 21);
            this.textBox5.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(22, 21);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "C";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Distancia_Radial);
            this.Controls.Add(this.RFID_Encontrado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RFID_Asociado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Activo);
            this.KeyPreview = true;
            this.Menu = this.Menu_Principal;
            this.Name = "Form1";
            this.Text = "Búsqueda de Activos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Activo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RFID_Asociado;
        private System.Windows.Forms.Label RFID_Encontrado;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Distancia_Radial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;


    }
}

