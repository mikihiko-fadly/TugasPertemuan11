namespace TugasPertemuan11.View
{
    partial class FormPelatihan
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
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridViewPelatihan = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelatihan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "SELAMAT DATANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(314, 86);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(117, 23);
            this.btnhapus.TabIndex = 9;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(171, 86);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridViewPelatihan
            // 
            this.dataGridViewPelatihan.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridViewPelatihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelatihan.Location = new System.Drawing.Point(32, 137);
            this.dataGridViewPelatihan.Name = "dataGridViewPelatihan";
            this.dataGridViewPelatihan.Size = new System.Drawing.Size(399, 280);
            this.dataGridViewPelatihan.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(32, 86);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Tambah";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FormPelatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridViewPelatihan);
            this.Controls.Add(this.btnadd);
            this.Name = "FormPelatihan";
            this.Text = "FormPelatihan";
            this.Load += new System.EventHandler(this.FormPelatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelatihan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridViewPelatihan;
        private System.Windows.Forms.Button btnadd;
    }
}