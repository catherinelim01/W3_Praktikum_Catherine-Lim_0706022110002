
namespace W3_Praktikum_Catherine__Lim_0706022110002
{
    partial class FormPenambahanData
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihatData = new System.Windows.Forms.Button();
            this.labelNama1 = new System.Windows.Forms.Label();
            this.labelAlamat1 = new System.Windows.Forms.Label();
            this.labelTelpon1 = new System.Windows.Forms.Label();
            this.textBoxNama1 = new System.Windows.Forms.TextBox();
            this.textBoxAlamat1 = new System.Windows.Forms.TextBox();
            this.textBoxTelpon1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSimpan.Location = new System.Drawing.Point(33, 128);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(91, 34);
            this.buttonSimpan.TabIndex = 0;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihatData
            // 
            this.buttonLihatData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatData.Location = new System.Drawing.Point(285, 128);
            this.buttonLihatData.Name = "buttonLihatData";
            this.buttonLihatData.Size = new System.Drawing.Size(98, 34);
            this.buttonLihatData.TabIndex = 1;
            this.buttonLihatData.Text = "Lihat Data";
            this.buttonLihatData.UseVisualStyleBackColor = true;
            this.buttonLihatData.Click += new System.EventHandler(this.buttonLihatData_Click);
            // 
            // labelNama1
            // 
            this.labelNama1.AutoSize = true;
            this.labelNama1.Location = new System.Drawing.Point(29, 25);
            this.labelNama1.Name = "labelNama1";
            this.labelNama1.Size = new System.Drawing.Size(63, 20);
            this.labelNama1.TabIndex = 2;
            this.labelNama1.Text = "Nama  :";
            // 
            // labelAlamat1
            // 
            this.labelAlamat1.AutoSize = true;
            this.labelAlamat1.Location = new System.Drawing.Point(29, 57);
            this.labelAlamat1.Name = "labelAlamat1";
            this.labelAlamat1.Size = new System.Drawing.Size(63, 20);
            this.labelAlamat1.TabIndex = 3;
            this.labelAlamat1.Text = "Alamat:";
            // 
            // labelTelpon1
            // 
            this.labelTelpon1.AutoSize = true;
            this.labelTelpon1.Location = new System.Drawing.Point(29, 89);
            this.labelTelpon1.Name = "labelTelpon1";
            this.labelTelpon1.Size = new System.Drawing.Size(61, 20);
            this.labelTelpon1.TabIndex = 4;
            this.labelTelpon1.Text = "Telpon:";
            // 
            // textBoxNama1
            // 
            this.textBoxNama1.Location = new System.Drawing.Point(106, 19);
            this.textBoxNama1.Name = "textBoxNama1";
            this.textBoxNama1.Size = new System.Drawing.Size(277, 26);
            this.textBoxNama1.TabIndex = 5;
            // 
            // textBoxAlamat1
            // 
            this.textBoxAlamat1.Location = new System.Drawing.Point(106, 51);
            this.textBoxAlamat1.Name = "textBoxAlamat1";
            this.textBoxAlamat1.Size = new System.Drawing.Size(277, 26);
            this.textBoxAlamat1.TabIndex = 5;
            // 
            // textBoxTelpon1
            // 
            this.textBoxTelpon1.Location = new System.Drawing.Point(106, 83);
            this.textBoxTelpon1.Name = "textBoxTelpon1";
            this.textBoxTelpon1.Size = new System.Drawing.Size(145, 26);
            this.textBoxTelpon1.TabIndex = 5;
            this.textBoxTelpon1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelpon1_KeyPress);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 197);
            this.Controls.Add(this.textBoxTelpon1);
            this.Controls.Add(this.textBoxAlamat1);
            this.Controls.Add(this.textBoxNama1);
            this.Controls.Add(this.labelTelpon1);
            this.Controls.Add(this.labelAlamat1);
            this.Controls.Add(this.labelNama1);
            this.Controls.Add(this.buttonLihatData);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonLihatData;
        private System.Windows.Forms.Label labelNama1;
        private System.Windows.Forms.Label labelAlamat1;
        private System.Windows.Forms.Label labelTelpon1;
        private System.Windows.Forms.TextBox textBoxNama1;
        private System.Windows.Forms.TextBox textBoxAlamat1;
        private System.Windows.Forms.TextBox textBoxTelpon1;
    }
}

