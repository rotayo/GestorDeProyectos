using Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms.MenuGestionarProyectos
{
    public partial class MiniaturaProyecto : UserControl
    {
        public MiniaturaProyecto(string id, string cliente, string encargado, string fechaEntrega)
        {
            InitializeComponent();
            Labelid.Text = id;
            LabelCliente.Text = cliente;
            LabelEncargado.Text = encargado;
            string[] fecha = fechaEntrega.Split(' ');
            LabelFecha.Text = fecha[0];
        }

        private void MiniaturaProyecto_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(225, 50, 100), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(225, 50, 100), Color.FromArgb(249, 118, 176), LinearGradientMode.Vertical);
            graphics.FillRectangle(lgb, area);
            graphics.DrawRectangle(pen, area);
        }

        private void MiniaturaProyecto_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new PlantillaProyecto(Labelid.Text, LabelCliente.Text, LabelEncargado.Text));
        }
    }
}
