namespace WFAzoldseges
{
    partial class FrmMain
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
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Dátum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termék = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bevétel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.btnElad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szűrés termék alapján:";
            // 
            // tbKereses
            // 
            this.tbKereses.Location = new System.Drawing.Point(223, 34);
            this.tbKereses.Margin = new System.Windows.Forms.Padding(4);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.Size = new System.Drawing.Size(132, 22);
            this.tbKereses.TabIndex = 1;
            this.tbKereses.TextChanged += new System.EventHandler(this.tbKereses_TextChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dátum,
            this.Termék,
            this.Bevétel});
            this.dgvMain.Location = new System.Drawing.Point(13, 72);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(505, 222);
            this.dgvMain.TabIndex = 2;
            // 
            // Dátum
            // 
            this.Dátum.HeaderText = "Dátum";
            this.Dátum.Name = "Dátum";
            // 
            // Termék
            // 
            this.Termék.HeaderText = "Termék";
            this.Termék.Name = "Termék";
            // 
            // Bevétel
            // 
            this.Bevétel.HeaderText = "Bevétel";
            this.Bevétel.Name = "Bevétel";
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(13, 311);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(220, 43);
            this.btnRogzit.TabIndex = 3;
            this.btnRogzit.Text = "Új termék típus rögzítése";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // btnElad
            // 
            this.btnElad.Location = new System.Drawing.Point(297, 311);
            this.btnElad.Name = "btnElad";
            this.btnElad.Size = new System.Drawing.Size(220, 43);
            this.btnElad.TabIndex = 3;
            this.btnElad.Text = "Új eladás rögzítése";
            this.btnElad.UseVisualStyleBackColor = true;
            this.btnElad.Click += new System.EventHandler(this.btnElad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 376);
            this.Controls.Add(this.btnElad);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dátum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termék;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bevétel;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Button btnElad;
    }
}

