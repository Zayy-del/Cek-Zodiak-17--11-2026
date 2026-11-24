using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class aplikasizodiak : Form
    {
        public aplikasizodiak()
        {
            InitializeComponent();
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int bulan = Convert.ToInt32(txtBulan.Text);
            int tanggal = Convert.ToInt32(txtTanggal.Text);
            Convert.ToInt32(txtTanggal.Text);

            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
            {
                txtHasil.Text = "Aquarius";
            }
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
            {
                txtHasil.Text = "Pisces";
            }
            else if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
            {
                txtHasil.Text = "Aries";
            }
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
            {
                txtHasil.Text = "Taurus";
            }
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
            {
                txtHasil.Text = "Gemini";
            }
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
            {
                txtHasil.Text = "Cancer";
            }
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
            {
                txtHasil.Text = "Leo";
            }
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
            {
                txtHasil.Text = "Virgo";
            }
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
            {
                txtHasil.Text = "Libra";
            }
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
            {
                txtHasil.Text = "Scorpio";
            }
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
            {
                txtHasil.Text = "Sagittarius";
            }
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
            {
                txtHasil.Text = "Capricorn";
            }

            else
            {
                txtHasil.Text = "Tanggal atau bulan tidak valid";
            }
        }
    }
}
