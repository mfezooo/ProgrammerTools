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
            string RepositoryData = "using Microsoft.EntityFrameworkCore; \n" +
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
            string RepositoryData = "using " + tbDomainModels.Text + "; \n" +
            "using " + tbRepositoryGenaric.Text + "; \n" +
            "namespace " + tbRepoNameSpace.Text + "\n" +
            "{" + "\n" +
               "    public interface I" + modelName + "Repository : IRepository<" + modelName + "> \n" +
                "    {" + "\n" +
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
            string RepositoryData = "using System; \n " +
            "using System.Collections.Generic; \n" +
            "using System.Threading.Tasks; \n" +
            "using " + tbServiceDTOFolderName.Text + "; \n" +
            "namespace " + tbServiceInterfaceFolderName.Text + "\n" +
            "{" + "\n" +
               "    public interface I" + modelName + "Service \n" +
                "    {" + "\n" +
                "        Task<" + modelNameDTO + "> Get" + modelName + "ByID(Guid ID); \n" +
                "        Task<IEnumerable<" + modelNameDTO + ">> GetAll" + modelName + "(D); \n" +

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
        bool check()
        {
            if (string.IsNullOrEmpty(tbSelectedPath.Text))
            {
                MessageBox.Show("select Repostiroy destination");
                return false;
            }
            if (string.IsNullOrEmpty(tbSelectedPath.Text))
            {
                MessageBox.Show("select Repostiroy destination");
                return false;
            }
            if (string.IsNullOrEmpty(tbRepoNameSpace.Text))
            {
                MessageBox.Show("select Name Space ");
                return false;
            }
            if (string.IsNullOrEmpty(tbDomainModels.Text))
            {
                MessageBox.Show("select Domain Models ");
                return false;
            }
            if (string.IsNullOrEmpty(tbDomainInterface.Text))
            {
                MessageBox.Show("select Domain Interface ");
                return false;
            }
            if (string.IsNullOrEmpty(tbDbContext.Text))
            {
                MessageBox.Show("select DbContext Name ");
                return false;
            }
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("select Models");
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

            string pathOfRepo = SelectedPath + "\\" + "Repository";
            if (!System.IO.Directory.Exists(pathOfRepo)) System.IO.Directory.CreateDirectory(pathOfRepo);
            string pathOfIRepo = SelectedPath + "\\" + "IRepository";
            if (!System.IO.Directory.Exists(pathOfIRepo)) System.IO.Directory.CreateDirectory(pathOfIRepo);


            CreateRepositoryGroup(sFileNames, pathOfRepo);
            CreateIRepositoryGroup(sFileNames, pathOfIRepo);
            CreateUnitOfWork(sFileNames, SelectedPath);
            CreateIUnitOfWork(sFileNames, SelectedPath);
            CreateAppDbContext(sFileNames, SelectedPath);

            CreateConfigFIle(SelectedPath);

            MessageBox.Show("All Done Well");
            Process.Start("explorer.exe", SelectedPath);

        }

        private void CreateRepositoryGroup(List<string> sFilesNames, string path)
        {
            //create IRepository
            foreach (var modelName in sFileNames)
            { CreateRepoFileByName(modelName, path); }
        }
        private void CreateIRepositoryGroup(List<string> sFilesNames, string path)
        {
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
    }
}