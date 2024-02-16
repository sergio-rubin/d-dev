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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalSisEc_Click(object sender, EventArgs e)
        {
            #region 1
            double a1 = Convert.ToDouble(Ec1_a1.Text);
            double d1 = Convert.ToDouble(Ec1_d1.Text);
            double b1 = Convert.ToDouble(Ec1_b1.Text);
            double c1 = Convert.ToDouble(Ec1_c1.Text);
            #endregion

            #region 2
            double a2 = Convert.ToDouble(Ec2_a2.Text);
            double b2 = Convert.ToDouble(Ec2_b2.Text);
            double c2 = Convert.ToDouble(Ec2_c2.Text);
            double d2 = Convert.ToDouble(Ec2_d2.Text);
            #endregion

            #region 3
            double a3 = Convert.ToDouble(Ec3_a3.Text);
            double b3 = Convert.ToDouble(Ec3_b3.Text);
            double c3 = Convert.ToDouble(Ec3_c3.Text);
            double d3 = Convert.ToDouble(Ec3_d3.Text);
            #endregion

            double numerador_x = (d1 * b2 * c3 + d2 * b3 * c1 + d3 * b1 * c2) - (c1 * b2 * d3 + c2 * b3 * d1 + c3 * b1 * d2);
            double numerador_y = (a1 * d2 * c3 + a2 * d3 * c1 + a3 * d1 * c2) - (c1 * d2 * a3 + c2 * d3 * a1 + c3 * d1 * a2);
            double numerador_z = (a1 * b2 * d3 + a2 * b3 * d1 + a3 * b1 * d2) - (d1 * b2 * a3 + d2 * b3 * a1 + d3 * b1 * a2);
            double denominador_comun = (a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2) - (c1 * b2 * a3 + c2 * b3 * a1 + c3 * b1 * a2);

            AnswerLabel.Text = String.Format("x = {1} / {0} = {2}\ny = {3} / {0} = {4}\nz = {5} / {0} = {6}", denominador_comun, numerador_x, numerador_x / denominador_comun, numerador_y, numerador_y / denominador_comun, numerador_z, numerador_z / denominador_comun);
        }
    }
}
