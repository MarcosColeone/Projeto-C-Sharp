namespace projetinho
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndiabetes = new System.Windows.Forms.Button();
            this.btnpressao = new System.Windows.Forms.Button();
            this.btncolesterol = new System.Windows.Forms.Button();
            this.btnlactose = new System.Windows.Forms.Button();
            this.btncreditos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btndiabetes
            // 
            this.btndiabetes.BackColor = System.Drawing.Color.Red;
            this.btndiabetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndiabetes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndiabetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiabetes.ForeColor = System.Drawing.Color.White;
            this.btndiabetes.Location = new System.Drawing.Point(410, 466);
            this.btndiabetes.Name = "btndiabetes";
            this.btndiabetes.Size = new System.Drawing.Size(243, 43);
            this.btndiabetes.TabIndex = 1;
            this.btndiabetes.Text = "SAIBA MAIS";
            this.btndiabetes.UseVisualStyleBackColor = false;
            this.btndiabetes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpressao
            // 
            this.btnpressao.BackColor = System.Drawing.Color.Red;
            this.btnpressao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpressao.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnpressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpressao.ForeColor = System.Drawing.Color.White;
            this.btnpressao.Location = new System.Drawing.Point(712, 466);
            this.btnpressao.Name = "btnpressao";
            this.btnpressao.Size = new System.Drawing.Size(243, 43);
            this.btnpressao.TabIndex = 2;
            this.btnpressao.Text = "SAIBA MAIS";
            this.btnpressao.UseVisualStyleBackColor = false;
            this.btnpressao.Click += new System.EventHandler(this.btnpressao_Click);
            // 
            // btncolesterol
            // 
            this.btncolesterol.BackColor = System.Drawing.Color.Red;
            this.btncolesterol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncolesterol.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncolesterol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncolesterol.ForeColor = System.Drawing.Color.White;
            this.btncolesterol.Location = new System.Drawing.Point(1010, 466);
            this.btncolesterol.Name = "btncolesterol";
            this.btncolesterol.Size = new System.Drawing.Size(243, 43);
            this.btncolesterol.TabIndex = 3;
            this.btncolesterol.Text = "SAIBA MAIS";
            this.btncolesterol.UseVisualStyleBackColor = false;
            this.btncolesterol.Click += new System.EventHandler(this.btncolesterol_Click);
            // 
            // btnlactose
            // 
            this.btnlactose.BackColor = System.Drawing.Color.Red;
            this.btnlactose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlactose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnlactose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlactose.ForeColor = System.Drawing.Color.White;
            this.btnlactose.Location = new System.Drawing.Point(114, 466);
            this.btnlactose.Name = "btnlactose";
            this.btnlactose.Size = new System.Drawing.Size(243, 43);
            this.btnlactose.TabIndex = 4;
            this.btnlactose.Text = "SAIBA MAIS";
            this.btnlactose.UseVisualStyleBackColor = false;
            this.btnlactose.Click += new System.EventHandler(this.btnlactose_Click);
            // 
            // btncreditos
            // 
            this.btncreditos.BackColor = System.Drawing.SystemColors.Control;
            this.btncreditos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreditos.Location = new System.Drawing.Point(613, 630);
            this.btncreditos.Name = "btncreditos";
            this.btncreditos.Size = new System.Drawing.Size(140, 35);
            this.btncreditos.TabIndex = 5;
            this.btncreditos.Text = "Créditos";
            this.btncreditos.UseVisualStyleBackColor = false;
            this.btncreditos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btncreditos);
            this.Controls.Add(this.btnlactose);
            this.Controls.Add(this.btncolesterol);
            this.Controls.Add(this.btnpressao);
            this.Controls.Add(this.btndiabetes);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndiabetes;
        private System.Windows.Forms.Button btnpressao;
        private System.Windows.Forms.Button btncolesterol;
        private System.Windows.Forms.Button btnlactose;
        private System.Windows.Forms.Button btncreditos;
    }
}

