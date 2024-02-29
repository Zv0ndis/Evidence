using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence
{

    public enum MessageBoxButtons
    {
        HighSchool, University, Cancel
    }

    public partial class MainForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zvond\\OneDrive\\Dokumenty\\Applience.mdf;Integrated Security=True;Connect Timeout=30";

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

        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            listBox2.SelectedItems.Clear();
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void synchronizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        List<string> allApplicationIds = new List<string>();
        foreach (Application selectedApplication in applications)
        {
            allApplicationIds.Add(selectedApplication.Id);
        }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Convert the list of IDs to a comma-separated string
                    string idsString = string.Join(",", allApplicationIds.Select(id => "'" + id + "'"));

                    // Delete applications that are not in the list from HighSchool and University tables
                    string deleteQuery = $@"DELETE FROM [dbo].[HighSchool] WHERE Id NOT IN ({idsString})";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction);
                    deleteCommand.ExecuteNonQuery();

                    deleteQuery = $@"DELETE FROM[dbo].[University] WHERE Id NOT IN({idsString})";
                    deleteCommand = new SqlCommand(deleteQuery, connection, transaction);


                    foreach (var application in applications)
                    {
                        // Check if the application exists in HighSchool table
                        string selectHighSchoolQuery = "SELECT COUNT(*) FROM [dbo].[HighSchool] WHERE Id = @Id";
                        SqlCommand selectHighSchoolCommand = new SqlCommand(selectHighSchoolQuery, connection, transaction);
                        selectHighSchoolCommand.Parameters.AddWithValue("@Id", application.Id);
                        int highSchoolCount = (int)selectHighSchoolCommand.ExecuteScalar();

                        // Check if the application exists in University table
                        string selectUniversityQuery = "SELECT COUNT(*) FROM [dbo].[University] WHERE Id = @Id";
                        SqlCommand selectUniversityCommand = new SqlCommand(selectUniversityQuery, connection, transaction);
                        selectUniversityCommand.Parameters.AddWithValue("@Id", application.Id);
                        int universityCount = (int)selectUniversityCommand.ExecuteScalar();

                        if (highSchoolCount > 0)
                        {
                            // If the application exists in HighSchool, update it
                            string updateQuery = "UPDATE [dbo].[HighSchool] SET /* columns = values */ WHERE Id = @Id";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                            updateCommand.Parameters.AddWithValue("@Id", application.Id);
                            updateCommand.Parameters.AddWithValue("@Name", application.Name);
                            updateCommand.Parameters.AddWithValue("@Surname", application.Surname);
                            updateCommand.Parameters.AddWithValue("@Dob", application.Dob);
                            updateCommand.Parameters.AddWithValue("@Study", application.Study);
                            updateCommand.Parameters.AddWithValue("@Points", application.Points);
                            updateCommand.Parameters.AddWithValue("@Accepted", application.Accepted);
                            updateCommand.ExecuteNonQuery();
                        }
                        else if (application is HSApplication)
                        {
                            string insertHighSchoolQuery = "INSERT INTO [dbo].[HighSchool] ([Id], [Name], [Surname], [Dob], [Study], [Points], [Accepted]) " +
                                                           "VALUES (@Id, @Name, @Surname, @Dob, @Study, @Points, @Accepted)";
                            SqlCommand insertHighSchoolCommand = new SqlCommand(insertHighSchoolQuery, connection, transaction);
                            insertHighSchoolCommand.Parameters.AddWithValue("@Id", application.Id);
                            insertHighSchoolCommand.Parameters.AddWithValue("@Name", application.Name);
                            insertHighSchoolCommand.Parameters.AddWithValue("@Surname", application.Surname);
                            insertHighSchoolCommand.Parameters.AddWithValue("@Dob", application.Dob);
                            insertHighSchoolCommand.Parameters.AddWithValue("@Study", application.Study); // Assuming this is the correct property
                            insertHighSchoolCommand.Parameters.AddWithValue("@Points", application.Points); // Assuming this is the correct property
                            insertHighSchoolCommand.Parameters.AddWithValue("@Accepted", application.Accepted); // Assuming this is the correct property
                            insertHighSchoolCommand.ExecuteNonQuery();
                        }

                        if (universityCount > 0)
                        {
                            string updateQuery = "UPDATE [dbo].[University] SET [Name] = @Name, [Surname] = @Surname, [Dob] = @Dob, [Study] = @Study, [Points] = @Points, [Average] = @Average, [Accepted] = @Accepted WHERE [Id] = @Id";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                            updateCommand.Parameters.AddWithValue("@Id", application.Id);
                            updateCommand.Parameters.AddWithValue("@Name", application.Name);
                            updateCommand.Parameters.AddWithValue("@Surname", application.Surname);
                            updateCommand.Parameters.AddWithValue("@Dob", application.Dob);
                            updateCommand.Parameters.AddWithValue("@Study", application.Study); // Assuming this is the correct property
                            updateCommand.Parameters.AddWithValue("@Points", application.Points); // Assuming this is the correct property
                            updateCommand.Parameters.AddWithValue("@Average", ((UApplication)application).Average); // Assuming this is the correct property
                            updateCommand.Parameters.AddWithValue("@Accepted", application.Accepted); // Assuming this is the correct property
                            updateCommand.ExecuteNonQuery();
                        }
                        else if (application is UApplication)
                        {
                            string insertUniversityQuery = "INSERT INTO [dbo].[University] ([Id], [Name], [Surname], [Dob], [Study], [Points], [Average], [Accepted]) " +
                                                           "VALUES (@Id, @Name, @Surname, @Dob, @Study, @Points, @Average, @Accepted)";
                            SqlCommand insertUniversityCommand = new SqlCommand(insertUniversityQuery, connection, transaction);
                            insertUniversityCommand.Parameters.AddWithValue("@Id", application.Id);
                            insertUniversityCommand.Parameters.AddWithValue("@Name", application.Name);
                            insertUniversityCommand.Parameters.AddWithValue("@Surname", application.Surname);
                            insertUniversityCommand.Parameters.AddWithValue("@Dob", application.Dob);
                            insertUniversityCommand.Parameters.AddWithValue("@Study", application.Study); // Assuming this is the correct property
                            insertUniversityCommand.Parameters.AddWithValue("@Points", application.Points); // Assuming this is the correct property
                            insertUniversityCommand.Parameters.AddWithValue("@Average", ((UApplication)application).Average); // Assuming this is the correct property
                            insertUniversityCommand.Parameters.AddWithValue("@Accepted", application.Accepted); // Assuming this is the correct property
                            insertUniversityCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();

                    }
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an exception occurs
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message + ex.Source);
                }
            }

        }

        private void lookUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                foreach (Application selectedApplication in applications)
                {
                    if (textBox1.Text == selectedApplication.Id)
                    {

                        string educationType = applications.IndexOf(selectedApplication) >= listBox1.Items.Count ? "University" : "High School";

                        StringBuilder infoBuilder = new StringBuilder();
                        infoBuilder.AppendLine($"Information about student:");
                        infoBuilder.AppendLine($"ID: {selectedApplication.Id}");
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

                }

            }
        }

        private void showAcceptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CustomForm = new CustomMessageBox(applications);
            CustomForm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = IndexSelect();
            switch (sender as ToolStripMenuItem)
            {
                case var menuItem when menuItem == showToolStripMenuItem:
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
                        infoBuilder.AppendLine($"Education Type: {educationType}");

                        MessageBox.Show(infoBuilder.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please select a student.");
                    }
                    break;

                case var menuItem when menuItem == showToolStripMenuItem1:
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

                        if (selectedApplication is UApplication universityApplication)
                        {
                            infoBuilder.AppendLine($"Average: {universityApplication.Average}");
                        }

                        infoBuilder.AppendLine($"Education Type: {educationType}");

                        MessageBox.Show(infoBuilder.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please select a student.");
                    }
                    break;
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vytvoříme novou instanci Form2
            Form2 form2 = new Form2(filePathHighSchool, filePathUniversity);

            // Zobrazíme Form2
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadFilesToolStripMenuItem_Click(object sender, EventArgs e)
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
                        // Parse parts correctly and assign to variables
                        string uniqueCode = parts[0];
                        string name = parts[1];
                        string surname = parts[2];
                        DateTime dateOfBirth = DateTime.Parse(parts[3]);
                        string selectedStudy = parts[4];
                        double points = Convert.ToDouble(parts[5]);
                        double average = Convert.ToDouble(parts[6]);
                        bool acceptedChoice = Convert.ToBoolean(parts[7]);

                        // Create UApplication object with correct parameters
                        UApplication actual = new UApplication(uniqueCode, name, surname, dateOfBirth, selectedStudy, points, average, acceptedChoice);
                        applications.Add(actual);

                        // Add item to ListBox
                        listBox2.Items.Add($"{name} {surname} - {selectedStudy}");
                    }
                }
            }
        }
    }

}