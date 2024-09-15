using System;
using System.Windows.Forms;
using TaskDistributor.Components;
using System.IO;
using TaskDistributor.Client;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace TaskDistributor
{
    public partial class MainForm : BorderLessFormController
    {
        private string selectTaskName;
        private DataSource selectTaskData;

        private string selectGroupName;
        private DataSource selectGroupData;

        public MainForm()
        {
            InitializeComponent();

            tasksComplectCB.DropDownStyle = ComboBoxStyle.DropDownList;
            groupCB.DropDownStyle = ComboBoxStyle.DropDownList;

            this.loadCBData();
        }

        private void loadCBData()
        {
            // Load task set:
            string selectTask = tasksComplectCB.Text;
            DirectoryInfo tasksDirectory = new DirectoryInfo("Inputs");
            FileInfo[] tasksDirectoryFiles = tasksDirectory.GetFiles();

            tasksComplectCB.Items.Clear();
            foreach (FileInfo fileInfo in tasksDirectoryFiles)
            {
                tasksComplectCB.Items.Add(fileInfo.Name);
            }

            if (selectTask != null && selectTask.Replace(" ", "") != "" && tasksComplectCB.Items.Contains(selectTask))
            {
                tasksComplectCB.Text = selectTask;
            }

            // Load groups list:
            string selectGroup = groupCB.Text;
            DirectoryInfo groupsDirectory = new DirectoryInfo("Groups");
            FileInfo[] groupsDirectoryFiles = groupsDirectory.GetFiles();

            groupCB.Items.Clear();
            foreach (FileInfo fileInfo in groupsDirectoryFiles)
            {
                groupCB.Items.Add(fileInfo.Name);
            }

            if (selectGroup != null && selectGroup.Replace(" ", "") != "" && groupCB.Items.Contains(selectGroup))
            {
                groupCB.Text = selectGroup;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tasksComplectCB_SelectedValueChanged(object sender, EventArgs e)
        {
            this.selectTaskName = tasksComplectCB.Text;
            this.reloadSelectTaskData();
            this.updateSelectingInfo();
        }

        private void reloadSelectTaskData()
        {
            try
            {
                using (FileStream fileStream = new FileStream($@"Inputs\{this.selectTaskName}", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        this.selectTaskData = new DataSource(streamReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла",
                    $"Возникли ошибки при загрузке файла {this.selectTaskName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.selectTaskName = null;
                this.selectTaskData = null;
            }
        }

        private void groupCB_SelectedValueChanged(object sender, EventArgs e)
        {
            this.selectGroupName = groupCB.Text;
            this.reloadSelectGroupData();
            this.updateSelectingInfo();
        }

        private void reloadSelectGroupData()
        {
            try
            {
                using (FileStream fileStream = new FileStream($@"Groups\{this.selectGroupName}", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        this.selectGroupData = new DataSource(streamReader);
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла", 
                    $"Возникли ошибки при загрузке файла {this.selectGroupName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.selectGroupName = null;
                this.selectGroupData = null;
            }
        }

        private void updateSelectingInfo()
        {
            if (this.selectTaskName != null && this.selectTaskData != null)
            {
                this.selectDiscipline.Visible = true;
                this.selectWork.Visible = true;
                this.selectWorkName.Visible = true;

                List<string> discriptionData = selectTaskData.GetDataByGroup("Discription");
                this.selectDiscipline.Text = discriptionData[0];
                this.selectWork.Text = discriptionData[1];
                this.selectWorkName.Text = discriptionData[2];
            }
            else
            {
                this.selectDiscipline.Visible = false;
                this.selectWork.Visible = false;
                this.selectWorkName.Visible = false;
            }

            if (this.selectGroupName != null && this.selectGroupData != null)
            {
                this.selectGroup.Visible = true;

                List<string> groupInfoData = selectGroupData.GetDataByGroup("GroupInfo");
                this.selectGroup.Text = groupInfoData[0];
            }
            else
            {
                this.selectGroup.Visible = false;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (this.selectTaskName != null && this.selectTaskData != null &&
                this.selectGroupName != null && this.selectGroupData != null)
            {
                this.Close();

                Thread f1f2 = new Thread(open);
                f1f2.SetApartmentState(ApartmentState.STA);
                f1f2.Start();
            }
        }

        public void open(object obj)
        {
            WorkingForm workingForm = new WorkingForm(this.selectTaskData, this.selectGroupData);
            Application.Run(workingForm);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            loadCBData();
            updateSelectingInfo();
        }
    }
}
