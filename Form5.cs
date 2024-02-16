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
using IronPython.Hosting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Interpolation;
using Symbolism;
using MathNet.Symbolics;

namespace CalculoFormsApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnGra_Click(object sender, EventArgs e)
        {
            
            String funcion = ExpTextBox.Text.Replace(" ", "");

            //Create a graph with ZedGraph
            ZedGraphControl zedGraphControl1 = new ZedGraphControl();
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Grafica de la funcion";
            myPane.XAxis.Title.Text = "X";
            myPane.YAxis.Title.Text = "Y";

            //Costumize the deign of the graph
            myPane.XAxis.Scale.Min = -10;
            myPane.XAxis.Scale.Max = 10;
            myPane.YAxis.Scale.Min = -10;
            myPane.YAxis.Scale.Max = 10;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            
            //Colors of the graph
            myPane.Chart.Fill = new Fill(Color.Snow);
            myPane.Fill = new Fill(Color.Snow);

            //Size of the graph based onthe size of the panel
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.Size = GraphPanel.Size;
            zedGraphControl1.GraphPane = myPane;

            //Colorize the outline of the graph and the axis
            myPane.Border.Color = Color.FromArgb(35, 32, 39);
            myPane.XAxis.Color = Color.FromArgb(35, 32, 39);
            myPane.YAxis.Color = Color.FromArgb(35, 32, 39);

            //Generate the list of points doing the evaluation of the function in the range of -10 to 10
            PointPairList list = new PointPairList();
            for (double x = -10; x <= 10; x += 0.1)
            {
                var engine = Python.CreateEngine();
                var scope = engine.CreateScope();

                //Add trigonometric functions to be available in the evaluation of the function
                scope.SetVariable("sin", new Func<double, double>(Math.Sin));
                scope.SetVariable("cos", new Func<double, double>(Math.Cos));
                scope.SetVariable("tan", new Func<double, double>(Math.Tan));
                scope.SetVariable("asin", new Func<double, double>(Math.Asin));
                scope.SetVariable("acos", new Func<double, double>(Math.Acos));
                scope.SetVariable("atan", new Func<double, double>(Math.Atan));
                scope.SetVariable("sinh", new Func<double, double>(Math.Sinh));
                scope.SetVariable("cosh", new Func<double, double>(Math.Cosh));
                scope.SetVariable("tanh", new Func<double, double>(Math.Tanh));
                scope.SetVariable("asinh", new Func<double, double>(Math.Asinh));
                scope.SetVariable("acosh", new Func<double, double>(Math.Acosh));
                scope.SetVariable("atanh", new Func<double, double>(Math.Atanh));
                scope.SetVariable("log", new Func<double, double>(Math.Log));
                scope.SetVariable("log10", new Func<double, double>(Math.Log10));
                scope.SetVariable("log2", new Func<double, double>(Math.Log2));
                scope.SetVariable("exp", new Func<double, double>(Math.Exp));
                scope.SetVariable("sqrt", new Func<double, double>(Math.Sqrt));
                scope.SetVariable("abs", new Func<double, double>(Math.Abs));
                scope.SetVariable("pi", Math.PI);
                scope.SetVariable("e", Math.E);

                scope.SetVariable("x", x);
                var result = engine.Execute<double>(funcion, scope);
                list.Add(x, result);
            }
            //Show numbers in the axis of the graph
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.MajorStep = 1;

            //Add the list of points to the pane with the funciont "funcion"
            LineItem myCurve = myPane.AddCurve(funcion, list, Color.Red, SymbolType.None);

            //Generate the graph
            zedGraphControl1.AxisChange();

            //Convert the graph to a image
            Bitmap bmp = myPane.GetImage();

            //Show the image in the panel
            GraphPanel.BackgroundImage = bmp;

            //Make the image to not repeat
            GraphPanel.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
            //Try to evaluate the function with the value of XTextBox and show the result in YTextBox if it is possible
            try
            {
                EvaluateFunctionAndReplaceInY(ExpTextBox.Text.Replace(" ", ""));
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede evaluar la funcion.");
            }
        }

        private void EvaluateFunctionAndReplaceInY(String funcion)
        {
            funcion = ExpTextBox.Text.Replace(" ", "");

            //Fill the text box YTextBox with the result of the evaluation of the function in the point XTextBox
            var engine4 = Python.CreateEngine();
            var scope4 = engine4.CreateScope();
            scope4.SetVariable("x", Convert.ToDouble(XTextBox.Text));

            scope4.SetVariable("sin", new Func<double, double>(Math.Sin));
            scope4.SetVariable("cos", new Func<double, double>(Math.Cos));
            scope4.SetVariable("tan", new Func<double, double>(Math.Tan));
            scope4.SetVariable("asin", new Func<double, double>(Math.Asin));
            scope4.SetVariable("acos", new Func<double, double>(Math.Acos));
            scope4.SetVariable("atan", new Func<double, double>(Math.Atan));
            scope4.SetVariable("sinh", new Func<double, double>(Math.Sinh));
            scope4.SetVariable("cosh", new Func<double, double>(Math.Cosh));
            scope4.SetVariable("tanh", new Func<double, double>(Math.Tanh));
            scope4.SetVariable("asinh", new Func<double, double>(Math.Asinh));
            scope4.SetVariable("acosh", new Func<double, double>(Math.Acosh));
            scope4.SetVariable("atanh", new Func<double, double>(Math.Atanh));
            scope4.SetVariable("log", new Func<double, double>(Math.Log));
            scope4.SetVariable("log10", new Func<double, double>(Math.Log10));
            scope4.SetVariable("log2", new Func<double, double>(Math.Log2));
            scope4.SetVariable("exp", new Func<double, double>(Math.Exp));
            scope4.SetVariable("sqrt", new Func<double, double>(Math.Sqrt));
            scope4.SetVariable("abs", new Func<double, double>(Math.Abs));
            scope4.SetVariable("pi", Math.PI);
            scope4.SetVariable("e", Math.E);

            var result4 = engine4.Execute<double>(funcion, scope4);
            YLabel.Text = result4.ToString();
        }

        private void BtnPegar_Click(object sender, EventArgs e)
        {
            //Pegar el contenido del portapapeles en el textbox de la funcion
            ExpTextBox.Text = Clipboard.GetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //intentar descargar la grafica en un archivo png
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PNG Image|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    if (GraphPanel.BackgroundImage != null)
                    {
                        GraphPanel.BackgroundImage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else
                    {
                        MessageBox.Show("No hay grafica para guardar.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar la imagen.");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
