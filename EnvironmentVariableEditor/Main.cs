using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace EnvironmentVariableEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SortedList<int, string> pathList = new SortedList<int, string>();

        private EnvironmentVariableTarget target = EnvironmentVariableTarget.Machine;

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadPath();

            LoadEnvVariableList();
        }

        private void LoadPath()
        {
            LoadPathListFromEnvVariable();

            LoadFromPathList();
        }

        private void LoadEnvVariableList()
        {
            listView2.Items.Clear();
            foreach (DictionaryEntry i in Environment.GetEnvironmentVariables(this.target))
            {
                if (i.Key.ToString().ToUpper() == "PATH")
                {
                    continue;
                }

                listView2.Items.Add(new ListViewItem(new string[] {i.Key.ToString(), i.Value.ToString()}));
            }
        }

        private void LoadPathListFromEnvVariable()
        {
            string envPath = Environment.GetEnvironmentVariable("Path", this.target);
            LoadPathList(envPath);
        }

        private void LoadPathList(string pathString)
        {
            pathList.Clear();

            if (string.IsNullOrEmpty(pathString))
            {
                return;
            }

            int i = 0;
            foreach (string p in pathString.Split(';'))
            {
                pathList.Add(i, p);
                i++;
            }
        }

        private void LoadFromPathList()
        {
            listView1.Items.Clear();
            foreach (string p in pathList.Values)
            {
                listView1.Items.Add(p);
            }
        }

        private void btnPathSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save ???", "Save ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.SetEnvironmentVariable("Path", GetPathString(),this.target);
                MessageBox.Show("Successfully Saved To Windows :-)");
            }
        }

        private string GetPathString()
        {
            string path = string.Empty;

            foreach (string p in pathList.Values)
            {
                path += p + ";";
            }

            path = path.Remove(path.Length - 1);
            return path;
        }

        private void btnPathCheck_Click(object sender, EventArgs e)
        {
            bool foldersOk = true;

            foreach (string p in pathList.Values)
            {
                if (!System.IO.Path.IsPathRooted(p))
                {
                    foldersOk = false;
                    MessageBox.Show("Dir Not Exists :-(" + Environment.NewLine + p, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (foldersOk)
            {
                MessageBox.Show("Directories OK :-)", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPathUp_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int selected = this.pathList.IndexOfValue(this.listView1.SelectedItems[0].Text);

            if (selected >= 1)
            {
                string upValue = this.pathList[selected - 1];
                this.pathList[selected - 1] = this.pathList[selected];
                this.pathList[selected] = upValue;

                LoadFromPathList();

                this.listView1.Items[selected - 1].Selected = true;
            }

        }

        private void btnPathDown_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int selected = this.pathList.IndexOfValue(this.listView1.SelectedItems[0].Text);

            if (selected <  this.pathList.Count - 1)
            {
                string downValue = this.pathList[selected + 1];
                this.pathList[selected + 1] = this.pathList[selected];
                this.pathList[selected] = downValue;

                LoadFromPathList();

                this.listView1.Items[selected + 1].Selected = true;
            }

        }

        private void btnPathAdd_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.pathList.Add(pathList.Count + 1, dialog.SelectedPath);
                    LoadFromPathList();
                }
            }
        }

        private void btnPathRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Remove Path " + listView1.SelectedItems[0].Text + " ???", "Remove ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.pathList.RemoveAt(listView1.SelectedItems[0].Index);
                LoadFromPathList();
            }
        }

        private void btnPathExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Path String|*.txt";
            fileDialog.FileName = "Path String (" + DateTime.Now.ToLongDateString() + ")";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(fileDialog.FileName);
                sr.Write(GetPathString());
                sr.Close();
            }
        }

        private void btnPathImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Path String|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName);
                LoadPathList(sr.ReadToEnd());
                LoadFromPathList();
                sr.Close();
            }
        }

        private void btnPathRefresh_Click(object sender, EventArgs e)
        {
            LoadPath();
        }

        private void btnPathOpen_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            if (!System.IO.Path.IsPathRooted(listView1.SelectedItems[0].Text))
            {
                MessageBox.Show("Dir Not Exists :-(" + Environment.NewLine + listView1.SelectedItems[0].Text, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start("explorer.exe",  "/select," + listView1.SelectedItems[0].Text + "\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err :-(" + Environment.NewLine + ex.ToString(), "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMachine.Focused)
            {
                ChangeTarget(EnvironmentVariableTarget.Machine);
            }
        }

        private void ChangeTarget(EnvironmentVariableTarget target)
        {
            this.target = target;
            LoadData();
            txtParam.Text = string.Empty;
            txtValue.Text = string.Empty;
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Focused)
            {
                ChangeTarget(EnvironmentVariableTarget.User);
            }

        }

        private void rbProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProcess.Focused)
            {
                ChangeTarget(EnvironmentVariableTarget.Process);
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = listView2.SelectedItems[0];
            txtParam.Text = selected.SubItems[0].Text;
            txtValue.Text = selected.SubItems[1].Text;
        }

        private void btnSaveVariable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParam.Text))
            {
                return;
            }

            if (MessageBox.Show("Save ???", "Save ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.SetEnvironmentVariable(txtParam.Text, txtValue.Text, this.target);
                MessageBox.Show("Successfully Saved To Windows :-)");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://environmentvareditor.codeplex.com/");
        }
    }
}
