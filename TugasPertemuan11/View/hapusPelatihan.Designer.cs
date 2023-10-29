namespace TugasPertemuan11.View
{
    partial class hapusPelatihan
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnhapuspelatihan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txthapus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(348, 397);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(99, 23);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnhapuspelatihan
            // 
            this.btnhapuspelatihan.Location = new System.Drawing.Point(16, 397);
            this.btnhapuspelatihan.Name = "btnhapuspelatihan";
            this.btnhapuspelatihan.Size = new System.Drawing.Size(326, 23);
            this.btnhapuspelatihan.TabIndex = 8;
            this.btnhapuspelatihan.Text = "HAPUS";
            this.btnhapuspelatihan.UseVisualStyleBackColor = true;
            this.btnhapuspelatihan.Click += new System.EventHandler(this.btnhapuspeserta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 242);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PILIH ID PESERTA YANG INGIN DI HAPUS";
            // 
            // txthapus
            // 
            this.txthapus.Location = new System.Drawing.Point(253, 305);
            this.txthapus.Name = "txthapus";
            this.txthapus.Size = new System.Drawing.Size(194, 20);
            this.txthapus.TabIndex = 5;
            // 
            // hapusPelatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnhapuspelatihan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthapus);
            this.Name = "hapusPelatihan";
            this.Text = "hapusPelatihan";
            this.Load += new System.EventHandler(this.hapusPelatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnhapuspelatihan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthapus;
    }
}