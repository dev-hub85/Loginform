using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class patientrecordupdateform : Form
    {
        public patientrecordupdateform()
        {
            InitializeComponent();
            this.Load += patientrecordupdateform_Load;
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

        private void patientrecordupdateform_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistSelectionform staff = new ReceptionistSelectionform();
            staff.ShowDialog();
        }

        private void patientid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to select all data from the patient table
                string query = "SELECT * FROM patient WHERE PatientID = @patid";

                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access columns using their names or indexes
                            string patientID = reader["PatientID"].ToString();
                            string fname = reader["Fname"].ToString();
                            string lname = reader["Lname"].ToString();
                            string dob = reader["DOB"].ToString();
                            string gender = reader["Gender"].ToString();
                            string cellno = reader["Cellno"].ToString();
                            fnamebox.Text = fname;
                            Lastnamebox.Text = lname;
                            datepatient.Text = dob;
                            genderbox.Text = gender;
                            Cellnobox.Text = cellno;


                            Console.WriteLine($"PatientID: {patientID}, Fname: {fname}, Lname: {lname}, DOB: {dob}, Gender: {gender}, Cellno: {cellno}");
                        }
                    }
                }
            }

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to select all data from the patient table
                string query = "UPDATE patient SET Fname = @fname,Lname = @lname,DOB = @date,Gender = @gen,Cellno = @cell where PatientID = @patid ;";

                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;
                    command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fnamebox.Text;
                    command.Parameters.Add("@lname", SqlDbType.VarChar).Value = Lastnamebox.Text;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = datepatient.Text;
                    command.Parameters.Add("@gen", SqlDbType.VarChar).Value = genderbox.Text;
                    command.Parameters.Add("@cell", SqlDbType.VarChar).Value = Cellnobox.Text;
                    command.ExecuteNonQuery();

                }
                }
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("All data has been Updated successfully");
                this.Hide();
                patientrecordupdateform sm = new patientrecordupdateform();
                sm.ShowDialog();
            }
        }
        }
    }
