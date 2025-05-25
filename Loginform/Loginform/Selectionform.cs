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
    public partial class Selectionform : Form
    {
        public Selectionform()
        {
            InitializeComponent();
            this.Load += Selectionform_Load;
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
                // Display the vertical and/or horizontal scroll bars
                panel1.AutoScroll = true;
            }
            else
            {
                // Hide the scroll bars if the content is fully visible
                panel1.AutoScroll = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void Selectionform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selectionoptionstaffform staff = new Selectionoptionstaffform();
            staff.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            DoctorSelectionform staff = new DoctorSelectionform();
            staff.ShowDialog();
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            ReceptionistSelectionform staff = new ReceptionistSelectionform();
            staff.ShowDialog();
        }

        [Obsolete]
        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            billingselectionform staff = new billingselectionform();
            staff.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            inventoryselectionform staff = new inventoryselectionform();
            staff.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Loginform staff = new Loginform();
            staff.ShowDialog();

        }
    }
}
