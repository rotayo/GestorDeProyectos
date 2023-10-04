namespace Proyecto.Forms.MenuGestionarProyectos
{
    partial class MiniaturaProyecto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Labelid = new Label();
            LabelCliente = new Label();
            label3 = new Label();
            LabelEncargado = new Label();
            label4 = new Label();
            LabelFecha = new Label();
            label6 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(243, 228, 243);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 0;
            label1.Text = "Proyecto:";
            // 
            // Labelid
            // 
            Labelid.AutoSize = true;
            Labelid.BackColor = Color.Transparent;
            Labelid.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Labelid.ForeColor = Color.FromArgb(243, 228, 243);
            Labelid.Location = new Point(136, 0);
            Labelid.Name = "Labelid";
            Labelid.Size = new Size(93, 37);
            Labelid.TabIndex = 1;
            Labelid.Text = "#0000";
            // 
            // LabelCliente
            // 
            LabelCliente.AutoSize = true;
            LabelCliente.BackColor = Color.Transparent;
            LabelCliente.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCliente.ForeColor = Color.FromArgb(243, 228, 243);
            LabelCliente.Location = new Point(82, 49);
            LabelCliente.Name = "LabelCliente";
            LabelCliente.Size = new Size(158, 30);
            LabelCliente.TabIndex = 3;
            LabelCliente.Text = "NombreCliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(243, 228, 243);
            label3.Location = new Point(7, 49);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // LabelEncargado
            // 
            LabelEncargado.AutoSize = true;
            LabelEncargado.BackColor = Color.Transparent;
            LabelEncargado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEncargado.ForeColor = Color.FromArgb(243, 228, 243);
            LabelEncargado.Location = new Point(344, 49);
            LabelEncargado.Name = "LabelEncargado";
            LabelEncargado.Size = new Size(115, 30);
            LabelEncargado.TabIndex = 5;
            LabelEncargado.Text = "Encargado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(243, 228, 243);
            label4.Location = new Point(233, 49);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 4;
            label4.Text = "Encargado:";
            // 
            // LabelFecha
            // 
            LabelFecha.AutoSize = true;
            LabelFecha.BackColor = Color.Transparent;
            LabelFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFecha.ForeColor = Color.FromArgb(243, 228, 243);
            LabelFecha.Location = new Point(399, 90);
            LabelFecha.Name = "LabelFecha";
            LabelFecha.Size = new Size(116, 25);
            LabelFecha.TabIndex = 9;
            LabelFecha.Text = "30/30/2023";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(243, 228, 243);
            label6.Location = new Point(233, 90);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 8;
            label6.Text = "Fecha de entrega:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 228, 243);
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(24, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 1);
            panel1.TabIndex = 10;
            // 
            // MiniaturaProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(panel1);
            Controls.Add(LabelFecha);
            Controls.Add(label6);
            Controls.Add(LabelEncargado);
            Controls.Add(label4);
            Controls.Add(LabelCliente);
            Controls.Add(label3);
            Controls.Add(Labelid);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(530, 150);
            Name = "MiniaturaProyecto";
            Size = new Size(522, 150);
            Click += MiniaturaProyecto_Click;
            Paint += MiniaturaProyecto_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Labelid;
        private Label LabelCliente;
        private Label label3;
        private Label LabelEncargado;
        private Label label4;
        private Label LabelFecha;
        private Label label6;
        private Panel panel1;
    }
}
