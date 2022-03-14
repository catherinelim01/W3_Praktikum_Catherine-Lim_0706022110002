using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3_Praktikum_Catherine__Lim_0706022110002
{
    public partial class FormTampilanData : Form
    {
        public FormTampilanData()
        {
            InitializeComponent();

            textBoxNama2.Enabled = false;
            textBoxAlamat2.Enabled = false;
            textBoxTelpon2.Enabled = false;

            textBoxNama2.Text = FormPenambahanData.dataSimpan[hitung, 0];
            textBoxAlamat2.Text = FormPenambahanData.dataSimpan[hitung, 1];
            textBoxTelpon2.Text = FormPenambahanData.dataSimpan[hitung, 2];
        }
        
        public static int hitung = 0;

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormPenambahanData FormKembali = new FormPenambahanData();
            FormKembali.Show();
            this.Visible = false;
        }

        private void buttonNextData_Click(object sender, EventArgs e)
        {
            hitung++;

            if (hitung > (10 - 1))
            {
                hitung = 10;
                MessageBox.Show("Data Sudah Data Terakhir");
            }
            else if (FormPenambahanData.hitungIndex == hitung)
            {  
                MessageBox.Show("Data Sudah Data Terakhir");
                hitung = FormPenambahanData.hitungIndex - 1;
            }
            else
            {
                textBoxNama2.Text = FormPenambahanData.dataSimpan[hitung, 0];
                textBoxAlamat2.Text = FormPenambahanData.dataSimpan[hitung, 1];
                textBoxTelpon2.Text = FormPenambahanData.dataSimpan[hitung, 2];
            }
        }

        private void buttonPrevData_Click(object sender, EventArgs e)
        {
            hitung--;
            if (hitung < 0)
            {
                hitung = 0;
                MessageBox.Show("Data Sudah Data Pertama");
            }
            else
            {
                textBoxNama2.Text = FormPenambahanData.dataSimpan[hitung, 0];
                textBoxAlamat2.Text = FormPenambahanData.dataSimpan[hitung, 1];
                textBoxTelpon2.Text = FormPenambahanData.dataSimpan[hitung, 2];
            }
        }
    }
}
