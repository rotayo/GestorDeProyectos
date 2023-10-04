namespace Clientes
{
    partial class Proyectos
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
            Botón_Proyectos = new FontAwesome.Sharp.IconButton();
            btnCrearProyecto = new Button();
            btnGestionarProyectos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
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
            Botón_Proyectos.Location = new Point(0, 0);
            Botón_Proyectos.Name = "Botón_Proyectos";
            Botón_Proyectos.Padding = new Padding(10, 0, 20, 0);
            Botón_Proyectos.Size = new Size(579, 40);
            Botón_Proyectos.TabIndex = 3;
            Botón_Proyectos.Text = "Proyectos";
            Botón_Proyectos.TextAlign = ContentAlignment.MiddleLeft;
            Botón_Proyectos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Botón_Proyectos.UseVisualStyleBackColor = true;
            // 
            // btnCrearProyecto
            // 
            btnCrearProyecto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearProyecto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearProyecto.Cursor = Cursors.Hand;
            btnCrearProyecto.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnCrearProyecto.FlatAppearance.BorderSize = 3;
            btnCrearProyecto.FlatAppearance.MouseDownBackColor = Color.FromArgb(249, 118, 176);
            btnCrearProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 118, 176);
            btnCrearProyecto.FlatStyle = FlatStyle.Flat;
            btnCrearProyecto.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearProyecto.ForeColor = Color.FromArgb(249, 118, 176);
            btnCrearProyecto.Location = new Point(100, 72);
            btnCrearProyecto.Name = "btnCrearProyecto";
            btnCrearProyecto.Padding = new Padding(10, 0, 0, 0);
            btnCrearProyecto.Size = new Size(150, 150);
            btnCrearProyecto.TabIndex = 4;
            btnCrearProyecto.Text = "+";
            btnCrearProyecto.TextAlign = ContentAlignment.TopCenter;
            btnCrearProyecto.UseVisualStyleBackColor = false;
            btnCrearProyecto.Click += btnCrearProyecto_Click;
            btnCrearProyecto.MouseLeave += btnCrearProyecto_MouseLeave;
            btnCrearProyecto.MouseHover += btnCrearProyecto_MouseHover;
            // 
            // btnGestionarProyectos
            // 
            btnGestionarProyectos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGestionarProyectos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGestionarProyectos.BackColor = Color.FromArgb(34, 33, 74);
            btnGestionarProyectos.Cursor = Cursors.Hand;
            btnGestionarProyectos.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnGestionarProyectos.FlatAppearance.BorderSize = 3;
            btnGestionarProyectos.FlatStyle = FlatStyle.Flat;
            btnGestionarProyectos.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionarProyectos.ForeColor = Color.FromArgb(249, 118, 176);
            btnGestionarProyectos.Location = new Point(329, 72);
            btnGestionarProyectos.Name = "btnGestionarProyectos";
            btnGestionarProyectos.Size = new Size(150, 150);
            btnGestionarProyectos.TabIndex = 5;
            btnGestionarProyectos.Text = "g/";
            btnGestionarProyectos.UseVisualStyleBackColor = false;
            btnGestionarProyectos.Click += btnGestionarProyectos_Click;
            btnGestionarProyectos.MouseLeave += btnGestionarProyectos_MouseLeave;
            btnGestionarProyectos.MouseHover += btnGestionarProyectos_MouseHover;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 118, 176);
            label1.Location = new Point(110, 237);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 6;
            label1.Text = "Crear Nuevo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(249, 118, 176);
            label2.Location = new Point(125, 267);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 7;
            label2.Text = "Proyecto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(249, 118, 176);
            label3.Location = new Point(353, 237);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 8;
            label3.Text = "Gestionar";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(249, 118, 176);
            label4.Location = new Point(353, 267);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 9;
            label4.Text = "Proyectos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Proyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGestionarProyectos);
            Controls.Add(btnCrearProyecto);
            Controls.Add(Botón_Proyectos);
            Name = "Proyectos";
            Text = "Proyectos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton Botón_Proyectos;
        private Button btnCrearProyecto;
        private Button btnGestionarProyectos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}