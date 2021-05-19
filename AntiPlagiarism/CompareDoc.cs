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
    public partial class CompareDoc : MaterialForm
    {
        public CompareDoc()
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

        private void OpenFirstDocBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word 97-2003|*.doc|Word Document|*.docx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object fileName = ofd.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word._Document document;
                    Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    rtfData1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                }
            }
        }

        private void OpenSecondDocBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word 97-2003|*.doc|Word Document|*.docx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object fileName = ofd.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word._Document document;
                    Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    rtfData2.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                }
            }

        }

        private void CompareDocBtn_Click(object sender, EventArgs e)
        {
            var sig1 = Shingles.GetShingleHashes(rtfData1.Text, 2);
            var sig2 = Shingles.GetShingleHashes(rtfData2.Text, 2);
            var like = Shingles.Compare(sig1, sig2);
            MessageBox.Show("Совпадение составляет: " + like * 100 + " %");
        }
    }
}
