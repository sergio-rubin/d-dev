namespace CalculoFormsApp
{
    partial class Form2
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
            this.EcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEcSimplify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnPegar = new System.Windows.Forms.Button();
            this.BtnMic = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EcTextBox
            // 
            this.EcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EcTextBox.ForeColor = System.Drawing.Color.Snow;
            this.EcTextBox.Location = new System.Drawing.Point(56, 69);
            this.EcTextBox.Name = "EcTextBox";
            this.EcTextBox.Size = new System.Drawing.Size(468, 27);
            this.EcTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa la ecuación que deseas resolver:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnEcSimplify
            // 
            this.BtnEcSimplify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnEcSimplify.FlatAppearance.BorderSize = 0;
            this.BtnEcSimplify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnEcSimplify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEcSimplify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEcSimplify.ForeColor = System.Drawing.Color.Snow;
            this.BtnEcSimplify.Location = new System.Drawing.Point(56, 125);
            this.BtnEcSimplify.Name = "BtnEcSimplify";
            this.BtnEcSimplify.Size = new System.Drawing.Size(100, 50);
            this.BtnEcSimplify.TabIndex = 2;
            this.BtnEcSimplify.Text = "Simplificar";
            this.BtnEcSimplify.UseVisualStyleBackColor = false;
            this.BtnEcSimplify.Click += new System.EventHandler(this.BtnEcSimplify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(56, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.ForeColor = System.Drawing.Color.Snow;
            this.AnswerLabel.Location = new System.Drawing.Point(56, 214);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(17, 20);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "0";
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.Gray;
            this.BtnCopiar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.copy_ico;
            this.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(417, 27);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(29, 29);
            this.BtnCopiar.TabIndex = 5;
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnPegar
            // 
            this.BtnPegar.BackColor = System.Drawing.Color.Gray;
            this.BtnPegar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.paste_ico;
            this.BtnPegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPegar.Location = new System.Drawing.Point(469, 27);
            this.BtnPegar.Name = "BtnPegar";
            this.BtnPegar.Size = new System.Drawing.Size(29, 29);
            this.BtnPegar.TabIndex = 6;
            this.BtnPegar.UseVisualStyleBackColor = false;
            this.BtnPegar.Click += new System.EventHandler(this.BtnPegar_Click);
            // 
            // BtnMic
            // 
            this.BtnMic.BackColor = System.Drawing.Color.Gray;
            this.BtnMic.BackgroundImage = global::CalculoFormsApp.Properties.Resources.mic_ico;
            this.BtnMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMic.Location = new System.Drawing.Point(442, 136);
            this.BtnMic.Name = "BtnMic";
            this.BtnMic.Size = new System.Drawing.Size(29, 29);
            this.BtnMic.TabIndex = 7;
            this.BtnMic.UseVisualStyleBackColor = false;
            this.BtnMic.Click += new System.EventHandler(this.BtnMic_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Gray;
            this.BtnStop.BackgroundImage = global::CalculoFormsApp.Properties.Resources.stop_ico;
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Location = new System.Drawing.Point(495, 136);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(29, 29);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnMic);
            this.Controls.Add(this.BtnPegar);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEcSimplify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EcTextBox);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EcTextBox;
        private Label label1;
        private Button BtnEcSimplify;
        private Label label2;
        private Label AnswerLabel;
        private Button BtnCopiar;
        private Button BtnPegar;
        private Button BtnMic;
        private Button BtnStop;
    }
}