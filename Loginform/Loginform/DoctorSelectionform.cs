using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class DoctorSelectionform : Form
    {
        public DoctorSelectionform()
        {
            InitializeComponent();
            this.Load += DoctorSelectionform_Load;
            this.Resize += MainForm_Resize;
        }

        private void CenterContent()
        {
            // Calculate the center of the form
            int centerX = (this.ClientSize.Width - panel1.Width) / 2;
            int centerY = (this.ClientSize.Height - panel1.Height) / 2;

            // Set the location of the panel to the center
            panel1.Location = new System.Drawing.Point(centerX, centerY);
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterContent();
            EnableScrollBars();
        }
        private void EnableScrollBars()
        {
            if (panel1.Right > this.ClientSize.Width || panel1.Bottom > this.ClientSize.Height)
            {
                panel1.AutoScroll = true;
            }
            else
            {
                panel1.AutoScroll = false;
            }
        }

        private void DoctorSelectionform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selectionform staff= new Selectionform();
            staff.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctorform staff = new Doctorform();
            staff.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkappointmentform staff = new checkappointmentform();
            staff.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatespecilizationform staff = new updatespecilizationform();
            staff.ShowDialog();
        }

    }
}
