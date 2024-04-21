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
    public partial class FrmPermissions : Form
    {
        public FrmPermissions()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string textlist = rtbSource.Text;
            var SelectedList = textlist.Trim().Split(',');
           var  SelectedPath =@"D:\NewGerated";
            CreateCustomFileGroup(SelectedList.ToList(), SelectedPath);
        }
        private void CreateCustomFileGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "PermissionFiles";
            string fileNameWithExt = "Permissions.txt";
            if (!System.IO.Directory.Exists(path))
            { System.IO.Directory.CreateDirectory(path); }
            string result = "";
            foreach (var modelName in sFilesNames)
            {
                result += CreateCustomFile(modelName);
            }
            using (FileStream fs = File.Create(path + "\\" + fileNameWithExt))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(result);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private string CreateCustomFile(string ModelName)
        {
            ModelName = ModelName.Replace("\n", "");
            string content  = rtbstatment.Text +"\n \n"; 
             content  = content.Replace("{0}", ModelName);
            return content;



        }
    }
}
