namespace citas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombreC = new System.Windows.Forms.TextBox();
            this.contactoC = new System.Windows.Forms.TextBox();
            this.horaC = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.servicioC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.citasC = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "D\' Luis Barbershop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::citas.Properties.Resources.Foto_Barberia;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 228);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nombreC
            // 
            this.nombreC.Location = new System.Drawing.Point(311, 145);
            this.nombreC.Name = "nombreC";
            this.nombreC.Size = new System.Drawing.Size(222, 22);
            this.nombreC.TabIndex = 2;
            this.nombreC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contactoC
            // 
            this.contactoC.Location = new System.Drawing.Point(592, 145);
            this.contactoC.Name = "contactoC";
            this.contactoC.Size = new System.Drawing.Size(222, 22);
            this.contactoC.TabIndex = 3;
            this.contactoC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // horaC
            // 
            this.horaC.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaC.Location = new System.Drawing.Point(1001, 148);
            this.horaC.Name = "horaC";
            this.horaC.Size = new System.Drawing.Size(120, 22);
            this.horaC.TabIndex = 4;
            this.horaC.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celular";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear Cita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicioC
            // 
            this.servicioC.FormattingEnabled = true;
            this.servicioC.Items.AddRange(new object[] {
            "Cerquillo",
            "Corte a maquina",
            "Corte a Tijera",
            "Barba",
            "Completo"});
            this.servicioC.Location = new System.Drawing.Point(847, 145);
            this.servicioC.Name = "servicioC";
            this.servicioC.Size = new System.Drawing.Size(121, 24);
            this.servicioC.TabIndex = 9;
            this.servicioC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Servicio";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // citasC
            // 
            this.citasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasC.Location = new System.Drawing.Point(362, 304);
            this.citasC.Name = "citasC";
            this.citasC.RowHeadersWidth = 51;
            this.citasC.RowTemplate.Height = 24;
            this.citasC.Size = new System.Drawing.Size(708, 179);
            this.citasC.TabIndex = 11;
            this.citasC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.citasC_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Borrar todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar cita";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.citasC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.servicioC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horaC);
            this.Controls.Add(this.contactoC);
            this.Controls.Add(this.nombreC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nombreC;
        private System.Windows.Forms.TextBox contactoC;
        private System.Windows.Forms.DateTimePicker horaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox servicioC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView citasC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

