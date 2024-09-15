namespace TaskDistributor
{
    partial class WorkingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingForm));
            this.mainTabControl = new TaskDistributor.Components.TabControl.FlatTabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.treeViewTasks = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.checkBoxAlign = new System.Windows.Forms.CheckBox();
            this.checBoxRandom = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Export = new System.Windows.Forms.Button();
            this.buttonDistributeRandom = new System.Windows.Forms.Button();
            this.imageListStudents = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.tabPageTasks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonClose.Location = new System.Drawing.Point(773, 1);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.TitleLabel.Size = new System.Drawing.Size(140, 15);
            this.TitleLabel.Text = "Распределение задач";
            // 
            // buttonMaxType
            // 
            this.buttonMaxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonMaxType.FlatAppearance.BorderSize = 0;
            this.buttonMaxType.Location = new System.Drawing.Point(748, 1);
            // 
            // buttonMinType
            // 
            this.buttonMinType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonMinType.FlatAppearance.BorderSize = 0;
            this.buttonMinType.Location = new System.Drawing.Point(723, 1);
            // 
            // timer
            // 
            this.timer.Enabled = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.mainTabControl.BorderSize = 1;
            this.mainTabControl.Controls.Add(this.tabPageStudents);
            this.mainTabControl.Controls.Add(this.tabPageTasks);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.DrawBorders = false;
            this.mainTabControl.DrawTopCurtain = false;
            this.mainTabControl.Location = new System.Drawing.Point(5, 30);
            this.mainTabControl.myBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(788, 536);
            this.mainTabControl.TabIndex = 7;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.listViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(780, 507);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // listViewStudents
            // 
            this.listViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStudents.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(3, 3);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(774, 501);
            this.listViewStudents.TabIndex = 0;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.List;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Controls.Add(this.treeViewTasks);
            this.tabPageTasks.Location = new System.Drawing.Point(4, 25);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(780, 507);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Комплекты";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // treeViewTasks
            // 
            this.treeViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTasks.Location = new System.Drawing.Point(3, 3);
            this.treeViewTasks.Name = "treeViewTasks";
            this.treeViewTasks.Size = new System.Drawing.Size(774, 501);
            this.treeViewTasks.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.checkBoxAlign);
            this.tabPage1.Controls.Add(this.checBoxRandom);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.Export);
            this.tabPage1.Controls.Add(this.buttonDistributeRandom);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 507);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Распределить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fastColoredTextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 465);
            this.panel1.TabIndex = 30;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.Transparent;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.DarkSlateGray;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(780, 465);
            this.fastColoredTextBox1.TabIndex = 26;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // checkBoxAlign
            // 
            this.checkBoxAlign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAlign.AutoSize = true;
            this.checkBoxAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAlign.Location = new System.Drawing.Point(620, 480);
            this.checkBoxAlign.Name = "checkBoxAlign";
            this.checkBoxAlign.Size = new System.Drawing.Size(79, 17);
            this.checkBoxAlign.TabIndex = 29;
            this.checkBoxAlign.Text = "Выравнять";
            this.checkBoxAlign.UseVisualStyleBackColor = true;
            // 
            // checBoxRandom
            // 
            this.checBoxRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checBoxRandom.AutoSize = true;
            this.checBoxRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checBoxRandom.Location = new System.Drawing.Point(487, 480);
            this.checBoxRandom.Name = "checBoxRandom";
            this.checBoxRandom.Size = new System.Drawing.Size(115, 17);
            this.checBoxRandom.TabIndex = 28;
            this.checBoxRandom.Text = "Рандомизировать";
            this.checBoxRandom.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(272, 478);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 19);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Выводить номер комплекта";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export.Location = new System.Drawing.Point(137, 474);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(125, 27);
            this.Export.TabIndex = 25;
            this.Export.Text = "Экспорт наборов";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // buttonDistributeRandom
            // 
            this.buttonDistributeRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDistributeRandom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonDistributeRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDistributeRandom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDistributeRandom.Location = new System.Drawing.Point(6, 474);
            this.buttonDistributeRandom.Name = "buttonDistributeRandom";
            this.buttonDistributeRandom.Size = new System.Drawing.Size(125, 27);
            this.buttonDistributeRandom.TabIndex = 24;
            this.buttonDistributeRandom.Text = "Распределить";
            this.buttonDistributeRandom.UseVisualStyleBackColor = true;
            this.buttonDistributeRandom.Click += new System.EventHandler(this.buttonDistributeRandom_Click);
            // 
            // imageListStudents
            // 
            this.imageListStudents.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStudents.ImageStream")));
            this.imageListStudents.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStudents.Images.SetKeyName(0, "userIcon.png");
            this.imageListStudents.Images.SetKeyName(1, "userIcon.png");
            this.imageListStudents.Images.SetKeyName(2, "userIcon.png");
            // 
            // WorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(798, 571);
            this.Controls.Add(this.mainTabControl);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.MinimumSize = new System.Drawing.Size(730, 380);
            this.Name = "WorkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkingForm";
            this.Controls.SetChildIndex(this.buttonMaxType, 0);
            this.Controls.SetChildIndex(this.buttonClose, 0);
            this.Controls.SetChildIndex(this.buttonMinType, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.mainTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageTasks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.TabControl.FlatTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageTasks;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ImageList imageListStudents;
        private System.Windows.Forms.TreeView treeViewTasks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button buttonDistributeRandom;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checBoxRandom;
        private System.Windows.Forms.CheckBox checkBoxAlign;
        private System.Windows.Forms.Panel panel1;
    }
}