
namespace W3_Praktikum_Catherine__Lim_0706022110002
{
    partial class FormTampilanData
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
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.labelNama2 = new System.Windows.Forms.Label();
            this.labelAlamat2 = new System.Windows.Forms.Label();
            this.labelTelpon2 = new System.Windows.Forms.Label();
            this.textBoxNama2 = new System.Windows.Forms.TextBox();
            this.textBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.textBoxTelpon2 = new System.Windows.Forms.TextBox();
            this.buttonPrevData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKembali.Location = new System.Drawing.Point(33, 136);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(93, 37);
            this.buttonKembali.TabIndex = 0;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonNextData
            // 
            this.buttonNextData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextData.Location = new System.Drawing.Point(285, 136);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(90, 37);
            this.buttonNextData.TabIndex = 1;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            this.buttonNextData.Click += new System.EventHandler(this.buttonNextData_Click);
            // 
            // labelNama2
            // 
            this.labelNama2.AutoSize = true;
            this.labelNama2.Location = new System.Drawing.Point(29, 25);
            this.labelNama2.Name = "labelNama2";
            this.labelNama2.Size = new System.Drawing.Size(63, 20);
            this.labelNama2.TabIndex = 2;
            this.labelNama2.Text = "Nama  :";
            // 
            // labelAlamat2
            // 
            this.labelAlamat2.AutoSize = true;
            this.labelAlamat2.Location = new System.Drawing.Point(29, 57);
            this.labelAlamat2.Name = "labelAlamat2";
            this.labelAlamat2.Size = new System.Drawing.Size(63, 20);
            this.labelAlamat2.TabIndex = 3;
            this.labelAlamat2.Text = "Alamat:";
            // 
            // labelTelpon2
            // 
            this.labelTelpon2.AutoSize = true;
            this.labelTelpon2.Location = new System.Drawing.Point(29, 89);
            this.labelTelpon2.Name = "labelTelpon2";
            this.labelTelpon2.Size = new System.Drawing.Size(61, 20);
            this.labelTelpon2.TabIndex = 4;
            this.labelTelpon2.Text = "Telpon:";
            // 
            // textBoxNama2
            // 
            this.textBoxNama2.Location = new System.Drawing.Point(98, 19);
            this.textBoxNama2.Name = "textBoxNama2";
            this.textBoxNama2.Size = new System.Drawing.Size(277, 26);
            this.textBoxNama2.TabIndex = 5;
            // 
            // textBoxAlamat2
            // 
            this.textBoxAlamat2.Location = new System.Drawing.Point(98, 51);
            this.textBoxAlamat2.Name = "textBoxAlamat2";
            this.textBoxAlamat2.Size = new System.Drawing.Size(277, 26);
            this.textBoxAlamat2.TabIndex = 6;
            // 
            // textBoxTelpon2
            // 
            this.textBoxTelpon2.Location = new System.Drawing.Point(98, 86);
            this.textBoxTelpon2.Name = "textBoxTelpon2";
            this.textBoxTelpon2.Size = new System.Drawing.Size(145, 26);
            this.textBoxTelpon2.TabIndex = 7;
            // 
            // buttonPrevData
            // 
            this.buttonPrevData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevData.Location = new System.Drawing.Point(192, 136);
            this.buttonPrevData.Name = "buttonPrevData";
            this.buttonPrevData.Size = new System.Drawing.Size(87, 37);
            this.buttonPrevData.TabIndex = 8;
            this.buttonPrevData.Text = "Prev Data";
            this.buttonPrevData.UseVisualStyleBackColor = true;
            this.buttonPrevData.Click += new System.EventHandler(this.buttonPrevData_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 203);
            this.Controls.Add(this.buttonPrevData);
            this.Controls.Add(this.textBoxTelpon2);
            this.Controls.Add(this.textBoxAlamat2);
            this.Controls.Add(this.textBoxNama2);
            this.Controls.Add(this.labelTelpon2);
            this.Controls.Add(this.labelAlamat2);
            this.Controls.Add(this.labelNama2);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.buttonKembali);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonNextData;
        private System.Windows.Forms.Label labelNama2;
        private System.Windows.Forms.Label labelAlamat2;
        private System.Windows.Forms.Label labelTelpon2;
        private System.Windows.Forms.TextBox textBoxNama2;
        private System.Windows.Forms.TextBox textBoxAlamat2;
        private System.Windows.Forms.TextBox textBoxTelpon2;
        private System.Windows.Forms.Button buttonPrevData;
    }
}