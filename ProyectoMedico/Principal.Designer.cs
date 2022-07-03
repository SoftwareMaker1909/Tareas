namespace ProyectoMedico
{
    partial class Principal
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
            this.sicktxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new ProyectoMedico.LoginDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.pacientesTableAdapter = new ProyectoMedico.LoginDataSetTableAdapters.PacientesTableAdapter();
            this.citasC = new System.Windows.Forms.DataGridView();
            this.Habtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasC)).BeginInit();
            this.SuspendLayout();
            // 
            // sicktxt
            // 
            this.sicktxt.Location = new System.Drawing.Point(552, 98);
            this.sicktxt.Name = "sicktxt";
            this.sicktxt.Size = new System.Drawing.Size(216, 22);
            this.sicktxt.TabIndex = 1;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(44, 98);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(208, 22);
            this.nametxt.TabIndex = 2;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "MEDATA";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(310, 195);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 33);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Agregar";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(624, 195);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(94, 33);
            this.delbtn.TabIndex = 6;
            this.delbtn.Text = "Eliminar";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Padecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre y apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero de contacto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(313, 98);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(208, 22);
            this.lnametxt.TabIndex = 11;
            this.lnametxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // citasC
            // 
            this.citasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasC.Location = new System.Drawing.Point(145, 285);
            this.citasC.Name = "citasC";
            this.citasC.RowHeadersWidth = 51;
            this.citasC.RowTemplate.Height = 24;
            this.citasC.Size = new System.Drawing.Size(750, 150);
            this.citasC.TabIndex = 13;
            // 
            // Habtxt
            // 
            this.Habtxt.Location = new System.Drawing.Point(805, 98);
            this.Habtxt.Name = "Habtxt";
            this.Habtxt.Size = new System.Drawing.Size(148, 22);
            this.Habtxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Habitacion";
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(962, 484);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 16;
            this.closebtn.Text = "Cerrar";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Habtxt);
            this.Controls.Add(this.citasC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.sicktxt);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sicktxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lnametxt;
        private LoginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private LoginDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridView citasC;
        private System.Windows.Forms.TextBox Habtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closebtn;
    }
}