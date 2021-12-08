using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final_Grupo_3.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        ExpedientesView VistaUsuarios;
        ServiciosFr Vistaservicio;
        RegistroView VistaDetalles;
        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void ServiciostoolStripButton2_Click(object sender, EventArgs e)
        {
            VistaUsuarios = new RegistroView();
            VistaUsuarios.MdiParent = this;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Vistaservicio = new ServiciosFr();
            Vistaservicio.MdiParent = this();
                
        }
    }
}
