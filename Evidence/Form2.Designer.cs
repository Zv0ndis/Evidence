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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.button1 = new System.Windows.Forms.Button();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "accountant",
            "informatic",
            "president",
            "politic",
            "otrokovican"});
            this.comboBox1.Location = new System.Drawing.Point(41, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.maskedTextBoxPoints.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPoints_MaskInputRejected);
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
            this.radioButtonAccepted.Location = new System.Drawing.Point(41, 210);
            this.radioButtonAccepted.Name = "radioButtonAccepted";
            this.radioButtonAccepted.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAccepted.TabIndex = 11;
            this.radioButtonAccepted.TabStop = true;
            this.radioButtonAccepted.Text = "Accepted";
            this.radioButtonAccepted.UseVisualStyleBackColor = true;
            // 
            // radioButtonDenied
            // 
            this.radioButtonDenied.AutoSize = true;
            this.radioButtonDenied.Location = new System.Drawing.Point(118, 210);
            this.radioButtonDenied.Name = "radioButtonDenied";
            this.radioButtonDenied.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDenied.TabIndex = 12;
            this.radioButtonDenied.TabStop = true;
            this.radioButtonDenied.Text = "Denied";
            this.radioButtonDenied.UseVisualStyleBackColor = true;
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
            this.radioButtonUniversity.Location = new System.Drawing.Point(291, 12);
            this.radioButtonUniversity.Name = "radioButtonUniversity";
            this.radioButtonUniversity.Size = new System.Drawing.Size(71, 17);
            this.radioButtonUniversity.TabIndex = 15;
            this.radioButtonUniversity.TabStop = true;
            this.radioButtonUniversity.Text = "University";
            this.radioButtonUniversity.UseVisualStyleBackColor = true;
            this.radioButtonUniversity.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSecondarySchool
            // 
            this.radioButtonSecondarySchool.AutoSize = true;
            this.radioButtonSecondarySchool.Location = new System.Drawing.Point(49, 12);
            this.radioButtonSecondarySchool.Name = "radioButtonSecondarySchool";
            this.radioButtonSecondarySchool.Size = new System.Drawing.Size(112, 17);
            this.radioButtonSecondarySchool.TabIndex = 14;
            this.radioButtonSecondarySchool.TabStop = true;
            this.radioButtonSecondarySchool.Text = "Secondary School";
            this.radioButtonSecondarySchool.UseVisualStyleBackColor = true;
            this.radioButtonSecondarySchool.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.maskedTextBoxAverage.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxAverage_MaskInputRejected);
            this.maskedTextBoxAverage.TextChanged += new System.EventHandler(this.maskedTextBoxAverage_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(387, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.maskedTextBoxAverage);
            this.Controls.Add(this.radioButtonUniversity);
            this.Controls.Add(this.radioButtonSecondarySchool);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.radioButtonDenied);
            this.Controls.Add(this.radioButtonAccepted);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.maskedTextBoxPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Button button1;
    }
}

