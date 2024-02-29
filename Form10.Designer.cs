namespace CalculoFormsApp
{
    partial class Form10
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
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEcSimplify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el problema a resolver:";
            // 
            // EcTextBox
            // 
            this.EcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EcTextBox.ForeColor = System.Drawing.Color.Snow;
            this.EcTextBox.Location = new System.Drawing.Point(12, 59);
            this.EcTextBox.Multiline = true;
            this.EcTextBox.Name = "EcTextBox";
            this.EcTextBox.Size = new System.Drawing.Size(460, 100);
            this.EcTextBox.TabIndex = 3;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.ForeColor = System.Drawing.Color.Snow;
            this.AnswerLabel.Location = new System.Drawing.Point(12, 265);
            this.AnswerLabel.MaximumSize = new System.Drawing.Size(2000, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(31, 20);
            this.AnswerLabel.TabIndex = 7;
            this.AnswerLabel.Text = "n/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado:";
            // 
            // BtnEcSimplify
            // 
            this.BtnEcSimplify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnEcSimplify.FlatAppearance.BorderSize = 0;
            this.BtnEcSimplify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnEcSimplify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEcSimplify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEcSimplify.ForeColor = System.Drawing.Color.Snow;
            this.BtnEcSimplify.Location = new System.Drawing.Point(12, 176);
            this.BtnEcSimplify.Name = "BtnEcSimplify";
            this.BtnEcSimplify.Size = new System.Drawing.Size(100, 50);
            this.BtnEcSimplify.TabIndex = 5;
            this.BtnEcSimplify.Text = "Enviar";
            this.BtnEcSimplify.UseVisualStyleBackColor = false;
            this.BtnEcSimplify.Click += new System.EventHandler(this.BtnEcSimplify_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEcSimplify);
            this.Controls.Add(this.EcTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox EcTextBox;
        private Label AnswerLabel;
        private Label label2;
        private Button BtnEcSimplify;
    }
}