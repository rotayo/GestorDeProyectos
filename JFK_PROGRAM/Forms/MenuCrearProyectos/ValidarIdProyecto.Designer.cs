namespace Proyecto.Forms.MenuProyectos
{
    partial class ValidarIdProyecto
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
            textBoxIDcliente = new TextBox();
            panel1 = new Panel();
            btnValidar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // textBoxIDcliente
            // 
            textBoxIDcliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxIDcliente.BackColor = Color.FromArgb(34, 33, 74);
            textBoxIDcliente.BorderStyle = BorderStyle.None;
            textBoxIDcliente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDcliente.ForeColor = Color.FromArgb(54, 54, 124);
            textBoxIDcliente.Location = new Point(50, 150);
            textBoxIDcliente.Name = "textBoxIDcliente";
            textBoxIDcliente.Size = new Size(400, 32);
            textBoxIDcliente.TabIndex = 0;
            textBoxIDcliente.Text = "Ingrese el ID de un Cliente";
            textBoxIDcliente.Enter += textBoxIDcliente_Enter;
            textBoxIDcliente.Leave += textBoxIDcliente_Leave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 118, 176);
            panel1.Location = new Point(50, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 1);
            panel1.TabIndex = 1;
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
            btnValidar.Location = new Point(450, 296);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 50);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            btnValidar.MouseLeave += btnValidar_MouseLeave;
            btnValidar.MouseHover += btnValidar_MouseHover;
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
            btnSalir.Location = new Point(30, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 50);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseHover += btnSalir_MouseHover;
            // 
            // ValidarIdProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(btnSalir);
            Controls.Add(btnValidar);
            Controls.Add(panel1);
            Controls.Add(textBoxIDcliente);
            Name = "ValidarIdProyecto";
            Text = "NuevoProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIDcliente;
        private Panel panel1;
        private Button btnValidar;
        private Button btnSalir;
    }
}