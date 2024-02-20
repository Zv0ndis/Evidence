using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography;
using System.Web;
using static System.Windows.Forms.LinkLabel;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence
{
    public partial class Form2 : Form
    {
        private bool editMode = false;
        private bool radioButtonAcceptedChoice;
        private string filePathHighSchool, filePathUniversity;
        private Application applicationActual;

        public Form2(string filePathHighSchool, string filePathUniversity, Application application)
        {
            InitializeComponent();
            this.filePathUniversity = filePathUniversity;
            this.filePathHighSchool = filePathHighSchool;
            applicationActual = application;
            if(applicationActual is UApplication)
            {
                fillParametersOfStudent((UApplication)applicationActual);
            }
            else
            {
                fillParametersOfStudent(applicationActual);
            }

            editMode = true;
            groupBox1.Enabled = false;

        }

        public Form2(string filePathHighSchool, string filePathUniversity)
        {
            InitializeComponent();
            this.filePathUniversity = filePathUniversity;
            this.filePathHighSchool = filePathHighSchool;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePickerDoB.Format = DateTimePickerFormat.Short;
            dateTimePickerDoB.CustomFormat = "dd/MM/yyyy";
            radioButtonSecondarySchool.Checked = true;
            UniqueCodeGenerator.LoadExistingCodes(filePathHighSchool, filePathUniversity);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void maskedTextBoxAverage_TextChanged(object sender, EventArgs e)
        {
            string text = maskedTextBoxAverage.Text;

            if (double.TryParse(text, out double average) && average <= 1.5)
            {
                radioButtonAccepted.Checked = true;
                radioButtonAcceptedChoice = true;
                groupBox2.Enabled = false;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editMode)
            {
                UpdateApplicationRecord(applicationActual);
            }
            else
            {
                AddNewApplicationRecord();
            }

        }

        private void radioButtonAccepted_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAccepted.Checked)
            {
                radioButtonAcceptedChoice = true;
            }
        }

        private void radioButtonDenied_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDenied.Checked)
            {
                radioButtonAcceptedChoice = false;
            }
        }

        private void radioButtonSecondarySchool_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxAverage.Visible = false;
            labelAverage.Visible = false;
        }

        private void radioButtonUniversity_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxAverage.Visible = true;
            labelAverage.Visible = true;
        }

        private void maskedTextBoxAverage_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddNewApplicationRecord()
        {
            string uniqueCode = UniqueCodeGenerator.GenerateUniqueCode();
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            DateTime dateOfBirth = dateTimePickerDoB.Value;
            string selectedStudy = comboBoxStudy.SelectedItem.ToString();
            bool acceptedChoice = radioButtonAcceptedChoice;
            double points;

            if (double.TryParse(maskedTextBoxPoints.Text, out double hodnota))
            {
                points = hodnota;

                if (radioButtonUniversity.Checked)
                {
                    double average = Convert.ToDouble(maskedTextBoxAverage.Text);

                    using (StreamWriter sw = new StreamWriter(filePathUniversity, true))
                    {
                        string dataLine = $"{uniqueCode},{name},{surname},{dateOfBirth},{selectedStudy},{points},{average},{acceptedChoice}";
                        sw.WriteLine(dataLine);
                    }
                }
                else if (radioButtonSecondarySchool.Checked)
                {
                    using (StreamWriter sw = new StreamWriter(filePathHighSchool, true))
                    {
                        string dataline = $"{uniqueCode},{name},{surname},{dateOfBirth},{selectedStudy},{points},{acceptedChoice}";
                        sw.WriteLine(dataline);
                    }
                }
            }
        }

        private void UpdateApplicationRecord(Application originalApplication)
        {
            originalApplication.Name = textBoxName.Text;
            originalApplication.Surname = textBoxSurname.Text;
            originalApplication.Dob = dateTimePickerDoB.Value;
            originalApplication.Study = comboBoxStudy.SelectedItem.ToString();
            originalApplication.Accepted = radioButtonAcceptedChoice;

            if (double.TryParse(maskedTextBoxPoints.Text, out double points))
            {
                originalApplication.Points = points;
            }

            string filePath = radioButtonUniversity.Checked ? filePathUniversity : filePathHighSchool;

            List<string> updatedLines = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1 && parts[0] == originalApplication.Id)
                    {
                        if (originalApplication is UApplication)
                        {
                            ((UApplication)originalApplication).Average = Convert.ToDouble(maskedTextBoxAverage.Text);
                            line = $"{originalApplication.Id},{originalApplication.Name},{originalApplication.Surname},{originalApplication.Dob},{originalApplication.Study},{originalApplication.Points},{((UApplication)originalApplication).Average},{originalApplication.Accepted}";
                        }
                        else
                        {
                            line = $"{originalApplication.Id},{originalApplication.Name},{originalApplication.Surname},{originalApplication.Dob},{originalApplication.Study},{originalApplication.Points},{originalApplication.Accepted}";
                        }
                    }
                    updatedLines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string updatedLine in updatedLines)
                {
                    writer.WriteLine(updatedLine);
                }
            }
        }

        private void fillParametersOfStudent(Application apps)
        {
            textBoxName.Text = apps.Name;
            textBoxSurname.Text = apps.Surname;
            dateTimePickerDoB.Value = apps.Dob.Date;
            comboBoxStudy.Text = apps.Study;


            if (apps is UApplication)
            {
                UApplication application = (UApplication)apps;
                radioButtonUniversity.Checked = true;
                maskedTextBoxAverage.Visible = true;
                maskedTextBoxPoints.Text = application.Points.ToString("000");
                maskedTextBoxAverage.Text = application.Average.ToString("0.0");
            }
            else
            {
                maskedTextBoxPoints.Text = apps.Points.ToString();
                radioButtonSecondarySchool.Checked = true;
            }

            if (apps.Accepted)
            {
                radioButtonAccepted.Checked = true;
            }
            else
            {
                radioButtonDenied.Checked = true;
            }
        }
    }

    public class UniqueCodeGenerator
    {
        private static HashSet<string> existingCodes = new HashSet<string>();

        public static void LoadExistingCodes(string filePathHighSchool, string filePathUniversity)
        {
            if (File.Exists(filePathHighSchool))
            {
                using (StreamReader sr = new StreamReader(filePathHighSchool))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 1)
                        {
                            string code = parts[0];
                            existingCodes.Add(code);
                        }
                    }
                }
            }

            if (File.Exists(filePathUniversity))
            {
                using (StreamReader sr = new StreamReader(filePathUniversity))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 1)
                        {
                            string code = parts[0];
                            existingCodes.Add(code);
                        }
                    }
                }
            }
        }

        public static string GenerateUniqueCode()
        {
            string code;
            do
            {
                code = GenerateCode();
            } while (existingCodes.Contains(code));

            existingCodes.Add(code);
            return code;
        }

        private static string GenerateCode()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[32];
                rng.GetBytes(buffer);
                return BitConverter.ToString(buffer).Replace("-", "");
            }
        }
    }
}
