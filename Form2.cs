using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.Diagnostics;
using System.IO;

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Speech;


namespace CalculoFormsApp
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEcSimplify_Click(object sender, EventArgs e)
        {
            using Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            //Set the process start by using relative path
            process.StartInfo.FileName = "EcSimplifier.exe";

            //Dont create a window
            process.StartInfo.CreateNoWindow = true;

            String ecuacion = EcTextBox.Text.Replace(" ", "");
            String args = "S " + ecuacion;
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

        /*private void PythonEcuationSimplifier()
        {
            String ecuacion = EcTextBox.Text.Replace(" ", "");
            String pathPython = @"C:\Users\ZomserchXD\OneDrive - Benemérita Universidad Autónoma de Puebla\Proyecto de Cálculo (App)\CalculoFormsApp\EcSimplifier.py";

            var runtime = Python.CreateRuntime();
            var engine = runtime.GetEngine("python");
            var scope = engine.CreateScope();

            try
            {
                scope.ImportModule("sys");
                dynamic pyProgram = runtime.UseFile(pathPython);
                var result = pyProgram.simplificar(ecuacion);

                AnswerLabel.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {
            BtnMic.Enabled = true;
            BtnStop.Enabled = false;
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

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        public Choices clist;

        private void BtnMic_Click(object sender, EventArgs e)
        {
            BtnMic.Enabled = false;
            BtnMic.Text = "Escuchando...";
            ss.Speak("Escuchando...");
            BtnStop.Enabled = true;
            
            //reiniciar la lista de palabras
            clist = new Choices();
            sre.UnloadAllGrammars();

            String[] choices = { "más", "menos", "por", "entre", "paréntesis abierto", "paréntesis cerrado", "elevado", "potencia", "raíz", 
                "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "cero", 
                "equis", "euler", "seno", "coseno", "tangente", "secante", "cosecante", "cotangente", "pi", 
                "logaritmo", "logaritmo natural", "espacio", "borrar", "borar todo", "listo", "derecha", "izquierda" };
            clist.Add(choices);

            GrammarBuilder gb = new GrammarBuilder();
            
            gb.Culture = new System.Globalization.CultureInfo("es-ES"); 
            gb.Append(clist);

            Grammar gr = new Grammar(gb);
            
            try
            {
                
                sre.RequestRecognizerUpdate();
                sre.LoadGrammarAsync(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "más":
                    EcTextBox.Text += "+";
                    break;
                case "menos":
                    EcTextBox.Text += "-";
                    break;
                case "por":
                    EcTextBox.Text += "*";
                    break;
                case "entre":
                    EcTextBox.Text += "/";
                    break;
                case "paréntesis abierto":
                    EcTextBox.Text += "(";
                    break;
                case "paréntesis cerrado":
                    EcTextBox.Text += ")";
                    break;
                case "elevado":
                    EcTextBox.Text += "**";
                    break;
                case "potencia":
                    EcTextBox.Text += "**";
                    break;
                case "raíz":
                    EcTextBox.Text += "sqrt(";
                    break;
                case "uno":
                    EcTextBox.Text += "1";
                    break;
                case "dos":
                    EcTextBox.Text += "2";
                    break;
                case "tres":
                    EcTextBox.Text += "3";
                    break;
                case "cuatro":
                    EcTextBox.Text += "4";
                    break;
                case "cinco":
                    EcTextBox.Text += "5";
                    break;
                case "seis":
                    EcTextBox.Text += "6";
                    break;
                case "siete":
                    EcTextBox.Text += "7";
                    break;
                case "ocho":
                    EcTextBox.Text += "8";
                    break;
                case "nueve":
                    EcTextBox.Text += "9";
                    break;
                case "cero":
                    EcTextBox.Text += "0";
                    break;
                case "equis":
                    EcTextBox.Text += "x";
                    break;
                case "euler":
                    EcTextBox.Text += "e";
                    break;
                case "seno":
                    EcTextBox.Text += "sin(";
                    break;
                case "coseno":
                    EcTextBox.Text += "cos(";
                    break;
                case "tangente":
                    EcTextBox.Text += "tan(";
                    break;
                case "secante":
                    EcTextBox.Text += "sec(";
                    break;
                case "cosecante":
                    EcTextBox.Text += "csc(";
                    break;
                case "cotangente":
                    EcTextBox.Text += "cot(";
                    break;
                case "pi":
                    EcTextBox.Text += "pi";
                    break;
                case "logaritmo":
                    EcTextBox.Text += "log(";
                    break;
                case "logaritmo natural":
                    EcTextBox.Text += "ln(";
                    break;
                case "espacio":
                    EcTextBox.Text += " ";
                    break;
                case "borrar":

                    //borrar el ultimo caracter
                    if (EcTextBox.Text.Length > 0)
                    {
                        EcTextBox.Text = EcTextBox.Text.Remove(EcTextBox.Text.Length - 1, 1);
                    }
                    break;
                case "borar todo":

                    //borrar todo el texto
                    EcTextBox.Text = "";
                    break;
                case "listo":

                    //detener el reconocimiento de voz
                    sre.RecognizeAsyncStop();
                    
                    //llamar al metodo que evalua la expresion por medio del boton BtnEcSimplify
                    BtnEcSimplify_Click(sender, e);

                    BtnMic.Enabled = true;
                    BtnStop.Enabled = false;

                    //Reiniciar la gramatica
                    clist = new Choices();

                    ss.Speak("Obteniendo el resultado...");
                    break;
                case "derecha":

                    //mover el cursor a la derecha del caracter actual
                    EcTextBox.SelectionStart = EcTextBox.Text.Length;
                    break;
                case "izquierda":
                    //mover el cursor a la izquierda del ultimo caracter
                    try
                    {
                        EcTextBox.SelectionStart = EcTextBox.Text.Length - 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //detener el reconocimiento de voz
            try
            {
                BtnMic.Enabled = true;
                BtnStop.Enabled = false;
                sre.RecognizeAsyncStop();

                //Reiniciar la gramatica
                clist = new Choices();

                ss.Speak("Obteniendo el resultado...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
