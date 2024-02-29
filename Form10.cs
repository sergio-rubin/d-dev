using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.AI.OpenAI;

namespace CalculoFormsApp
{
    public partial class Form10 : Form
    {
        OpenAIClient client = new OpenAIClient("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");

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private async void BtnEcSimplify_Click(object sender, EventArgs e)
        {
            CompletionsOptions options = new CompletionsOptions();
            options.DeploymentName = "gpt-3.5-turbo-instruct-0914";
            options.Prompts.Add("Resuelve el siguiente problema usando técnicas de conteo. Solo dame fórmula y resultado. " + EcTextBox.Text);
            options.MaxTokens = 100;
            options.Temperature = 1;

            var openAiResponse = await client.GetCompletionsAsync(options);

            foreach (var choice in openAiResponse.Value.Choices)
            {
                AnswerLabel.Text = choice.Text;
            }
        }
    }
}
