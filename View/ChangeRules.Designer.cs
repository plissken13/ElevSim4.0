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
            this.lbl_addWorker.Location = new System.Drawing.Point(226, 13);
            this.lbl_addWorker.Name = "lbl_addWorker";
            this.lbl_addWorker.Size = new System.Drawing.Size(189, 25);
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
            this.btn_random.Location = new System.Drawing.Point(622, 13);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(112, 34);
            this.btn_random.TabIndex = 8;
            this.btn_random.Text = "Случайно";
            this.btn_random.UseVisualStyleBackColor = true;
            // 
            // ChangeRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}