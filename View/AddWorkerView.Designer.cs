namespace View
{
    partial class AddWorkerView
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_floor1 = new System.Windows.Forms.Label();
            this.txt_floor1 = new System.Windows.Forms.TextBox();
            this.lbl_floor2 = new System.Windows.Forms.Label();
            this.txt_floor2 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Имя";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(105, 31);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_floor1
            // 
            this.lbl_floor1.AutoSize = true;
            this.lbl_floor1.Location = new System.Drawing.Point(136, 13);
            this.lbl_floor1.Name = "lbl_floor1";
            this.lbl_floor1.Size = new System.Drawing.Size(67, 25);
            this.lbl_floor1.TabIndex = 2;
            this.lbl_floor1.Text = "Этаж 1";
            // 
            // txt_floor1
            // 
            this.txt_floor1.Location = new System.Drawing.Point(135, 41);
            this.txt_floor1.Name = "txt_floor1";
            this.txt_floor1.Size = new System.Drawing.Size(105, 31);
            this.txt_floor1.TabIndex = 3;
            // 
            // lbl_floor2
            // 
            this.lbl_floor2.AutoSize = true;
            this.lbl_floor2.Location = new System.Drawing.Point(137, 82);
            this.lbl_floor2.Name = "lbl_floor2";
            this.lbl_floor2.Size = new System.Drawing.Size(67, 25);
            this.lbl_floor2.TabIndex = 4;
            this.lbl_floor2.Text = "Этаж 2";
            // 
            // txt_floor2
            // 
            this.txt_floor2.Location = new System.Drawing.Point(136, 110);
            this.txt_floor2.Name = "txt_floor2";
            this.txt_floor2.Size = new System.Drawing.Size(105, 31);
            this.txt_floor2.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(271, 82);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(271, 35);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(112, 34);
            this.btn_random.TabIndex = 7;
            this.btn_random.Text = "Случайно";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddWorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 161);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_floor2);
            this.Controls.Add(this.lbl_floor2);
            this.Controls.Add(this.txt_floor1);
            this.Controls.Add(this.lbl_floor1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddWorkerView";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_floor1;
        private System.Windows.Forms.TextBox txt_floor1;
        private System.Windows.Forms.Label lbl_floor2;
        private System.Windows.Forms.TextBox txt_floor2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_random;
    }
}