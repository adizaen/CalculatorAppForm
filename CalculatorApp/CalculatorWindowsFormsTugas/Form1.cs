using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsTugas
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            cbOperasi.Items.Add("Penambahan");
            cbOperasi.Items.Add("Pengurangan");
            cbOperasi.Items.Add("Perkalian");
            cbOperasi.Items.Add("Pembagian");
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            int index = cbOperasi.SelectedIndex;
            switch(index)
            {
                case 0:
                    txtHasil.Text = Penambahan(a, b).ToString();
                    break;
                case 1:
                    txtHasil.Text = Pengurangan(a, b).ToString();
                    break;
                case 2:
                    txtHasil.Text = Perkalian(a, b).ToString();
                    break;
                case 3:
                    txtHasil.Text = Pembagian(a, b).ToString();
                    break;
            }
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
