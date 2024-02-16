namespace CalculoFormsApp
{
    partial class Form5
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
            this.ExpTextBox = new System.Windows.Forms.TextBox();
            this.BtnGra = new System.Windows.Forms.Button();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEvaluar = new System.Windows.Forms.Button();
            this.YLabel = new System.Windows.Forms.Label();
            this.BtnPegar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresión:";
            // 
            // ExpTextBox
            // 
            this.ExpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ExpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ExpTextBox.Location = new System.Drawing.Point(48, 70);
            this.ExpTextBox.Name = "ExpTextBox";
            this.ExpTextBox.Size = new System.Drawing.Size(460, 27);
            this.ExpTextBox.TabIndex = 1;
            // 
            // BtnGra
            // 
            this.BtnGra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnGra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGra.ForeColor = System.Drawing.Color.Snow;
            this.BtnGra.Location = new System.Drawing.Point(48, 124);
            this.BtnGra.Name = "BtnGra";
            this.BtnGra.Size = new System.Drawing.Size(94, 40);
            this.BtnGra.TabIndex = 8;
            this.BtnGra.Text = "Graficar";
            this.BtnGra.UseVisualStyleBackColor = false;
            this.BtnGra.Click += new System.EventHandler(this.BtnGra_Click);
            // 
            // GraphPanel
            // 
            this.GraphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.GraphPanel.Location = new System.Drawing.Point(110, 183);
            this.GraphPanel.MaximumSize = new System.Drawing.Size(600, 600);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(281, 158);
            this.GraphPanel.TabIndex = 9;
            // 
            // XTextBox
            // 
            this.XTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.XTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.XTextBox.Location = new System.Drawing.Point(113, 399);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(76, 27);
            this.XTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puntos:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "y";
            // 
            // BtnEvaluar
            // 
            this.BtnEvaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEvaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvaluar.ForeColor = System.Drawing.Color.Snow;
            this.BtnEvaluar.Location = new System.Drawing.Point(174, 446);
            this.BtnEvaluar.Name = "BtnEvaluar";
            this.BtnEvaluar.Size = new System.Drawing.Size(94, 40);
            this.BtnEvaluar.TabIndex = 15;
            this.BtnEvaluar.Text = "Evaluar";
            this.BtnEvaluar.UseVisualStyleBackColor = false;
            this.BtnEvaluar.Click += new System.EventHandler(this.BtnEvaluar_Click);
            // 
            // YLabel
            // 
            this.YLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(250, 401);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(59, 20);
            this.YLabel.TabIndex = 16;
            this.YLabel.Text = "Y_Value";
            // 
            // BtnPegar
            // 
            this.BtnPegar.BackColor = System.Drawing.Color.Gray;
            this.BtnPegar.BackgroundImage = global::CalculoFormsApp.Properties.Resources.paste_ico;
            this.BtnPegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPegar.Location = new System.Drawing.Point(479, 25);
            this.BtnPegar.Name = "BtnPegar";
            this.BtnPegar.Size = new System.Drawing.Size(29, 29);
            this.BtnPegar.TabIndex = 18;
            this.BtnPegar.UseVisualStyleBackColor = false;
            this.BtnPegar.Click += new System.EventHandler(this.BtnPegar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(385, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 95);
            this.button1.TabIndex = 19;
            this.button1.Text = "Descargar (png)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPegar);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.BtnEvaluar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.BtnGra);
            this.Controls.Add(this.ExpTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ExpTextBox;
        private Button BtnGra;
        private Panel GraphPanel;
        private TextBox XTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnEvaluar;
        private Label YLabel;
        private Button BtnPegar;
        private Button button1;
    }
}