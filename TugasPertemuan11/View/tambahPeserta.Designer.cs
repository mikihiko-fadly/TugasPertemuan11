namespace TugasPertemuan11.View
{
    partial class tambahPeserta
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
            this.btnsave = new System.Windows.Forms.Button();
            this.txtidpeserta = new System.Windows.Forms.TextBox();
            this.txtnamapeserta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemailpeserta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotelppeserta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(60, 357);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtidpeserta
            // 
            this.txtidpeserta.Location = new System.Drawing.Point(136, 83);
            this.txtidpeserta.Name = "txtidpeserta";
            this.txtidpeserta.Size = new System.Drawing.Size(208, 20);
            this.txtidpeserta.TabIndex = 2;
            // 
            // txtnamapeserta
            // 
            this.txtnamapeserta.Location = new System.Drawing.Point(136, 130);
            this.txtnamapeserta.Name = "txtnamapeserta";
            this.txtnamapeserta.Size = new System.Drawing.Size(208, 20);
            this.txtnamapeserta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAMA";
            // 
            // txtemailpeserta
            // 
            this.txtemailpeserta.Location = new System.Drawing.Point(136, 175);
            this.txtemailpeserta.Name = "txtemailpeserta";
            this.txtemailpeserta.Size = new System.Drawing.Size(208, 20);
            this.txtemailpeserta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-MAIL";
            // 
            // txtnotelppeserta
            // 
            this.txtnotelppeserta.Location = new System.Drawing.Point(136, 226);
            this.txtnotelppeserta.Name = "txtnotelppeserta";
            this.txtnotelppeserta.Size = new System.Drawing.Size(208, 20);
            this.txtnotelppeserta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NO. TELP";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(234, 357);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tambahPeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtnotelppeserta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemailpeserta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnamapeserta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidpeserta);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Name = "tambahPeserta";
            this.Text = "tambahPeserta";
            this.Load += new System.EventHandler(this.tambahPeserta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.TextBox txtidpeserta;
        public System.Windows.Forms.TextBox txtnamapeserta;
        public System.Windows.Forms.TextBox txtemailpeserta;
        public System.Windows.Forms.TextBox txtnotelppeserta;
    }
}