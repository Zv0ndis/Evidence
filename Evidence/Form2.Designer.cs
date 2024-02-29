using System.Windows.Forms;

namespace Evidence
{
    partial class Form2
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxPoints = new System.Windows.Forms.MaskedTextBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.radioButtonAccepted = new System.Windows.Forms.RadioButton();
            this.radioButtonDenied = new System.Windows.Forms.RadioButton();
            this.labelState = new System.Windows.Forms.Label();
            this.radioButtonUniversity = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondarySchool = new System.Windows.Forms.RadioButton();
            this.labelAverage = new System.Windows.Forms.Label();
            this.maskedTextBoxAverage = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(38, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(144, 37);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(147, 53);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DoB";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.Checked = false;
            this.dateTimePickerDoB.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDoB.Location = new System.Drawing.Point(41, 92);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerDoB.TabIndex = 6;
            // 
            // comboBoxStudy
            // 
            this.comboBoxStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudy.FormattingEnabled = true;
            this.comboBoxStudy.Items.AddRange(new object[] {
            "accountant",
            "informatic",
            "president",
            "politic",
            "otrokovican"});
            this.comboBoxStudy.Location = new System.Drawing.Point(240, 92);
            this.comboBoxStudy.Name = "comboBoxStudy";
            this.comboBoxStudy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obor";
            // 
            // maskedTextBoxPoints
            // 
            this.maskedTextBoxPoints.Location = new System.Drawing.Point(41, 171);
            this.maskedTextBoxPoints.Mask = "000";
            this.maskedTextBoxPoints.Name = "maskedTextBoxPoints";
            this.maskedTextBoxPoints.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBoxPoints.TabIndex = 9;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(38, 155);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(36, 13);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "Points";
            // 
            // radioButtonAccepted
            // 
            this.radioButtonAccepted.AutoSize = true;
            this.radioButtonAccepted.Location = new System.Drawing.Point(8, 19);
            this.radioButtonAccepted.Name = "radioButtonAccepted";
            this.radioButtonAccepted.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAccepted.TabIndex = 11;
            this.radioButtonAccepted.Tag = "Group2";
            this.radioButtonAccepted.Text = "Accepted";
            this.radioButtonAccepted.UseVisualStyleBackColor = true;
            // 
            // radioButtonDenied
            // 
            this.radioButtonDenied.AutoSize = true;
            this.radioButtonDenied.Location = new System.Drawing.Point(106, 19);
            this.radioButtonDenied.Name = "radioButtonDenied";
            this.radioButtonDenied.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDenied.TabIndex = 12;
            this.radioButtonDenied.Tag = "";
            this.radioButtonDenied.Text = "Denied";
            this.radioButtonDenied.UseVisualStyleBackColor = true;
            this.radioButtonDenied.CheckedChanged += new System.EventHandler(this.radioButtonDenied_CheckedChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(38, 194);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(82, 13);
            this.labelState.TabIndex = 13;
            this.labelState.Text = "State of student";
            // 
            // radioButtonUniversity
            // 
            this.radioButtonUniversity.AutoSize = true;
            this.radioButtonUniversity.Location = new System.Drawing.Point(164, 14);
            this.radioButtonUniversity.Name = "radioButtonUniversity";
            this.radioButtonUniversity.Size = new System.Drawing.Size(71, 17);
            this.radioButtonUniversity.TabIndex = 15;
            this.radioButtonUniversity.Tag = "Group1";
            this.radioButtonUniversity.Text = "University";
            this.radioButtonUniversity.UseVisualStyleBackColor = true;
            this.radioButtonUniversity.CheckedChanged += new System.EventHandler(this.radioButtonUniversity_CheckedChanged);
            // 
            // radioButtonSecondarySchool
            // 
            this.radioButtonSecondarySchool.AutoSize = true;
            this.radioButtonSecondarySchool.Location = new System.Drawing.Point(29, 15);
            this.radioButtonSecondarySchool.Name = "radioButtonSecondarySchool";
            this.radioButtonSecondarySchool.Size = new System.Drawing.Size(112, 17);
            this.radioButtonSecondarySchool.TabIndex = 14;
            this.radioButtonSecondarySchool.Tag = "Group1";
            this.radioButtonSecondarySchool.Text = "Secondary School";
            this.radioButtonSecondarySchool.UseVisualStyleBackColor = true;
            this.radioButtonSecondarySchool.CheckedChanged += new System.EventHandler(this.radioButtonSecondarySchool_CheckedChanged);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(80, 155);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(47, 13);
            this.labelAverage.TabIndex = 17;
            this.labelAverage.Text = "Average";
            // 
            // maskedTextBoxAverage
            // 
            this.maskedTextBoxAverage.Location = new System.Drawing.Point(79, 171);
            this.maskedTextBoxAverage.Mask = "0.0";
            this.maskedTextBoxAverage.Name = "maskedTextBoxAverage";
            this.maskedTextBoxAverage.Size = new System.Drawing.Size(22, 20);
            this.maskedTextBoxAverage.TabIndex = 16;
            this.maskedTextBoxAverage.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxAverage_MaskInputRejected_1);
            this.maskedTextBoxAverage.TextChanged += new System.EventHandler(this.maskedTextBoxAverage_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButtonUniversity);
            this.groupBox1.Controls.Add(this.radioButtonSecondarySchool);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 37);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.radioButtonAccepted);
            this.groupBox2.Controls.Add(this.radioButtonDenied);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(41, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 52);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(387, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.maskedTextBoxAverage);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.maskedTextBoxPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStudy);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.ComboBox comboBoxStudy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPoints;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.RadioButton radioButtonAccepted;
        private System.Windows.Forms.RadioButton radioButtonDenied;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.RadioButton radioButtonUniversity;
        private System.Windows.Forms.RadioButton radioButtonSecondarySchool;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

