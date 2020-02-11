namespace Temperatura
{
    partial class frmTemperatura
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbF1 = new System.Windows.Forms.RadioButton();
            this.rdbK1 = new System.Windows.Forms.RadioButton();
            this.rdbC1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbF2 = new System.Windows.Forms.RadioButton();
            this.rdbK2 = new System.Windows.Forms.RadioButton();
            this.rdbC2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(33, 12);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(57, 20);
            this.txtValue1.TabIndex = 0;
            this.txtValue1.TextChanged += new System.EventHandler(this.txtValue1_TextChanged);
            this.txtValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue1_KeyPress);
            // 
            // txtValue2
            // 
            this.txtValue2.Enabled = false;
            this.txtValue2.Location = new System.Drawing.Point(118, 12);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(57, 20);
            this.txtValue2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbF1);
            this.groupBox1.Controls.Add(this.rdbK1);
            this.groupBox1.Controls.Add(this.rdbC1);
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(57, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdbF1
            // 
            this.rdbF1.AutoSize = true;
            this.rdbF1.Location = new System.Drawing.Point(6, 65);
            this.rdbF1.Name = "rdbF1";
            this.rdbF1.Size = new System.Drawing.Size(38, 17);
            this.rdbF1.TabIndex = 2;
            this.rdbF1.TabStop = true;
            this.rdbF1.Text = "° F";
            this.rdbF1.UseVisualStyleBackColor = true;
            this.rdbF1.CheckedChanged += new System.EventHandler(this.rdbF1_CheckedChanged);
            // 
            // rdbK1
            // 
            this.rdbK1.AutoSize = true;
            this.rdbK1.Location = new System.Drawing.Point(6, 42);
            this.rdbK1.Name = "rdbK1";
            this.rdbK1.Size = new System.Drawing.Size(39, 17);
            this.rdbK1.TabIndex = 1;
            this.rdbK1.TabStop = true;
            this.rdbK1.Text = "° K";
            this.rdbK1.UseVisualStyleBackColor = true;
            this.rdbK1.CheckedChanged += new System.EventHandler(this.rdbK1_CheckedChanged);
            // 
            // rdbC1
            // 
            this.rdbC1.AutoSize = true;
            this.rdbC1.Checked = true;
            this.rdbC1.Location = new System.Drawing.Point(6, 19);
            this.rdbC1.Name = "rdbC1";
            this.rdbC1.Size = new System.Drawing.Size(39, 17);
            this.rdbC1.TabIndex = 0;
            this.rdbC1.TabStop = true;
            this.rdbC1.Text = "° C";
            this.rdbC1.UseVisualStyleBackColor = true;
            this.rdbC1.CheckedChanged += new System.EventHandler(this.rdbC1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbF2);
            this.groupBox2.Controls.Add(this.rdbK2);
            this.groupBox2.Controls.Add(this.rdbC2);
            this.groupBox2.Location = new System.Drawing.Point(118, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(57, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rdbF2
            // 
            this.rdbF2.AutoSize = true;
            this.rdbF2.Location = new System.Drawing.Point(6, 65);
            this.rdbF2.Name = "rdbF2";
            this.rdbF2.Size = new System.Drawing.Size(38, 17);
            this.rdbF2.TabIndex = 2;
            this.rdbF2.TabStop = true;
            this.rdbF2.Text = "° F";
            this.rdbF2.UseVisualStyleBackColor = true;
            this.rdbF2.CheckedChanged += new System.EventHandler(this.rdbF2_CheckedChanged);
            // 
            // rdbK2
            // 
            this.rdbK2.AutoSize = true;
            this.rdbK2.Location = new System.Drawing.Point(6, 42);
            this.rdbK2.Name = "rdbK2";
            this.rdbK2.Size = new System.Drawing.Size(39, 17);
            this.rdbK2.TabIndex = 1;
            this.rdbK2.TabStop = true;
            this.rdbK2.Text = "° K";
            this.rdbK2.UseVisualStyleBackColor = true;
            this.rdbK2.CheckedChanged += new System.EventHandler(this.rdbK2_CheckedChanged);
            // 
            // rdbC2
            // 
            this.rdbC2.AutoSize = true;
            this.rdbC2.Checked = true;
            this.rdbC2.Location = new System.Drawing.Point(6, 19);
            this.rdbC2.Name = "rdbC2";
            this.rdbC2.Size = new System.Drawing.Size(39, 17);
            this.rdbC2.TabIndex = 0;
            this.rdbC2.TabStop = true;
            this.rdbC2.Text = "° C";
            this.rdbC2.UseVisualStyleBackColor = true;
            this.rdbC2.CheckedChanged += new System.EventHandler(this.rdbC2_CheckedChanged);
            // 
            // frmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 146);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "frmTemperatura";
            this.Text = "Temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbF1;
        private System.Windows.Forms.RadioButton rdbK1;
        private System.Windows.Forms.RadioButton rdbC1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbF2;
        private System.Windows.Forms.RadioButton rdbK2;
        private System.Windows.Forms.RadioButton rdbC2;
    }
}

