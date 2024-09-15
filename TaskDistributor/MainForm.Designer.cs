namespace TaskDistributor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tasksComplectCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectDiscipline = new System.Windows.Forms.Label();
            this.selectWork = new System.Windows.Forms.Label();
            this.selectWorkName = new System.Windows.Forms.Label();
            this.selectGroup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupOtherIcon = new TaskDistributor.Components.InteractiveIcon();
            this.taskComplectOtherIcon = new TaskDistributor.Components.InteractiveIcon();
            this.pictureBoxGitHub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOtherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskComplectOtherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonClose.Location = new System.Drawing.Point(449, 1);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.TitleLabel.Size = new System.Drawing.Size(210, 15);
            this.TitleLabel.Text = "Распределение задач | Главная";
            // 
            // buttonMaxType
            // 
            this.buttonMaxType.FlatAppearance.BorderSize = 0;
            this.buttonMaxType.Location = new System.Drawing.Point(424, 1);
            this.buttonMaxType.Visible = false;
            // 
            // buttonMinType
            // 
            this.buttonMinType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonMinType.FlatAppearance.BorderSize = 0;
            this.buttonMinType.Location = new System.Drawing.Point(424, 1);
            // 
            // timer
            // 
            this.timer.Enabled = false;
            // 
            // tasksComplectCB
            // 
            this.tasksComplectCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksComplectCB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksComplectCB.FormattingEnabled = true;
            this.tasksComplectCB.Location = new System.Drawing.Point(202, 46);
            this.tasksComplectCB.Name = "tasksComplectCB";
            this.tasksComplectCB.Size = new System.Drawing.Size(250, 23);
            this.tasksComplectCB.TabIndex = 7;
            this.tasksComplectCB.SelectedValueChanged += new System.EventHandler(this.tasksComplectCB_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Набор задач:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Учебная группа:";
            // 
            // groupCB
            // 
            this.groupCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupCB.FormattingEnabled = true;
            this.groupCB.Location = new System.Drawing.Point(202, 78);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(250, 23);
            this.groupCB.TabIndex = 10;
            this.groupCB.SelectedValueChanged += new System.EventHandler(this.groupCB_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.panel1.Location = new System.Drawing.Point(7, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 2);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дисциплина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Работа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Название работы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Выбранная группа:";
            // 
            // selectDiscipline
            // 
            this.selectDiscipline.AutoSize = true;
            this.selectDiscipline.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDiscipline.Location = new System.Drawing.Point(155, 133);
            this.selectDiscipline.Name = "selectDiscipline";
            this.selectDiscipline.Size = new System.Drawing.Size(42, 15);
            this.selectDiscipline.TabIndex = 16;
            this.selectDiscipline.Text = "#none";
            this.selectDiscipline.Visible = false;
            // 
            // selectWork
            // 
            this.selectWork.AutoSize = true;
            this.selectWork.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectWork.Location = new System.Drawing.Point(155, 156);
            this.selectWork.Name = "selectWork";
            this.selectWork.Size = new System.Drawing.Size(42, 15);
            this.selectWork.TabIndex = 17;
            this.selectWork.Text = "#none";
            this.selectWork.Visible = false;
            // 
            // selectWorkName
            // 
            this.selectWorkName.AutoSize = true;
            this.selectWorkName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectWorkName.Location = new System.Drawing.Point(155, 179);
            this.selectWorkName.Name = "selectWorkName";
            this.selectWorkName.Size = new System.Drawing.Size(42, 15);
            this.selectWorkName.TabIndex = 18;
            this.selectWorkName.Text = "#none";
            this.selectWorkName.Visible = false;
            // 
            // selectGroup
            // 
            this.selectGroup.AutoSize = true;
            this.selectGroup.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectGroup.Location = new System.Drawing.Point(155, 202);
            this.selectGroup.Name = "selectGroup";
            this.selectGroup.Size = new System.Drawing.Size(42, 15);
            this.selectGroup.TabIndex = 19;
            this.selectGroup.Text = "#none";
            this.selectGroup.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.panel2.Location = new System.Drawing.Point(7, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 2);
            this.panel2.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(367, 257);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 27);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(276, 257);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(85, 27);
            this.buttonContinue.TabIndex = 23;
            this.buttonContinue.Text = "Далее";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // groupOtherIcon
            // 
            this.groupOtherIcon.Image = global::TaskDistributor.Properties.Resources.othersIcon;
            this.groupOtherIcon.Location = new System.Drawing.Point(429, 78);
            this.groupOtherIcon.Name = "groupOtherIcon";
            this.groupOtherIcon.Size = new System.Drawing.Size(23, 23);
            this.groupOtherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupOtherIcon.TabIndex = 21;
            this.groupOtherIcon.TabStop = false;
            this.groupOtherIcon.Visible = false;
            // 
            // taskComplectOtherIcon
            // 
            this.taskComplectOtherIcon.Image = global::TaskDistributor.Properties.Resources.othersIcon;
            this.taskComplectOtherIcon.Location = new System.Drawing.Point(429, 46);
            this.taskComplectOtherIcon.Name = "taskComplectOtherIcon";
            this.taskComplectOtherIcon.Size = new System.Drawing.Size(23, 23);
            this.taskComplectOtherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taskComplectOtherIcon.TabIndex = 20;
            this.taskComplectOtherIcon.TabStop = false;
            this.taskComplectOtherIcon.Visible = false;
            // 
            // pictureBoxGitHub
            // 
            this.pictureBoxGitHub.Image = global::TaskDistributor.Properties.Resources.gitHubIcon;
            this.pictureBoxGitHub.Location = new System.Drawing.Point(22, 254);
            this.pictureBoxGitHub.Name = "pictureBoxGitHub";
            this.pictureBoxGitHub.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGitHub.TabIndex = 24;
            this.pictureBoxGitHub.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.pictureBoxGitHub);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupOtherIcon);
            this.Controls.Add(this.taskComplectOtherIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.selectGroup);
            this.Controls.Add(this.selectWorkName);
            this.Controls.Add(this.selectWork);
            this.Controls.Add(this.selectDiscipline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasksComplectCB);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.Name = "MainForm";
            this.Resizeable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.buttonMaxType, 0);
            this.Controls.SetChildIndex(this.buttonClose, 0);
            this.Controls.SetChildIndex(this.buttonMinType, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.tasksComplectCB, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupCB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.selectDiscipline, 0);
            this.Controls.SetChildIndex(this.selectWork, 0);
            this.Controls.SetChildIndex(this.selectWorkName, 0);
            this.Controls.SetChildIndex(this.selectGroup, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.taskComplectOtherIcon, 0);
            this.Controls.SetChildIndex(this.groupOtherIcon, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.Controls.SetChildIndex(this.buttonContinue, 0);
            this.Controls.SetChildIndex(this.pictureBoxGitHub, 0);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOtherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskComplectOtherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tasksComplectCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label selectDiscipline;
        private System.Windows.Forms.Label selectWork;
        private System.Windows.Forms.Label selectWorkName;
        private System.Windows.Forms.Label selectGroup;
        private System.Windows.Forms.Panel panel2;
        private Components.InteractiveIcon taskComplectOtherIcon;
        private Components.InteractiveIcon groupOtherIcon;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.PictureBox pictureBoxGitHub;
    }
}

