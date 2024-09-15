using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskDistributor.Client;
using TaskDistributor.Components;

namespace TaskDistributor
{
    internal partial class WorkingForm : BorderLessFormController
    {
        private DataSource selectTaskData;
        private DataSource selectGroupData;

        private TaskDistributorManager taskDistributor;

        public WorkingForm(DataSource selectTaskData, DataSource selectGroupData)
        {
            this.selectTaskData = selectTaskData;
            this.selectGroupData = selectGroupData;

            InitializeComponent();

            List<string> groupInfoData = selectGroupData.GetDataByGroup("GroupInfo");
            string groupName = groupInfoData[0];
            this.TitleLabel.Text = $"Распределение задач | { groupName }";

            this.loadStudentsList(groupName);
            this.loadTasksList();

            this.taskDistributor = new TaskDistributorManager(selectGroupData.GetDataByGroup("Students"), selectTaskData.data);
        }

        private void loadStudentsList(string groupName)
        {
            this.listViewStudents.StateImageList = imageListStudents;
            this.listViewStudents.Columns.Add(new ColumnHeader() { Text = "Имя", Width = 320 });
            this.listViewStudents.Columns.Add(new ColumnHeader() { Text = "Группа", Width = 180 });
            this.listViewStudents.MultiSelect = false;
            this.listViewStudents.View = View.Details;
            this.listViewStudents.Items.Clear();

            List<string> studentsData = selectGroupData.GetDataByGroup("Students");
            foreach (string student in studentsData) 
            {
                this.listViewStudents.Items.Add(new ListViewItem(new string[] { student, groupName }));
            }
        }

        private void loadTasksList()
        {
            List<string> taskGroups = this.selectTaskData.GetGroups();

            this.treeViewTasks.Nodes.Clear();
            foreach (string group in taskGroups)
            {
                if (group == "Discription") continue;
                TreeNode treeNode = new TreeNode(group);

                List<string> taskGroupData = this.selectTaskData.GetDataByGroup(group);
                foreach (string groupData in taskGroupData)
                {
                    treeNode.Nodes.Add(groupData);
                }

                this.treeViewTasks.Nodes.Add(treeNode);
            }
        }

        //private void buttonDistributeRandom_Click(object sender, EventArgs e)
        //{
        //    Dictionary<string, Dictionary<string, DistributionInfo>> distributionTasks = 
        //        this.taskDistributor.DistributeTasks(this.checBoxRandom.Checked);

        //    fastColoredTextBox1.Text = "";
        //    foreach (var student in distributionTasks)
        //    {
        //        fastColoredTextBox1.Text += ($"Задания для {student.Key}:");
        //        foreach (var pack in student.Value)
        //        {
        //            if (checkBox1.Checked) 
        //            { 
        //                fastColoredTextBox1.Text += ($" - {pack.Key}: {pack.Value.distributionIndex}");
        //            }
        //            else
        //            {
        //                fastColoredTextBox1.Text += ($" {pack.Value.distributionIndex} ");
        //            }
        //        }
        //        fastColoredTextBox1.Text += "\n";
        //    }
        //}

        private Dictionary<string, Dictionary<string, DistributionInfo>> distributionTasks;
        private void buttonDistributeRandom_Click(object sender, EventArgs e)
        {
            this.distributionTasks = this.taskDistributor.DistributeTasks(this.checBoxRandom.Checked);

            fastColoredTextBox1.Text = "";
            foreach (var student in this.distributionTasks)
            {
                fastColoredTextBox1.Text += ($"Задания для {student.Key}:");

                if (checkBoxAlign.Checked)
                {
                    fastColoredTextBox1.Text += '\n';
                }

                foreach (var pack in student.Value)
                {
                    if (checkBoxAlign.Checked) 
                    {
                        string packKeyFormatted = pack.Key.PadRight(5);
                        string distributionText = checkBox1.Checked
                            ? $"{packKeyFormatted}: {pack.Value.distributionIndex}"
                            : $"{pack.Value.distributionIndex}";

                        fastColoredTextBox1.Text += distributionText.PadRight(5);
                    }
                    else
                    {
                        fastColoredTextBox1.Text += checkBox1.Checked ? ($" - {pack.Key}: {pack.Value.distributionIndex}") :
                            ($" {pack.Value.distributionIndex} ");
                    }
                }
                fastColoredTextBox1.Text += "\n";
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (this.distributionTasks == null)
            {
                this.distributionTasks = this.taskDistributor.DistributeTasks(this.checBoxRandom.Checked);
            }

            List<string> groupInfoData = selectGroupData.GetDataByGroup("GroupInfo");
            string groupName = groupInfoData[0];

            string dirPath = $@"Export\{groupName}\";

            if (!new DirectoryInfo(dirPath).Exists)
            {
                Directory.CreateDirectory(dirPath);
            }

            foreach (var student in this.distributionTasks)
            {
                string studentFilePath = dirPath + student.Key + ".txt";

                using (FileStream fileStream = new FileStream(studentFilePath, FileMode.Create))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream)) 
                    {
                        int taskNum = 1;
                        foreach (var pack in student.Value)
                        {
                            string packContext = WrapText(pack.Value.distributionText, 65);
                            streamWriter.WriteLine($"Задание {taskNum++}, вариант {pack.Value.distributionIndex}:");
                            streamWriter.WriteLine(packContext);
                            streamWriter.WriteLine();
                        }
                    }
                }
            }
        }

        public static string WrapText(string text, int maxLineLength)
        {
            StringBuilder result = new StringBuilder();
            string[] words = text.Split(' ');

            StringBuilder currentLine = new StringBuilder();

            foreach (string word in words)
            {
                if (currentLine.Length + word.Length + 1 > maxLineLength)
                {
                    result.AppendLine(currentLine.ToString());
                    currentLine.Clear();
                }

                if (currentLine.Length > 0)
                {
                    currentLine.Append(" ");
                }
                currentLine.Append(word);
            }

            if (currentLine.Length > 0)
            {
                result.AppendLine(currentLine.ToString());
            }

            return result.ToString();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            syntaxHighlight(e);
        }

        private static TextStyle MagentaStyle =
            new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        private void syntaxHighlight(TextChangedEventArgs e)
        {
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
        }
    }
}
