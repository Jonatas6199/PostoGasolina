namespace PostoGasolina.WindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnMinimizar = new Button();
            btnFechar = new Button();
            cbxCombustíveis = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxNivelPureza = new ComboBox();
            npdLitros = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            cbxFormaPagamento = new ComboBox();
            lblParcelas = new Label();
            btnComprar = new Button();
            label6 = new Label();
            dgvExtrato = new DataGridView();
            cbxParcelas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)npdLitros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.ButtonFace;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnMinimizar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(937, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(34, 28);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ButtonFace;
            btnFechar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnFechar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(978, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(34, 28);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cbxCombustíveis
            // 
            cbxCombustíveis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCombustíveis.FormattingEnabled = true;
            cbxCombustíveis.Location = new Point(72, 173);
            cbxCombustíveis.Name = "cbxCombustíveis";
            cbxCombustíveis.Size = new Size(140, 29);
            cbxCombustíveis.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(72, 140);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 3;
            label1.Text = "Combustíveis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(294, 40);
            label2.Name = "label2";
            label2.Size = new Size(380, 47);
            label2.TabIndex = 4;
            label2.Text = "POSTO DE GASOLINA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(278, 140);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 6;
            label3.Text = "Nível de Pureza";
            // 
            // cbxNivelPureza
            // 
            cbxNivelPureza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNivelPureza.FormattingEnabled = true;
            cbxNivelPureza.Location = new Point(278, 173);
            cbxNivelPureza.Name = "cbxNivelPureza";
            cbxNivelPureza.Size = new Size(164, 29);
            cbxNivelPureza.TabIndex = 5;
            // 
            // npdLitros
            // 
            npdLitros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            npdLitros.Location = new Point(502, 173);
            npdLitros.Name = "npdLitros";
            npdLitros.Size = new Size(140, 29);
            npdLitros.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(502, 140);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 8;
            label4.Text = "Litros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(693, 139);
            label5.Name = "label5";
            label5.Size = new Size(220, 30);
            label5.TabIndex = 10;
            label5.Text = "Forma de Pagamento";
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Location = new Point(693, 172);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(164, 29);
            cbxFormaPagamento.TabIndex = 9;
            cbxFormaPagamento.SelectedIndexChanged += cbxFormaPagamento_SelectedIndexChanged;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.BackColor = Color.Transparent;
            lblParcelas.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblParcelas.ForeColor = SystemColors.ButtonFace;
            lblParcelas.Location = new Point(778, 211);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(93, 30);
            lblParcelas.TabIndex = 14;
            lblParcelas.Text = "Parcelas";
            lblParcelas.Click += lblParcelas_Click;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(754, 534);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(103, 34);
            btnComprar.TabIndex = 15;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(72, 342);
            label6.Name = "label6";
            label6.Size = new Size(81, 30);
            label6.TabIndex = 17;
            label6.Text = "Extrato";
            // 
            // dgvExtrato
            // 
            dgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtrato.Location = new Point(72, 375);
            dgvExtrato.Name = "dgvExtrato";
            dgvExtrato.Size = new Size(370, 193);
            dgvExtrato.TabIndex = 18;
            // 
            // cbxParcelas
            // 
            cbxParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxParcelas.FormattingEnabled = true;
            cbxParcelas.Location = new Point(794, 244);
            cbxParcelas.Name = "cbxParcelas";
            cbxParcelas.Size = new Size(63, 29);
            cbxParcelas.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1024, 681);
            Controls.Add(cbxParcelas);
            Controls.Add(dgvExtrato);
            Controls.Add(label6);
            Controls.Add(btnComprar);
            Controls.Add(lblParcelas);
            Controls.Add(label5);
            Controls.Add(cbxFormaPagamento);
            Controls.Add(label4);
            Controls.Add(npdLitros);
            Controls.Add(label3);
            Controls.Add(cbxNivelPureza);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxCombustíveis);
            Controls.Add(btnFechar);
            Controls.Add(btnMinimizar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)npdLitros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimizar;
        private Button btnFechar;
        private ComboBox cbxCombustíveis;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbxNivelPureza;
        private NumericUpDown npdLitros;
        private Label label4;
        private Label label5;
        private ComboBox cbxFormaPagamento;
        private Label lblParcelas;
        private Button btnComprar;
        private Label label6;
        private DataGridView dgvExtrato;
        private ComboBox cbxParcelas;
    }
}
