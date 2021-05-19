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
    public partial class CompareText : MaterialForm
    {
        public CompareText()
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            this.Hide();
            newForm.Show();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var sig1 = Shingles.GetShingleHashes(textBox1.Text, 2);
            var sig2 = Shingles.GetShingleHashes(textBox2.Text, 2);
            var like = Shingles.Compare(sig1, sig2);
            MessageBox.Show("Совпадение составляет: " + like * 100 + " %");
        }
    }
}
