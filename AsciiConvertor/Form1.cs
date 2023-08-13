using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int index = 0;
            string inputtxt = txtTwo.Text;
            string printTxt = "";
            string txt = "";
            // Convert the string to ASCII
            byte[] asciiBytes = Encoding.ASCII.GetBytes(txtTwo.Text);
            if (chkBox.Checked)
            {
                foreach (byte b in asciiBytes)
                {
                    txt += lblOne.Text + "  P" + ($"{b}") + Environment.NewLine;
                }
                txtThree.Text = txt;
            }
            else {
                foreach (byte b in asciiBytes)
                {
                    if (($"{b}").Equals("32", StringComparison.OrdinalIgnoreCase))
                    {
                        printTxt = "space";
                        index++;
                    }
                    else {
                        printTxt = inputtxt[index++]+"";
                    }
                    txt += lblOne.Text + "  P" + ($"{b}") + "(" + printTxt + ")" + Environment.NewLine;
                }
                txtThree.Text = txt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                    string filePath = "E:\\My New Creation\\final.txt";
                    string textToSave = txtThree.Text;

                    File.WriteAllText(filePath, textToSave);

                    MessageBox.Show("File saved successfully.");
             
            }
        }
    }
}
