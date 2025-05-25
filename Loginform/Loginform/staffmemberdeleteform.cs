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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Loginform
{
    public partial class staffmemberdeleteform : Form
    {
        public staffmemberdeleteform()
        {
            InitializeComponent();
            this.Load += staffmemberdeleteform_Load;
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
        private void staffmemberdeleteform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selectionoptionstaffform so = new Selectionoptionstaffform();
            so.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep any textbox empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Select Street, City, Postcode from branchstaff3 where branchno3 = @staffid";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string str = reader["Street"].ToString();
                                string Cit = reader["City"].ToString();
                                string pcode = reader["Postcode"].ToString();
                                street.Text = str;
                                city.Text = Cit;
                                postcode.Text = pcode;
                            }
                        }
                    }
                }


                string query2 = "Select dname,droomno from Clinicdepartment where departmentno = @staffid";
                using (SqlCommand scmd = new SqlCommand(query2, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string depname = reader["dname"].ToString();
                                string deproom = reader["droomno"].ToString();
                                departmentbox.Text = depname;
                                roomno.Text = deproom;
                            }
                        }
                    }
                }

                string query3 = "Select  CNIC,Firstname,Lastname,Gender,position,Daeofbirth,Salary,Email,Cellno FROM ClinicStaffmembers where staffId = @staffid";
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
                                string g = reader["Gender"].ToString();
                                string Pos = reader["position"].ToString();
                                string Dat = reader["Daeofbirth"].ToString();
                                string Sal = reader["Salary"].ToString();
                                string Em = reader["Email"].ToString();
                                string Cell = reader["Cellno"].ToString();
                                staffno.Text = cn;
                                fnamebox.Text = Fn;
                                Lastname.Text = Ln;
                                genderbox.Text = g;
                                positionstaff.Text = Pos;
                                datebox.Text = Dat;
                                moneystaff.Text = Sal;
                                email.Text = Em;
                                Cellno.Text = Cell;
                            }
                        }
                    }

                }
            }
        }

        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(staffidbox3.Text)
                )
                return false;
            else
            {
                return true;
            }
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "delete from ClinicStaffmembers where staffId = @staffid";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.ExecuteNonQuery();
                }

                string query2 = "delete from Clinicdepartment where departmentno = @staffid";
                using (SqlCommand scmd = new SqlCommand(query2, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.ExecuteNonQuery();
                }

                string query3 = "delete from branchstaff3 where branchno3 = @staffid";
                using (SqlCommand scmd = new SqlCommand(query3, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.ExecuteNonQuery();
                }

                int number = 1;
                if (number == 1)
                {
                    MessageBox.Show("All data has been deleted successfully");

                    this.Hide();
                    staffmemberdeleteform sm = new staffmemberdeleteform();
                    sm.ShowDialog();
                }
            }
        }
    }
}
