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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.btn_addAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность тревоги:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 1;
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
            // 
            // AlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 109);
            this.Controls.Add(this.btn_addAlarm);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AlarmView";
            this.Text = "Тревога!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Button btn_addAlarm;
    }
}