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
    public partial class Greeting : MaterialForm
    {
        public Greeting()
        {
            InitializeComponent();
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            this.Hide();
            newForm.Show();
        }
    }
}
