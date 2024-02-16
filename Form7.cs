using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFormsApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Copy link to clipboard
            Clipboard.SetText("https://www.instagram.com/los_hijos_de_hades/");

            //Send message to user
            MessageBox.Show("Link Copied to Clipboard");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Copy link to clipboard
            Clipboard.SetText("https://www.facebook.com/profile.php?id=100081220722174&sk=about");

            //send message to user
            MessageBox.Show("Link Copied to Clipboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
