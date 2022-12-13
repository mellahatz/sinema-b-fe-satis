using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satiş_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, çay, su, toplam;
            mısır = Convert.ToInt16(TxtMisir.Text);
            bilet=Convert.ToInt16(TxtBilet.Text);
            çay = Convert.ToInt16(TxtÇay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            toplam = mısır * 4 + bilet * 8 + çay * 2 + su * 1;
            LblToplam.Text = toplam.ToString() + "TL" ;
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + "TL";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtÇay.Text = "";
            TxtSu.Text = "";
            TxtMisir.Text = "";
            TxtMisir.Focus();

        }
    }
}
