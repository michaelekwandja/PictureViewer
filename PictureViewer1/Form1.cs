using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
