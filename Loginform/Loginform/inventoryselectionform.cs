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
    public partial class inventoryselectionform : Form
    {
        public inventoryselectionform()
        {
            InitializeComponent();
            this.Load += inventoryselectionform_Load;
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
        private void inventoryselectionform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selectionform staff = new Selectionform();
            staff.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addinventoryform staff = new addinventoryform();
            staff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removeitemform staff = new removeitemform();
            staff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateinventoryform staff = new updateinventoryform();
            staff.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkinventoryform staff = new checkinventoryform();
            staff.ShowDialog();

        }
    }
}
