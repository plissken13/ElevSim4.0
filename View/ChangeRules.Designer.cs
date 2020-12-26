namespace View
{
    partial class ChangeRules
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
            this.lb_eventList = new System.Windows.Forms.ListBox();
            this.lbl_addWorker = new System.Windows.Forms.Label();
            this.lbl_workerName = new System.Windows.Forms.Label();
            this.txt_workerName = new System.Windows.Forms.TextBox();
            this.lbl_floor1 = new System.Windows.Forms.Label();
            this.lbl_floor2 = new System.Windows.Forms.Label();
            this.txt_floor1 = new System.Windows.Forms.TextBox();
            this.txt_floor2 = new System.Windows.Forms.TextBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.lbl_liftStrategy = new System.Windows.Forms.Label();
            this.chb_1 = new System.Windows.Forms.CheckBox();
            this.chb_2 = new System.Windows.Forms.CheckBox();
            this.chb_3 = new System.Windows.Forms.CheckBox();
            this.btn_applyStrategy = new System.Windows.Forms.Button();
            this.lbl_wait = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_wait = new System.Windows.Forms.TextBox();
            this.btn_addWait = new System.Windows.Forms.Button();
            this.lbl_alarm = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_alam = new System.Windows.Forms.TextBox();
            this.btn_addAlarm = new System.Windows.Forms.Button();
            this.btn_applyRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_eventList
            // 
            this.lb_eventList.FormattingEnabled = true;
            this.lb_eventList.ItemHeight = 25;
            this.lb_eventList.Location = new System.Drawing.Point(13, 13);
            this.lb_eventList.Name = "lb_eventList";
            this.lb_eventList.Size = new System.Drawing.Size(180, 404);
            this.lb_eventList.TabIndex = 0;
            // 
            // lbl_addWorker
            // 
            this.lbl_addWorker.AutoSize = true;
            this.lbl_addWorker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_addWorker.Location = new System.Drawing.Point(226, 13);
            this.lbl_addWorker.Name = "lbl_addWorker";
            this.lbl_addWorker.Size = new System.Drawing.Size(203, 25);
            this.lbl_addWorker.TabIndex = 1;
            this.lbl_addWorker.Text = "Добавить сотрудника";
            // 
            // lbl_workerName
            // 
            this.lbl_workerName.AutoSize = true;
            this.lbl_workerName.Location = new System.Drawing.Point(226, 52);
            this.lbl_workerName.Name = "lbl_workerName";
            this.lbl_workerName.Size = new System.Drawing.Size(47, 25);
            this.lbl_workerName.TabIndex = 2;
            this.lbl_workerName.Text = "Имя";
            // 
            // txt_workerName
            // 
            this.txt_workerName.Location = new System.Drawing.Point(279, 52);
            this.txt_workerName.Name = "txt_workerName";
            this.txt_workerName.Size = new System.Drawing.Size(119, 31);
            this.txt_workerName.TabIndex = 3;
            // 
            // lbl_floor1
            // 
            this.lbl_floor1.AutoSize = true;
            this.lbl_floor1.Location = new System.Drawing.Point(434, 13);
            this.lbl_floor1.Name = "lbl_floor1";
            this.lbl_floor1.Size = new System.Drawing.Size(67, 25);
            this.lbl_floor1.TabIndex = 4;
            this.lbl_floor1.Text = "Этаж 1";
            // 
            // lbl_floor2
            // 
            this.lbl_floor2.AutoSize = true;
            this.lbl_floor2.Location = new System.Drawing.Point(523, 13);
            this.lbl_floor2.Name = "lbl_floor2";
            this.lbl_floor2.Size = new System.Drawing.Size(67, 25);
            this.lbl_floor2.TabIndex = 5;
            this.lbl_floor2.Text = "Этаж 2";
            // 
            // txt_floor1
            // 
            this.txt_floor1.Location = new System.Drawing.Point(434, 52);
            this.txt_floor1.Name = "txt_floor1";
            this.txt_floor1.Size = new System.Drawing.Size(67, 31);
            this.txt_floor1.TabIndex = 6;
            // 
            // txt_floor2
            // 
            this.txt_floor2.Location = new System.Drawing.Point(523, 52);
            this.txt_floor2.Name = "txt_floor2";
            this.txt_floor2.Size = new System.Drawing.Size(67, 31);
            this.txt_floor2.TabIndex = 7;
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(612, 13);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(112, 34);
            this.btn_random.TabIndex = 8;
            this.btn_random.Text = "Случайно";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(612, 50);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(112, 34);
            this.btn_addWorker.TabIndex = 9;
            this.btn_addWorker.Text = "Добавить";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            // 
            // lbl_liftStrategy
            // 
            this.lbl_liftStrategy.AutoSize = true;
            this.lbl_liftStrategy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_liftStrategy.Location = new System.Drawing.Point(226, 110);
            this.lbl_liftStrategy.Name = "lbl_liftStrategy";
            this.lbl_liftStrategy.Size = new System.Drawing.Size(168, 25);
            this.lbl_liftStrategy.TabIndex = 10;
            this.lbl_liftStrategy.Text = "Стратегия лифтов";
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.Location = new System.Drawing.Point(226, 152);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(283, 29);
            this.chb_1.TabIndex = 11;
            this.chb_1.Text = "Минимум времени ожидания";
            this.chb_1.UseVisualStyleBackColor = true;
            // 
            // chb_2
            // 
            this.chb_2.AutoSize = true;
            this.chb_2.Location = new System.Drawing.Point(226, 188);
            this.chb_2.Name = "chb_2";
            this.chb_2.Size = new System.Drawing.Size(254, 29);
            this.chb_2.TabIndex = 12;
            this.chb_2.Text = "Минимум холостых ходов";
            this.chb_2.UseVisualStyleBackColor = true;
            // 
            // chb_3
            // 
            this.chb_3.AutoSize = true;
            this.chb_3.Location = new System.Drawing.Point(226, 224);
            this.chb_3.Name = "chb_3";
            this.chb_3.Size = new System.Drawing.Size(54, 29);
            this.chb_3.TabIndex = 13;
            this.chb_3.Text = "??";
            this.chb_3.UseVisualStyleBackColor = true;
            // 
            // btn_applyStrategy
            // 
            this.btn_applyStrategy.Location = new System.Drawing.Point(226, 260);
            this.btn_applyStrategy.Name = "btn_applyStrategy";
            this.btn_applyStrategy.Size = new System.Drawing.Size(112, 34);
            this.btn_applyStrategy.TabIndex = 14;
            this.btn_applyStrategy.Text = "Применить";
            this.btn_applyStrategy.UseVisualStyleBackColor = true;
            // 
            // lbl_wait
            // 
            this.lbl_wait.AutoSize = true;
            this.lbl_wait.Location = new System.Drawing.Point(226, 318);
            this.lbl_wait.Name = "lbl_wait";
            this.lbl_wait.Size = new System.Drawing.Size(63, 25);
            this.lbl_wait.TabIndex = 15;
            this.lbl_wait.Text = "Ждать";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(279, 346);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(38, 25);
            this.lbl_1.TabIndex = 16;
            this.lbl_1.Text = "сек";
            // 
            // txt_wait
            // 
            this.txt_wait.Location = new System.Drawing.Point(226, 346);
            this.txt_wait.Name = "txt_wait";
            this.txt_wait.Size = new System.Drawing.Size(47, 31);
            this.txt_wait.TabIndex = 17;
            // 
            // btn_addWait
            // 
            this.btn_addWait.Location = new System.Drawing.Point(226, 383);
            this.btn_addWait.Name = "btn_addWait";
            this.btn_addWait.Size = new System.Drawing.Size(112, 34);
            this.btn_addWait.TabIndex = 18;
            this.btn_addWait.Text = "Добавить";
            this.btn_addWait.UseVisualStyleBackColor = true;
            // 
            // lbl_alarm
            // 
            this.lbl_alarm.AutoSize = true;
            this.lbl_alarm.Location = new System.Drawing.Point(389, 318);
            this.lbl_alarm.Name = "lbl_alarm";
            this.lbl_alarm.Size = new System.Drawing.Size(78, 25);
            this.lbl_alarm.TabIndex = 19;
            this.lbl_alarm.Text = "Тревога";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(442, 346);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(38, 25);
            this.lbl_2.TabIndex = 16;
            this.lbl_2.Text = "сек";
            // 
            // txt_alam
            // 
            this.txt_alam.Location = new System.Drawing.Point(389, 346);
            this.txt_alam.Name = "txt_alam";
            this.txt_alam.Size = new System.Drawing.Size(47, 31);
            this.txt_alam.TabIndex = 17;
            // 
            // btn_addAlarm
            // 
            this.btn_addAlarm.Location = new System.Drawing.Point(389, 383);
            this.btn_addAlarm.Name = "btn_addAlarm";
            this.btn_addAlarm.Size = new System.Drawing.Size(112, 34);
            this.btn_addAlarm.TabIndex = 18;
            this.btn_addAlarm.Text = "Добавить";
            this.btn_addAlarm.UseVisualStyleBackColor = true;
            // 
            // btn_applyRules
            // 
            this.btn_applyRules.Location = new System.Drawing.Point(612, 357);
            this.btn_applyRules.Name = "btn_applyRules";
            this.btn_applyRules.Size = new System.Drawing.Size(112, 60);
            this.btn_applyRules.TabIndex = 20;
            this.btn_applyRules.Text = "Применить правила";
            this.btn_applyRules.UseVisualStyleBackColor = true;
            this.btn_applyRules.Click += new System.EventHandler(this.btn_applyRules_Click);
            // 
            // ChangeRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btn_applyRules);
            this.Controls.Add(this.btn_addAlarm);
            this.Controls.Add(this.txt_alam);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_alarm);
            this.Controls.Add(this.btn_addWait);
            this.Controls.Add(this.txt_wait);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_wait);
            this.Controls.Add(this.btn_applyStrategy);
            this.Controls.Add(this.chb_3);
            this.Controls.Add(this.chb_2);
            this.Controls.Add(this.chb_1);
            this.Controls.Add(this.lbl_liftStrategy);
            this.Controls.Add(this.btn_addWorker);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.txt_floor2);
            this.Controls.Add(this.txt_floor1);
            this.Controls.Add(this.lbl_floor2);
            this.Controls.Add(this.lbl_floor1);
            this.Controls.Add(this.txt_workerName);
            this.Controls.Add(this.lbl_workerName);
            this.Controls.Add(this.lbl_addWorker);
            this.Controls.Add(this.lb_eventList);
            this.Name = "ChangeRules";
            this.Text = "Смена правил";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_eventList;
        private System.Windows.Forms.Label lbl_addWorker;
        private System.Windows.Forms.Label lbl_workerName;
        private System.Windows.Forms.TextBox txt_workerName;
        private System.Windows.Forms.Label lbl_floor1;
        private System.Windows.Forms.Label lbl_floor2;
        private System.Windows.Forms.TextBox txt_floor1;
        private System.Windows.Forms.TextBox txt_floor2;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.Label lbl_liftStrategy;
        private System.Windows.Forms.CheckBox chb_1;
        private System.Windows.Forms.CheckBox chb_2;
        private System.Windows.Forms.CheckBox chb_3;
        private System.Windows.Forms.Button btn_applyStrategy;
        private System.Windows.Forms.Label lbl_wait;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_wait;
        private System.Windows.Forms.Button btn_addWait;
        private System.Windows.Forms.Label lbl_alarm;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_alam;
        private System.Windows.Forms.Button btn_addAlarm;
        private System.Windows.Forms.Button btn_applyRules;
    }
}