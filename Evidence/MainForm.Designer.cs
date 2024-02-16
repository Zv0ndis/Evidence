namespace Evidence
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonApplience = new System.Windows.Forms.Button();
            this.buttonHighSchool = new System.Windows.Forms.Button();
            this.buttonSynchronize = new System.Windows.Forms.Button();
            this.buttonFileDialog = new System.Windows.Forms.Button();
            this.buttonCloseFile = new System.Windows.Forms.Button();
            this.buttonNewApllience = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonLookUp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(21, 24);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 1;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonApplience
            // 
            this.buttonApplience.Location = new System.Drawing.Point(21, 53);
            this.buttonApplience.Name = "buttonApplience";
            this.buttonApplience.Size = new System.Drawing.Size(75, 23);
            this.buttonApplience.TabIndex = 2;
            this.buttonApplience.Text = "Applience";
            this.buttonApplience.UseVisualStyleBackColor = true;
            this.buttonApplience.Click += new System.EventHandler(this.buttonApplience_Click);
            // 
            // buttonHighSchool
            // 
            this.buttonHighSchool.Location = new System.Drawing.Point(21, 82);
            this.buttonHighSchool.Name = "buttonHighSchool";
            this.buttonHighSchool.Size = new System.Drawing.Size(75, 23);
            this.buttonHighSchool.TabIndex = 3;
            this.buttonHighSchool.Text = "High School";
            this.buttonHighSchool.UseVisualStyleBackColor = true;
            // 
            // buttonSynchronize
            // 
            this.buttonSynchronize.Location = new System.Drawing.Point(21, 111);
            this.buttonSynchronize.Name = "buttonSynchronize";
            this.buttonSynchronize.Size = new System.Drawing.Size(75, 23);
            this.buttonSynchronize.TabIndex = 4;
            this.buttonSynchronize.Text = "Synchronize";
            this.buttonSynchronize.UseVisualStyleBackColor = true;
            // 
            // buttonFileDialog
            // 
            this.buttonFileDialog.Location = new System.Drawing.Point(102, 24);
            this.buttonFileDialog.Name = "buttonFileDialog";
            this.buttonFileDialog.Size = new System.Drawing.Size(89, 23);
            this.buttonFileDialog.TabIndex = 5;
            this.buttonFileDialog.Text = "Load File";
            this.buttonFileDialog.UseVisualStyleBackColor = true;
            this.buttonFileDialog.Visible = false;
            this.buttonFileDialog.Click += new System.EventHandler(this.buttonFileDialog_Click);
            // 
            // buttonCloseFile
            // 
            this.buttonCloseFile.Location = new System.Drawing.Point(102, 53);
            this.buttonCloseFile.Name = "buttonCloseFile";
            this.buttonCloseFile.Size = new System.Drawing.Size(89, 23);
            this.buttonCloseFile.TabIndex = 6;
            this.buttonCloseFile.Text = "Close File";
            this.buttonCloseFile.UseVisualStyleBackColor = true;
            this.buttonCloseFile.Visible = false;
            this.buttonCloseFile.Click += new System.EventHandler(this.buttonCloseFile_Click);
            // 
            // buttonNewApllience
            // 
            this.buttonNewApllience.Location = new System.Drawing.Point(102, 53);
            this.buttonNewApllience.Name = "buttonNewApllience";
            this.buttonNewApllience.Size = new System.Drawing.Size(89, 23);
            this.buttonNewApllience.TabIndex = 7;
            this.buttonNewApllience.Text = "New Apllience";
            this.buttonNewApllience.UseVisualStyleBackColor = true;
            this.buttonNewApllience.Click += new System.EventHandler(this.buttonNewApllience_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(102, 82);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(89, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(102, 111);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(102, 140);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(89, 23);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(102, 169);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(89, 23);
            this.buttonShowAll.TabIndex = 11;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            // 
            // buttonLookUp
            // 
            this.buttonLookUp.Location = new System.Drawing.Point(102, 198);
            this.buttonLookUp.Name = "buttonLookUp";
            this.buttonLookUp.Size = new System.Drawing.Size(89, 23);
            this.buttonLookUp.TabIndex = 12;
            this.buttonLookUp.Text = "Look Up";
            this.buttonLookUp.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.Enter += new System.EventHandler(this.listBox1_Enter);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(263, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 95);
            this.listBox2.TabIndex = 14;
            this.listBox2.Enter += new System.EventHandler(this.listBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SŠ Přihlášky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "VŠ Přihlášky";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(248, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLookUp);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNewApllience);
            this.Controls.Add(this.buttonCloseFile);
            this.Controls.Add(this.buttonFileDialog);
            this.Controls.Add(this.buttonSynchronize);
            this.Controls.Add(this.buttonHighSchool);
            this.Controls.Add(this.buttonApplience);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonApplience;
        private System.Windows.Forms.Button buttonHighSchool;
        private System.Windows.Forms.Button buttonSynchronize;
        private System.Windows.Forms.Button buttonFileDialog;
        private System.Windows.Forms.Button buttonCloseFile;
        private System.Windows.Forms.Button buttonNewApllience;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonLookUp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

