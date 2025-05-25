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
    public partial class staffmemberupdateform : Form
    {
        public staffmemberupdateform()
        {
            InitializeComponent();
            this.Load += staffmemberupdateform_Load;
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

        private void staffmemberupdateform_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selectionoptionstaffform so = new Selectionoptionstaffform();
            so.ShowDialog();
        }

        private void Insert_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                                departmentname.Text = depname;
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
                                genderbox3.Text = g;
                                positionstaff.Text = Pos;
                                datestaff.Text = Dat;
                                moneystaff.Text = Sal;
                                email.Text = Em;
                                Cellno.Text = Cell;
                            }
                        }
                    }

                }
            }
        }





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Selectionoptionstaffform so = new Selectionoptionstaffform();
            so.ShowDialog();
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            if (!Authenticate1())
            {
                MessageBox.Show("Do not keep any textbox empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Update branchstaff3 set Street = @street , City = @city , Postcode = @postcode where branchno3 = @staffid";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.Parameters.Add("@street", SqlDbType.VarChar).Value = street.Text;
                    scmd.Parameters.Add("@city", SqlDbType.VarChar).Value = city.Text;
                    scmd.Parameters.Add("@postcode", SqlDbType.VarChar).Value = postcode.Text;
                    scmd.ExecuteNonQuery();
                }

                string query2 = "Update Clinicdepartment set dname = @dname , droomno = @droomno where departmentno = @staffid";
                using (SqlCommand scmd = new SqlCommand(query2, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.Parameters.Add("@dname", SqlDbType.VarChar).Value = departmentname.Text;
                    scmd.Parameters.Add("@droomno", SqlDbType.VarChar).Value = roomno.Text;

                    scmd.ExecuteNonQuery();
                }

                string query3 = "update ClinicStaffmembers set CNIC = @cnic ,Firstname = @fname ,Lastname = @lname, Gender = @gender,position = @position, Daeofbirth  = @date, Salary = @salary, Email = @email, Cellno = @cellno where staffId = @staffid";
                using (SqlCommand scmd = new SqlCommand(query3, con))
                {
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                    scmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = staffno.Text;
                    scmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fnamebox.Text;
                    scmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = Lastname.Text;
                    scmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = genderbox3.Text;
                    scmd.Parameters.Add("@position", SqlDbType.VarChar).Value = positionstaff.Text;
                    scmd.Parameters.Add("@date", SqlDbType.Date).Value = datestaff.Text;
                    scmd.Parameters.Add("@salary", SqlDbType.Money).Value = moneystaff.Text;
                    scmd.Parameters.Add("@cellno", SqlDbType.VarChar).Value = Cellno.Text;
                    scmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email.Text;

                    scmd.ExecuteNonQuery();
                }
                int number = 1;
                if (number == 1)
                {
                    MessageBox.Show("All data has been updated successfully");

                    this.Hide();
                    staffmemberupdateform sm = new staffmemberupdateform();
                    sm.ShowDialog();
                }
            }
        }

        bool Authenticate1()
        {
            if (string.IsNullOrWhiteSpace(staffno.Text) ||
                string.IsNullOrWhiteSpace(fnamebox.Text) ||
                    string.IsNullOrWhiteSpace(Lastname.Text) ||
                string.IsNullOrWhiteSpace(genderbox3.Text) ||
                string.IsNullOrWhiteSpace(datestaff.Text) ||
                string.IsNullOrWhiteSpace(moneystaff.Text) ||
                string.IsNullOrWhiteSpace(positionstaff.Text) ||
                string.IsNullOrWhiteSpace(Cellno.Text) ||
                string.IsNullOrWhiteSpace(street.Text) ||
                string.IsNullOrWhiteSpace(city.Text) ||
                string.IsNullOrWhiteSpace(postcode.Text) ||
                string.IsNullOrWhiteSpace(staffidbox3.Text) ||
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
