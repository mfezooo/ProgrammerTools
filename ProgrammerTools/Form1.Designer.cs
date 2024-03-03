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
            this.label9 = new System.Windows.Forms.Label();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddNewModel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gpCheckBoxs = new System.Windows.Forms.GroupBox();
            this.cbIsGenaric = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbSaveConfig = new System.Windows.Forms.CheckBox();
            this.RBManager = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpCheckBoxs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelectedPath
            // 
            this.tbSelectedPath.Location = new System.Drawing.Point(271, 79);
            this.tbSelectedPath.Name = "tbSelectedPath";
            this.tbSelectedPath.Size = new System.Drawing.Size(200, 20);
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
            this.btnSelectModels.Size = new System.Drawing.Size(205, 20);
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
            this.listBox1.Size = new System.Drawing.Size(206, 329);
            this.listBox1.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(145, 486);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 20);
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
            this.btnSelectRepoPath.Location = new System.Drawing.Point(477, 80);
            this.btnSelectRepoPath.Name = "btnSelectRepoPath";
            this.btnSelectRepoPath.Size = new System.Drawing.Size(77, 20);
            this.btnSelectRepoPath.TabIndex = 2;
            this.btnSelectRepoPath.Text = "Select Folder";
            this.btnSelectRepoPath.UseVisualStyleBackColor = true;
            this.btnSelectRepoPath.Click += new System.EventHandler(this.btnSelectRepoPath_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(271, 444);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(177, 49);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Developed by Fezo";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
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
            this.btnRemoveAll.Location = new System.Drawing.Point(28, 486);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(87, 20);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(24, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Developer Helper";
            // 
            // gpCheckBoxs
            // 
            this.gpCheckBoxs.Controls.Add(this.cbIsGenaric);
            this.gpCheckBoxs.Controls.Add(this.cbAll);
            this.gpCheckBoxs.Controls.Add(this.btnCustom);
            this.gpCheckBoxs.Location = new System.Drawing.Point(273, 332);
            this.gpCheckBoxs.Name = "gpCheckBoxs";
            this.gpCheckBoxs.Size = new System.Drawing.Size(177, 75);
            this.gpCheckBoxs.TabIndex = 12;
            this.gpCheckBoxs.TabStop = false;
            this.gpCheckBoxs.Text = "Generate";
            // 
            // cbIsGenaric
            // 
            this.cbIsGenaric.AutoSize = true;
            this.cbIsGenaric.Location = new System.Drawing.Point(37, 43);
            this.cbIsGenaric.Name = "cbIsGenaric";
            this.cbIsGenaric.Size = new System.Drawing.Size(84, 17);
            this.cbIsGenaric.TabIndex = 0;
            this.cbIsGenaric.Text = "IsGenaricSp";
            this.cbIsGenaric.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(16, 20);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(37, 17);
            this.cbAll.TabIndex = 0;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            this.cbAll.CheckStateChanged += new System.EventHandler(this.cbAll_CheckStateChanged);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(88, 343);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(85, 26);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "save your time, save your effort";
            // 
            // cbSaveConfig
            // 
            this.cbSaveConfig.AutoSize = true;
            this.cbSaveConfig.Location = new System.Drawing.Point(271, 421);
            this.cbSaveConfig.Name = "cbSaveConfig";
            this.cbSaveConfig.Size = new System.Drawing.Size(133, 17);
            this.cbSaveConfig.TabIndex = 0;
            this.cbSaveConfig.Text = "Save My Configuration";
            this.cbSaveConfig.UseVisualStyleBackColor = true;
            // 
            // RBManager
            // 
            this.RBManager.Location = new System.Drawing.Point(273, 142);
            this.RBManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBManager.Name = "RBManager";
            this.RBManager.Size = new System.Drawing.Size(282, 115);
            this.RBManager.TabIndex = 13;
            this.RBManager.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ManagerMethods";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.RBManager);
            this.Controls.Add(this.cbSaveConfig);
            this.Controls.Add(this.gpCheckBoxs);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModelName);
            this.Controls.Add(this.tbSelectedPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Developer Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Label label9;
        private TextBox tbModelName;
        private Label label10;
        private Button btnAddNewModel;
        private Label label11;
        private Button btnRemoveAll;
        private Label label12;
        private GroupBox gpCheckBoxs;
        private CheckBox cbAll;
        private Label label20;
        private Button btnCustom;
        private CheckBox cbSaveConfig;
        private CheckBox cbIsGenaric;
        private RichTextBox RBManager;
        private Label label3;
    }
}