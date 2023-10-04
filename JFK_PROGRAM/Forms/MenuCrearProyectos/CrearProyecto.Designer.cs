namespace Proyecto.Forms.MenuProyectos
{
    partial class CrearProyecto
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
            listaEncargados = new ComboBox();
            label6 = new Label();
            descripcionTexto = new TextBox();
            label5 = new Label();
            btnCrear = new Button();
            FechaInicio = new DateTimePicker();
            FechaEntrega = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // listaEncargados
            // 
            listaEncargados.BackColor = Color.FromArgb(34, 33, 74);
            listaEncargados.DropDownStyle = ComboBoxStyle.DropDownList;
            listaEncargados.FlatStyle = FlatStyle.Popup;
            listaEncargados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listaEncargados.ForeColor = Color.FromArgb(153, 152, 209);
            listaEncargados.FormattingEnabled = true;
            listaEncargados.Items.AddRange(new object[] { "Joel", "Edward", "Sergio", "Sebastian" });
            listaEncargados.Location = new Point(124, 165);
            listaEncargados.Name = "listaEncargados";
            listaEncargados.Size = new Size(111, 29);
            listaEncargados.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(159, 159, 213);
            label6.Location = new Point(12, 165);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 16;
            label6.Text = "Encargado:";
            // 
            // descripcionTexto
            // 
            descripcionTexto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionTexto.BackColor = Color.FromArgb(34, 33, 74);
            descripcionTexto.BorderStyle = BorderStyle.FixedSingle;
            descripcionTexto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descripcionTexto.ForeColor = Color.FromArgb(54, 54, 124);
            descripcionTexto.Location = new Point(8, 47);
            descripcionTexto.MaxLength = 100;
            descripcionTexto.Multiline = true;
            descripcionTexto.Name = "descripcionTexto";
            descripcionTexto.ScrollBars = ScrollBars.Vertical;
            descripcionTexto.Size = new Size(555, 95);
            descripcionTexto.TabIndex = 15;
            descripcionTexto.Text = "Descripción del proyecto";
            descripcionTexto.Enter += descripcionTexto_Enter;
            descripcionTexto.Leave += descripcionTexto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(159, 159, 213);
            label5.Location = new Point(8, 9);
            label5.Name = "label5";
            label5.Size = new Size(290, 25);
            label5.TabIndex = 14;
            label5.Text = "Descripción general del proyecto";
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnCrear.FlatAppearance.BorderSize = 2;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.FromArgb(249, 118, 176);
            btnCrear.Location = new Point(467, 296);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(100, 50);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            btnCrear.MouseLeave += btnCrear_MouseLeave;
            btnCrear.MouseHover += btnCrear_MouseHover;
            // 
            // FechaInicio
            // 
            FechaInicio.CalendarFont = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FechaInicio.CalendarForeColor = Color.FromArgb(153, 152, 209);
            FechaInicio.CalendarMonthBackground = Color.FromArgb(34, 33, 74);
            FechaInicio.CalendarTitleForeColor = Color.FromArgb(153, 152, 209);
            FechaInicio.CustomFormat = "yyyy/MM/dd";
            FechaInicio.Format = DateTimePickerFormat.Custom;
            FechaInicio.Location = new Point(130, 219);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(105, 23);
            FechaInicio.TabIndex = 19;
            // 
            // FechaEntrega
            // 
            FechaEntrega.CalendarForeColor = Color.FromArgb(153, 152, 209);
            FechaEntrega.CalendarMonthBackground = Color.FromArgb(34, 33, 74);
            FechaEntrega.CalendarTitleForeColor = Color.FromArgb(153, 152, 209);
            FechaEntrega.CustomFormat = "yyyy/MM/dd";
            FechaEntrega.Format = DateTimePickerFormat.Custom;
            FechaEntrega.Location = new Point(378, 219);
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.Size = new Size(105, 23);
            FechaEntrega.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(159, 159, 213);
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 21;
            label1.Text = "Fecha de inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(159, 159, 213);
            label2.Location = new Point(241, 219);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 22;
            label2.Text = "Fecha de entrega:";
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
            btnSalir.Location = new Point(12, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 50);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseHover += btnSalir_MouseHover;
            // 
            // CrearProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaEntrega);
            Controls.Add(FechaInicio);
            Controls.Add(btnCrear);
            Controls.Add(listaEncargados);
            Controls.Add(label6);
            Controls.Add(descripcionTexto);
            Controls.Add(label5);
            Name = "CrearProyecto";
            Text = "CrearNuevoProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listaEncargados;
        private Label label6;
        private TextBox descripcionTexto;
        private Label label5;
        private Button btnCrear;
        private DateTimePicker FechaInicio;
        private DateTimePicker FechaEntrega;
        private Label label1;
        private Label label2;
        private Button btnSalir;
    }
}