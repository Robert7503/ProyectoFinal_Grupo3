using Proyecto_Final_Grupo_3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Grupo_3.Vistas
{
    public partial class ServiciosFr : Form
    {
        public ServiciosFr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tiposervicio=0;
            //int NUMERO = 0;
         
            //string detalle = "";
            tiposervicio = comboBox1.SelectedIndex;
            SqlCommand comando = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CooConexion"].ConnectionString);

            switch (tiposervicio)
            {
                case -1:

                    MessageBox.Show("Debe seleccionar un servicio");
                    comboBox1.SelectedIndex = -1;

                    break;
                case 0:

                    MessageBox.Show("Debe seleccionar un servicio");
                    comboBox1.SelectedIndex = -1;
                    break;

                default:
                    
                    MiConexion.Open();
                   

                    comando = new SqlCommand("insert into servicios (Numero_de_Servicio,Tipo_de_Servicios,Detalle_de_Servicios) VALUES ("+comboBox1.SelectedIndex + ",'"+comboBox1.SelectedItem+"','"+textBox1.Text+"')", MiConexion);
                    comando.ExecuteNonQuery();
                    MiConexion.Close();
                    MessageBox.Show("Datos agregados");
                    break;



            }
        }

        private void ServiciosFr_Load(object sender, EventArgs e)
        {

        }
    }
}
