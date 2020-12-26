namespace View
{
    partial class AlarmView
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
            this.lbl_alarm = new System.Windows.Forms.Label();
            this.txt_alarm = new System.Windows.Forms.TextBox();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.btn_addAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_alarm
            // 
            this.lbl_alarm.AutoSize = true;
            this.lbl_alarm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alarm.Location = new System.Drawing.Point(13, 13);
            this.lbl_alarm.Name = "lbl_alarm";
            this.lbl_alarm.Size = new System.Drawing.Size(273, 25);
            this.lbl_alarm.TabIndex = 0;
            this.lbl_alarm.Text = "Продолжительность тревоги:";
            // 
            // txt_alarm
            // 
            this.txt_alarm.Location = new System.Drawing.Point(13, 60);
            this.txt_alarm.Name = "txt_alarm";
            this.txt_alarm.Size = new System.Drawing.Size(150, 31);
            this.txt_alarm.TabIndex = 1;
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Location = new System.Drawing.Point(169, 66);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(41, 25);
            this.lbl_sec.TabIndex = 2;
            this.lbl_sec.Text = "Сек";
            // 
            // btn_addAlarm
            // 
            this.btn_addAlarm.Location = new System.Drawing.Point(244, 57);
            this.btn_addAlarm.Name = "btn_addAlarm";
            this.btn_addAlarm.Size = new System.Drawing.Size(112, 34);
            this.btn_addAlarm.TabIndex = 3;
            this.btn_addAlarm.Text = "Добавить";
            this.btn_addAlarm.UseVisualStyleBackColor = true;
            this.btn_addAlarm.Click += new System.EventHandler(this.btn_addAlarm_Click);
            // 
            // AlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 109);
            this.Controls.Add(this.btn_addAlarm);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.txt_alarm);
            this.Controls.Add(this.lbl_alarm);
            this.Name = "AlarmView";
            this.Text = "Тревога!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_alarm;
        private System.Windows.Forms.TextBox txt_alarm;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Button btn_addAlarm;
    }
}