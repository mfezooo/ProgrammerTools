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



        //public void CreateService(string modelName, string path)
        //{
        //    StringBuilder data = new StringBuilder();
        //    data.AppendLine("using AutoMapper;");
        //    data.AppendLine("using " + tbDTONameSpace.Text + ";");
        //    data.AppendLine("using " + tbServiceInterface.Text + ";");
        //    data.Append(rtUsingAdditonal.Text);
        //    data.AppendLine("");
        //    data.AppendLine("");
        //    data.AppendLine("namespace " + tbServiceNameSpace.Text);
        //    data.AppendLine("{");
        //    data.AppendLine("    public class " + modelName + "Service : BaseService, I" + modelName + "Service");
        //    data.AppendLine("    {");
        //    data.AppendLine("        public " + modelName + "Service(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)");
        //    data.AppendLine("        {");
        //    data.AppendLine("        }");
        //    //Add Methoud
        //    data.AppendLine("        public async Task<bool> Add" + modelName + "(" + modelName + "DTO Model)");
        //    data.AppendLine("        {");
        //    data.AppendLine("            var Entity = _mapper.Map<" + modelName + ">(Model);");
        //    data.AppendLine("            _unitOfWork." + modelName + "Repository.Add(Entity);");
        //    data.AppendLine("            _unitOfWork.Complete();");
        //    data.AppendLine("            return true;");
        //    data.AppendLine("        }");
        //    data.AppendLine("");

        //    //Delete Methoud
        //    data.AppendLine("        public async Task<bool> Delete" + modelName + "(int " + modelName + "ID)");
        //    data.AppendLine("        {");
        //    data.AppendLine("            var Entity = await _unitOfWork." + modelName+"Repository.FirstOrDefult(q => q.Id == "+modelName+"ID);");
        //    data.AppendLine("            Entity.IsDelete = true;");
        //    data.AppendLine("            _unitOfWork.Complete();");
        //    data.AppendLine("            //Message = \"\"تم الحذف بنجاح\";");
        //    data.AppendLine("            return true;");
        //    data.AppendLine("        }");
        //    data.AppendLine("");

        //    //GetAll  Methoud
        //    data.AppendLine("        public async Task<IEnumerable<" + modelName + "DTO>> GetAll" + modelName + "()");
        //    data.AppendLine("         {");
        //    data.AppendLine("            var Entity = await _unitOfWork." + modelName+ "Repository.Find(c => c.IsDelete == false);");
        //    data.AppendLine("            var EntityList = _mapper.Map<IEnumerable<" + modelName+"DTO>>(Entity);");
        //    data.AppendLine("            return EntityList;"); 
        //    data.AppendLine("        }");
        //    data.AppendLine("");
        //    //GetbyId  Methoud
        //    data.AppendLine("        public async Task<" + modelName+"DTO> Get"+modelName+"ByID(int ID)");
        //    data.AppendLine("        {");
        //    data.AppendLine("            var Entity = await _unitOfWork."+modelName+ "Repository.Find(c => c.IsDelete == false && c.Id == ID);");
        //    data.AppendLine("            return _mapper.Map<"+modelName+"DTO>(Entity);"); 
        //    data.AppendLine("        }");
        //    data.AppendLine("");

        //    //UpdateBranch  Methoud
        //    data.AppendLine("        public async Task<bool> Update" + modelName + "(" + modelName + "DTO Model)");
        //    data.AppendLine("        {");
        //    data.AppendLine("            var Entity = await _unitOfWork." + modelName + "Repository.Get(Model." + modelName + "ID);");
        //    data.AppendLine("            _mapper.Map(Model, Entity);");
        //    data.AppendLine("            _unitOfWork.Complete();");
        //    data.AppendLine("            //Message = \"\"تم التعديل بنجاح\";");
        //    data.AppendLine("            return true;");
        //    data.AppendLine("        }");
        //    data.AppendLine("");

        //    data.AppendLine("    }");
        //    data.AppendLine("}");


        //    //using (FileStream fs = File.Create(path + "\\" + modelName + "Service.cs"))
        //    //{
        //    //    byte[] info = new UTF8Encoding(true).GetBytes(data.ToString()); 
        //    //    fs.Write(info, 0, info.Length);
        //    //}
        //    string cFileName = path + "\\" + modelName + "Service.cs";
        //    StreamWriter writer = new StreamWriter(cFileName, false);
        //    writer.Write(data.ToString());
        //    writer.Close();


        //}
        private void CreateServiceInterfaceGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "ServiceInterfaces";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            { CreateServiceInterface(modelName, path); }
        }
        public void CreateServiceInterface(string modelName, string path)
        {
            //StringBuilder data = new StringBuilder();
            //data.AppendLine("using " + tbDTONameSpace.Text + ";");
            //data.AppendLine("namespace " + tbServiceInterface.Text);
            //data.AppendLine("{");
            //data.AppendLine("    public interface I" + modelName + "Service");
            //data.AppendLine("    {");
            //data.AppendLine("        Task<" + modelName + "DTO> Get" + modelName + "ByID(string ID);");
            //data.AppendLine("        Task<Update" + modelName + "DTO> Get" + modelName + "ByIDToUpdate(string ID);");
            //data.AppendLine("        Task<IEnumerable<" + modelName + "DTO>> GetAll" + modelName + "();");
            //data.AppendLine("        Task<bool> Add" + modelName + "(Create" + modelName + "DTO Model);");
            //data.AppendLine("        Task<bool> Update" + modelName + "(Update" + modelName + "DTO Model);");
            //data.AppendLine("        Task<bool> Delete" + modelName + "(string " + modelName + "ID);");
            //data.AppendLine("    }");
            //data.AppendLine("}");


            //// Create the file, or overwrite if the file exists. 
            //using (FileStream fs = File.Create(path + "\\I" + modelName + "Service.cs"))
            //{
            //    byte[] info = new UTF8Encoding(true).GetBytes(data.ToString());
            //    // Add some information to the file.
            //    fs.Write(info, 0, info.Length);
            //}


        }
        //public void CreateServiceInterface(string modelName, string path)
        //{
        //    StringBuilder data = new StringBuilder();
        //    data.AppendLine("using " + tbDTONameSpace.Text + ";");
        //    data.AppendLine("namespace " + tbServiceInterface.Text);
        //    data.AppendLine("{");
        //    data.AppendLine("    public interface I" + modelName + "Service");
        //    data.AppendLine("    {");
        //    data.AppendLine("        Task<" + modelName + "DTO> Get" + modelName + "ByID(int ID);");
        //    data.AppendLine("        Task<IEnumerable<" + modelName + "DTO>> GetAll" + modelName + "();");
        //    data.AppendLine("        Task<bool> Add" + modelName + "(" + modelName + "DTO Model);");
        //    data.AppendLine("        Task<bool> Update" + modelName + "(" + modelName + "DTO Model);");
        //    data.AppendLine("        Task<bool> Delete" + modelName + "(int " + modelName + "ID);");
        //    data.AppendLine("    }");
        //    data.AppendLine("}");


        //    // Create the file, or overwrite if the file exists. 
        //    using (FileStream fs = File.Create(path + "\\I" + modelName + "Service.cs"))
        //    {
        //        byte[] info = new UTF8Encoding(true).GetBytes(data.ToString());
        //        // Add some information to the file.
        //        fs.Write(info, 0, info.Length);
        //    }


        //}
        private void CreateDTOGroup(List<string> sFilesNames, string path)
        {
            //if (cbBaseClass.Checked)
            //    baseClass = " : "+ tbInhirit.Text;
            //    path += "\\" + "DTOs";
            //if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            ////create IRepository
            //foreach (var modelName in sFileNames)
            //{
            //    getDataFromModel(modelName, sDirectory, path);
            //    getDataFromModelToCreateDTO(modelName, sDirectory, path);
            //    getDataFromModelToUpdateDTO(modelName, sDirectory, path); 

            //}
        }
        string baseClass = string.Empty;
        public void getDataFromModel(string modelName, string FilePath, string outPutPath)
        {

            //StringBuilder dataForDTO = new StringBuilder();
            //dataForDTO.AppendLine("using System.ComponentModel.DataAnnotations;");
            //dataForDTO.AppendLine("using WeTech.Service.Common;");
            //dataForDTO.AppendLine("");
            //dataForDTO.AppendLine("namespace " + tbDTONameSpace.Text);
            //dataForDTO.AppendLine("{");
            //dataForDTO.AppendLine("    public class " + modelName + "DTO"+baseClass);
            //dataForDTO.AppendLine("    {");
            //dataForDTO.AppendLine("        public int " + modelName + "ID { get; set; }");
            //string sFilePath = sDirectory + "\\" + modelName + ".cs";

            //StreamReader reader = new StreamReader(sFilePath);

            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    if (
            //        string.IsNullOrWhiteSpace(line) ||
            //        line.Trim().ToLower().StartsWith("using") ||
            //        line.Trim().ToLower().StartsWith("system") ||
            //        line.Trim().ToLower().StartsWith("{") ||
            //        line.Trim().ToLower().StartsWith("}") ||
            //        line.Trim().ToLower().StartsWith("public class") ||
            //        line.Trim().ToLower().StartsWith("public partial class") ||
            //        line.Trim().ToLower().StartsWith("[foreignkey") ||
            //        line.Trim().ToLower().StartsWith("public virtual ") ||
            //        line.Trim().ToLower().StartsWith("namespace")||
            //        line.Trim().ToLower().Contains("()")||
            //        line.Trim().ToLower().Contains("HashSet<")
            //        )
            //    {
            //        continue;
            //    }

            //    //Do any edits to the line as needed
            //    string editedLine = line.Replace(" Name ", " " + modelName + "Name");
            //    dataForDTO.AppendLine(editedLine);
            //    //Write the edited line to the output file
            //}
            //reader.Close();
            //dataForDTO.AppendLine(" public string? EncId { get { return EncryptDecrypt.Encrypt("+ modelName+"ID.ToString()); } }");
            //dataForDTO.AppendLine("    }");
            //dataForDTO.AppendLine("}");

            //string cFileName = outPutPath + "\\" + modelName + "DTO.cs";
            //StreamWriter writer = new StreamWriter(cFileName, false);
            //writer.Write(dataForDTO.ToString());
            //writer.Close();

        }
        public void getDataFromModelToCreateDTO(string modelName, string FilePath, string outPutPath)
        {

            //StringBuilder dataForDTO = new StringBuilder();
            //dataForDTO.AppendLine("using System.ComponentModel.DataAnnotations;");
            //dataForDTO.AppendLine("using WeTech.Service.Common;");
            //dataForDTO.AppendLine("");
            //dataForDTO.AppendLine("namespace " + tbDTONameSpace.Text);
            //dataForDTO.AppendLine("{");
            //dataForDTO.AppendLine("    public class Create" + modelName + "DTO");
            //dataForDTO.AppendLine("    {"); 
            //string sFilePath = sDirectory + "\\" + modelName + ".cs";

            //StreamReader reader = new StreamReader(sFilePath);

            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    if (
            //        string.IsNullOrWhiteSpace(line) ||
            //        line.Trim().ToLower().StartsWith("using") ||
            //        line.Trim().ToLower().StartsWith("system") ||
            //        line.Trim().ToLower().StartsWith("{") ||
            //        line.Trim().ToLower().StartsWith("}") ||
            //        line.Trim().ToLower().StartsWith("public class") ||
            //        line.Trim().ToLower().StartsWith("public partial class") ||
            //        line.Trim().ToLower().StartsWith("[foreignkey") ||
            //        line.Trim().ToLower().StartsWith("public virtual ") ||
            //        line.Trim().ToLower().StartsWith("namespace") ||
            //        line.Trim().ToLower().Contains("()") ||
            //        line.Trim().ToLower().Contains("HashSet<")
            //        )
            //    {
            //        continue;
            //    }

            //    //Do any edits to the line as needed
            //    string editedLine = line.Replace(" Name ", " " + modelName + "Name");
            //    dataForDTO.AppendLine(editedLine);
            //    //Write the edited line to the output file
            //}
            //reader.Close();
            //dataForDTO.AppendLine("        public bool IsActive { get; set; } = true;");
            //dataForDTO.AppendLine("        public int CreatedBy { get; set; }");
            //dataForDTO.AppendLine("    }");
            //dataForDTO.AppendLine("}");

            //string cFileName = outPutPath + "\\" +"Create"+ modelName + "DTO.cs";
            //StreamWriter writer = new StreamWriter(cFileName, false);
            //writer.Write(dataForDTO.ToString());
            //writer.Close();

        }
        public void getDataFromModelToUpdateDTO(string modelName, string FilePath, string outPutPath)
        {

            //StringBuilder dataForDTO = new StringBuilder();
            //dataForDTO.AppendLine("using System.ComponentModel.DataAnnotations;");
            //dataForDTO.AppendLine("using WeTech.Service.Common;");
            //dataForDTO.AppendLine("");
            //dataForDTO.AppendLine("namespace " + tbDTONameSpace.Text);
            //dataForDTO.AppendLine("{");
            //dataForDTO.AppendLine("    public class Update" + modelName + "DTO");
            //dataForDTO.AppendLine("    {");
            //dataForDTO.AppendLine("        public int " + modelName + "ID { get; set; }");
            //string sFilePath = sDirectory + "\\" + modelName + ".cs";

            //StreamReader reader = new StreamReader(sFilePath);

            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    if (
            //        string.IsNullOrWhiteSpace(line) ||
            //        line.Trim().ToLower().StartsWith("using") ||
            //        line.Trim().ToLower().StartsWith("system") ||
            //        line.Trim().ToLower().StartsWith("{") ||
            //        line.Trim().ToLower().StartsWith("}") ||
            //        line.Trim().ToLower().StartsWith("public class") ||
            //        line.Trim().ToLower().StartsWith("public partial class") ||
            //        line.Trim().ToLower().StartsWith("[foreignkey") ||
            //        line.Trim().ToLower().StartsWith("public virtual ") ||
            //        line.Trim().ToLower().StartsWith("namespace") ||
            //        line.Trim().ToLower().Contains("()") ||
            //        line.Trim().ToLower().Contains("HashSet<")
            //        )
            //    {
            //        continue;
            //    }

            //    //Do any edits to the line as needed
            //    string editedLine = line.Replace(" Name ", " " + modelName + "Name");
            //    dataForDTO.AppendLine(editedLine);
            //    //Write the edited line to the output file
            //}
            //reader.Close();
            //dataForDTO.AppendLine("        public bool IsActive { get; set; } = true;");
            //dataForDTO.AppendLine("        public int UpdatedBy { get; set; }");
            //dataForDTO.AppendLine("        public DateTime? LastUpdatedOn { get; set; }");
            //dataForDTO.AppendLine("        public string? EncId { get { return EncryptDecrypt.Encrypt(" + modelName + "ID.ToString()); } }");
            //dataForDTO.AppendLine("    }");
            //dataForDTO.AppendLine("}");

            //string cFileName = outPutPath + "\\" + "Update" + modelName + "DTO.cs";
            //StreamWriter writer = new StreamWriter(cFileName, false);
            //writer.Write(dataForDTO.ToString());
            //writer.Close();

        }
        public void CreateIRepoFileByName(string modelName, string path)
        {
            //string RepositoryData =
            //"using " + tbDomainModels.Text + "; \n" +
            //"using " + tbRepositoryGenaric.Text + "; \n" +
            //"namespace " + tbRepoNameSpace.Text + "\n" +
            //"{" + "\n" +
            //   "    public interface I" + modelName + "Repository : IRepository<" + modelName + "> \n" +
            //    "    {" + "\n" +
            //    " " +
            //    "    }" + "\n" +
            //"}";


            // Create the file, or overwrite if the file exists. 
            //using (FileStream fs = File.Create(path + "\\I" + modelName + "Repository.cs"))
            //{
            //    byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
            //    // Add some information to the file.
            //    fs.Write(info, 0, info.Length);
            //}
        }
        public void CreateServiceIRepoFileByName(string modelName, string path)
        {
            string modelNameDTO = modelName + "DTO";
            string RepositoryData = $"using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing StockApp.Service.DTO;\r\n\r\nnamespace StockApp.Service.Interfaces\r\n{{\r\n    public interface I{{0}}Service\r\n    {{\r\n        Task<{{0}}DTO> Get{{0}}ByID(int ID);\r\n        Task<IEnumerable<BranchDTO>> GetAll{{0}}();\r\n        Task<bool> Add{{0}}({{0}}DTO Model);\r\n        Task<bool> Update{{0}}({{0}}DTO Model);\r\n        Task<bool> Delete{{0}}(int {{0}}ID);\r\n    }}\r\n}}\r\n";

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
            //if (string.IsNullOrEmpty(tbRepoNameSpace.Text))
            //{
            //    MessageBox.Show("select Name Space ", "Error Message");
            //    return false;
            //}
            //if (string.IsNullOrEmpty(tbDomainModels.Text))
            //{
            //    MessageBox.Show("select Domain Models ", "Error Message");
            //    return false;
            //}
            //if (string.IsNullOrEmpty(tbDomainInterface.Text))
            //{
            //    MessageBox.Show("select Domain Interface ", "Error Message");
            //    return false;
            //}
            //if (string.IsNullOrEmpty(tbDbContext.Text))
            //{
            //    MessageBox.Show("select DbContext Name ", "Error Message");
            //    return false;
            //}
            //if (cbCustomFile.Checked && string.IsNullOrEmpty(FileContent))
            //{
            //    MessageBox.Show("Custom file has no Data. \n please click Custom button and set your data ", "Error Message");
            //    return false;
            //}
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("Please select models first or add its names", "Error Message");
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var lasts = getManagerMethouds();

            //getCurrentProccess();
            if (!check())
                return;

            sFileNames = new List<string>();
            GetFileNames();
            string SelectedPath = tbSelectedPath.Text;
            if (cbIsGenaric.Checked)
                CreateGroup(sFileNames, SelectedPath);

            if (cbSaveConfig.Checked)
                CreateConfigFIle(SelectedPath);

            MessageBox.Show("All Done Well");
            Process.Start("explorer.exe", SelectedPath);

        }
        private void CreateGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "Group";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            {
                path += "\\" + modelName;
                if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);

                var (commandList, queryList, returnTypes) = getManagerMethouds();
                for (int i = 0; i < queryList.Count; i++)
                {
                    CreateSearchQuery(queryList[i], path, returnTypes[i],modelName);
                    CreateSearchHandler(queryList[i], path, returnTypes[i],modelName);
                }
                for (int i = 0; i < commandList.Count; i++)
                {
                    CreateCommand(commandList[i], path, modelName);
                    CreateHandler(commandList[i], path, modelName);
                }
               
                CreateSearchFilter(modelName, path);

                CreateIService(modelName, path);
                CreateService(modelName, path);
            }
        }
        public (List<string>, List<string>, List<string>) getManagerMethouds()
        {
            var methoudQuery = new List<string>();
            var methoudQueryReturnType = new List<string>();
            var methoudCommand = new List<string>();
            string multilineString = RBManager.Text;
            foreach (var item in RBManager.Lines)
            {
                var arrFuncWords = item.Trim().Split(new char[] { ' ' });
                if (item.Trim().StartsWith("public void"))
                {
                    var funcName = arrFuncWords?[2].Split(new char[] { '(' })[0];
                    if (funcName != "")
                        methoudCommand.Add(funcName);
                }
                else if (item.Trim().StartsWith("public "))
                {
                    var funcName = arrFuncWords?[2].Split(new char[] { '(' })[0];
                    var returnType = arrFuncWords[1];
                    if (funcName != "" && funcName != ":")
                    {
                        methoudQuery.Add(funcName);
                        methoudQueryReturnType.Add(returnType);
                    }
                }
            }
            return (methoudCommand, methoudQuery, methoudQueryReturnType);
        }
        public void CreateSearchHandler(string FuncName, string path, string returnType,string ModelName)
        {
            string multilineString = @"
using Dapper;
using MediatR;
using SAPTEC.Framework.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SAPTEC.ERP.Infrastructure;

namespace SAPTEC.ERP.Setup.Domain 
{
    public class {0}Handler : IRequestHandler<{0}Query, {1}>
    {
        public async Task<{1}> Handle({0}Query request, CancellationToken cancellationToken)
        {
            var parameters = new DynamicParameters();
            parameters.Add(""@MerchantId"", request.Filter.MerchantId); 
            parameters.Add(""@Id"", request.Filter.Id);
            parameters.Add(""@Language"", request.Filter.LanguageId);
            parameters.Add(""@PageNumber"", request.Filter.PageNumber);
            parameters.Add(""@PageSize"", request.Filter.PageSize); 

            parameters.AddTotalNumberParameter(); 

            var list = await DapperHelper.ExecuteQueryListAsync<{2}>(SetupConstants.{2}.SP_{0}GetAll, parameters, cancellationToken);
            int totalNumberOfResult = parameters.Get<int>(""@TotalNumberOfResult"");

            return (list, totalNumberOfResult);
        }
    } 
} 
                ";
            string interpolatedString = multilineString.Replace("{0}", FuncName);
            interpolatedString = interpolatedString.Replace("{1}", returnType);
            interpolatedString = interpolatedString.Replace("{2}", ModelName);
            path += "\\" + "Query";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            using (FileStream fs = File.Create(path + "\\" + FuncName + "Handler.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateSearchQuery(string FuncName, string path, string returnType,string modelName)
        {
            string multilineString = @"
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPTEC.ERP.Setup.Domain 
{
    public class {0}Query : IRequest<{1}>
    {
        public {2}Filter Filter { get; set; }
    }
}

                ";
            string interpolatedString = multilineString.Replace("{0}", FuncName);
            interpolatedString = interpolatedString.Replace("{1}", returnType);
            interpolatedString = interpolatedString.Replace("{2}", modelName);

            path += "\\" + "Query";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);

            using (FileStream fs = File.Create(path + "\\" + FuncName + "Query.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateSearchFilter(string modelName, string path)
        {
            string multilineString = @"
using SAPTEC.ERP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPTEC.ERP.Setup.Domain 
{
    public class {0}SearchFilter :BaseFilter
    {  
        public int? MerchantId { get; set; } 
        public int? Id { get; set; } 

    }
}
                ";
            string interpolatedString = multilineString.Replace("{0}", modelName);
            using (FileStream fs = File.Create(path + "\\" + modelName + "SearchFilter.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateCommand(string FuncName, string path, string modelName)
        {
            string multilineString = @"
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPTEC.ERP.Setup.Domain 
{
    public class {0}Command : IRequest
    {
        public {0} Entity { get; set; }
        public bool IsDeleted { get; set; }
    }
}";
            string interpolatedString = multilineString.Replace("{0}", FuncName);
            path += "\\" + "Command";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            using (FileStream fs = File.Create(path + "\\" + modelName + "Command.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateHandler(string FuncName, string path, string modelName)
        {
            string multilineString = @"
using MediatR;
using Newtonsoft.Json;
using SAPTEC.ERP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SAPTEC.ERP.Setup.Domain.SetupConstants;

namespace SAPTEC.ERP.Setup.Domain 
{
    public class {0}Handler : IRequestHandler<{0}Command>
    {
        public async Task Handle({0}Command request, CancellationToken cancellationToken)
        {
            var genaricEntity = new GenericEntity();
            genaricEntity.MasterTableName = TablesNames.{0};
            genaricEntity.Id = request.Entity.Id; 
            genaricEntity.MerchantId = request.Entity.MerchantId; 
            genaricEntity.ProcessCode = request.IsDeleted ? DALConstants.SharedStoredProcedures.SP_GenericTableDelete : request.Entity.Id > 0 ? ProcessCode.{0}Update : ProcessCode.{0}Add;
            genaricEntity.UserId = request.Entity.Id > 0 || request.IsDeleted ? request.Entity.ModifiedBy : request.Entity.CreatedBy;
            if (!request.IsDeleted)
            {
                if (request.Entity.Id > 0)
                {
                    genaricEntity.MasterTableData = request.Entity.ConvertModel<{0}, Editable{0}>();
                }
                else
                {
                    genaricEntity.MasterTableData = JsonConvert.SerializeObject(request.Entity);
                }
            }

            if (!request.IsDeleted)
            {
                await GenericCommandHandler.Save(genaricEntity);
                request.Entity.Id = (int)genaricEntity.Id;
            }
            else
            { 
                await GenericCommandHandler.Delete(genaricEntity);
            }

            request.Entity.Flag = genaricEntity.Flag;
        }
    }
}
";
            string interpolatedString = multilineString.Replace("{0}", FuncName);
            path += "\\" + "Command";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            using (FileStream fs = File.Create(path + "\\" + modelName + "Handler.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        public void CreateIService(string modelName, string path)
        {
            string multilineString = @"
using SAPTEC.ERP.Setup.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAPTEC.ERP.Setup.Application 
{
    public interface I{0}Service
    {
        Task<(List<{0}>, int)> GetAll({0}SearchFilter filter);
        Task Save({0} entity);
        Task Delete({0} entity);
    }
}
";
            string interpolatedString = multilineString.Replace("{0}", modelName);
            using (FileStream fs = File.Create(path + "\\I" + modelName + "Service.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public void CreateService(string modelName, string path)
        {
            string multilineString = @"
using MediatR;
using SAPTEC.ERP.Infrastructure;
using SAPTEC.ERP.Setup.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAPTEC.ERP.Setup.Application 
{
    public class {0}Service : I{0}Service
    {
        private readonly IMediator _mediator;

        public {0}Service(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<(List<{0}>, int)> GetAll({0}SearchFilter filter)
        {
            var result = await _mediator.Send(new Search{0}Query { Filter = filter });
            return result;
        }
        public async Task Save({0} entity)
        {
            await _mediator.Send(new {0}Command { Entity = entity });
            entity.Flag.Language = entity.Language;
            entity.Flag = await ValidationHelper.GetValidationMessage(entity.Flag);
        }
        public async Task Delete({0} entity)
        {
            await _mediator.Send(new {0}Command { Entity = entity, IsDeleted = true });
            entity.Flag.Language = entity.Language;
            entity.Flag = await ValidationHelper.GetValidationMessage(entity.Flag);
        }
    }
}

";
            string interpolatedString = multilineString.Replace("{0}", modelName);
            using (FileStream fs = File.Create(path + "\\" + modelName + "Service.cs"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(interpolatedString);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        private void getCurrentProccess()
        {
            string txt = "";

            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                txt += "Process Name: " + process.ProcessName;
                txt += "Process ID: " + process.Id;
                txt += "-------------------------------------";
                txt += "Modules:";
                foreach (ProcessModule module in process.Modules)
                {

                    try
                    {
                        txt += "    Name:  " + module.ModuleName;
                        txt += "    File Name:  " + module.FileName;
                        txt += "    Memory Size: " + module.ModuleMemorySize;
                        txt += "-------------------------------------";
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }

                }
            }
            MessageBox.Show(txt);
        }
        private void CreateControllersGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "ApiControllers";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            { CreateControllers(modelName, path); }
        }
        private void CreateControllersMVCGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "ControllersMVC";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            foreach (var modelName in sFileNames)
            { CreateControllersMVC(modelName, path); }
        }
        public void CreateControllersMVC(string modelName, string path)
        {
            //StringBuilder data = new StringBuilder();
            //data.AppendLine("using Microsoft.AspNetCore.Mvc;");
            //data.AppendLine("using Microsoft.Extensions.Localization;");
            //data.AppendLine("using " + tbDTONameSpace.Text + ";");
            //data.AppendLine("using " + tbServiceInterface.Text + ";"); 
            //data.AppendLine("");
            //data.AppendLine("namespace " + tbControllerNameSpace.Text);
            //data.AppendLine("{");
            //data.AppendLine("    public class " + modelName + "Controller : Controller");
            //data.AppendLine("    {");
            //data.AppendLine("        private readonly I" + modelName + "Service _Service;");
            //data.AppendLine("        private readonly IStringLocalizer<HomeController> _loc;");

            //data.AppendLine("        public " + modelName + "Controller(I" + modelName + "Service service, IStringLocalizer<HomeController> loc)");
            //data.AppendLine("        {");
            //data.AppendLine("            _Service = service;");
            //data.AppendLine("            _loc = loc;");
            //data.AppendLine("        }");
            ////Views 
            ////Index
            //data.AppendLine("        public IActionResult Index()");
            //data.AppendLine("        {");
            //data.AppendLine("              return View();"); 
            //data.AppendLine("        }");
            //data.AppendLine("");
            ////Create
            //data.AppendLine("        public IActionResult Create()");
            //data.AppendLine("        {");
            //data.AppendLine("              return View();");
            //data.AppendLine("        }");
            //data.AppendLine("");
            ////Edit
            //data.AppendLine("        public IActionResult Edit(string EncId)");
            //data.AppendLine("        {");
            //data.AppendLine("            var entity = _Service.Get"+ modelName + "ByIDToUpdate(EncId).Result;");
            //data.AppendLine("            return View(entity);");
            //data.AppendLine("        }");
            //data.AppendLine("");

            ////Add Methoud
            //data.AppendLine("        #region Methouds"); 

            //data.AppendLine("        [HttpGet]");
            //data.AppendLine("        public async Task<IActionResult> GetAll()");
            //data.AppendLine("        {");
            //data.AppendLine("            var Result = await _Service.GetAll" + modelName + "();");
            //data.AppendLine("            return Json(new { data = Result }); ");
            //data.AppendLine("        }");
            //data.AppendLine("");

            //data.AppendLine("        [HttpPost]");
            //data.AppendLine("        public async Task<IActionResult> Create(Create" + modelName + "DTO model)");
            //data.AppendLine("        {");
            //data.AppendLine("             model.CreatedBy = 8;"); 
            //data.AppendLine("            var Result = await _Service.Add" + modelName + "(model);");
            //data.AppendLine("            if (Result)");
            //data.AppendLine("                return Json(new { success = true, message = _loc[\"global:Message:Success\"].Value });"); 
            //data.AppendLine("            return Json(new { success = false, message = _loc[\"global: Message:Error\"].Value });"); 
            //data.AppendLine("        }");
            //data.AppendLine("");

            //data.AppendLine("        [HttpPost]");
            //data.AppendLine("        public async Task<IActionResult> Update([FromForm]Update" + modelName + "DTO model)");
            //data.AppendLine("        {"); 
            //data.AppendLine("            var Result = await _Service.Update" + modelName + "(model);");
            //data.AppendLine("            if (Result)");
            //data.AppendLine("                return Json(new { success = true, message = _loc[\"global:Message:Success\"].Value });");
            //data.AppendLine("            return Json(new { success = false, message = _loc[\"global: Message:Error\"].Value });");
            //data.AppendLine("        }");
            //data.AppendLine("");

            //data.AppendLine("        [HttpDelete]");
            //data.AppendLine("        public async Task<IActionResult> Delete(string EncId)");
            //data.AppendLine("        {");
            //data.AppendLine("            var Result = await _Service.Delete" + modelName + "(EncId);");
            //data.AppendLine("            if (Result)");
            //data.AppendLine("                return Json(new { success = true, message = _loc[\"global:Message:Success\"].Value });");
            //data.AppendLine("            return Json(new { success = false, message = _loc[\"global: Message:Error\"].Value });");
            //data.AppendLine("        }");
            //data.AppendLine("");

            //data.AppendLine("        #endregion");
            //data.AppendLine("");
            //data.AppendLine("    }");
            //data.AppendLine("}");

            //string cFileName = path + "\\" + modelName + "Controller.cs";
            //StreamWriter writer = new StreamWriter(cFileName, false);
            //writer.Write(data.ToString());
            //writer.Close();


        }
        public void CreateControllers(string modelName, string path)
        {

        }
        private void CreateMapperGroup(List<string> sFilesNames, string path)
        {
            path += "\\" + "Mapper";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            //create IRepository
            StringBuilder data = new StringBuilder();
            StringBuilder ctorMethods = new StringBuilder();
            ctorMethods.AppendLine("        //Mapper Ctor - MapperConfig() Part Start");
            data.AppendLine("        //Methods Start");
            foreach (var modelName in sFileNames)
            {
                ctorMethods.AppendLine("            " + modelName + "Mapper();");

                data.AppendLine("        private void " + modelName + "Mapper()");
                data.AppendLine("        {");
                data.AppendLine("            CreateMap<" + modelName + "DTO, " + modelName + ">()");
                data.AppendLine("               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src." + modelName + "ID))");
                data.AppendLine("               .ReverseMap();");
                data.AppendLine("            CreateMap<Create" + modelName + "DTO, " + modelName + ">();");
                data.AppendLine("            CreateMap<" + modelName + ",Update" + modelName + "DTO>()");
                data.AppendLine("               .ForMember(dest => dest." + modelName + "ID, opt => opt.MapFrom(src => src.Id ))");
                data.AppendLine("               .ReverseMap();");
                data.AppendLine("        }");
                data.AppendLine("");

            }
            ctorMethods.AppendLine("        //Mapper Ctor - MapperConfig() Part End");
            ctorMethods.AppendLine(" ");
            data.AppendLine("        //Methods End");
            ctorMethods.Append(data.ToString());
            // Create the file, or overwrite if the file exists. 
            using (FileStream fs = File.Create(path + "mapperFunctions.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(ctorMethods.ToString());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
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
                //tbRepoNameSpace.Text = keyValuePairs["RepositoryNameSpace"] != null ? keyValuePairs["RepositoryNameSpace"] : "";
                //tbDomainInterface.Text = keyValuePairs["InterfaceNameSpace"] != null ? keyValuePairs["InterfaceNameSpace"] : "";
                //tbDomainModels.Text = keyValuePairs["ModelsNameSpace"] != null ? keyValuePairs["ModelsNameSpace"] : "";
                //tbDbContextNameSpace.Text = keyValuePairs["DBContextNameSpace"] != null ? keyValuePairs["DBContextNameSpace"] : "";
                //tbDbContext.Text = keyValuePairs["DBContextName"] != null ? keyValuePairs["DBContextName"] : "";
                //tbdbContextInstance.Text = keyValuePairs["dbContextInstanceName"] != null ? keyValuePairs["dbContextInstanceName"] : "";

                //tbRepositoryGenaric.Text = keyValuePairs["RepositoryGenaric"] != null ? keyValuePairs["RepositoryGenaric"] : "";
                //tbDTONameSpace.Text = keyValuePairs["DTONameSpace"] != null ? keyValuePairs["DTONameSpace"] : "";
                //tbControllerNameSpace.Text = keyValuePairs["ControllerNameSpace"] != null ? keyValuePairs["ControllerNameSpace"] : "";
                //tbServiceInterface.Text = keyValuePairs["ServiceInterface"] != null ? keyValuePairs["ServiceInterface"] : "";
                //tbServiceNameSpace.Text = keyValuePairs["ServiceNameSpace"] != null ? keyValuePairs["ServiceNameSpace"] : "";

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
            //keyValuePairs.Add("RepositoryNameSpace", tbRepoNameSpace.Text);
            //keyValuePairs.Add("InterfaceNameSpace", tbDomainInterface.Text);
            //keyValuePairs.Add("ModelsNameSpace", tbDomainModels.Text);
            //keyValuePairs.Add("DBContextNameSpace", tbDbContextNameSpace.Text);
            //keyValuePairs.Add("DBContextName", tbDbContext.Text);
            //keyValuePairs.Add("dbContextInstanceName", tbdbContextInstance.Text);

            //keyValuePairs.Add("RepositoryGenaric", tbRepositoryGenaric.Text);
            //keyValuePairs.Add("DTONameSpace", tbDTONameSpace.Text);
            //keyValuePairs.Add("ControllerNameSpace", tbControllerNameSpace.Text); 
            //keyValuePairs.Add("ServiceInterface", tbServiceInterface.Text); 
            //keyValuePairs.Add("ServiceNameSpace", tbServiceNameSpace.Text);  

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
                char lastCharacter = modelName[modelName.Length - 1];
                string s = lastCharacter == 'y' ? "ies" : "s";
                string modelNamePlural = modelName.Remove(modelName.Length - 1) + s;
                RepositoryData += "        public virtual DbSet<" + modelName + "> " + modelNamePlural + " { set; get; }  \n";
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
            //string RepositoryData = "//UnitOfWork Start Constractor() part \n";
            //foreach (var modelName in sFilesNames)
            //{
            //    RepositoryData += modelName + "Repository" + " = new " + modelName + "Repository(" + tbdbContextInstance.Text + "); \n";
            //}
            //RepositoryData += "// End Constractor part \n \n";
            //RepositoryData += "// strat Content \n";

            //foreach (var modelName in sFilesNames)
            //{
            //    RepositoryData += "public I" + modelName + "Repository " + modelName + "Repository" + " { get; private set; }  \n";
            //}
            //RepositoryData += "// End Content \n";

            //path += "\\" + "UnitOfWork";
            //if (!System.IO.Directory.Exists(path))
            //{
            //    System.IO.Directory.CreateDirectory(path);
            //}

            //using (FileStream fs = File.Create(path + "\\" + "AddToUnitOfWork.txt"))
            //{
            //    byte[] info = new UTF8Encoding(true).GetBytes(RepositoryData);
            //    // Add some information to the file.
            //    fs.Write(info, 0, info.Length);
            //}
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

        private void cbDTOs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBaseClass_CheckedChanged(object sender, EventArgs e)
        {
            //tbInhirit.Enabled = cbBaseClass.Checked;
        }

        private void rtUsingAdditonal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}