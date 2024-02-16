namespace CalculoFormsApp
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VarTextBox = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalDerEx = new System.Windows.Forms.Button();
            this.BtnPegar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce la expresión a derivar:";
            // 
            // EcTextBox
            // 
            this.EcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EcTextBox.ForeColor = System.Drawing.Color.Snow;
            this.EcTextBox.Location = new System.Drawing.Point(43, 69);
            this.EcTextBox.Name = "EcTextBox";
            this.EcTextBox.Size = new System.Drawing.Size(479, 27);
            this.EcTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Derivar con respecto a:";
            // 
            // VarTextBox
            // 
            this.VarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.VarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VarTextBox.ForeColor = System.Drawing.Color.Snow;
            this.VarTextBox.Location = new System.Drawing.Point(251, 117);
            this.VarTextBox.Name = "VarTextBox";
            this.VarTextBox.Size = new System.Drawing.Size(94, 27);
            this.VarTextBox.TabIndex = 3;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.ForeColor = System.Drawing.Color.Snow;
            this.AnswerLabel.Location = new System.Drawing.Point(43, 203);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(17, 20);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(43, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // BtnCalDerEx
            // 
            this.BtnCalDerEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnCalDerEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalDerEx.ForeColor = System.Drawing.Color.Snow;
            this.BtnCalDerEx.Location = new System.Drawing.Point(422, 117);
            this.BtnCalDerEx.Name = "BtnCalDerEx";
            this.BtnCalDerEx.Size = new System.Drawing.Size(100, 40);
            this.BtnCalDerEx.TabIndex = 6;
            this.BtnCalDerEx.Text = "Calcular";
            this.BtnCalDerEx.UseVisualStyleBackColor = false;
            this.BtnCalDerEx.Click += new System.EventHandler(this.BtnCalDerEx_Click);
            // 
            // BtnPegar
            // 
            this.BtnPegar.BackColor = System.Drawing.Color.Gray;
            this.BtnPegar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.paste_ico;
            this.BtnPegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPegar.Location = new System.Drawing.Point(493, 33);
            this.BtnPegar.Name = "BtnPegar";
            this.BtnPegar.Size = new System.Drawing.Size(29, 29);
            this.BtnPegar.TabIndex = 11;
            this.BtnPegar.UseVisualStyleBackColor = false;
            this.BtnPegar.Click += new System.EventHandler(this.BtnPegar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.Gray;
            this.BtnCopiar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.copy_ico;
            this.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(441, 33);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(29, 29);
            this.BtnCopiar.TabIndex = 10;
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.BtnPegar);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.BtnCalDerEx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.VarTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EcTextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox EcTextBox;
        private Label label2;
        private TextBox VarTextBox;
        private Label AnswerLabel;
        private Label label4;
        private Button BtnCalDerEx;
        private Button BtnPegar;
        private Button BtnCopiar;
    }
}