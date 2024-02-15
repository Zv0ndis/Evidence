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
    public partial class MainForm : Form
    {
        List<Application> applications = new List<Application>();
        string filePathHighSchool = "prihlasky_stredni.txt";
        string filePathUniversity = "prihlasky_vyssi.txt";

        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists(filePathHighSchool))  using (StreamWriter sw1 = File.CreateText(filePathHighSchool)) { }

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

            using(StreamReader sr = new StreamReader(filePathHighSchool))
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
                        new UApplication(parts[0], parts[1], parts[2], DateTime.Parse(parts[3]), parts[4], Convert.ToDouble(parts[5]),Convert.ToDouble(parts[6]), Convert.ToBoolean(parts[7])));
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
            Form2 form2 = new Form2(filePathHighSchool, filePathUniversity, applications);

            // Zobrazíme Form2
            this.Hide();
            form2.ShowDialog();
            this.Show();
            // Skryjeme Form1


        }
    }
}
