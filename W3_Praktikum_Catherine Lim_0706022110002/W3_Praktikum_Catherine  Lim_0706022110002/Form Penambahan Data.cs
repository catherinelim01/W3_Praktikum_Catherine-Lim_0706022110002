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
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }

        public static string [,] dataSimpan = new string [10,3];
        public static int hitungIndex = 0;
        public static DataTable dataKu = new DataTable();

        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
            
        }

        public void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (hitungIndex > (10 - 1))
            {
                MessageBox.Show("Data telah penuh!");
            }
            else
            {
                dataSimpan[hitungIndex, 0] = textBoxNama1.Text;
                dataSimpan[hitungIndex, 1] = textBoxAlamat1.Text;
                dataSimpan[hitungIndex, 2] = textBoxTelpon1.Text;
            }

            textBoxNama1.Text = "";
            textBoxAlamat1.Text = "";
            textBoxTelpon1.Text = "";

            hitungIndex++;
        }
        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData FormData = new FormTampilanData();
            FormData.Show();
            this.Visible = false;

        }

        private void textBoxTelpon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
