namespace Proyecto.Forms.MenuGestionarProyectos
{
    partial class PlantillaEditarProyecto
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
            btnCancelar = new Button();
            btnValidar = new Button();
            LabelDetalles = new TextBox();
            LabelCosto = new Label();
            label11 = new Label();
            label12 = new Label();
            LabelCantidad = new Label();
            LabelMaterial = new Label();
            LabelCliente = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            LabelProyecto = new Label();
            label1 = new Label();
            ListaEncargados = new ComboBox();
            LabelFechaInicio = new DateTimePicker();
            LabelFechaFinal = new DateTimePicker();
            LabelMano = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(249, 118, 176);
            btnCancelar.Location = new Point(144, 298);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 50);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnValidar
            // 
            btnValidar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnValidar.FlatAppearance.BorderColor = Color.FromArgb(249, 118, 176);
            btnValidar.FlatAppearance.BorderSize = 2;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidar.ForeColor = Color.FromArgb(249, 118, 176);
            btnValidar.Location = new Point(319, 298);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 50);
            btnValidar.TabIndex = 22;
            btnValidar.Text = "Aceptar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // LabelDetalles
            // 
            LabelDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelDetalles.BackColor = Color.White;
            LabelDetalles.BorderStyle = BorderStyle.FixedSingle;
            LabelDetalles.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDetalles.ForeColor = Color.FromArgb(159, 159, 213);
            LabelDetalles.Location = new Point(291, 56);
            LabelDetalles.MaxLength = 100;
            LabelDetalles.Multiline = true;
            LabelDetalles.Name = "LabelDetalles";
            LabelDetalles.ScrollBars = ScrollBars.Vertical;
            LabelDetalles.Size = new Size(239, 95);
            LabelDetalles.TabIndex = 44;
            LabelDetalles.Text = "Descripción del proyecto";
            // 
            // LabelCosto
            // 
            LabelCosto.AutoSize = true;
            LabelCosto.BackColor = Color.Transparent;
            LabelCosto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCosto.ForeColor = Color.FromArgb(159, 159, 213);
            LabelCosto.Location = new Point(129, 200);
            LabelCosto.Name = "LabelCosto";
            LabelCosto.Size = new Size(66, 30);
            LabelCosto.TabIndex = 42;
            LabelCosto.Text = "costo";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(249, 118, 176);
            label11.Location = new Point(290, 200);
            label11.Name = "label11";
            label11.Size = new Size(157, 30);
            label11.TabIndex = 41;
            label11.Text = "Mano de obra:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(249, 118, 176);
            label12.Location = new Point(23, 200);
            label12.Name = "label12";
            label12.Size = new Size(75, 30);
            label12.TabIndex = 40;
            label12.Text = "Costo:";
            // 
            // LabelCantidad
            // 
            LabelCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelCantidad.AutoSize = true;
            LabelCantidad.BackColor = Color.Transparent;
            LabelCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCantidad.ForeColor = Color.FromArgb(159, 159, 213);
            LabelCantidad.Location = new Point(403, 154);
            LabelCantidad.Name = "LabelCantidad";
            LabelCantidad.Size = new Size(98, 30);
            LabelCantidad.TabIndex = 39;
            LabelCantidad.Text = "cantidad";
            // 
            // LabelMaterial
            // 
            LabelMaterial.AutoSize = true;
            LabelMaterial.BackColor = Color.Transparent;
            LabelMaterial.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMaterial.ForeColor = Color.FromArgb(159, 159, 213);
            LabelMaterial.Location = new Point(129, 154);
            LabelMaterial.Name = "LabelMaterial";
            LabelMaterial.Size = new Size(93, 30);
            LabelMaterial.TabIndex = 36;
            LabelMaterial.Text = "material";
            // 
            // LabelCliente
            // 
            LabelCliente.AutoSize = true;
            LabelCliente.BackColor = Color.Transparent;
            LabelCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCliente.ForeColor = Color.FromArgb(159, 159, 213);
            LabelCliente.Location = new Point(116, 69);
            LabelCliente.Name = "LabelCliente";
            LabelCliente.Size = new Size(78, 30);
            LabelCliente.TabIndex = 34;
            LabelCliente.Text = "cliente";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(249, 118, 176);
            label9.Location = new Point(270, 244);
            label9.Name = "label9";
            label9.Size = new Size(186, 30);
            label9.TabIndex = 33;
            label9.Text = "Fecha de Entrega:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(249, 118, 176);
            label8.Location = new Point(290, 154);
            label8.Name = "label8";
            label8.Size = new Size(107, 30);
            label8.TabIndex = 32;
            label8.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(249, 118, 176);
            label7.Location = new Point(23, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 31;
            label7.Text = "Material:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(249, 118, 176);
            label6.Location = new Point(291, 16);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 30;
            label6.Text = "Detalles:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(249, 118, 176);
            label5.Location = new Point(23, 69);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 29;
            label5.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(249, 118, 176);
            label4.Location = new Point(23, 108);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 28;
            label4.Text = "Encargado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(249, 118, 176);
            label3.Location = new Point(23, 242);
            label3.Name = "label3";
            label3.Size = new Size(166, 30);
            label3.TabIndex = 27;
            label3.Text = "Fecha de Inicio:";
            // 
            // LabelProyecto
            // 
            LabelProyecto.AutoSize = true;
            LabelProyecto.BackColor = Color.Transparent;
            LabelProyecto.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelProyecto.ForeColor = Color.FromArgb(159, 159, 213);
            LabelProyecto.Location = new Point(151, 9);
            LabelProyecto.Name = "LabelProyecto";
            LabelProyecto.Size = new Size(93, 37);
            LabelProyecto.TabIndex = 26;
            LabelProyecto.Text = "#0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 118, 176);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 25;
            label1.Text = "Proyecto:";
            // 
            // ListaEncargados
            // 
            ListaEncargados.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaEncargados.FormattingEnabled = true;
            ListaEncargados.Items.AddRange(new object[] { "Joel", "Edward", "Sergio", "Sebastian" });
            ListaEncargados.Location = new Point(151, 115);
            ListaEncargados.Name = "ListaEncargados";
            ListaEncargados.Size = new Size(121, 23);
            ListaEncargados.TabIndex = 45;
            // 
            // LabelFechaInicio
            // 
            LabelFechaInicio.CalendarFont = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFechaInicio.CalendarForeColor = Color.FromArgb(153, 152, 209);
            LabelFechaInicio.CalendarMonthBackground = Color.FromArgb(34, 33, 74);
            LabelFechaInicio.CalendarTitleForeColor = Color.FromArgb(153, 152, 209);
            LabelFechaInicio.CustomFormat = "yyyy/MM/dd";
            LabelFechaInicio.Format = DateTimePickerFormat.Custom;
            LabelFechaInicio.Location = new Point(186, 249);
            LabelFechaInicio.Name = "LabelFechaInicio";
            LabelFechaInicio.Size = new Size(86, 23);
            LabelFechaInicio.TabIndex = 47;
            // 
            // LabelFechaFinal
            // 
            LabelFechaFinal.CalendarFont = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFechaFinal.CalendarForeColor = Color.FromArgb(153, 152, 209);
            LabelFechaFinal.CalendarMonthBackground = Color.FromArgb(34, 33, 74);
            LabelFechaFinal.CalendarTitleForeColor = Color.FromArgb(153, 152, 209);
            LabelFechaFinal.CustomFormat = "yyyy/MM/dd";
            LabelFechaFinal.Format = DateTimePickerFormat.Custom;
            LabelFechaFinal.Location = new Point(471, 249);
            LabelFechaFinal.Name = "LabelFechaFinal";
            LabelFechaFinal.Size = new Size(105, 23);
            LabelFechaFinal.TabIndex = 48;
            // 
            // LabelMano
            // 
            LabelMano.Location = new Point(471, 207);
            LabelMano.Name = "LabelMano";
            LabelMano.Size = new Size(100, 23);
            LabelMano.TabIndex = 49;
            // 
            // PlantillaEditarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(LabelMano);
            Controls.Add(LabelFechaFinal);
            Controls.Add(LabelFechaInicio);
            Controls.Add(ListaEncargados);
            Controls.Add(LabelDetalles);
            Controls.Add(LabelCosto);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(LabelCantidad);
            Controls.Add(LabelMaterial);
            Controls.Add(LabelCliente);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LabelProyecto);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnValidar);
            MaximumSize = new Size(595, 397);
            MinimumSize = new Size(595, 397);
            Name = "PlantillaEditarProyecto";
            Text = "PlantillaEditarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnValidar;
        private TextBox LabelDetalles;
        private Label LabelCosto;
        private Label label11;
        private Label label12;
        private Label LabelCantidad;
        private Label LabelMaterial;
        private Label LabelCliente;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label LabelProyecto;
        private Label label1;
        private ComboBox ListaEncargados;
        private TextBox manoObra;
        private DateTimePicker LabelFechaInicio;
        private DateTimePicker LabelFechaFinal;
        private TextBox LabelMano;
    }
}