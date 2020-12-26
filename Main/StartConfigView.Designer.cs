namespace Main
{
    partial class StartConfigView
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
            this.lbl_buildingParameters = new System.Windows.Forms.Label();
            this.lbl_floorNum = new System.Windows.Forms.Label();
            this.lbl_liftNum = new System.Windows.Forms.Label();
            this.txt_floorNum = new System.Windows.Forms.TextBox();
            this.txt_liftNum = new System.Windows.Forms.TextBox();
            this.lbl_liftParameters = new System.Windows.Forms.Label();
            this.btn_addBuilding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_buildingParameters
            // 
            this.lbl_buildingParameters.AutoSize = true;
            this.lbl_buildingParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_buildingParameters.Location = new System.Drawing.Point(14, 16);
            this.lbl_buildingParameters.Name = "lbl_buildingParameters";
            this.lbl_buildingParameters.Size = new System.Drawing.Size(251, 29);
            this.lbl_buildingParameters.TabIndex = 0;
            this.lbl_buildingParameters.Text = "Параметры здания";
            // 
            // lbl_floorNum
            // 
            this.lbl_floorNum.AutoSize = true;
            this.lbl_floorNum.Location = new System.Drawing.Point(20, 86);
            this.lbl_floorNum.Name = "lbl_floorNum";
            this.lbl_floorNum.Size = new System.Drawing.Size(131, 25);
            this.lbl_floorNum.TabIndex = 1;
            this.lbl_floorNum.Text = "Кол-во этажей";
            // 
            // lbl_liftNum
            // 
            this.lbl_liftNum.AutoSize = true;
            this.lbl_liftNum.Location = new System.Drawing.Point(219, 86);
            this.lbl_liftNum.Name = "lbl_liftNum";
            this.lbl_liftNum.Size = new System.Drawing.Size(134, 25);
            this.lbl_liftNum.TabIndex = 2;
            this.lbl_liftNum.Text = "Кол-во лифтов";
            // 
            // txt_floorNum
            // 
            this.txt_floorNum.Location = new System.Drawing.Point(24, 115);
            this.txt_floorNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_floorNum.Name = "txt_floorNum";
            this.txt_floorNum.Size = new System.Drawing.Size(130, 31);
            this.txt_floorNum.TabIndex = 3;
            // 
            // txt_liftNum
            // 
            this.txt_liftNum.Location = new System.Drawing.Point(223, 115);
            this.txt_liftNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_liftNum.Name = "txt_liftNum";
            this.txt_liftNum.Size = new System.Drawing.Size(130, 31);
            this.txt_liftNum.TabIndex = 4;
            // 
            // lbl_liftParameters
            // 
            this.lbl_liftParameters.AutoSize = true;
            this.lbl_liftParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_liftParameters.Location = new System.Drawing.Point(20, 212);
            this.lbl_liftParameters.Name = "lbl_liftParameters";
            this.lbl_liftParameters.Size = new System.Drawing.Size(254, 29);
            this.lbl_liftParameters.TabIndex = 5;
            this.lbl_liftParameters.Text = "Параметры лифтов";
            // 
            // btn_addBuilding
            // 
            this.btn_addBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addBuilding.Location = new System.Drawing.Point(749, 531);
            this.btn_addBuilding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addBuilding.Name = "btn_addBuilding";
            this.btn_addBuilding.Size = new System.Drawing.Size(128, 54);
            this.btn_addBuilding.TabIndex = 6;
            this.btn_addBuilding.Text = "Применить";
            this.btn_addBuilding.UseVisualStyleBackColor = true;
            this.btn_addBuilding.Click += new System.EventHandler(this.btn_addBuilding_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 598);
            this.Controls.Add(this.btn_addBuilding);
            this.Controls.Add(this.lbl_liftParameters);
            this.Controls.Add(this.txt_liftNum);
            this.Controls.Add(this.txt_floorNum);
            this.Controls.Add(this.lbl_liftNum);
            this.Controls.Add(this.lbl_floorNum);
            this.Controls.Add(this.lbl_buildingParameters);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Симулятор лифта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_buildingParameters;
        private System.Windows.Forms.Label lbl_floorNum;
        private System.Windows.Forms.Label lbl_liftNum;
        private System.Windows.Forms.TextBox txt_floorNum;
        private System.Windows.Forms.TextBox txt_liftNum;
        private System.Windows.Forms.Label lbl_liftParameters;
        private System.Windows.Forms.Button btn_addBuilding;
    }
}

