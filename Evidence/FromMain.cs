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

    public partial class FormsMain : Form
    {
        public FormsMain()
        {
            InitializeComponent();
        }
        string fileContent = string.Empty;
        string filePath = string.Empty;

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
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
                Form2 form2 = new Form2(filePath);

                // Zobrazíme Form2
                form2.Show();

                // Skryjeme Form1
                this.Hide();


        }
    }
}
