using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Doctorform : Form
    {
        
        public Doctorform()
        {
            InitializeComponent();
            this.Load += Doctorform_Load;
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
        private void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query2 = "Insert into Doctor values(@staffid,@spec)";
                using (SqlCommand sc = new SqlCommand(query2, con))
                {
                    sc.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    sc.Parameters.Add("@spec", SqlDbType.VarChar).Value = specializationbox3.Text;
                    sc.ExecuteNonQuery();
                }
            }
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("All data has been entered successfully");
                this.Hide();
                Doctorform sm = new Doctorform();
                sm.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctorform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorSelectionform staff = new DoctorSelectionform();
            staff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
                {
                    con.Open();

                    string query3 = "Select c.CNIC,c.Firstname,c.Lastname,c.position,c.Cellno,c.Gender,d.dname,d.droomno from ClinicStaffmembers c, Clinicdepartment d where c.position='Doctor' and c.staffId=@staffid and d.departmentno=@staffid;";
                    using (SqlCommand scmd = new SqlCommand(query3, con))
                    {
                        scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string cn = reader["CNIC"].ToString();
                                    string Fn = reader["Firstname"].ToString();
                                    string Ln = reader["Lastname"].ToString();
                                    string Pos = reader["position"].ToString();
                                    string cell = reader["Cellno"].ToString();
                                    string gen = reader["Gender"].ToString();
                                    string dn = reader["dname"].ToString();
                                    string dr = reader["droomno"].ToString();
                                    staffno.Text = cn;
                                    fnamebox.Text = Fn;
                                    Lastname.Text = Ln;
                                    positionstaff.Text = Pos;                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffidbox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
