namespace Proyecto.Forms.MenuProyectos
{
    partial class PresupuestoProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listaProductos = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            textBoxManoObra = new TextBox();
            btnValidar = new Button();
            cantidadProducto = new ComboBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 118, 176);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 0;
            label1.Text = "Rellene los siguientes datos: ";
            // 
            // listaProductos
            // 
            listaProductos.BackColor = Color.FromArgb(34, 33, 74);
            listaProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            listaProductos.FlatStyle = FlatStyle.Popup;
            listaProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listaProductos.ForeColor = Color.FromArgb(153, 152, 209);
            listaProductos.FormattingEnabled = true;
            listaProductos.Location = new Point(12, 96);
            listaProductos.Name = "listaProductos";
            listaProductos.Size = new Size(525, 29);
            listaProductos.TabIndex = 1;
            listaProductos.SelectionChangeCommitted += listaProductos_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(159, 159, 213);
            label3.Location = new Point(7, 63);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 3;
            label3.Text = "Material a utilizar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(159, 159, 213);
            label2.Location = new Point(8, 154);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(159, 159, 213);
            label4.Location = new Point(9, 208);
            label4.Name = "label4";
            label4.Size = new Size(269, 25);
            label4.TabIndex = 5;
            label4.Text = "Presupuesto de mano de obra:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 118, 176);
            panel1.Location = new Point(13, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 1);
            panel1.TabIndex = 8;
            // 
            // textBoxManoObra
            // 
            textBoxManoObra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxManoObra.BackColor = Color.FromArgb(34, 33, 74);
            textBoxManoObra.BorderStyle = BorderStyle.None;
            textBoxManoObra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManoObra.ForeColor = Color.FromArgb(54, 54, 124);
            textBoxManoObra.Location = new Point(14, 235);
            textBoxManoObra.Name = "textBoxManoObra";
            textBoxManoObra.Size = new Size(519, 26);
            textBoxManoObra.TabIndex = 7;
            textBoxManoObra.Text = "Ingrese un valor numerico";
            textBoxManoObra.Enter += textBoxManoObra_Enter;
            textBoxManoObra.KeyPress += textBoxManoObra_KeyPress;
            textBoxManoObra.Leave += textBoxManoObra_Leave;
            // 
            // btnValidar
            // 
            btnValidar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnValidar.FlatAppearance.BorderSize = 2;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidar.ForeColor = Color.FromArgb(249, 118, 176);
            btnValidar.Location = new Point(462, 296);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 50);
            btnValidar.TabIndex = 14;
            btnValidar.Text = "Siguiente";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            btnValidar.MouseLeave += btnValidar_MouseLeave;
            btnValidar.MouseHover += btnValidar_MouseHover;
            // 
            // cantidadProducto
            // 
            cantidadProducto.BackColor = Color.FromArgb(34, 33, 74);
            cantidadProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cantidadProducto.Enabled = false;
            cantidadProducto.FlatStyle = FlatStyle.Flat;
            cantidadProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cantidadProducto.ForeColor = Color.FromArgb(153, 152, 209);
            cantidadProducto.FormattingEnabled = true;
            cantidadProducto.Location = new Point(117, 157);
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.Size = new Size(92, 28);
            cantidadProducto.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(249, 118, 176);
            btnSalir.Location = new Point(14, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 50);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseHover += btnSalir_MouseHover;
            // 
            // PresupuestoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(btnSalir);
            Controls.Add(cantidadProducto);
            Controls.Add(btnValidar);
            Controls.Add(panel1);
            Controls.Add(textBoxManoObra);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(listaProductos);
            Controls.Add(label1);
            Name = "PresupuestoProyecto";
            Text = "AgregarNuevoProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox listaProductos;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private TextBox textBoxManoObra;
        private Button btnValidar;
        private ComboBox cantidadProducto;
        private Button btnSalir;
    }
}