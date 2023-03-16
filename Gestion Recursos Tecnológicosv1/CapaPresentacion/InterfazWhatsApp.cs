using Gestion_Recursos_Tecnológicos.CapaLogicaNegocio;
using Gestion_Recursos_Tecnológicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Recursos_Tecnológicos.CapaPresentacion
{
    public partial class InterfazWhatsApp : Form, IObservador
    {
        #region Atributos
        private string razonMantenimiento;
        private string[] contactos;

        #endregion

        public InterfazWhatsApp()
        {
            InitializeComponent();
        }

        public void generarMailsNotificacion(string motivo, List<string>[] listaContactos)
        {
            razonMantenimiento = motivo;
            contactos = listaContactos[1].ToArray();
            this.Show();
            enviarNotificacion();
        }

        public void enviarNotificacion()
        {
            Random rnd = new Random();
            // Aquí se implementa la comunicación con la API de WhatsApp para que envíe el mensaje.

            mensaje.Text = "Gracias por elegir WhatsApp!!\n\n" +
                "El mensaje fue enviado a los siguientes contactos: \n";
            foreach (string numero in contactos)
            {
                int rInt = rnd.Next((int)111111, (int)999999);
                mensaje.Text += "- 3516" + rInt.ToString() + "\n";
            }
            
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
