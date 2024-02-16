namespace CalculoFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.BtnInstrUso = new System.Windows.Forms.Button();
            this.BtnConfiguración = new System.Windows.Forms.Button();
            this.BtnCalDer = new System.Windows.Forms.Button();
            this.SubPanelCalLim = new System.Windows.Forms.Panel();
            this.BtnSubPanelGraLim = new System.Windows.Forms.Button();
            this.BtnSubPanelExpLim = new System.Windows.Forms.Button();
            this.BtnCalLim = new System.Windows.Forms.Button();
            this.SubPanelCalEc = new System.Windows.Forms.Panel();
            this.BtnSubPanelSisEc = new System.Windows.Forms.Button();
            this.BtnSubPanelEc = new System.Windows.Forms.Button();
            this.BtnCalEc = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.PanelChildForm = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BgLogo = new System.Windows.Forms.Panel();
            this.btnChatGPT = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.SubPanelCalLim.SuspendLayout();
            this.SubPanelCalEc.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.PanelChildForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnChatGPT);
            this.panelSideMenu.Controls.Add(this.BtnInstrUso);
            this.panelSideMenu.Controls.Add(this.BtnConfiguración);
            this.panelSideMenu.Controls.Add(this.BtnCalDer);
            this.panelSideMenu.Controls.Add(this.SubPanelCalLim);
            this.panelSideMenu.Controls.Add(this.BtnCalLim);
            this.panelSideMenu.Controls.Add(this.SubPanelCalEc);
            this.panelSideMenu.Controls.Add(this.BtnCalEc);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.MinimumSize = new System.Drawing.Size(350, 853);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(350, 853);
            this.panelSideMenu.TabIndex = 0;
            // 
            // BtnInstrUso
            // 
            this.BtnInstrUso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInstrUso.FlatAppearance.BorderSize = 0;
            this.BtnInstrUso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnInstrUso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInstrUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstrUso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInstrUso.ForeColor = System.Drawing.Color.Snow;
            this.BtnInstrUso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInstrUso.Location = new System.Drawing.Point(0, 443);
            this.BtnInstrUso.Name = "BtnInstrUso";
            this.BtnInstrUso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInstrUso.Size = new System.Drawing.Size(350, 45);
            this.BtnInstrUso.TabIndex = 8;
            this.BtnInstrUso.Text = "Instrucciones de Uso";
            this.BtnInstrUso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInstrUso.UseVisualStyleBackColor = true;
            this.BtnInstrUso.Click += new System.EventHandler(this.BtnInstrUso_Click);
            // 
            // BtnConfiguración
            // 
            this.BtnConfiguración.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguración.FlatAppearance.BorderSize = 0;
            this.BtnConfiguración.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnConfiguración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguración.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfiguración.ForeColor = System.Drawing.Color.Snow;
            this.BtnConfiguración.Location = new System.Drawing.Point(0, 398);
            this.BtnConfiguración.Name = "BtnConfiguración";
            this.BtnConfiguración.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConfiguración.Size = new System.Drawing.Size(350, 45);
            this.BtnConfiguración.TabIndex = 7;
            this.BtnConfiguración.Text = "Acerca de";
            this.BtnConfiguración.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguración.UseVisualStyleBackColor = true;
            this.BtnConfiguración.Click += new System.EventHandler(this.BtnConfiguración_Click);
            // 
            // BtnCalDer
            // 
            this.BtnCalDer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCalDer.FlatAppearance.BorderSize = 0;
            this.BtnCalDer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCalDer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCalDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalDer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalDer.ForeColor = System.Drawing.Color.Snow;
            this.BtnCalDer.Location = new System.Drawing.Point(0, 353);
            this.BtnCalDer.Name = "BtnCalDer";
            this.BtnCalDer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCalDer.Size = new System.Drawing.Size(350, 45);
            this.BtnCalDer.TabIndex = 5;
            this.BtnCalDer.Text = "Calculadora de Derivadas";
            this.BtnCalDer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalDer.UseVisualStyleBackColor = true;
            this.BtnCalDer.Click += new System.EventHandler(this.BtnCalDer_Click);
            // 
            // SubPanelCalLim
            // 
            this.SubPanelCalLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubPanelCalLim.Controls.Add(this.BtnSubPanelGraLim);
            this.SubPanelCalLim.Controls.Add(this.BtnSubPanelExpLim);
            this.SubPanelCalLim.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelCalLim.Location = new System.Drawing.Point(0, 284);
            this.SubPanelCalLim.Name = "SubPanelCalLim";
            this.SubPanelCalLim.Size = new System.Drawing.Size(350, 69);
            this.SubPanelCalLim.TabIndex = 2;
            // 
            // BtnSubPanelGraLim
            // 
            this.BtnSubPanelGraLim.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubPanelGraLim.FlatAppearance.BorderSize = 0;
            this.BtnSubPanelGraLim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSubPanelGraLim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSubPanelGraLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubPanelGraLim.ForeColor = System.Drawing.Color.Snow;
            this.BtnSubPanelGraLim.Location = new System.Drawing.Point(0, 29);
            this.BtnSubPanelGraLim.Name = "BtnSubPanelGraLim";
            this.BtnSubPanelGraLim.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnSubPanelGraLim.Size = new System.Drawing.Size(350, 29);
            this.BtnSubPanelGraLim.TabIndex = 1;
            this.BtnSubPanelGraLim.Text = "Graficadora";
            this.BtnSubPanelGraLim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubPanelGraLim.UseVisualStyleBackColor = true;
            this.BtnSubPanelGraLim.Click += new System.EventHandler(this.BtnSubPanelGraLim_Click);
            // 
            // BtnSubPanelExpLim
            // 
            this.BtnSubPanelExpLim.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubPanelExpLim.FlatAppearance.BorderSize = 0;
            this.BtnSubPanelExpLim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSubPanelExpLim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSubPanelExpLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubPanelExpLim.ForeColor = System.Drawing.Color.Snow;
            this.BtnSubPanelExpLim.Location = new System.Drawing.Point(0, 0);
            this.BtnSubPanelExpLim.Name = "BtnSubPanelExpLim";
            this.BtnSubPanelExpLim.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnSubPanelExpLim.Size = new System.Drawing.Size(350, 29);
            this.BtnSubPanelExpLim.TabIndex = 0;
            this.BtnSubPanelExpLim.Text = "Expresión";
            this.BtnSubPanelExpLim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubPanelExpLim.UseVisualStyleBackColor = true;
            this.BtnSubPanelExpLim.Click += new System.EventHandler(this.BtnSubPanelExpLim_Click);
            // 
            // BtnCalLim
            // 
            this.BtnCalLim.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCalLim.FlatAppearance.BorderSize = 0;
            this.BtnCalLim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCalLim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCalLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalLim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalLim.ForeColor = System.Drawing.Color.Snow;
            this.BtnCalLim.Location = new System.Drawing.Point(0, 239);
            this.BtnCalLim.Name = "BtnCalLim";
            this.BtnCalLim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCalLim.Size = new System.Drawing.Size(350, 45);
            this.BtnCalLim.TabIndex = 1;
            this.BtnCalLim.Text = "Calculadora de Límites";
            this.BtnCalLim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalLim.UseVisualStyleBackColor = true;
            this.BtnCalLim.Click += new System.EventHandler(this.BtnCalLim_Click_1);
            // 
            // SubPanelCalEc
            // 
            this.SubPanelCalEc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubPanelCalEc.Controls.Add(this.BtnSubPanelSisEc);
            this.SubPanelCalEc.Controls.Add(this.BtnSubPanelEc);
            this.SubPanelCalEc.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelCalEc.Location = new System.Drawing.Point(0, 170);
            this.SubPanelCalEc.Name = "SubPanelCalEc";
            this.SubPanelCalEc.Size = new System.Drawing.Size(350, 69);
            this.SubPanelCalEc.TabIndex = 2;
            // 
            // BtnSubPanelSisEc
            // 
            this.BtnSubPanelSisEc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubPanelSisEc.FlatAppearance.BorderSize = 0;
            this.BtnSubPanelSisEc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSubPanelSisEc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSubPanelSisEc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubPanelSisEc.ForeColor = System.Drawing.Color.Snow;
            this.BtnSubPanelSisEc.Location = new System.Drawing.Point(0, 29);
            this.BtnSubPanelSisEc.Name = "BtnSubPanelSisEc";
            this.BtnSubPanelSisEc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnSubPanelSisEc.Size = new System.Drawing.Size(350, 29);
            this.BtnSubPanelSisEc.TabIndex = 1;
            this.BtnSubPanelSisEc.Text = "Sistemas de Ecuaciones";
            this.BtnSubPanelSisEc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubPanelSisEc.UseVisualStyleBackColor = true;
            this.BtnSubPanelSisEc.Click += new System.EventHandler(this.BtnSubPanelSisEc_Click);
            // 
            // BtnSubPanelEc
            // 
            this.BtnSubPanelEc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubPanelEc.FlatAppearance.BorderSize = 0;
            this.BtnSubPanelEc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSubPanelEc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSubPanelEc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubPanelEc.ForeColor = System.Drawing.Color.Snow;
            this.BtnSubPanelEc.Location = new System.Drawing.Point(0, 0);
            this.BtnSubPanelEc.Name = "BtnSubPanelEc";
            this.BtnSubPanelEc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnSubPanelEc.Size = new System.Drawing.Size(350, 29);
            this.BtnSubPanelEc.TabIndex = 0;
            this.BtnSubPanelEc.Text = "Ecuaciones";
            this.BtnSubPanelEc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubPanelEc.UseVisualStyleBackColor = true;
            this.BtnSubPanelEc.Click += new System.EventHandler(this.BtnSubPanelEc_Click);
            // 
            // BtnCalEc
            // 
            this.BtnCalEc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCalEc.FlatAppearance.BorderSize = 0;
            this.BtnCalEc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCalEc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCalEc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalEc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalEc.ForeColor = System.Drawing.Color.Snow;
            this.BtnCalEc.Location = new System.Drawing.Point(0, 125);
            this.BtnCalEc.Name = "BtnCalEc";
            this.BtnCalEc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCalEc.Size = new System.Drawing.Size(350, 45);
            this.BtnCalEc.TabIndex = 1;
            this.BtnCalEc.Text = "Calculadora de Ecuaciones";
            this.BtnCalEc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalEc.UseVisualStyleBackColor = true;
            this.BtnCalEc.Click += new System.EventHandler(this.BtnCalEc_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.LogoPanel);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(350, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPanel.AutoSize = true;
            this.LogoPanel.BackgroundImage = global::CalculoFormsApp.Properties.Resources.LogoFormsApp__Icon_;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Location = new System.Drawing.Point(114, 6);
            this.LogoPanel.MaximumSize = new System.Drawing.Size(112, 113);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(112, 113);
            this.LogoPanel.TabIndex = 0;
            // 
            // PanelChildForm
            // 
            this.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(7)))));
            this.PanelChildForm.Controls.Add(this.groupBox1);
            this.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildForm.Location = new System.Drawing.Point(350, 0);
            this.PanelChildForm.Name = "PanelChildForm";
            this.PanelChildForm.Size = new System.Drawing.Size(632, 853);
            this.PanelChildForm.TabIndex = 1;
            this.PanelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChildForm_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BgLogo);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 829);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BgLogo
            // 
            this.BgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BgLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BgLogo.BackgroundImage = global::CalculoFormsApp.Properties.Resources.devX_logo_bk;
            this.BgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BgLogo.Location = new System.Drawing.Point(127, 158);
            this.BgLogo.Name = "BgLogo";
            this.BgLogo.Size = new System.Drawing.Size(365, 343);
            this.BgLogo.TabIndex = 0;
            this.BgLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.BgLogo_Paint);
            // 
            // btnChatGPT
            // 
            this.btnChatGPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChatGPT.FlatAppearance.BorderSize = 0;
            this.btnChatGPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnChatGPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChatGPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatGPT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChatGPT.ForeColor = System.Drawing.Color.Snow;
            this.btnChatGPT.Location = new System.Drawing.Point(0, 488);
            this.btnChatGPT.Name = "btnChatGPT";
            this.btnChatGPT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChatGPT.Size = new System.Drawing.Size(350, 45);
            this.btnChatGPT.TabIndex = 9;
            this.btnChatGPT.Text = "ChatGPT";
            this.btnChatGPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChatGPT.UseVisualStyleBackColor = true;
            this.btnChatGPT.Click += new System.EventHandler(this.btnChatGPT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.PanelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{d}{dev}x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.SubPanelCalLim.ResumeLayout(false);
            this.SubPanelCalEc.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.PanelChildForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Button BtnCalEc;
        private Panel panelLogo;
        private Panel SubPanelCalEc;
        private Button BtnSubPanelSisEc;
        private Button BtnSubPanelEc;
        private Button BtnConfiguración;
        private Button BtnCalDer;
        private Panel SubPanelCalLim;
        private Button BtnSubPanelGraLim;
        private Button BtnSubPanelExpLim;
        private Button BtnCalLim;
        private Panel PanelChildForm;
        private Panel LogoPanel;
        private Panel BgLogo;
        private Button BtnInstrUso;
        private GroupBox groupBox1;
        private Button btnChatGPT;
    }
}