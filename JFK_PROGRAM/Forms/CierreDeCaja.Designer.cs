namespace Clientes.Forms
{
    partial class CierreDeCaja
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
            dataGridView1 = new DataGridView();
            btn_facturas = new Button();
            label1 = new Label();
            btn_calculo = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(510, 214);
            dataGridView1.TabIndex = 0;
            // 
            // btn_facturas
            // 
            btn_facturas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_facturas.Location = new Point(39, 251);
            btn_facturas.Name = "btn_facturas";
            btn_facturas.Size = new Size(88, 47);
            btn_facturas.TabIndex = 1;
            btn_facturas.Text = "Mostrar facturas";
            btn_facturas.UseVisualStyleBackColor = true;
            btn_facturas.Click += btn_facturas_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 256);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // btn_calculo
            // 
            btn_calculo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_calculo.Location = new Point(39, 304);
            btn_calculo.Name = "btn_calculo";
            btn_calculo.Size = new Size(88, 46);
            btn_calculo.TabIndex = 3;
            btn_calculo.Text = "Calcular";
            btn_calculo.UseVisualStyleBackColor = true;
            btn_calculo.Click += btn_calculo_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(421, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 4;
            // 
            // CierreDeCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(579, 358);
            Controls.Add(textBox1);
            Controls.Add(btn_calculo);
            Controls.Add(label1);
            Controls.Add(btn_facturas);
            Controls.Add(dataGridView1);
            Location = new Point(505, 253);
            Name = "CierreDeCaja";
            Text = "CierreDeCaja";
            Load += CierreDeCaja_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_facturas;
        private Label label1;
        private Button btn_calculo;
        private TextBox textBox1;
    }
}