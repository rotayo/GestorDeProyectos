using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Forms.MenuGestionarProyectos;
using Proyecto.Forms.MenuProyectos;

namespace Clientes
{
    public partial class Proyectos : Form
    {
        public Proyectos()
        {
            InitializeComponent();
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new ValidarIdProyecto());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearProyecto_MouseHover(object sender, EventArgs e)
        {
            btnCrearProyecto.ForeColor = Color.FromArgb(34, 33, 74);
            btnCrearProyecto.BackColor = Color.FromArgb(249, 118, 176);
        }

        private void btnCrearProyecto_MouseLeave(object sender, EventArgs e)
        {
            btnCrearProyecto.BackColor = Color.FromArgb(34, 33, 74);
            btnCrearProyecto.ForeColor = Color.FromArgb(249, 118, 176);
        }

        private void btnGestionarProyectos_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new VistaDeProyectos());
        }

        private void btnGestionarProyectos_MouseHover(object sender, EventArgs e)
        {
            btnGestionarProyectos.ForeColor = Color.FromArgb(34, 33, 74);
            btnGestionarProyectos.BackColor = Color.FromArgb(249, 118, 176);
        }

        private void btnGestionarProyectos_MouseLeave(object sender, EventArgs e)
        {
            btnGestionarProyectos.BackColor = Color.FromArgb(34, 33, 74);
            btnGestionarProyectos.ForeColor = Color.FromArgb(249, 118, 176);
        }
    }
}
