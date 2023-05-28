using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Serialization;


namespace ProgrammerTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> sFileNames;
        List<string> sFilePathes;
        OpenFileDialog openFileDialog1;
        private void btnSelectModels_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\mfayez\source\repos";
            openFileDialog1.Filter = "Models files (*.cs)|*.cs|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //listBox1.Items.Clear();
                // listBox1 = new ListBox();
                listBox1.Items.AddRange(openFileDialog1.SafeFileNames);
                sFilePathes = new List<string>();
                sFilePathes = openFileDialog1.FileNames.ToList();

            }

        }
        string sRepoPath = string.Empty;
        private void btnSelectRepoPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    sRepoPath = fbd.SelectedPath;
                    tbSelectedPath.Text = sRepoPath;

                }
            }
        }
        string sIRepoPath = string.Empty;

        private void btnSelectIRepoPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    sIRepoPath = fbd.SelectedPath;

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        void GetFileNames()
        {
            foreach (var fName in listBox1.Items)
            {
                sFileNames.Add(Path.GetFileNameWithoutExtension(listBox1.GetItemText(fName)));
            }
        }
        public void CreateRepoFileByName(string modelName, string path)
        {
            string nameSpace = tbDomainInterface.Text;
            string RepositoryData =
            "using Microsoft.EntityFrameworkCore; \n" +
            "using " + tbRepoNameSpace.Text + "; \n" +
            "using " + tbDomainModels.Text + "; \n" +
            "using " + tbRepositoryGenaric.Text + "; \n" +
            "namespace " + nameSpace + "\n" +
            "{" + "\n" +
               "    public class " + modelName + "Repository : Repository<" + modelName + ">, I" + modelName + "Repository" + "\n" +
                "    {" + "\n" +
                   "        public " + modelName + "Repository(" + "DbContext" + " " + tbdbContextInstance.Text + " ) : base(" + tbdbContextInstance.Text + ") \n" +
                    "        {" + "\n" +
                    "        }" + "\n" +
                "    }" + "\n" +
            "}";

            using (FileStream fs = File.Create(path + "\\" + modelName + "Repository.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateIRepoFileByName(string modelName, string path)
        {
            string RepositoryData =
            "using " + tbDomainModels.Text + "; \n" +
            "using " + tbRepositoryGenaric.Text + "; \n" +
            "namespace " + tbRepoNameSpace.Text + "\n" +
            "{" + "\n" +
               "    public interface I" + modelName + "Repository : IRepository<" + modelName + "> \n" +
                "    {" + "\n" +
                " " +
                "    }" + "\n" +
            "}";


            // Create the file, or overwrite if the file exists. 
            using (FileStream fs = File.Create(path + "\\I" + modelName + "Repository.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateServiceIRepoFileByName(string modelName, string path)
        {
            string modelNameDTO = modelName + "DTO";
            string RepositoryData = $"using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing StockApp.Service.DTO;\r\n\r\nnamespace StockApp.Service.Interfaces\r\n{{\r\n    public interface I{{0}}Service\r\n    {{\r\n        Task<{{0}}DTO> Get{{0}}ByID(Guid ID);\r\n        Task<IEnumerable<BranchDTO>> GetAll{{0}}();\r\n        Task<bool> Add{{0}}({{0}}DTO Model);\r\n        Task<bool> Update{{0}}({{0}}DTO Model);\r\n        Task<bool> Delete{{0}}(Guid {{0}}ID);\r\n    }}\r\n}}\r\n";

            RepositoryData = RepositoryData.Replace("{0}", modelName);
            // Create the file, or overwrite if the file exists. 
            using (FileStream fs = File.Create(path + "\\I" + modelName + "Repository.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private bool isAnyCheck()
        {
            foreach (Control c in gpCheckBoxs.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                        return true;
                }
            }
            return false;
        }
        bool check()
        {
            if (!isAnyCheck())
            {
                MessageBox.Show("Please check what files you need to create", "Error Message");
                return false;
            }
            if (string.IsNullOrEmpty(tbSelectedPath.Text))
            {
                MessageBox.Show("select output file destination", "Error Message");
                return false;
            }
            if (string.IsNullOrEmpty(tbRepoNameSpace.Text))
            {
                MessageBox.Show("select Name Space ", "Error Message");
                return false;
            }
            if (string.IsNullOrEmpty(tbDomainModels.Text))
            {
                MessageBox.Show("select Domain Models ", "Error Message");
                return false;
            }
            if (string.IsNullOrEmpty(tbDomainInterface.Text))
            {
                MessageBox.Show("select Domain Interface ", "Error Message");
                return false;
            }
            if (string.IsNullOrEmpty(tbDbContext.Text))
            {
                MessageBox.Show("select DbContext Name ", "Error Message");
                return false;
            }
            if (cbCustomFile.Checked && string.IsNullOrEmpty(FileContent))
            {
                MessageBox.Show("Custom file has no Data. \n please click Custom button and set your data ", "Error Message");
                return false;
            }
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("Please select models first or add its names", "Error Message");
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!check())
                return;

            sFileNames = new List<string>();
            GetFileNames();
            string SelectedPath = tbSelectedPath.Text;


            if (cbRepository.Checked)
                CreateRepositoryGroup(sFileNames, SelectedPath);
            if (cbIRepository.Checked)
                CreateIRepositoryGroup(sFileNames, SelectedPath);
            if (cbUnitOfWork.Checked)
                CreateUnitOfWork(sFileNames, SelectedPath);
            if (cbIUnitOfWork.Checked)
                CreateIUnitOfWork(sFileNames, SelectedPath);
            if (cbCustomFile.Checked)
                CreateCustomFileGroup(sFileNames, SelectedPath);
            if (cbServices.Checked)
                CreateCustomFileGroup(sFileNames, SelectedPath);
            if (cbSaveConfig.Checked)
                CreateAppDbContext(sFileNames, SelectedPath);


            CreateConfigFIle(SelectedPath);

            MessageBox.Show("All Done Well");
            Process.Start("explorer.exe", SelectedPath);

        }
        private void CreateCustomFileGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "CustomFiles";
            if (!System.IO.Directory.Exists(path))
            { System.IO.Directory.CreateDirectory(path); }

            foreach (var modelName in sFileNames)
            {
                CreateCustomFile(modelName, path);
            }

        }
        private void CreateRepositoryGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "Repository";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            { CreateRepoFileByName(modelName, path); }
        }
        private void CreateIRepositoryGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "IRepository";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            {
                CreateIRepoFileByName(modelName, path);
            }
        }
        private void ReadConfiguration(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                char delimiter = '=';

                var keyValuePairs = new System.Collections.Generic.Dictionary<string, string>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(delimiter);
                    string key = parts[0];
                    string value = parts[1];
                    keyValuePairs[key] = value;
                }
                tbSelectedPath.Text = keyValuePairs["outputPath"] != null ? keyValuePairs["outputPath"] : "";
                tbRepoNameSpace.Text = keyValuePairs["RepositoryNameSpace"] != null ? keyValuePairs["RepositoryNameSpace"] : "";
                tbDomainInterface.Text = keyValuePairs["InterfaceNameSpace"] != null ? keyValuePairs["InterfaceNameSpace"] : "";
                tbDomainModels.Text = keyValuePairs["ModelsNameSpace"] != null ? keyValuePairs["ModelsNameSpace"] : "";
                tbDbContextNameSpace.Text = keyValuePairs["DBContextNameSpace"] != null ? keyValuePairs["DBContextNameSpace"] : "";
                tbDbContext.Text = keyValuePairs["DBContextName"] != null ? keyValuePairs["DBContextName"] : "";
                tbdbContextInstance.Text = keyValuePairs["dbContextInstanceName"] != null ? keyValuePairs["dbContextInstanceName"] : "";
            }
            catch (Exception ex)
            {
            }

        }
         
        private void CreateConfigFIle(string SelectedOutPut)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("outputPath", SelectedOutPut);
            keyValuePairs.Add("RepositoryNameSpace", tbRepoNameSpace.Text);
            keyValuePairs.Add("InterfaceNameSpace", tbDomainInterface.Text);
            keyValuePairs.Add("ModelsNameSpace", tbDomainModels.Text);
            keyValuePairs.Add("DBContextNameSpace", tbDbContextNameSpace.Text);
            keyValuePairs.Add("DBContextName", tbDbContext.Text);
            keyValuePairs.Add("dbContextInstanceName", tbdbContextInstance.Text);

            string fileName = path + "//" + "data.txt";
            char delimiter = '=';

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (KeyValuePair<string, string> kvp in keyValuePairs)
                {
                    string line = kvp.Key + delimiter + kvp.Value;
                    writer.WriteLine(line);
                }
            }

        }
        private void CreateAppDbContext(List<string> sFilesNames, string path)
        {
            string RepositoryData = "// Start ApplicationDbContext \n";

            foreach (var modelName in sFilesNames)
            {
                RepositoryData += "        public virtual DbSet<" + modelName + "> " + modelName + "s { set; get; }  \n";
            }
            RepositoryData += "// End ApplicationDbContext \n";

            path += "\\" + "AppDbContext";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            using (FileStream fs = File.Create(path + "\\" + "AddToAppDbContext.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private void CreateUnitOfWork(List<string> sFilesNames, string path)
        {
            string RepositoryData = "//UnitOfWork Start Constractor() part \n";
            foreach (var modelName in sFilesNames)
            {
                RepositoryData += modelName + "Repository" + " = new " + modelName + "Repository(" + tbdbContextInstance.Text + "); \n";
            }
            RepositoryData += "// End Constractor part \n \n";
            RepositoryData += "// strat Content \n";

            foreach (var modelName in sFilesNames)
            {
                RepositoryData += "public I" + modelName + "Repository " + modelName + "Repository" + " { get; private set; }  \n";
            }
            RepositoryData += "// End Content \n";

            path += "\\" + "UnitOfWork";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            using (FileStream fs = File.Create(path + "\\" + "AddToUnitOfWork.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private void CreateIUnitOfWork(List<string> sFilesNames, string path)
        {
            string RepositoryData = "// Start IUniteOfWork \n";

            foreach (var modelName in sFilesNames)
            {
                RepositoryData += "        I" + modelName + "Repository " + modelName + "Repository" + " { get; }  \n";
            }
            RepositoryData += "// End IUniteOfWork \n";

            path += "\\" + "UnitOfWork";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            using (FileStream fs = File.Create(path + "\\" + "AddToIUnitOfWork.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private void CreateCustomFile(string ModelName, string path)
        {
            string contentAfterReplaced = string.Empty;
            string content = FileContent;
            string fileNameWithExt = PreFileName + ModelName + AfterFileName + "." + FileExtention;
            contentAfterReplaced = content.Replace("{0}", ModelName);

            using (FileStream fs = File.Create(path + "\\" + fileNameWithExt))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(contentAfterReplaced);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        private void btnAddNewModel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbModelName.Text))
                return;
            listBox1.Items.Add(tbModelName.Text + ".cs");
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My number is : (002) 01023283130");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string configPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            configPath += "\\" + "data.txt";
            if (System.IO.File.Exists(configPath))
            {
                ReadConfiguration(configPath);

            }
        }
        string FileContent;
        string PreFileName;
        string AfterFileName;
        string FileExtention;

        private void btnCustom_Click(object sender, EventArgs e)
        {

            FrmCustom frmCustom = new FrmCustom();
            if (!string.IsNullOrEmpty(FileContent))
            {
                frmCustom.FileContent = FileContent;
                frmCustom.PreFileName = PreFileName;
                frmCustom.AfterFileName = AfterFileName;
                frmCustom.FileExtention = FileExtention;
            }
            frmCustom.ShowDialog();
            if (frmCustom.DialogResult == DialogResult.OK)
            {
                FileContent = frmCustom.FileContent;
                PreFileName = frmCustom.PreFileName;
                AfterFileName = frmCustom.AfterFileName;
                FileExtention = frmCustom.FileExtention;
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void cbAll_CheckStateChanged(object sender, EventArgs e)
        {
            checkAll(((CheckBox)sender).Checked);

        }
        private void checkAll(bool check)
        {
            foreach (Control c in gpCheckBoxs.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = check;
                }
            }
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("By Mohamed Fayez \n Mobile +201023283130", "Contact Information");
        }

        private void tbModelName_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btnAddNewModel_Click(sender, e);
            //}

        }
    }
}