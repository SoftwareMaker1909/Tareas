namespace ProyectoMedico
{
    partial class Login
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
            this.entrarBTN = new System.Windows.Forms.Button();
            this.CerrarBTN = new System.Windows.Forms.Button();
            this.UserNtxt = new System.Windows.Forms.TextBox();
            this.PassWtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // entrarBTN
            // 
            this.entrarBTN.Location = new System.Drawing.Point(342, 339);
            this.entrarBTN.Name = "entrarBTN";
            this.entrarBTN.Size = new System.Drawing.Size(127, 46);
            this.entrarBTN.TabIndex = 0;
            this.entrarBTN.Text = "Entrar";
            this.entrarBTN.UseVisualStyleBackColor = true;
            this.entrarBTN.Click += new System.EventHandler(this.entrarBTN_Click);
            // 
            // CerrarBTN
            // 
            this.CerrarBTN.Location = new System.Drawing.Point(633, 339);
            this.CerrarBTN.Name = "CerrarBTN";
            this.CerrarBTN.Size = new System.Drawing.Size(127, 46);
            this.CerrarBTN.TabIndex = 1;
            this.CerrarBTN.Text = "Cerrar";
            this.CerrarBTN.UseVisualStyleBackColor = true;
            this.CerrarBTN.Click += new System.EventHandler(this.CerrarBTN_Click);
            // 
            // UserNtxt
            // 
            this.UserNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNtxt.Location = new System.Drawing.Point(427, 83);
            this.UserNtxt.Multiline = true;
            this.UserNtxt.Name = "UserNtxt";
            this.UserNtxt.Size = new System.Drawing.Size(242, 46);
            this.UserNtxt.TabIndex = 2;
            // 
            // PassWtxt
            // 
            this.PassWtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWtxt.Location = new System.Drawing.Point(427, 228);
            this.PassWtxt.Multiline = true;
            this.PassWtxt.Name = "PassWtxt";
            this.PassWtxt.PasswordChar = '*';
            this.PassWtxt.Size = new System.Drawing.Size(242, 46);
            this.PassWtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 501);
            this.panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWtxt);
            this.Controls.Add(this.UserNtxt);
            this.Controls.Add(this.CerrarBTN);
            this.Controls.Add(this.entrarBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrarBTN;
        private System.Windows.Forms.Button CerrarBTN;
        private System.Windows.Forms.TextBox UserNtxt;
        private System.Windows.Forms.TextBox PassWtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

