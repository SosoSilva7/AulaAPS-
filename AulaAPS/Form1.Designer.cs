namespace AulaAPS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.txtPerimetro);
            this.groupBox1.Controls.Add(this.lblPerimetro);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.cmbObjetos);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.txtRaio);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.lblRaio);
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.cmbTriangulo);
            this.groupBox1.Controls.Add(this.cmbForma);
            this.groupBox1.Location = new System.Drawing.Point(56, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(761, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas Geométricas";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPerimetro.ForeColor = System.Drawing.Color.HotPink;
            this.txtPerimetro.Location = new System.Drawing.Point(544, 95);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(132, 22);
            this.txtPerimetro.TabIndex = 13;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(472, 98);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 12;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.AliceBlue;
            this.txtArea.ForeColor = System.Drawing.Color.HotPink;
            this.txtArea.Location = new System.Drawing.Point(544, 154);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(132, 22);
            this.txtArea.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(473, 160);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area:";
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(544, 42);
            this.cmbObjetos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(160, 24);
            this.cmbObjetos.TabIndex = 9;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.HotPink;
            this.btnCriar.ForeColor = System.Drawing.Color.Snow;
            this.btnCriar.Location = new System.Drawing.Point(409, 39);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(100, 28);
            this.btnCriar.TabIndex = 8;
            this.btnCriar.Text = "Calcular";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.BackColor = System.Drawing.Color.Ivory;
            this.txtRaio.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtRaio.Location = new System.Drawing.Point(85, 101);
            this.txtRaio.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(132, 22);
            this.txtRaio.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.Ivory;
            this.txtAltura.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtAltura.Location = new System.Drawing.Point(85, 129);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(132, 22);
            this.txtAltura.TabIndex = 6;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.Ivory;
            this.txtBase.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtBase.Location = new System.Drawing.Point(85, 159);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(132, 22);
            this.txtBase.TabIndex = 5;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(22, 101);
            this.lblRaio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(39, 16);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(20, 129);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 16);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(20, 159);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(42, 16);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base:";
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.BackColor = System.Drawing.Color.Ivory;
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(213, 42);
            this.cmbTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(160, 24);
            this.cmbTriangulo.TabIndex = 1;
            this.cmbTriangulo.Visible = false;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            // 
            // cmbForma
            // 
            this.cmbForma.BackColor = System.Drawing.Color.Ivory;
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Triângulo",
            "Retângulo"});
            this.cmbForma.Location = new System.Drawing.Point(31, 42);
            this.cmbForma.Margin = new System.Windows.Forms.Padding(4);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(173, 24);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(887, 374);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
    }
}

