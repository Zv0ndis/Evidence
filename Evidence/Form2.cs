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

namespace Evidence
{
    public partial class Form2 : Form
    {
        private string filePathHighSchool, filePathUniversity;
        List<Application> applications;
        public Form2(string filePathHighSchool, string filePathUniversity, List<Application> applications)
        {
            InitializeComponent();
            this.applications = applications;
            this.filePathUniversity = filePathUniversity;
            this.filePathHighSchool = filePathHighSchool;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            radioButtonSecondarySchool.Checked = true;
            UniqueCodeGenerator.LoadExistingCodes(filePathHighSchool, filePathUniversity);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        Application actualApplication;
        private bool radioButtonAcceptedChoice;

        private void maskedTextBoxAverage_TextChanged(object sender, EventArgs e)
        {
            string text = maskedTextBoxAverage.Text;

            if (double.TryParse(text, out double average) && average <= 1.5)
            {
                radioButtonAccepted.Checked = true;
                radioButtonDenied.Checked = false;
                radioButtonAccepted.Enabled = false;
                radioButtonDenied.Enabled = false;
            }
            else
            {
                radioButtonAccepted.Checked = false;
                radioButtonDenied.Checked = false;
                radioButtonAccepted.Enabled = true;
                radioButtonDenied.Enabled = true;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            string uniqueCode = UniqueCodeGenerator.GenerateUniqueCode();
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            DateTime dateOfBirth = dateTimePickerDoB.Value;
            string selectedStudy = comboBoxStudy.SelectedText;
            bool acceptedChoice = radioButtonAcceptedChoice;
            double points;

            if (double.TryParse(maskedTextBoxPoints.Text, out double hodnota))
            {
                points = hodnota;

                if (radioButtonUniversity.Checked)
                {
                    double average = Convert.ToDouble(maskedTextBoxAverage.Text);

                    using (StreamWriter sw = new StreamWriter(filePathUniversity, append: true))
                    {
                        string dataLine = $"{uniqueCode},{name},{surname},{dateOfBirth},{selectedStudy},{points},{average},{acceptedChoice}";
                        sw.WriteLine(dataLine);
                    }
                }
                else if (radioButtonSecondarySchool.Checked)
                {
                    using (StreamWriter sw = new StreamWriter(filePathHighSchool))
                    {
                        string dataline = $"{uniqueCode},{name},{surname},{dateOfBirth},{selectedStudy},{points},{acceptedChoice}";
                        sw.WriteLine(dataline);
                    }
                }
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
