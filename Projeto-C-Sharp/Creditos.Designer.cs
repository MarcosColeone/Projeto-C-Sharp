namespace projetinho
{
    partial class Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creditos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseCreditos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1349, 725);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseCreditos
            // 
            this.btnCloseCreditos.BackColor = System.Drawing.Color.Red;
            this.btnCloseCreditos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCloseCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCloseCreditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCreditos.Location = new System.Drawing.Point(58, 45);
            this.btnCloseCreditos.Name = "btnCloseCreditos";
            this.btnCloseCreditos.Size = new System.Drawing.Size(44, 30);
            this.btnCloseCreditos.TabIndex = 1;
            this.btnCloseCreditos.UseVisualStyleBackColor = false;
            this.btnCloseCreditos.Click += new System.EventHandler(this.btnCloseCreditos_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnCloseCreditos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Creditos";
            this.Text = "Creditos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseCreditos;
    }
}