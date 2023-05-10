using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerTools
{
    public partial class FrmCustom : Form
    {
        public FrmCustom()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public string FileContent = string.Empty;
        public string PreFileName;
        public string AfterFileName;
        public string FileExtention;
        private void btnOk_Click(object sender, EventArgs e)
        {
            FileContent = richTextBox1.Text;
            PreFileName = tbPreFileName.Text;
            AfterFileName = tbAfterFileName.Text;
            FileExtention = tbFileExtention.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            //string path = "C:\\Users\\Fezo\\Desktop\\output";
            //string modelName = "Table1";
            //string FullFileName = tbPreFileName.Text + modelName + tbAfterFileName.Text + "." + tbFileExtention.Text;
            //CreateFile("Table1", path, FullFileName);
        }
        private void CreateFile(string ModelName, string path, string fileNameWithExt)
        {
            string contentAfterReplaced = string.Empty;
            string content = richTextBox1.Text;

            contentAfterReplaced = content.Replace("{0}", ModelName);
            contentAfterReplaced += "// End Content \n";

            path += "\\" + "CustomFile";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            using (FileStream fs = File.Create(path + "\\" + fileNameWithExt))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(contentAfterReplaced);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        private void FrmCustom_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileContent))
            { 
                richTextBox1.Text = FileContent; 
                tbPreFileName.Text = PreFileName;
                tbAfterFileName.Text = AfterFileName;
                tbFileExtention.Text = FileExtention;
            }
        }
    }
}
