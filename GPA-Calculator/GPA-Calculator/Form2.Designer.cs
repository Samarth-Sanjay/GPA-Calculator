namespace GPA_Calculator
{
    partial class Form2
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.comboBoxCreditHours = new System.Windows.Forms.ComboBox();
            this.labelCreditHours = new System.Windows.Forms.Label();
            this.groupBoxGrades = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lstDetail = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGpaCalculator = new System.Windows.Forms.Label();
            this.groupBoxGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(889, 487);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 55);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(401, 476);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(123, 76);
            this.buttonRemoveSelected.TabIndex = 19;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Location = new System.Drawing.Point(219, 476);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(123, 76);
            this.buttonResetAll.TabIndex = 18;
            this.buttonResetAll.Text = "Reset All";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(34, 476);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(123, 76);
            this.buttonEnter.TabIndex = 17;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // comboBoxCreditHours
            // 
            this.comboBoxCreditHours.FormattingEnabled = true;
            this.comboBoxCreditHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCreditHours.Location = new System.Drawing.Point(343, 232);
            this.comboBoxCreditHours.Name = "comboBoxCreditHours";
            this.comboBoxCreditHours.Size = new System.Drawing.Size(99, 33);
            this.comboBoxCreditHours.TabIndex = 16;
            // 
            // labelCreditHours
            // 
            this.labelCreditHours.AutoSize = true;
            this.labelCreditHours.Location = new System.Drawing.Point(338, 170);
            this.labelCreditHours.Name = "labelCreditHours";
            this.labelCreditHours.Size = new System.Drawing.Size(138, 25);
            this.labelCreditHours.TabIndex = 15;
            this.labelCreditHours.Text = "Credit Hours:";
            // 
            // groupBoxGrades
            // 
            this.groupBoxGrades.Controls.Add(this.radioButton5);
            this.groupBoxGrades.Controls.Add(this.radioButton4);
            this.groupBoxGrades.Controls.Add(this.radioButton3);
            this.groupBoxGrades.Controls.Add(this.radioButton2);
            this.groupBoxGrades.Controls.Add(this.radioButton1);
            this.groupBoxGrades.Location = new System.Drawing.Point(34, 170);
            this.groupBoxGrades.Name = "groupBoxGrades";
            this.groupBoxGrades.Size = new System.Drawing.Size(216, 264);
            this.groupBoxGrades.TabIndex = 14;
            this.groupBoxGrades.TabStop = false;
            this.groupBoxGrades.Text = "Select a grade:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 229);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 29);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "F";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 178);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 132);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "4";
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lstDetail
            // 
            this.lstDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstDetail.FormattingEnabled = true;
            this.lstDetail.ItemHeight = 33;
            this.lstDetail.Location = new System.Drawing.Point(567, 144);
            this.lstDetail.Name = "lstDetail";
            this.lstDetail.Size = new System.Drawing.Size(294, 367);
            this.lstDetail.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "GPA:";
            // 
            // labelGpaCalculator
            // 
            this.labelGpaCalculator.AutoSize = true;
            this.labelGpaCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGpaCalculator.Location = new System.Drawing.Point(38, 78);
            this.labelGpaCalculator.Name = "labelGpaCalculator";
            this.labelGpaCalculator.Size = new System.Drawing.Size(253, 37);
            this.labelGpaCalculator.TabIndex = 11;
            this.labelGpaCalculator.Text = "GPA Calculator";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 630);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.comboBoxCreditHours);
            this.Controls.Add(this.labelCreditHours);
            this.Controls.Add(this.groupBoxGrades);
            this.Controls.Add(this.lstDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGpaCalculator);
            this.Name = "Form2";
            this.Text = "DataEntry";
            this.groupBoxGrades.ResumeLayout(false);
            this.groupBoxGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ComboBox comboBoxCreditHours;
        private System.Windows.Forms.Label labelCreditHours;
        private System.Windows.Forms.GroupBox groupBoxGrades;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lstDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGpaCalculator;
    }
}