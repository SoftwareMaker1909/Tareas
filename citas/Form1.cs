using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            citasC.ColumnCount = 4;
            citasC.Columns[0].Name = "Nombre Cliente";
            citasC.Columns[1].Name = "Numero de contacto";
            citasC.Columns[2].Name = "Servicio";
            citasC.Columns[3].Name = "Hora";

            //Para regular el tamaño

            citasC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            citasC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;   
            citasC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            citasC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;   


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citasC.Rows.Add(nombreC.Text,contactoC.Text, servicioC.Text,horaC.Text);
        }

        private void citasC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (citasC.CurrentRow == null)
                return;
            citasC.Rows.Clear();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (citasC == null) 
                return ;
            citasC.Rows.Remove(citasC.CurrentRow);  
        }
    }
}
