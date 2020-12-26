namespace View
{
    partial class MainFrame
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_startPause = new System.Windows.Forms.Button();
            this.btn_changeRules = new System.Windows.Forms.Button();
            this.lb_eventList = new System.Windows.Forms.ListBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(23, 20);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(595, 341);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(473, 373);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(145, 65);
            this.btn_addWorker.TabIndex = 1;
            this.btn_addWorker.Text = "Добавить сотрудника";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // btn_alarm
            // 
            this.btn_alarm.Location = new System.Drawing.Point(137, 373);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(145, 30);
            this.btn_alarm.TabIndex = 2;
            this.btn_alarm.Text = "Тревога!";
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_startPause
            // 
            this.btn_startPause.Location = new System.Drawing.Point(137, 406);
            this.btn_startPause.Name = "btn_startPause";
            this.btn_startPause.Size = new System.Drawing.Size(145, 32);
            this.btn_startPause.TabIndex = 3;
            this.btn_startPause.Text = "Пауза/Старт";
            this.btn_startPause.UseVisualStyleBackColor = true;
            // 
            // btn_changeRules
            // 
            this.btn_changeRules.Location = new System.Drawing.Point(23, 373);
            this.btn_changeRules.Name = "btn_changeRules";
            this.btn_changeRules.Size = new System.Drawing.Size(108, 64);
            this.btn_changeRules.TabIndex = 4;
            this.btn_changeRules.Text = "Смена правил";
            this.btn_changeRules.UseVisualStyleBackColor = true;
            this.btn_changeRules.Click += new System.EventHandler(this.btn_changeRules_Click);
            // 
            // lb_eventList
            // 
            this.lb_eventList.FormattingEnabled = true;
            this.lb_eventList.ItemHeight = 25;
            this.lb_eventList.Location = new System.Drawing.Point(643, 20);
            this.lb_eventList.Name = "lb_eventList";
            this.lb_eventList.Size = new System.Drawing.Size(145, 404);
            this.lb_eventList.TabIndex = 5;
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(288, 373);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(179, 30);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "Завершить работу";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(288, 409);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(179, 30);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Экспорт правил";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.lb_eventList);
            this.Controls.Add(this.btn_changeRules);
            this.Controls.Add(this.btn_startPause);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.btn_addWorker);
            this.Controls.Add(this.picture);
            this.Name = "MainFrame";
            this.Text = "Симулятор лифта";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_startPause;
        private System.Windows.Forms.Button btn_changeRules;
        private System.Windows.Forms.ListBox lb_eventList;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_export;
    }
}