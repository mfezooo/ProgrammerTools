using System.Windows.Forms;

namespace ProgrammerTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSelectedPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectModels = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectRepoPath = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbRepoNameSpace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDomainModels = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDomainInterface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDbContext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDbContextNameSpace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddNewModel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbdbContextInstance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRepositoryGenaric = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbServiceProjName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbServiceInterfaceFolderName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbServiceDTOFolderName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelectedPath
            // 
            this.tbSelectedPath.Location = new System.Drawing.Point(271, 79);
            this.tbSelectedPath.Name = "tbSelectedPath";
            this.tbSelectedPath.Size = new System.Drawing.Size(188, 20);
            this.tbSelectedPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collection";
            // 
            // btnSelectModels
            // 
            this.btnSelectModels.Location = new System.Drawing.Point(25, 118);
            this.btnSelectModels.Name = "btnSelectModels";
            this.btnSelectModels.Size = new System.Drawing.Size(206, 20);
            this.btnSelectModels.TabIndex = 2;
            this.btnSelectModels.Text = "Select Models";
            this.btnSelectModels.UseVisualStyleBackColor = true;
            this.btnSelectModels.Click += new System.EventHandler(this.btnSelectModels_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 342);
            this.listBox1.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(166, 505);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 20);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Path";
            // 
            // btnSelectRepoPath
            // 
            this.btnSelectRepoPath.Location = new System.Drawing.Point(465, 80);
            this.btnSelectRepoPath.Name = "btnSelectRepoPath";
            this.btnSelectRepoPath.Size = new System.Drawing.Size(77, 20);
            this.btnSelectRepoPath.TabIndex = 2;
            this.btnSelectRepoPath.Text = "Select Folder";
            this.btnSelectRepoPath.UseVisualStyleBackColor = true;
            this.btnSelectRepoPath.Click += new System.EventHandler(this.btnSelectRepoPath_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(933, 476);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 49);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbRepoNameSpace
            // 
            this.tbRepoNameSpace.Location = new System.Drawing.Point(274, 288);
            this.tbRepoNameSpace.Name = "tbRepoNameSpace";
            this.tbRepoNameSpace.Size = new System.Drawing.Size(259, 20);
            this.tbRepoNameSpace.TabIndex = 0;
            this.tbRepoNameSpace.Text = "TransPro.DataAccess.Interfaces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Repository Name Space  [TableRepository]";
            // 
            // tbDomainModels
            // 
            this.tbDomainModels.Location = new System.Drawing.Point(274, 404);
            this.tbDomainModels.Name = "tbDomainModels";
            this.tbDomainModels.Size = new System.Drawing.Size(259, 20);
            this.tbDomainModels.TabIndex = 0;
            this.tbDomainModels.Text = "TransPro.Entities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Models Name Space [Entities]";
            // 
            // tbDomainInterface
            // 
            this.tbDomainInterface.Location = new System.Drawing.Point(274, 329);
            this.tbDomainInterface.Name = "tbDomainInterface";
            this.tbDomainInterface.Size = new System.Drawing.Size(259, 20);
            this.tbDomainInterface.TabIndex = 0;
            this.tbDomainInterface.Text = "TransPro.DataAccess.Repositories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Interface Name Space [ITableRepository]";
            // 
            // tbDbContext
            // 
            this.tbDbContext.Location = new System.Drawing.Point(274, 176);
            this.tbDbContext.Name = "tbDbContext";
            this.tbDbContext.Size = new System.Drawing.Size(259, 20);
            this.tbDbContext.TabIndex = 0;
            this.tbDbContext.Text = "TransProContext";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "DbContext Class Name";
            // 
            // tbDbContextNameSpace
            // 
            this.tbDbContextNameSpace.Location = new System.Drawing.Point(274, 135);
            this.tbDbContextNameSpace.Name = "tbDbContextNameSpace";
            this.tbDbContextNameSpace.Size = new System.Drawing.Size(259, 20);
            this.tbDbContextNameSpace.TabIndex = 0;
            this.tbDbContextNameSpace.Text = "TransPro.DataAccess.Context";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "DbContext Name Space";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(932, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Developed by Fezo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbModelName
            // 
            this.tbModelName.Location = new System.Drawing.Point(25, 80);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.Size = new System.Drawing.Size(151, 20);
            this.tbModelName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // btnAddNewModel
            // 
            this.btnAddNewModel.Location = new System.Drawing.Point(181, 80);
            this.btnAddNewModel.Name = "btnAddNewModel";
            this.btnAddNewModel.Size = new System.Drawing.Size(50, 20);
            this.btnAddNewModel.TabIndex = 2;
            this.btnAddNewModel.Text = "Add";
            this.btnAddNewModel.UseVisualStyleBackColor = true;
            this.btnAddNewModel.Click += new System.EventHandler(this.btnAddNewModel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Models";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(25, 505);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(74, 20);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(21, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(475, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Generate [Repository, IRepository, UnitOfWork, IUnitOfwork]";
            // 
            // tbdbContextInstance
            // 
            this.tbdbContextInstance.Location = new System.Drawing.Point(274, 217);
            this.tbdbContextInstance.Name = "tbdbContextInstance";
            this.tbdbContextInstance.Size = new System.Drawing.Size(259, 20);
            this.tbdbContextInstance.TabIndex = 0;
            this.tbdbContextInstance.Text = "_Context";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "DbContext Instance Name";
            // 
            // tbRepositoryGenaric
            // 
            this.tbRepositoryGenaric.Location = new System.Drawing.Point(274, 447);
            this.tbRepositoryGenaric.Name = "tbRepositoryGenaric";
            this.tbRepositoryGenaric.Size = new System.Drawing.Size(259, 20);
            this.tbRepositoryGenaric.TabIndex = 0;
            this.tbRepositoryGenaric.Text = "TransPro.Infrastructure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genaric Repository Name Space [Infrastructure]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "____________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(268, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(271, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "____________________________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbServiceDTOFolderName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbServiceInterfaceFolderName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbServiceProjName);
            this.groupBox1.Location = new System.Drawing.Point(561, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // tbServiceProjName
            // 
            this.tbServiceProjName.Location = new System.Drawing.Point(9, 41);
            this.tbServiceProjName.Name = "tbServiceProjName";
            this.tbServiceProjName.Size = new System.Drawing.Size(259, 20);
            this.tbServiceProjName.TabIndex = 0;
            this.tbServiceProjName.Text = "TransPro.Service";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Service Project Name";
            // 
            // tbServiceInterfaceFolderName
            // 
            this.tbServiceInterfaceFolderName.Location = new System.Drawing.Point(9, 81);
            this.tbServiceInterfaceFolderName.Name = "tbServiceInterfaceFolderName";
            this.tbServiceInterfaceFolderName.Size = new System.Drawing.Size(259, 20);
            this.tbServiceInterfaceFolderName.TabIndex = 0;
            this.tbServiceInterfaceFolderName.Text = "Interfaces";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Service Interfaces Folder Name";
            // 
            // tbServiceDTOFolderName
            // 
            this.tbServiceDTOFolderName.Location = new System.Drawing.Point(9, 121);
            this.tbServiceDTOFolderName.Name = "tbServiceDTOFolderName";
            this.tbServiceDTOFolderName.Size = new System.Drawing.Size(259, 20);
            this.tbServiceDTOFolderName.TabIndex = 0;
            this.tbServiceDTOFolderName.Text = "DTO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "DTO Folder Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAddNewModel);
            this.Controls.Add(this.btnSelectRepoPath);
            this.Controls.Add(this.btnSelectModels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbRepositoryGenaric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDbContextNameSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdbContextInstance);
            this.Controls.Add(this.tbDbContext);
            this.Controls.Add(this.tbDomainInterface);
            this.Controls.Add(this.tbDomainModels);
            this.Controls.Add(this.tbRepoNameSpace);
            this.Controls.Add(this.tbModelName);
            this.Controls.Add(this.tbSelectedPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Developer Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSelectedPath;
        private Label label1;
        private Button btnSelectModels;
        private ListBox listBox1;
        private Button btnRemove;
        private Label label2;
        private Button btnSelectRepoPath;
        private Button btnCreate;
        private TextBox tbRepoNameSpace;
        private Label label4;
        private TextBox tbDomainModels;
        private Label label5;
        private TextBox tbDomainInterface;
        private Label label6;
        private TextBox tbDbContext;
        private Label label7;
        private TextBox tbDbContextNameSpace;
        private Label label8;
        private Label label9;
        private TextBox tbModelName;
        private Label label10;
        private Button btnAddNewModel;
        private Label label11;
        private Button btnRemoveAll;
        private Label label12;
        private TextBox tbdbContextInstance;
        private Label label13;
        private TextBox tbRepositoryGenaric;
        private Label label3;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
        private Label label17;
        private TextBox tbServiceInterfaceFolderName;
        private Label label14;
        private TextBox tbServiceProjName;
        private Label label18;
        private TextBox tbServiceDTOFolderName;
    }
}