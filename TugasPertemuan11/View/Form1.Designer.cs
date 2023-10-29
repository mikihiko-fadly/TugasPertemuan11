namespace TugasPertemuan11
{
    partial class Formutama
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
            this.btnpeserta = new System.Windows.Forms.Button();
            this.btnpelatihan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESERTA";
            // 
            // btnpeserta
            // 
            this.btnpeserta.Location = new System.Drawing.Point(29, 288);
            this.btnpeserta.Name = "btnpeserta";
            this.btnpeserta.Size = new System.Drawing.Size(75, 23);
            this.btnpeserta.TabIndex = 1;
            this.btnpeserta.Text = "MASUK";
            this.btnpeserta.UseVisualStyleBackColor = true;
            this.btnpeserta.Click += new System.EventHandler(this.btnpeserta_Click);
            // 
            // btnpelatihan
            // 
            this.btnpelatihan.Location = new System.Drawing.Point(175, 288);
            this.btnpelatihan.Name = "btnpelatihan";
            this.btnpelatihan.Size = new System.Drawing.Size(75, 23);
            this.btnpelatihan.TabIndex = 3;
            this.btnpelatihan.Text = "MASUK";
            this.btnpelatihan.UseVisualStyleBackColor = true;
            this.btnpelatihan.Click += new System.EventHandler(this.btnpelatihan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PELATIHAN ";
            // 
            // btnregist
            // 
            this.btnregist.Location = new System.Drawing.Point(324, 288);
            this.btnregist.Name = "btnregist";
            this.btnregist.Size = new System.Drawing.Size(75, 23);
            this.btnregist.TabIndex = 5;
            this.btnregist.Text = "MASUK";
            this.btnregist.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "REGISTRASI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PELATIHAN PEMROGRAMAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PEMBERDAYAAN UMAT BERKELANJUTAN";
            // 
            // Formutama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnregist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnpelatihan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpeserta);
            this.Controls.Add(this.label1);
            this.Name = "Formutama";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpeserta;
        private System.Windows.Forms.Button btnpelatihan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

