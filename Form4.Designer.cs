namespace CalculoFormsApp
{
    partial class Form4
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
            this.NumLim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VarLim = new System.Windows.Forms.TextBox();
            this.BtnCalLimEc = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.BtnPegar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la expresión de la que quieres sacar el límite:";
            // 
            // EcTextBox
            // 
            this.EcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EcTextBox.ForeColor = System.Drawing.Color.Snow;
            this.EcTextBox.Location = new System.Drawing.Point(42, 77);
            this.EcTextBox.Name = "EcTextBox";
            this.EcTextBox.Size = new System.Drawing.Size(465, 27);
            this.EcTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el número al que va a tender el límite:";
            // 
            // NumLim
            // 
            this.NumLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.NumLim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLim.ForeColor = System.Drawing.Color.Snow;
            this.NumLim.Location = new System.Drawing.Point(426, 132);
            this.NumLim.Name = "NumLim";
            this.NumLim.Size = new System.Drawing.Size(81, 27);
            this.NumLim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese la variable de la cual se va a obtener el límite:";
            // 
            // VarLim
            // 
            this.VarLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.VarLim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VarLim.ForeColor = System.Drawing.Color.Snow;
            this.VarLim.Location = new System.Drawing.Point(458, 181);
            this.VarLim.Name = "VarLim";
            this.VarLim.Size = new System.Drawing.Size(49, 27);
            this.VarLim.TabIndex = 5;
            // 
            // BtnCalLimEc
            // 
            this.BtnCalLimEc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnCalLimEc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalLimEc.Location = new System.Drawing.Point(42, 226);
            this.BtnCalLimEc.Name = "BtnCalLimEc";
            this.BtnCalLimEc.Size = new System.Drawing.Size(100, 50);
            this.BtnCalLimEc.TabIndex = 6;
            this.BtnCalLimEc.Text = "Calcular";
            this.BtnCalLimEc.UseVisualStyleBackColor = false;
            this.BtnCalLimEc.Click += new System.EventHandler(this.BtnCalLimEc_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(42, 296);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(17, 20);
            this.AnswerLabel.TabIndex = 7;
            this.AnswerLabel.Text = "0";
            // 
            // BtnPegar
            // 
            this.BtnPegar.BackColor = System.Drawing.Color.Gray;
            this.BtnPegar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.paste_ico;
            this.BtnPegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPegar.Location = new System.Drawing.Point(522, 27);
            this.BtnPegar.Name = "BtnPegar";
            this.BtnPegar.Size = new System.Drawing.Size(29, 29);
            this.BtnPegar.TabIndex = 9;
            this.BtnPegar.UseVisualStyleBackColor = false;
            this.BtnPegar.Click += new System.EventHandler(this.BtnPegar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.Gray;
            this.BtnCopiar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.copy_ico;
            this.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(470, 27);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(29, 29);
            this.BtnCopiar.TabIndex = 8;
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.BtnPegar);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.BtnCalLimEc);
            this.Controls.Add(this.VarLim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumLim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EcTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox EcTextBox;
        private Label label2;
        private TextBox NumLim;
        private Label label3;
        private TextBox VarLim;
        private Button BtnCalLimEc;
        private Label AnswerLabel;
        private Button BtnPegar;
        private Button BtnCopiar;
    }
}