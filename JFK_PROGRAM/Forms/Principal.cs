using System.Collections;
using System.Runtime.InteropServices;
using Clientes.Forms;
using FontAwesome.Sharp;
namespace Clientes
{
    public partial class Principal : Form
    {
        //Atributos globales
        public string nombreServidor;
        public object[] datosProyectoNuevo;

        //Patron singleton
        private static Principal instancia;
        public static Principal ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new Principal();
            return instancia;
        }

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        private Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Metodos
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Botones
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //boton formulario hijo
                IconoFormularioHijoActual.IconChar = currentBtn.IconChar;
                IconoFormularioHijoActual.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(20, 20, 48);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void CambiarFormHijo(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abrir unico formulario 
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TituloFormularioHijo.Text = childForm.Text;
        }

        private void Botón_clientes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            CambiarFormHijo(new Clientes());
        }

        private void Botón_Proyectos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            CambiarFormHijo(new Proyectos());
        }

        private void Botón_Inventario_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            CambiarFormHijo(new Inventario());
        }

        private void Botón_Facturacion_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            CambiarFormHijo(new Facturación());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconoFormularioHijoActual.IconChar = IconChar.Home;
            IconoFormularioHijoActual.IconColor = Color.DarkOrchid;
            TituloFormularioHijo.Text = "Inicio";
        }

        private void Botón_Salir_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            this.Close();
        }

        private void TituloFormularioHijo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //arraste de formulario 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Botón_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Botón_CierreDeCaja_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            CambiarFormHijo(new CierreDeCaja());
        }
    }
}