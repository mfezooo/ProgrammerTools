﻿using System.Windows.Forms;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDTONameSpace = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbServiceInterface = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbServiceNameSpace = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbControllerNameSpace = new System.Windows.Forms.TextBox();
            this.gpCheckBoxs = new System.Windows.Forms.GroupBox();
            this.cbCustomFile = new System.Windows.Forms.CheckBox();
            this.cbMapDToToMdel = new System.Windows.Forms.CheckBox();
            this.cbControllers = new System.Windows.Forms.CheckBox();
            this.cbDTOs = new System.Windows.Forms.CheckBox();
            this.cbServiceInterface = new System.Windows.Forms.CheckBox();
            this.cbServices = new System.Windows.Forms.CheckBox();
            this.cbIUnitOfWork = new System.Windows.Forms.CheckBox();
            this.cbUnitOfWork = new System.Windows.Forms.CheckBox();
            this.cbIRepository = new System.Windows.Forms.CheckBox();
            this.cbRepository = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbSaveConfig = new System.Windows.Forms.CheckBox();
            this.rtUsingAdditonal = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbControllerMVC = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gpCheckBoxs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelectedPath
            // 
            this.tbSelectedPath.Location = new System.Drawing.Point(361, 97);
            this.tbSelectedPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSelectedPath.Name = "tbSelectedPath";
            this.tbSelectedPath.Size = new System.Drawing.Size(265, 22);
            this.tbSelectedPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collection";
            // 
            // btnSelectModels
            // 
            this.btnSelectModels.Location = new System.Drawing.Point(33, 145);
            this.btnSelectModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectModels.Name = "btnSelectModels";
            this.btnSelectModels.Size = new System.Drawing.Size(275, 25);
            this.btnSelectModels.TabIndex = 2;
            this.btnSelectModels.Text = "Select Models";
            this.btnSelectModels.UseVisualStyleBackColor = true;
            this.btnSelectModels.Click += new System.EventHandler(this.btnSelectModels_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 175);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 404);
            this.listBox1.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(193, 598);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 25);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Path";
            // 
            // btnSelectRepoPath
            // 
            this.btnSelectRepoPath.Location = new System.Drawing.Point(636, 98);
            this.btnSelectRepoPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectRepoPath.Name = "btnSelectRepoPath";
            this.btnSelectRepoPath.Size = new System.Drawing.Size(103, 25);
            this.btnSelectRepoPath.TabIndex = 2;
            this.btnSelectRepoPath.Text = "Select Folder";
            this.btnSelectRepoPath.UseVisualStyleBackColor = true;
            this.btnSelectRepoPath.Click += new System.EventHandler(this.btnSelectRepoPath_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1172, 539);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(236, 60);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbRepoNameSpace
            // 
            this.tbRepoNameSpace.Location = new System.Drawing.Point(8, 41);
            this.tbRepoNameSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRepoNameSpace.Name = "tbRepoNameSpace";
            this.tbRepoNameSpace.Size = new System.Drawing.Size(344, 22);
            this.tbRepoNameSpace.TabIndex = 0;
            this.tbRepoNameSpace.Text = "TransPro.DataAccess.Interfaces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Repository Name Space  [TableRepository]";
            // 
            // tbDomainModels
            // 
            this.tbDomainModels.Location = new System.Drawing.Point(8, 44);
            this.tbDomainModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDomainModels.Name = "tbDomainModels";
            this.tbDomainModels.Size = new System.Drawing.Size(344, 22);
            this.tbDomainModels.TabIndex = 0;
            this.tbDomainModels.Text = "TransPro.Entities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Models Name Space [Entities]";
            // 
            // tbDomainInterface
            // 
            this.tbDomainInterface.Location = new System.Drawing.Point(8, 91);
            this.tbDomainInterface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDomainInterface.Name = "tbDomainInterface";
            this.tbDomainInterface.Size = new System.Drawing.Size(344, 22);
            this.tbDomainInterface.TabIndex = 0;
            this.tbDomainInterface.Text = "TransPro.DataAccess.Repositories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Interface Name Space [ITableRepository]";
            // 
            // tbDbContext
            // 
            this.tbDbContext.Location = new System.Drawing.Point(12, 101);
            this.tbDbContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDbContext.Name = "tbDbContext";
            this.tbDbContext.Size = new System.Drawing.Size(344, 22);
            this.tbDbContext.TabIndex = 0;
            this.tbDbContext.Text = "TransProContext";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "DbContext Class Name";
            // 
            // tbDbContextNameSpace
            // 
            this.tbDbContextNameSpace.Location = new System.Drawing.Point(12, 50);
            this.tbDbContextNameSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDbContextNameSpace.Name = "tbDbContextNameSpace";
            this.tbDbContextNameSpace.Size = new System.Drawing.Size(344, 22);
            this.tbDbContextNameSpace.TabIndex = 0;
            this.tbDbContextNameSpace.Text = "TransPro.DataAccess.Context";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "DbContext Name Space";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1276, 603);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Developed by Fezo";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // tbModelName
            // 
            this.tbModelName.Location = new System.Drawing.Point(33, 98);
            this.tbModelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.Size = new System.Drawing.Size(200, 22);
            this.tbModelName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // btnAddNewModel
            // 
            this.btnAddNewModel.Location = new System.Drawing.Point(241, 98);
            this.btnAddNewModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewModel.Name = "btnAddNewModel";
            this.btnAddNewModel.Size = new System.Drawing.Size(67, 25);
            this.btnAddNewModel.TabIndex = 2;
            this.btnAddNewModel.Text = "Add";
            this.btnAddNewModel.UseVisualStyleBackColor = true;
            this.btnAddNewModel.Click += new System.EventHandler(this.btnAddNewModel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Models";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(37, 598);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(116, 25);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(32, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 28);
            this.label12.TabIndex = 5;
            this.label12.Text = "Developer Helper";
            // 
            // tbdbContextInstance
            // 
            this.tbdbContextInstance.Location = new System.Drawing.Point(12, 151);
            this.tbdbContextInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbdbContextInstance.Name = "tbdbContextInstance";
            this.tbdbContextInstance.Size = new System.Drawing.Size(344, 22);
            this.tbdbContextInstance.TabIndex = 0;
            this.tbdbContextInstance.Text = "_Context";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "DbContext Instance Name";
            // 
            // tbRepositoryGenaric
            // 
            this.tbRepositoryGenaric.Location = new System.Drawing.Point(8, 97);
            this.tbRepositoryGenaric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRepositoryGenaric.Name = "tbRepositoryGenaric";
            this.tbRepositoryGenaric.Size = new System.Drawing.Size(344, 22);
            this.tbRepositoryGenaric.TabIndex = 0;
            this.tbRepositoryGenaric.Text = "TransPro.Infrastructure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genaric Repository Name Space [Infrastructure]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDTONameSpace);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbServiceInterface);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbServiceNameSpace);
            this.groupBox1.Location = new System.Drawing.Point(767, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 214);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // tbDTONameSpace
            // 
            this.tbDTONameSpace.Location = new System.Drawing.Point(12, 39);
            this.tbDTONameSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDTONameSpace.Name = "tbDTONameSpace";
            this.tbDTONameSpace.Size = new System.Drawing.Size(344, 22);
            this.tbDTONameSpace.TabIndex = 0;
            this.tbDTONameSpace.Text = "StockApp.Service.DTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 68);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(182, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "_________________________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "DTO name space";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 90);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Service Interface Namespace";
            // 
            // tbServiceInterface
            // 
            this.tbServiceInterface.Location = new System.Drawing.Point(12, 110);
            this.tbServiceInterface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServiceInterface.Name = "tbServiceInterface";
            this.tbServiceInterface.Size = new System.Drawing.Size(344, 22);
            this.tbServiceInterface.TabIndex = 0;
            this.tbServiceInterface.Text = "StockApp.Service.Interfaces";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Service NameSpace";
            // 
            // tbServiceNameSpace
            // 
            this.tbServiceNameSpace.Location = new System.Drawing.Point(12, 169);
            this.tbServiceNameSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServiceNameSpace.Name = "tbServiceNameSpace";
            this.tbServiceNameSpace.Size = new System.Drawing.Size(344, 22);
            this.tbServiceNameSpace.TabIndex = 0;
            this.tbServiceNameSpace.Text = "StockApp.Service.Services";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbDbContext);
            this.groupBox2.Controls.Add(this.tbdbContextInstance);
            this.groupBox2.Controls.Add(this.tbDbContextNameSpace);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(365, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(373, 188);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DB Context";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbRepoNameSpace);
            this.groupBox3.Controls.Add(this.tbDomainInterface);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(365, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(373, 129);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repositories";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbDomainModels);
            this.groupBox4.Controls.Add(this.tbRepositoryGenaric);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(365, 478);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(373, 142);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entities && Infrastructure";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.tbControllerNameSpace);
            this.groupBox5.Location = new System.Drawing.Point(767, 367);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(373, 90);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controllers";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 30);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Controller Name Space";
            // 
            // tbControllerNameSpace
            // 
            this.tbControllerNameSpace.Location = new System.Drawing.Point(12, 50);
            this.tbControllerNameSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbControllerNameSpace.Name = "tbControllerNameSpace";
            this.tbControllerNameSpace.Size = new System.Drawing.Size(344, 22);
            this.tbControllerNameSpace.TabIndex = 0;
            this.tbControllerNameSpace.Text = "StockApp.WebAPI.Controllers";
            // 
            // gpCheckBoxs
            // 
            this.gpCheckBoxs.Controls.Add(this.cbControllerMVC);
            this.gpCheckBoxs.Controls.Add(this.cbCustomFile);
            this.gpCheckBoxs.Controls.Add(this.cbMapDToToMdel);
            this.gpCheckBoxs.Controls.Add(this.cbControllers);
            this.gpCheckBoxs.Controls.Add(this.cbDTOs);
            this.gpCheckBoxs.Controls.Add(this.cbServiceInterface);
            this.gpCheckBoxs.Controls.Add(this.cbServices);
            this.gpCheckBoxs.Controls.Add(this.cbIUnitOfWork);
            this.gpCheckBoxs.Controls.Add(this.cbUnitOfWork);
            this.gpCheckBoxs.Controls.Add(this.cbIRepository);
            this.gpCheckBoxs.Controls.Add(this.cbRepository);
            this.gpCheckBoxs.Controls.Add(this.cbAll);
            this.gpCheckBoxs.Controls.Add(this.btnCustom);
            this.gpCheckBoxs.Location = new System.Drawing.Point(1172, 66);
            this.gpCheckBoxs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpCheckBoxs.Name = "gpCheckBoxs";
            this.gpCheckBoxs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpCheckBoxs.Size = new System.Drawing.Size(236, 434);
            this.gpCheckBoxs.TabIndex = 12;
            this.gpCheckBoxs.TabStop = false;
            this.gpCheckBoxs.Text = "Generate";
            // 
            // cbCustomFile
            // 
            this.cbCustomFile.AutoSize = true;
            this.cbCustomFile.Location = new System.Drawing.Point(49, 327);
            this.cbCustomFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCustomFile.Name = "cbCustomFile";
            this.cbCustomFile.Size = new System.Drawing.Size(99, 20);
            this.cbCustomFile.TabIndex = 0;
            this.cbCustomFile.Text = "Custom File";
            this.cbCustomFile.UseVisualStyleBackColor = true;
            // 
            // cbMapDToToMdel
            // 
            this.cbMapDToToMdel.AutoSize = true;
            this.cbMapDToToMdel.Location = new System.Drawing.Point(49, 270);
            this.cbMapDToToMdel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMapDToToMdel.Name = "cbMapDToToMdel";
            this.cbMapDToToMdel.Size = new System.Drawing.Size(150, 20);
            this.cbMapDToToMdel.TabIndex = 0;
            this.cbMapDToToMdel.Text = "Map DTO to Models";
            this.cbMapDToToMdel.UseVisualStyleBackColor = true;
            // 
            // cbControllers
            // 
            this.cbControllers.AutoSize = true;
            this.cbControllers.Location = new System.Drawing.Point(49, 241);
            this.cbControllers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbControllers.Name = "cbControllers";
            this.cbControllers.Size = new System.Drawing.Size(117, 20);
            this.cbControllers.TabIndex = 0;
            this.cbControllers.Text = "API Controllers";
            this.cbControllers.UseVisualStyleBackColor = true;
            // 
            // cbDTOs
            // 
            this.cbDTOs.AutoSize = true;
            this.cbDTOs.Location = new System.Drawing.Point(49, 166);
            this.cbDTOs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDTOs.Name = "cbDTOs";
            this.cbDTOs.Size = new System.Drawing.Size(65, 20);
            this.cbDTOs.TabIndex = 0;
            this.cbDTOs.Text = "DTOs";
            this.cbDTOs.UseVisualStyleBackColor = true;
            this.cbDTOs.CheckedChanged += new System.EventHandler(this.cbDTOs_CheckedChanged);
            // 
            // cbServiceInterface
            // 
            this.cbServiceInterface.AutoSize = true;
            this.cbServiceInterface.Location = new System.Drawing.Point(49, 188);
            this.cbServiceInterface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbServiceInterface.Name = "cbServiceInterface";
            this.cbServiceInterface.Size = new System.Drawing.Size(129, 20);
            this.cbServiceInterface.TabIndex = 0;
            this.cbServiceInterface.Text = "Service Interface";
            this.cbServiceInterface.UseVisualStyleBackColor = true;
            // 
            // cbServices
            // 
            this.cbServices.AutoSize = true;
            this.cbServices.Location = new System.Drawing.Point(49, 213);
            this.cbServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(82, 20);
            this.cbServices.TabIndex = 0;
            this.cbServices.Text = "Services";
            this.cbServices.UseVisualStyleBackColor = true;
            // 
            // cbIUnitOfWork
            // 
            this.cbIUnitOfWork.AutoSize = true;
            this.cbIUnitOfWork.Location = new System.Drawing.Point(49, 138);
            this.cbIUnitOfWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIUnitOfWork.Name = "cbIUnitOfWork";
            this.cbIUnitOfWork.Size = new System.Drawing.Size(96, 20);
            this.cbIUnitOfWork.TabIndex = 0;
            this.cbIUnitOfWork.Text = "IUnitOfwork";
            this.cbIUnitOfWork.UseVisualStyleBackColor = true;
            // 
            // cbUnitOfWork
            // 
            this.cbUnitOfWork.AutoSize = true;
            this.cbUnitOfWork.Location = new System.Drawing.Point(49, 110);
            this.cbUnitOfWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUnitOfWork.Name = "cbUnitOfWork";
            this.cbUnitOfWork.Size = new System.Drawing.Size(105, 20);
            this.cbUnitOfWork.TabIndex = 0;
            this.cbUnitOfWork.Text = "UniteOfWork";
            this.cbUnitOfWork.UseVisualStyleBackColor = true;
            // 
            // cbIRepository
            // 
            this.cbIRepository.AutoSize = true;
            this.cbIRepository.Location = new System.Drawing.Point(49, 81);
            this.cbIRepository.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIRepository.Name = "cbIRepository";
            this.cbIRepository.Size = new System.Drawing.Size(98, 20);
            this.cbIRepository.TabIndex = 0;
            this.cbIRepository.Text = "IRepository";
            this.cbIRepository.UseVisualStyleBackColor = true;
            // 
            // cbRepository
            // 
            this.cbRepository.AutoSize = true;
            this.cbRepository.Location = new System.Drawing.Point(49, 53);
            this.cbRepository.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRepository.Name = "cbRepository";
            this.cbRepository.Size = new System.Drawing.Size(95, 20);
            this.cbRepository.TabIndex = 0;
            this.cbRepository.Text = "Repository";
            this.cbRepository.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(21, 25);
            this.cbAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(44, 20);
            this.cbAll.TabIndex = 0;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            this.cbAll.CheckStateChanged += new System.EventHandler(this.cbAll_CheckStateChanged);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(107, 394);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(113, 32);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 37);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "save your time, save your effort";
            // 
            // cbSaveConfig
            // 
            this.cbSaveConfig.AutoSize = true;
            this.cbSaveConfig.Location = new System.Drawing.Point(1172, 511);
            this.cbSaveConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSaveConfig.Name = "cbSaveConfig";
            this.cbSaveConfig.Size = new System.Drawing.Size(163, 20);
            this.cbSaveConfig.TabIndex = 0;
            this.cbSaveConfig.Text = "Save My Configuration";
            this.cbSaveConfig.UseVisualStyleBackColor = true;
            // 
            // rtUsingAdditonal
            // 
            this.rtUsingAdditonal.Location = new System.Drawing.Point(781, 66);
            this.rtUsingAdditonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtUsingAdditonal.Name = "rtUsingAdditonal";
            this.rtUsingAdditonal.Size = new System.Drawing.Size(357, 70);
            this.rtUsingAdditonal.TabIndex = 13;
            this.rtUsingAdditonal.Text = "using StockApp.DataAccess.UnitOfWork;\nusing StockApp.Service.Services.Base;\nusing" +
    " StockApp.Entities.business;";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(777, 46);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(183, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "Using [Addtional to Services] ";
            // 
            // cbControllerMVC
            // 
            this.cbControllerMVC.AutoSize = true;
            this.cbControllerMVC.Location = new System.Drawing.Point(49, 298);
            this.cbControllerMVC.Margin = new System.Windows.Forms.Padding(4);
            this.cbControllerMVC.Name = "cbControllerMVC";
            this.cbControllerMVC.Size = new System.Drawing.Size(118, 20);
            this.cbControllerMVC.TabIndex = 0;
            this.cbControllerMVC.Text = "MVC Controller";
            this.cbControllerMVC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 645);
            this.Controls.Add(this.rtUsingAdditonal);
            this.Controls.Add(this.cbSaveConfig);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.gpCheckBoxs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAddNewModel);
            this.Controls.Add(this.btnSelectRepoPath);
            this.Controls.Add(this.btnSelectModels);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModelName);
            this.Controls.Add(this.tbSelectedPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Developer Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gpCheckBoxs.ResumeLayout(false);
            this.gpCheckBoxs.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label17;
        private TextBox tbServiceInterface;
        private Label label14;
        private TextBox tbServiceNameSpace;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label19;
        private TextBox tbControllerNameSpace;
        private GroupBox gpCheckBoxs;
        private CheckBox cbDTOs;
        private CheckBox cbServices;
        private CheckBox cbIUnitOfWork;
        private CheckBox cbUnitOfWork;
        private CheckBox cbIRepository;
        private CheckBox cbRepository;
        private CheckBox cbAll;
        private CheckBox cbControllers;
        private CheckBox cbMapDToToMdel;
        private Label label20;
        private Button btnCustom;
        private CheckBox cbCustomFile;
        private CheckBox cbSaveConfig;
        private TextBox tbDTONameSpace;
        private Label label21;
        private Label label22;
        private CheckBox cbServiceInterface;
        private RichTextBox rtUsingAdditonal;
        private Label label23;
        private CheckBox cbControllerMVC;
    }
}