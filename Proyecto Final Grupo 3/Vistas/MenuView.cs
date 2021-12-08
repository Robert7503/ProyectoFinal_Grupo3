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
        ExpedientesView VistaDETALLES;
        ServiciosFr Vistaservicio;
        RegistroView VistaUSUARIOS;
        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void ServiciostoolStripButton2_Click(object sender, EventArgs e)
        {//registros
            if (VistaUSUARIOS == null)
            {
                VistaUSUARIOS = new RegistroView();
                VistaUSUARIOS.MdiParent = this;
                VistaUSUARIOS.FormClosed += Vistaservicio_FormClosed;
                VistaUSUARIOS.Show();
            }
            else
            {
                VistaUSUARIOS.Activate();
            }
        }

        private void Vistaservicio_FormClosed(object sender, FormClosedEventArgs e)
        {//registros boton
            VistaUSUARIOS = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {//BOTON SERVICIO
            if (Vistaservicio == null)
            {
                Vistaservicio = new ServiciosFr();
                Vistaservicio.MdiParent = this;
                Vistaservicio.FormClosed += Vistaservicio_FormClosed1; 
                Vistaservicio.Show();
            }
            else
            {
                Vistaservicio.Activate();
            }
        }

        private void Vistaservicio_FormClosed1(object sender, FormClosedEventArgs e)
        {//BOTON SERVICIO
            Vistaservicio = null;
        }

        private void ExpedientoolStripButton1_Click(object sender, EventArgs e)
        {
            if (VistaDETALLES == null)
            {
                VistaDETALLES = new ExpedientesView();
                VistaDETALLES.MdiParent = this;
                VistaDETALLES.FormClosed += VistaDETALLES_FormClosed; ;
                VistaDETALLES.Show();
            }
            else
            {
                VistaDETALLES.Activate();
            }
        }

        private void VistaDETALLES_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaDETALLES = null;
        }
    }
}
