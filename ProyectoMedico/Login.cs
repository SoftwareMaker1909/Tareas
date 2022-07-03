using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocios;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMedico
{
    public partial class Login : Form
    {
        E_Users objuser = new E_Users();
        N_Users objnuser = new N_Users();   
        Principal frm1 = new Principal();

        public static string usuario_nombre;
        public static string areas;



        void p_logueo()
        {
            DataTable dt = new DataTable();
            objuser.usuario = UserNtxt.Text;    
            objuser.clave = PassWtxt.Text;


            dt = objnuser.N_user(objuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString() , "Mensaje" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();  
                areas = dt.Rows[0][1].ToString();


                frm1.ShowDialog();

                Login login = new Login();
                login.ShowDialog();

                if (login.ShowDialog() == DialogResult.OK)
                    Application.Run(new Principal());

                UserNtxt.Clear();   
                PassWtxt.Clear();   
                

            }
            else
            {
                MessageBox.Show("Bienvenido  o Contraseña Incorrecta" , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

        }

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrarBTN_Click(object sender, EventArgs e)
        {
            //p_logueo();

            SqlConnection cn = new SqlConnection(@"data source=THEKILLERCODE\SQL;Initial Catalog = Login; Integrated Security = True;");

            //SqlCommand command = new SqlCommand("select id_area, nombre,usuario, contraseña from Usuario where usuario = @usuario and contraseña = @clave");
            SqlCommand cmd = new SqlCommand("sp_logueo_ez", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", UserNtxt.Text);
            cmd.Parameters.AddWithValue("@clave", PassWtxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido");

                Principal v1 = new Principal();
                this.Hide();
                v1.Show();

            
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El ususario o contraseña son incorrectos");

            }

        }
        }
    }
