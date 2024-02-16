using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFormsApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalDerEx_Click(object sender, EventArgs e)
        {
            using Process process = new Process();

            //Set the process start by using relative path
            process.StartInfo.FileName = "EcSimplifier.exe";

            //Dont create a window
            process.StartInfo.CreateNoWindow = true;

            String ecuacion = EcTextBox.Text.Replace(" ", "");
            String variable = VarTextBox.Text;

            String args = "D " + variable + " " + ecuacion;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            //Start the process
            process.Start();

            StreamReader reader = process.StandardOutput;
            String result = reader.ReadToEnd();
            process.WaitForExit();

            AnswerLabel.Text = result;
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            //Copiar el resultado al portapapeles
            Clipboard.SetText(AnswerLabel.Text);
        }

        private void BtnPegar_Click(object sender, EventArgs e)
        {
            //Pegar el contenido del portapapeles en el textbox
            EcTextBox.Text = Clipboard.GetText();
        }
    }
}
