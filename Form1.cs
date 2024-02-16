using System.Speech.Recognition;

namespace CalculoFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region CustomizedDesign

        #region Menus
        private void CustomizeDesign()
        {
            SubPanelCalEc.Visible = false;
            SubPanelCalLim.Visible = false;
        }

        private void HideSubMenu()
        {
            if (SubPanelCalEc.Visible == true)
                SubPanelCalEc.Visible = false;
            if (SubPanelCalLim.Visible == true)
                SubPanelCalLim.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        #endregion

        #region SubPanelCalEc
        private void BtnCalEc_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubPanelCalEc);
        }

        private void BtnSubPanelEc_Click(object sender, EventArgs e)
        {
            //Code...
            OpenChildForm(new Form2());
            HideSubMenu();
        }

        private void BtnSubPanelSisEc_Click(object sender, EventArgs e)
        {
            //Code...
            OpenChildForm(new Form3());
            HideSubMenu();
        }
        #endregion

        #region SubPanelCalLim
        private void BtnCalLim_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubPanelCalLim);
        }

        private void BtnSubPanelExpLim_Click(object sender, EventArgs e)
        {
            //Code...
            OpenChildForm(new Form4());
            HideSubMenu();
        }

        private void BtnSubPanelGraLim_Click(object sender, EventArgs e)
        {
            //Code...
            OpenChildForm(new Form5());
            HideSubMenu();
        }

        private void BtnCalLim_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(SubPanelCalLim);
        }
        #endregion

        #region OtherButtons
        private void BtnCalDer_Click(object sender, EventArgs e)
        {
            //Code...
            //Open Form...

            CloseChildForm();

            OpenChildForm(new Form6());
            
            HideSubMenu();
        }

        private void BtnConfiguración_Click(object sender, EventArgs e)
        {
            //Code...
            CloseChildForm();

            OpenChildForm(new Form7());

            HideSubMenu();
        }
        #endregion

        #endregion

        #region Forms

        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(ChildForm);
            PanelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        #endregion

        private void BtnInstrUso_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            OpenChildForm(new Form8());

            HideSubMenu();
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BgLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChatGPT_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            OpenChildForm(new Form9());

            HideSubMenu();
        }
    }
}