namespace Auta
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Vylozit = new System.Windows.Forms.Button();
            this.Nalozit_2000 = new System.Windows.Forms.Button();
            this.Nalozit = new System.Windows.Forms.Button();
            this.Nalozit_1000 = new System.Windows.Forms.Button();
            this.lblNosnost = new System.Windows.Forms.Label();
            this.lblZnacka = new System.Windows.Forms.Label();
            this.lblNaklad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Vylozit);
            this.groupBox1.Controls.Add(this.Nalozit_2000);
            this.groupBox1.Controls.Add(this.Nalozit);
            this.groupBox1.Controls.Add(this.Nalozit_1000);
            this.groupBox1.Controls.Add(this.lblNosnost);
            this.groupBox1.Controls.Add(this.lblZnacka);
            this.groupBox1.Controls.Add(this.lblNaklad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(270, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(239, 208);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(238, 253);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // Vylozit
            // 
            this.Vylozit.Location = new System.Drawing.Point(131, 242);
            this.Vylozit.Name = "Vylozit";
            this.Vylozit.Size = new System.Drawing.Size(101, 38);
            this.Vylozit.TabIndex = 9;
            this.Vylozit.Text = "Vylozit";
            this.Vylozit.UseVisualStyleBackColor = true;
            // 
            // Nalozit_2000
            // 
            this.Nalozit_2000.Location = new System.Drawing.Point(20, 242);
            this.Nalozit_2000.Name = "Nalozit_2000";
            this.Nalozit_2000.Size = new System.Drawing.Size(105, 39);
            this.Nalozit_2000.TabIndex = 8;
            this.Nalozit_2000.Text = "Nalozit 2000kg";
            this.Nalozit_2000.UseVisualStyleBackColor = true;
            // 
            // Nalozit
            // 
            this.Nalozit.Location = new System.Drawing.Point(131, 197);
            this.Nalozit.Name = "Nalozit";
            this.Nalozit.Size = new System.Drawing.Size(102, 39);
            this.Nalozit.TabIndex = 7;
            this.Nalozit.Text = "Naložit";
            this.Nalozit.UseVisualStyleBackColor = true;
            this.Nalozit.Click += new System.EventHandler(this.Nalozit_Click);
            // 
            // Nalozit_1000
            // 
            this.Nalozit_1000.Location = new System.Drawing.Point(20, 197);
            this.Nalozit_1000.Name = "Nalozit_1000";
            this.Nalozit_1000.Size = new System.Drawing.Size(105, 39);
            this.Nalozit_1000.TabIndex = 6;
            this.Nalozit_1000.Text = "Nalozit 1000kg";
            this.Nalozit_1000.UseVisualStyleBackColor = true;
            // 
            // lblNosnost
            // 
            this.lblNosnost.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNosnost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNosnost.Location = new System.Drawing.Point(80, 78);
            this.lblNosnost.Name = "lblNosnost";
            this.lblNosnost.Size = new System.Drawing.Size(200, 35);
            this.lblNosnost.TabIndex = 5;
            this.lblNosnost.Text = "label4";
            this.lblNosnost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZnacka
            // 
            this.lblZnacka.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblZnacka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZnacka.Location = new System.Drawing.Point(80, 30);
            this.lblZnacka.Name = "lblZnacka";
            this.lblZnacka.Size = new System.Drawing.Size(200, 35);
            this.lblZnacka.TabIndex = 4;
            this.lblZnacka.Text = "label5";
            this.lblZnacka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNaklad
            // 
            this.lblNaklad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNaklad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaklad.Location = new System.Drawing.Point(80, 133);
            this.lblNaklad.Name = "lblNaklad";
            this.lblNaklad.Size = new System.Drawing.Size(200, 35);
            this.lblNaklad.TabIndex = 3;
            this.lblNaklad.Text = "label6";
            this.lblNaklad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naklad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nosnost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Značka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNosnost;
        private System.Windows.Forms.Label lblZnacka;
        private System.Windows.Forms.Label lblNaklad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Vylozit;
        private System.Windows.Forms.Button Nalozit_2000;
        private System.Windows.Forms.Button Nalozit;
        private System.Windows.Forms.Button Nalozit_1000;
    }
}

