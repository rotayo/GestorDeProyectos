namespace Clientes
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelMenu = new Panel();
            Botón_Salir = new FontAwesome.Sharp.IconButton();
            Botón_CierreDeCaja = new FontAwesome.Sharp.IconButton();
            Botón_Facturacion = new FontAwesome.Sharp.IconButton();
            Botón_Inventario = new FontAwesome.Sharp.IconButton();
            Botón_Proyectos = new FontAwesome.Sharp.IconButton();
            Botón_Clientes = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            brnCerrar = new FontAwesome.Sharp.IconButton();
            TituloFormularioHijo = new Label();
            IconoFormularioHijoActual = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioHijoActual).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(20, 20, 48);
            panelMenu.Controls.Add(Botón_Salir);
            panelMenu.Controls.Add(Botón_CierreDeCaja);
            panelMenu.Controls.Add(Botón_Facturacion);
            panelMenu.Controls.Add(Botón_Inventario);
            panelMenu.Controls.Add(Botón_Proyectos);
            panelMenu.Controls.Add(Botón_Clientes);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // Botón_Salir
            // 
            Botón_Salir.Dock = DockStyle.Top;
            Botón_Salir.FlatAppearance.BorderSize = 0;
            Botón_Salir.FlatStyle = FlatStyle.Flat;
            Botón_Salir.ForeColor = Color.Gainsboro;
            Botón_Salir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            Botón_Salir.IconColor = Color.Gainsboro;
            Botón_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_Salir.IconSize = 32;
            Botón_Salir.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_Salir.Location = new Point(0, 340);
            Botón_Salir.Name = "Botón_Salir";
            Botón_Salir.Padding = new Padding(10, 0, 20, 0);
            Botón_Salir.Size = new Size(220, 40);
            Botón_Salir.TabIndex = 7;
            Botón_Salir.Text = "Salir";
            Botón_Salir.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Salir.UseVisualStyleBackColor = true;
            Botón_Salir.Click += Botón_Salir_Click_1;
            // 
            // Botón_CierreDeCaja
            // 
            Botón_CierreDeCaja.Dock = DockStyle.Top;
            Botón_CierreDeCaja.FlatAppearance.BorderSize = 0;
            Botón_CierreDeCaja.FlatStyle = FlatStyle.Flat;
            Botón_CierreDeCaja.ForeColor = Color.Gainsboro;
            Botón_CierreDeCaja.IconChar = FontAwesome.Sharp.IconChar.Archive;
            Botón_CierreDeCaja.IconColor = Color.Gainsboro;
            Botón_CierreDeCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_CierreDeCaja.IconSize = 32;
            Botón_CierreDeCaja.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_CierreDeCaja.Location = new Point(0, 300);
            Botón_CierreDeCaja.Name = "Botón_CierreDeCaja";
            Botón_CierreDeCaja.Padding = new Padding(10, 0, 20, 0);
            Botón_CierreDeCaja.Size = new Size(220, 40);
            Botón_CierreDeCaja.TabIndex = 6;
            Botón_CierreDeCaja.Text = "Cierre de caja";
            Botón_CierreDeCaja.TextAlign = ContentAlignment.MiddleLeft;
            Botón_CierreDeCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_CierreDeCaja.UseVisualStyleBackColor = true;
            Botón_CierreDeCaja.Click += Botón_CierreDeCaja_Click;
            // 
            // Botón_Facturacion
            // 
            Botón_Facturacion.Dock = DockStyle.Top;
            Botón_Facturacion.FlatAppearance.BorderSize = 0;
            Botón_Facturacion.FlatStyle = FlatStyle.Flat;
            Botón_Facturacion.ForeColor = Color.Gainsboro;
            Botón_Facturacion.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            Botón_Facturacion.IconColor = Color.Gainsboro;
            Botón_Facturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_Facturacion.IconSize = 32;
            Botón_Facturacion.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_Facturacion.Location = new Point(0, 260);
            Botón_Facturacion.Name = "Botón_Facturacion";
            Botón_Facturacion.Padding = new Padding(10, 0, 20, 0);
            Botón_Facturacion.Size = new Size(220, 40);
            Botón_Facturacion.TabIndex = 4;
            Botón_Facturacion.Text = "Facturación";
            Botón_Facturacion.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Facturacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Facturacion.UseVisualStyleBackColor = true;
            Botón_Facturacion.Click += Botón_Facturacion_Click;
            // 
            // Botón_Inventario
            // 
            Botón_Inventario.Dock = DockStyle.Top;
            Botón_Inventario.FlatAppearance.BorderSize = 0;
            Botón_Inventario.FlatStyle = FlatStyle.Flat;
            Botón_Inventario.ForeColor = Color.Gainsboro;
            Botón_Inventario.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            Botón_Inventario.IconColor = Color.Gainsboro;
            Botón_Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_Inventario.IconSize = 32;
            Botón_Inventario.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_Inventario.Location = new Point(0, 220);
            Botón_Inventario.Name = "Botón_Inventario";
            Botón_Inventario.Padding = new Padding(10, 0, 20, 0);
            Botón_Inventario.Size = new Size(220, 40);
            Botón_Inventario.TabIndex = 3;
            Botón_Inventario.Text = "Inventario";
            Botón_Inventario.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Inventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Inventario.UseVisualStyleBackColor = true;
            Botón_Inventario.Click += Botón_Inventario_Click;
            // 
            // Botón_Proyectos
            // 
            Botón_Proyectos.Dock = DockStyle.Top;
            Botón_Proyectos.FlatAppearance.BorderSize = 0;
            Botón_Proyectos.FlatStyle = FlatStyle.Flat;
            Botón_Proyectos.ForeColor = Color.Gainsboro;
            Botón_Proyectos.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            Botón_Proyectos.IconColor = Color.Gainsboro;
            Botón_Proyectos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_Proyectos.IconSize = 32;
            Botón_Proyectos.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_Proyectos.Location = new Point(0, 180);
            Botón_Proyectos.Name = "Botón_Proyectos";
            Botón_Proyectos.Padding = new Padding(10, 0, 20, 0);
            Botón_Proyectos.Size = new Size(220, 40);
            Botón_Proyectos.TabIndex = 2;
            Botón_Proyectos.Text = "Proyectos";
            Botón_Proyectos.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Proyectos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Proyectos.UseVisualStyleBackColor = true;
            Botón_Proyectos.Click += Botón_Proyectos_Click;
            // 
            // Botón_Clientes
            // 
            Botón_Clientes.Dock = DockStyle.Top;
            Botón_Clientes.FlatAppearance.BorderSize = 0;
            Botón_Clientes.FlatStyle = FlatStyle.Flat;
            Botón_Clientes.ForeColor = Color.Gainsboro;
            Botón_Clientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            Botón_Clientes.IconColor = Color.Gainsboro;
            Botón_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botón_Clientes.IconSize = 32;
            Botón_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            Botón_Clientes.Location = new Point(0, 140);
            Botón_Clientes.Name = "Botón_Clientes";
            Botón_Clientes.Padding = new Padding(10, 0, 20, 0);
            Botón_Clientes.Size = new Size(220, 40);
            Botón_Clientes.TabIndex = 1;
            Botón_Clientes.Text = "Clientes";
            Botón_Clientes.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Clientes.UseVisualStyleBackColor = true;
            Botón_Clientes.Click += Botón_clientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(-4, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(224, 140);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(20, 20, 48);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnMaximizar);
            panelTitleBar.Controls.Add(brnCerrar);
            panelTitleBar.Controls.Add(TituloFormularioHijo);
            panelTitleBar.Controls.Add(IconoFormularioHijoActual);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(580, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.Gainsboro;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 15;
            btnMinimizar.Location = new Point(505, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 20);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximizar.IconColor = Color.Gainsboro;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 15;
            btnMaximizar.Location = new Point(531, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 20);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += iconButton2_Click;
            // 
            // brnCerrar
            // 
            brnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            brnCerrar.FlatStyle = FlatStyle.Flat;
            brnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            brnCerrar.IconColor = Color.Gainsboro;
            brnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            brnCerrar.IconSize = 15;
            brnCerrar.Location = new Point(557, 3);
            brnCerrar.Name = "brnCerrar";
            brnCerrar.Size = new Size(20, 20);
            brnCerrar.TabIndex = 2;
            brnCerrar.UseVisualStyleBackColor = true;
            brnCerrar.Click += iconButton1_Click;
            // 
            // TituloFormularioHijo
            // 
            TituloFormularioHijo.AutoSize = true;
            TituloFormularioHijo.ForeColor = Color.Gainsboro;
            TituloFormularioHijo.Location = new Point(41, 44);
            TituloFormularioHijo.Name = "TituloFormularioHijo";
            TituloFormularioHijo.Size = new Size(36, 15);
            TituloFormularioHijo.TabIndex = 1;
            TituloFormularioHijo.Text = "Inicio";
            TituloFormularioHijo.Click += TituloFormularioHijo_Click;
            // 
            // IconoFormularioHijoActual
            // 
            IconoFormularioHijoActual.BackColor = Color.FromArgb(20, 20, 48);
            IconoFormularioHijoActual.ForeColor = Color.DarkOrchid;
            IconoFormularioHijoActual.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoFormularioHijoActual.IconColor = Color.DarkOrchid;
            IconoFormularioHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoFormularioHijoActual.IconSize = 25;
            IconoFormularioHijoActual.Location = new Point(13, 40);
            IconoFormularioHijoActual.Name = "IconoFormularioHijoActual";
            IconoFormularioHijoActual.Size = new Size(25, 25);
            IconoFormularioHijoActual.TabIndex = 0;
            IconoFormularioHijoActual.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(26, 24, 58);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(220, 75);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(580, 9);
            panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(580, 366);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktop);
            Controls.Add(panelSombra);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(816, 489);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioHijoActual).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton Botón_Clientes;
        private FontAwesome.Sharp.IconButton Botón_Facturacion;
        private FontAwesome.Sharp.IconButton Botón_Inventario;
        private FontAwesome.Sharp.IconButton Botón_Proyectos;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconoFormularioHijoActual;
        private Label TituloFormularioHijo;
        private Panel panelSombra;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton brnCerrar;
        private FontAwesome.Sharp.IconButton Botón_Salir;
        private FontAwesome.Sharp.IconButton Botón_CierreDeCaja;
    }
}