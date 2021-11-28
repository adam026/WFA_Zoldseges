namespace WFAzoldseges
{
    partial class FrmElad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEladdatum = new System.Windows.Forms.DateTimePicker();
            this.cbTermekek = new System.Windows.Forms.ComboBox();
            this.tbMennyiseg = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eladás dátuma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eladott termék:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eladott mennyiség:";
            // 
            // dtpEladdatum
            // 
            this.dtpEladdatum.Location = new System.Drawing.Point(51, 70);
            this.dtpEladdatum.Name = "dtpEladdatum";
            this.dtpEladdatum.Size = new System.Drawing.Size(200, 22);
            this.dtpEladdatum.TabIndex = 1;
            // 
            // cbTermekek
            // 
            this.cbTermekek.FormattingEnabled = true;
            this.cbTermekek.Location = new System.Drawing.Point(47, 160);
            this.cbTermekek.Name = "cbTermekek";
            this.cbTermekek.Size = new System.Drawing.Size(204, 24);
            this.cbTermekek.TabIndex = 2;
            // 
            // tbMennyiseg
            // 
            this.tbMennyiseg.Location = new System.Drawing.Point(47, 252);
            this.tbMennyiseg.Name = "tbMennyiseg";
            this.tbMennyiseg.Size = new System.Drawing.Size(201, 22);
            this.tbMennyiseg.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 307);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(201, 70);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Hozzáad";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmElad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 412);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbMennyiseg);
            this.Controls.Add(this.cbTermekek);
            this.Controls.Add(this.dtpEladdatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmElad";
            this.Text = "FrmElad";
            this.Load += new System.EventHandler(this.FrmElad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEladdatum;
        private System.Windows.Forms.ComboBox cbTermekek;
        private System.Windows.Forms.TextBox tbMennyiseg;
        private System.Windows.Forms.Button btnInsert;
    }
}