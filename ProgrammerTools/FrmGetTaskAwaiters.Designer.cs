namespace ProgrammerTools
{
    partial class FrmGetTaskAwaiters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Get Async Task Call Without Await";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(231, 133);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(213, 45);
            this.btnServices.TabIndex = 1;
            this.btnServices.Text = "Get all service called Without Await";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // FrmGetTaskAwaiters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 281);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmGetTaskAwaiters";
            this.Text = "FrmGetTaskAwaiters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnServices;
    }
}