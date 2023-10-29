namespace TugasPertemuan11.View
{
    partial class updatePeserta
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
            this.txtnotelppeserta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemailpeserta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamapeserta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidpeserta = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(252, 351);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtnotelppeserta
            // 
            this.txtnotelppeserta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnotelppeserta.Location = new System.Drawing.Point(119, 220);
            this.txtnotelppeserta.Name = "txtnotelppeserta";
            this.txtnotelppeserta.Size = new System.Drawing.Size(208, 20);
            this.txtnotelppeserta.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "NO. TELP";
            // 
            // txtemailpeserta
            // 
            this.txtemailpeserta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemailpeserta.Location = new System.Drawing.Point(119, 169);
            this.txtemailpeserta.Name = "txtemailpeserta";
            this.txtemailpeserta.Size = new System.Drawing.Size(208, 20);
            this.txtemailpeserta.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "E-MAIL";
            // 
            // txtnamapeserta
            // 
            this.txtnamapeserta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnamapeserta.Location = new System.Drawing.Point(119, 124);
            this.txtnamapeserta.Name = "txtnamapeserta";
            this.txtnamapeserta.Size = new System.Drawing.Size(208, 20);
            this.txtnamapeserta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NAMA";
            // 
            // txtidpeserta
            // 
            this.txtidpeserta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidpeserta.Location = new System.Drawing.Point(119, 77);
            this.txtidpeserta.Name = "txtidpeserta";
            this.txtidpeserta.Size = new System.Drawing.Size(208, 20);
            this.txtidpeserta.TabIndex = 12;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(43, 351);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // updatePeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(366, 450);
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
            this.Name = "updatePeserta";
            this.Text = "updatePeserta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtnotelppeserta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemailpeserta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnamapeserta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidpeserta;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
    }
}