using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Loginform
{
    public partial class StaffMemberform : Form
    {
        public StaffMemberform()
        {
            InitializeComponent();
            this.Load += StaffMemberform_Load;
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
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffMemberform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void Uploadfile_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void postcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Selectionoptionstaffform slec = new Selectionoptionstaffform();
            slec.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep any textbox empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Insert into branchstaff3 values(@staffid,@street,@city,@postcode)";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox.Text;
                    scmd.Parameters.Add("@street", SqlDbType.VarChar).Value = street.Text;
                    scmd.Parameters.Add("@city", SqlDbType.VarChar).Value = city.Text;
                    scmd.Parameters.Add("@postcode", SqlDbType.VarChar).Value = postcode.Text;
                    scmd.ExecuteNonQuery();
                }

                string query2 = "Insert into Clinicdepartment values(@staffid,@dname,@droomno)";
                using (SqlCommand scmd = new SqlCommand(query2, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox.Text;
                    scmd.Parameters.Add("@dname", SqlDbType.VarChar).Value = departmentname.Text;
                    scmd.Parameters.Add("@droomno", SqlDbType.VarChar).Value = roomno.Text;

                    scmd.ExecuteNonQuery();
                }

                string query3 = "Insert into ClinicStaffmembers values(@staffid,@cnic,@fname,@lname,@gender,@position,@date,@salary,@email,@cellno,@branch,@department)";
                using (SqlCommand scmd = new SqlCommand(query3, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox.Text;
                    scmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = staffno.Text;
                    scmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fnamebox.Text;
                    scmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = Lastname.Text;
                    scmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = genderbox.Text;
                    scmd.Parameters.Add("@position", SqlDbType.VarChar).Value = positionstaff.Text;
                    scmd.Parameters.Add("@date", SqlDbType.Date).Value = datestaff.Text;
                    scmd.Parameters.Add("@salary", SqlDbType.Money).Value = moneystaff.Text;
                    scmd.Parameters.Add("@cellno", SqlDbType.VarChar).Value = Cellno.Text;
                    scmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email.Text;
                    scmd.Parameters.Add("@branch", SqlDbType.VarChar).Value = staffidbox.Text;
                    scmd.Parameters.Add("@department", SqlDbType.VarChar).Value = staffidbox.Text;

                    scmd.ExecuteNonQuery();
                }
                int number = 1;
                if (number == 1)
                {
                    MessageBox.Show("All data has been entered successfully");

                    this.Hide();
                    StaffMemberform sm = new StaffMemberform();
                    sm.ShowDialog();
                }
            }
        }

        bool Authenticate() 
        {
            if (string.IsNullOrWhiteSpace(staffno.Text) ||
                string.IsNullOrWhiteSpace(fnamebox.Text) ||
                    string.IsNullOrWhiteSpace(Lastname.Text) ||
                string.IsNullOrWhiteSpace(genderbox.Text) ||
                string.IsNullOrWhiteSpace(datestaff.Text) ||
                string.IsNullOrWhiteSpace(moneystaff.Text) ||
                string.IsNullOrWhiteSpace(positionstaff.Text) ||
                string.IsNullOrWhiteSpace(Cellno.Text) ||
                string.IsNullOrWhiteSpace(street.Text) ||
                string.IsNullOrWhiteSpace(city.Text) ||
                string.IsNullOrWhiteSpace(postcode.Text) ||
                string.IsNullOrWhiteSpace(staffidbox.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(departmentname.Text) ||
                string.IsNullOrWhiteSpace(roomno.Text)
                )
                return false;
            else
            {
                return true;
            }
        }
    }
}
