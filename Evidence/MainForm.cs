using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence
{
    public enum MessageBoxButtons
    {
        HighSchool, University, Cancel
    }

    public partial class MainForm : Form
    {
        public List<Application> applications = new List<Application>();
        string filePathHighSchool = "prihlasky_stredni.txt";
        string filePathUniversity = "prihlasky_vyssi.txt";

        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists(filePathHighSchool)) using (StreamWriter sw1 = File.CreateText(filePathHighSchool)) { }

            if (!File.Exists(filePathUniversity)) using (StreamWriter sw2 = File.CreateText(filePathUniversity)) { }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            buttonFileDialog.Visible = false;
            buttonCloseFile.Visible = false;
            buttonDelete.Visible = false;
            buttonEdit.Visible = false;
            buttonLookUp.Visible = false;
            buttonShowAll.Visible = false;
            buttonShow.Visible = false;
            buttonNewApllience.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            buttonFileDialog.Visible = true;
            buttonCloseFile.Visible = true;
            buttonDelete.Visible = false;
            buttonEdit.Visible = false;
            buttonLookUp.Visible = false;
            buttonShowAll.Visible = false;
            buttonShow.Visible = false;
            buttonNewApllience.Visible = false;
        }
        private void buttonApplience_Click(object sender, EventArgs e)
        {
            buttonFileDialog.Visible = false;
            buttonCloseFile.Visible = false;
            buttonDelete.Visible = true;
            buttonEdit.Visible = true;
            buttonLookUp.Visible = true;
            buttonShowAll.Visible = true;
            buttonShow.Visible = true;
            buttonNewApllience.Visible = true;

        }

        private void buttonFileDialog_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            applications.Clear();

            using (StreamReader sr = new StreamReader(filePathHighSchool))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1)
                    {
                        applications.Add(
                            //             {uniqueCode},{name},{surname},       {dateOfBirth},     {selectedStudy}    {points},           {acceptedChoice}";
                            new HSApplication(parts[0], parts[1], parts[2], DateTime.Parse(parts[3]), parts[4], Convert.ToDouble(parts[5]), Convert.ToBoolean(parts[6])));
                        listBox1.Items.Add($"{parts[1]} {parts[2]} - {parts[4]}");
                    }
                }
            }

            using (StreamReader sr = new StreamReader(filePathUniversity))
            {
                listBox2.Items.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1)
                    {
                        applications.Add(
                        //             {uniqueCode},{name},{surname},       {dateOfBirth},     {selectedStudy}    {points},                 ,{average}               {acceptedChoice}";
                        new UApplication(parts[0], parts[1], parts[2], DateTime.Parse(parts[3]), parts[4], Convert.ToDouble(parts[5]), Convert.ToDouble(parts[6]), Convert.ToBoolean(parts[7])));
                        listBox2.Items.Add($"{parts[1]} {parts[2]} - {parts[4]}");
                    }
                }
            }
        }

        private void buttonCloseFile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewApllience_Click(object sender, EventArgs e)
        {

            // Vytvoříme novou instanci Form2
            Form2 form2 = new Form2(filePathHighSchool, filePathUniversity);

            // Zobrazíme Form2
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = IndexSelect();
            if (listBox1.SelectedIndex >= 0 || listBox2.SelectedIndex >= 0)
            {
                if (selectedIndex >= 0)
                {
                    Form2 form2 = new Form2(filePathHighSchool, filePathUniversity, applications[selectedIndex]);

                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            listBox2.SelectedItems.Clear();
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = IndexSelect();

            List<string> updatedLines = new List<string>();

            string filePath = selectedIndex >= listBox1.Items.Count ? filePathUniversity : filePathHighSchool;

            using (StreamReader sr = new StreamReader(filePath))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1 && parts[0] != applications[selectedIndex].Id)
                    {
                        updatedLines.Add(line);
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string line in updatedLines)
                {
                    sw.WriteLine(line);
                }
            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int selectedIndex = IndexSelect();

            if (selectedIndex >= 0)
            {
                Application selectedApplication = applications[selectedIndex];

                string educationType = selectedIndex >= listBox1.Items.Count ? "University" : "High School";

                StringBuilder infoBuilder = new StringBuilder();
                infoBuilder.AppendLine($"Information about student:");
                infoBuilder.AppendLine($"Name: {selectedApplication.Name}");
                infoBuilder.AppendLine($"Surname: {selectedApplication.Surname}");
                infoBuilder.AppendLine($"Date of birth: {selectedApplication.Dob.ToString("dd-MM-yyyy")}");
                infoBuilder.AppendLine($"Study: {selectedApplication.Study}");
                infoBuilder.AppendLine($"Points: {selectedApplication.Points}");



                if (educationType == "University")
                {
                    UApplication universityApplication = (UApplication)selectedApplication;
                    infoBuilder.AppendLine($"Average: {universityApplication.Average}");
                }

                infoBuilder.AppendLine($"Education Type: {educationType}");

                MessageBox.Show(infoBuilder.ToString());
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }
        private int IndexSelect()
        {
            int selectedIndex = -1;

            if (listBox1.SelectedIndex >= 0)
            {
                selectedIndex = listBox1.SelectedIndex;
            }
            else if (listBox2.SelectedIndex >= 0)
            {
                selectedIndex = listBox2.SelectedIndex + listBox1.Items.Count;
            }

            return selectedIndex;
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            Form CustomForm = new CustomMessageBox();
            CustomForm.ShowDialog();
        }
    }
}