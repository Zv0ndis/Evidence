using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence
{
    public partial class CustomMessageBox : Form
    {
        List<Application> applicationList;
        public CustomMessageBox(List<Application> applications)
        {
            applicationList = applications;
            InitializeComponent();

        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            label1.Location = new Point(Math.Max((ClientSize.Width - label1.Width) / 2, 0), 10);

            pictureBox1.Location = new Point(10, 10 + label1.Height);
            pictureBox1.Size = new Size(ClientSize.Width / 2 - 10, ClientSize.Height - 20 - label1.Height);
            pictureBox1.Image = Image.FromFile("gympl.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;

            pictureBox2.Location = new Point(ClientSize.Width / 2 + 10, 10 + label1.Height);
            pictureBox2.Size = new Size(ClientSize.Width / 2 - 20, ClientSize.Height - 20 - label1.Height);
            pictureBox2.Image = Image.FromFile("vejska.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (applicationList.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Application application in applicationList)
                {
                    if (application is HSApplication && application.Accepted) stringBuilder.AppendLine($"{application.Name} {application.Surname} - {application.Study}");
                }

                MessageBox.Show(stringBuilder.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (applicationList.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Application application in applicationList)
                {
                    if (application is UApplication && application.Accepted) stringBuilder.AppendLine($"{application.Name} {application.Surname} - {application.Study}");
                }

                MessageBox.Show(stringBuilder.ToString());
            }
        }
    }
}