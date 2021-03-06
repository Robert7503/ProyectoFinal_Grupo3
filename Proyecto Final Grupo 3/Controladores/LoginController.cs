using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Grupo_3.Vistas;
using Proyecto_Final_Grupo_3.Modelos;
using Proyecto_Final_Grupo_3.Entidades;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Proyecto_Final_Grupo_3.Controladores
{
    public class LoginController
    {
        LoginView Vista;
        
        public LoginController(LoginView view)
        {
            Vista = view;
            Vista.AceptarButton.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Nombre = Vista.txtNombreLOGIN.Text;
            user.Clave = EncriptarContraseña(Vista.txtClaveLOGIN.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Nombre Valido");
                MessageBox.Show("Acceso correcto");
                MenuView menu = new MenuView();
                Vista.Hide();
                menu.Show(); //AQUI LLMAO EL FORMULARIO MENU

                //AQUI ES PARA ENTRAR AL SIGUIENTE FORMULARIO SI EL USUARIO ES CORRECTO
                //Form1 f2 = new Form1();
                // f2.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Nombre incorrecto");
            }
        }

        public static string EncriptarContraseña(String str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("(0:x2)", stream[i]);
            return sb.ToString();


        }


    }
}
