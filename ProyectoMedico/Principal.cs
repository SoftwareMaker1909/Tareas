using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            citasC.ColumnCount = 4;
            citasC.Columns[0].Name = "Nombre Paciente";
            citasC.Columns[1].Name = "Numero de contacto";
            citasC.Columns[2].Name = "Padecimiento";
            citasC.Columns[3].Name = "Habitacion";

            //Para regular el tamaño

            citasC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            citasC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            citasC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            citasC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (citasC == null)
                return;
            citasC.Rows.Remove(citasC.CurrentRow);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            citasC.Rows.Add(nametxt.Text, lnametxt.Text, sicktxt.Text, Habtxt.Text);

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
