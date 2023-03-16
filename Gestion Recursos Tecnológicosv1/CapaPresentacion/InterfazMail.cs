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
    public partial class InterfazMail : Form, IObservador

    {
        #region Atributos
        private string razonMantenimiento;
        private string[] contactos;

        #endregion

        #region Métodos

        public InterfazMail()
        {
            InitializeComponent();
        }

        public void generarMailsNotificacion(string motivo, List<string>[] listaContactos)
        {
            razonMantenimiento = motivo;
            contactos = listaContactos[0].ToArray();
            this.Show();
            enviarNotificacion();
        }

        public void enviarNotificacion()
        {
            // Aquí se implementa la comunicación con la API de Gmail para que envíe el correo.

            mensaje.Text = "Gracias por elegir Gmail.\n\n" +
                "El correo fue enviado a los siguientes contactos: \n";
            foreach (string correo in contactos)
            {
                mensaje.Text += "- " + correo + "\n";
            }
        }

        private void InterfazMail_Load(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verMail_Click(object sender, EventArgs e)
        {
            mensaje.Text = "Estimado científico del Centro de Investigación:\n\n" +
                "Lamentamos informarle que su turno ha sido cancelado debido al \n" +
                "ingreso a mantenimiento correctivo del recurso tecnológico solicitado.\n" +
                "Razón del mantenimiento: " + razonMantenimiento + ".\n";
        }
    }
    #endregion
}

