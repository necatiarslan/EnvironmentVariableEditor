namespace EnvironmentVariableEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPathOpen = new System.Windows.Forms.Button();
            this.btnPathExport = new System.Windows.Forms.Button();
            this.btnPathImport = new System.Windows.Forms.Button();
            this.btnPathRemove = new System.Windows.Forms.Button();
            this.btnPathCheck = new System.Windows.Forms.Button();
            this.btnPathSave = new System.Windows.Forms.Button();
            this.btnPathAdd = new System.Windows.Forms.Button();
            this.btnPathDown = new System.Windows.Forms.Button();
            this.btnPathUp = new System.Windows.Forms.Button();
            this.btnPathRefresh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveVariable = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbMachine = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbProcess = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 428);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 466);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPathOpen);
            this.tabPage1.Controls.Add(this.btnPathExport);
            this.tabPage1.Controls.Add(this.btnPathImport);
            this.tabPage1.Controls.Add(this.btnPathRemove);
            this.tabPage1.Controls.Add(this.btnPathCheck);
            this.tabPage1.Controls.Add(this.btnPathSave);
            this.tabPage1.Controls.Add(this.btnPathAdd);
            this.tabPage1.Controls.Add(this.btnPathDown);
            this.tabPage1.Controls.Add(this.btnPathUp);
            this.tabPage1.Controls.Add(this.btnPathRefresh);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Path";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPathOpen
            // 
            this.btnPathOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathOpen.Location = new System.Drawing.Point(508, 367);
            this.btnPathOpen.Name = "btnPathOpen";
            this.btnPathOpen.Size = new System.Drawing.Size(75, 23);
            this.btnPathOpen.TabIndex = 10;
            this.btnPathOpen.Text = "Open";
            this.btnPathOpen.UseVisualStyleBackColor = true;
            this.btnPathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnPathExport
            // 
            this.btnPathExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathExport.Location = new System.Drawing.Point(508, 309);
            this.btnPathExport.Name = "btnPathExport";
            this.btnPathExport.Size = new System.Drawing.Size(75, 23);
            this.btnPathExport.TabIndex = 9;
            this.btnPathExport.Text = "Export";
            this.btnPathExport.UseVisualStyleBackColor = true;
            this.btnPathExport.Click += new System.EventHandler(this.btnPathExport_Click);
            // 
            // btnPathImport
            // 
            this.btnPathImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathImport.Location = new System.Drawing.Point(508, 338);
            this.btnPathImport.Name = "btnPathImport";
            this.btnPathImport.Size = new System.Drawing.Size(75, 23);
            this.btnPathImport.TabIndex = 8;
            this.btnPathImport.Text = "Import";
            this.btnPathImport.UseVisualStyleBackColor = true;
            this.btnPathImport.Click += new System.EventHandler(this.btnPathImport_Click);
            // 
            // btnPathRemove
            // 
            this.btnPathRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathRemove.Location = new System.Drawing.Point(508, 64);
            this.btnPathRemove.Name = "btnPathRemove";
            this.btnPathRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPathRemove.TabIndex = 7;
            this.btnPathRemove.Text = "Remove";
            this.btnPathRemove.UseVisualStyleBackColor = true;
            this.btnPathRemove.Click += new System.EventHandler(this.btnPathRemove_Click);
            // 
            // btnPathCheck
            // 
            this.btnPathCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathCheck.Location = new System.Drawing.Point(508, 396);
            this.btnPathCheck.Name = "btnPathCheck";
            this.btnPathCheck.Size = new System.Drawing.Size(75, 38);
            this.btnPathCheck.TabIndex = 6;
            this.btnPathCheck.Text = "Check Dir Exists";
            this.btnPathCheck.UseVisualStyleBackColor = true;
            this.btnPathCheck.Click += new System.EventHandler(this.btnPathCheck_Click);
            // 
            // btnPathSave
            // 
            this.btnPathSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPathSave.Location = new System.Drawing.Point(508, 93);
            this.btnPathSave.Name = "btnPathSave";
            this.btnPathSave.Size = new System.Drawing.Size(75, 43);
            this.btnPathSave.TabIndex = 5;
            this.btnPathSave.Text = "Save To Windows";
            this.btnPathSave.UseVisualStyleBackColor = true;
            this.btnPathSave.Click += new System.EventHandler(this.btnPathSave_Click);
            // 
            // btnPathAdd
            // 
            this.btnPathAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathAdd.Location = new System.Drawing.Point(508, 35);
            this.btnPathAdd.Name = "btnPathAdd";
            this.btnPathAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPathAdd.TabIndex = 4;
            this.btnPathAdd.Text = "Add New";
            this.btnPathAdd.UseVisualStyleBackColor = true;
            this.btnPathAdd.Click += new System.EventHandler(this.btnPathAdd_Click);
            // 
            // btnPathDown
            // 
            this.btnPathDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPathDown.Location = new System.Drawing.Point(508, 202);
            this.btnPathDown.Name = "btnPathDown";
            this.btnPathDown.Size = new System.Drawing.Size(23, 23);
            this.btnPathDown.TabIndex = 3;
            this.btnPathDown.Text = "↓";
            this.btnPathDown.UseVisualStyleBackColor = true;
            this.btnPathDown.Click += new System.EventHandler(this.btnPathDown_Click);
            // 
            // btnPathUp
            // 
            this.btnPathUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPathUp.Location = new System.Drawing.Point(508, 173);
            this.btnPathUp.Name = "btnPathUp";
            this.btnPathUp.Size = new System.Drawing.Size(23, 23);
            this.btnPathUp.TabIndex = 2;
            this.btnPathUp.Text = "↑";
            this.btnPathUp.UseVisualStyleBackColor = true;
            this.btnPathUp.Click += new System.EventHandler(this.btnPathUp_Click);
            // 
            // btnPathRefresh
            // 
            this.btnPathRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathRefresh.Location = new System.Drawing.Point(508, 6);
            this.btnPathRefresh.Name = "btnPathRefresh";
            this.btnPathRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnPathRefresh.TabIndex = 1;
            this.btnPathRefresh.Text = "Refresh";
            this.btnPathRefresh.UseVisualStyleBackColor = true;
            this.btnPathRefresh.Click += new System.EventHandler(this.btnPathRefresh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(583, 372);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Param";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveVariable);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.txtParam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 62);
            this.panel1.TabIndex = 2;
            // 
            // btnSaveVariable
            // 
            this.btnSaveVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveVariable.Location = new System.Drawing.Point(505, 6);
            this.btnSaveVariable.Name = "btnSaveVariable";
            this.btnSaveVariable.Size = new System.Drawing.Size(75, 50);
            this.btnSaveVariable.TabIndex = 4;
            this.btnSaveVariable.Text = "Save";
            this.btnSaveVariable.UseVisualStyleBackColor = true;
            this.btnSaveVariable.Click += new System.EventHandler(this.btnSaveVariable_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(52, 36);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(437, 20);
            this.txtValue.TabIndex = 3;
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Location = new System.Drawing.Point(52, 9);
            this.txtParam.Name = "txtParam";
            this.txtParam.ReadOnly = true;
            this.txtParam.Size = new System.Drawing.Size(437, 20);
            this.txtParam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(589, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbMachine
            // 
            this.rbMachine.AutoSize = true;
            this.rbMachine.Checked = true;
            this.rbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMachine.Location = new System.Drawing.Point(12, 12);
            this.rbMachine.Name = "rbMachine";
            this.rbMachine.Size = new System.Drawing.Size(94, 24);
            this.rbMachine.TabIndex = 2;
            this.rbMachine.TabStop = true;
            this.rbMachine.Text = "Machine";
            this.rbMachine.UseVisualStyleBackColor = true;
            this.rbMachine.CheckedChanged += new System.EventHandler(this.rbMachine_CheckedChanged);
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUser.Location = new System.Drawing.Point(112, 12);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(65, 24);
            this.rbUser.TabIndex = 3;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbProcess
            // 
            this.rbProcess.AutoSize = true;
            this.rbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbProcess.Location = new System.Drawing.Point(183, 12);
            this.rbProcess.Name = "rbProcess";
            this.rbProcess.Size = new System.Drawing.Size(91, 24);
            this.rbProcess.TabIndex = 4;
            this.rbProcess.Text = "Process";
            this.rbProcess.UseVisualStyleBackColor = true;
            this.rbProcess.CheckedChanged += new System.EventHandler(this.rbProcess_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(92, 208);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(404, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://environmentvareditor.codeplex.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 522);
            this.Controls.Add(this.rbProcess);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbMachine);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Enviroment Variable Editor (Necati ARSLAN)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPathAdd;
        private System.Windows.Forms.Button btnPathDown;
        private System.Windows.Forms.Button btnPathUp;
        private System.Windows.Forms.Button btnPathRefresh;
        private System.Windows.Forms.Button btnPathSave;
        private System.Windows.Forms.Button btnPathCheck;
        private System.Windows.Forms.Button btnPathRemove;
        private System.Windows.Forms.Button btnPathExport;
        private System.Windows.Forms.Button btnPathImport;
        private System.Windows.Forms.Button btnPathOpen;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RadioButton rbMachine;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveVariable;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

