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
using System.ComponentModel;

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
        string sDirectory;
        OpenFileDialog openFileDialog1;
        string FileContent;
        string PreFileName;
        string AfterFileName;
        string FileExtention;
        string sIRepoPath = string.Empty;

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

                sDirectory = Path.GetDirectoryName(openFileDialog1.FileNames.FirstOrDefault());

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
           
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("Please select models first or add its names", "Error Message");
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        { 

            //if (!check())
            //    return;

            //sFileNames = new List<string>();
            //GetFileNames();
            //string SelectedPath = tbSelectedPath.Text;
            //if (cbIsGenaric.Checked)
            //    CreateGroup(sFileNames, SelectedPath);

            //if (cbSaveConfig.Checked)
            //    CreateConfigFIle(SelectedPath);

            MessageBox.Show("All Done Well");
            //Process.Start("explorer.exe", SelectedPath);

        }
        private void CreateGroup(List<string> sFilesNames, string path)
        {
            //path += "\\" + "Group";
            //if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            ////create IRepository
            //foreach (var modelName in sFileNames)
            //{
            //    path += "\\" + modelName;
            //    if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);

            //    var (commandList, queryList, returnTypes) = getManagerMethouds();
            //    for (int i = 0; i < queryList.Count; i++)
            //    {
            //        CreateSearchQuery(queryList[i], path, returnTypes[i],modelName);
            //        CreateSearchHandler(queryList[i], path, returnTypes[i],modelName);
            //    }
            //    for (int i = 0; i < commandList.Count; i++)
            //    {
            //        CreateCommand(commandList[i], path, modelName);
            //        CreateHandler(commandList[i], path, modelName);
            //    }
               
            //    CreateSearchFilter(modelName, path);

            //    CreateIService(modelName, path);
            //    CreateService(modelName, path);
            //}
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
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete data.txt from application folder \n" + ex.Message);
            }

        }

        private void CreateConfigFIle(string SelectedOutPut)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("outputPath", SelectedOutPut);
        

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

   
    }
}