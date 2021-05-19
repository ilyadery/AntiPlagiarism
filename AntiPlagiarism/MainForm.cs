using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiPlagiarism
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CompareTextButton_Click(object sender, EventArgs e)
        {
            CompareText newForm = new CompareText();
            this.Hide();
            newForm.Show();
        }

        private void CompareDocButton_Click(object sender, EventArgs e)
        {
            CompareDoc newForm = new CompareDoc();
            this.Hide();
            newForm.Show();
        }

        private void CompareDBButton_Click(object sender, EventArgs e)
        {
            CompareDB newForm = new CompareDB();
            this.Hide();
            newForm.Show();
        }
    }
}
