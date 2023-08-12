using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiConvertor
{
    public partial class AsciiCovertor : Form
    {
        public AsciiCovertor()
        {
            InitializeComponent();
            lblOne.Text = txtOne.Text.Trim();
        }

        private void AsciiCovertor_Load(object sender, EventArgs e)
        {

        }

        private void txtOneChange(object sender, EventArgs e)
        {
            lblOne.Text = txtOne.Text;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string txt = "";
            // Convert the string to ASCII
            byte[] asciiBytes = Encoding.ASCII.GetBytes(txtTwo.Text);
            foreach (byte b in asciiBytes)
            {
                txt += lblOne.Text + "  p" +($"{b}")+Environment.NewLine;
            }
            txtThree.Text = txt;
        }
    }
}
