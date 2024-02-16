using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net; // Para usar la clase WebClient
using System.IO; // Para usar la clase StreamReader

using System.Diagnostics; // Para usar la clase Process
using EO.WebBrowser;



namespace CalculoFormsApp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            //Create the object of a web browser using EO.WebBrowser and then fill the form with it
            EO.WebBrowser.WebView webView = new EO.WebBrowser.WebView();
            webView.Create(this.Handle);
            webView.Url = "https://chat.openai.com/";
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            

        }
    }
}
