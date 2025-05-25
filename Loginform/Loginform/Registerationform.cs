using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Registerationform : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;");
        static SqlCommand scmd;
        public Registerationform()
        {
            InitializeComponent();
            this.Load += Registerationform_Load;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registerationform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string query = "Insert into Clinicuser values(@user,@pass,@name,@gender,@date)";
            con.Open();
            scmd = new SqlCommand(query, con);

            scmd.Parameters.Add("@user",SqlDbType.VarChar);
            scmd.Parameters["@user"].Value = Username.Text;

            scmd.Parameters.Add("@pass", SqlDbType.VarChar);
            scmd.Parameters["@pass"].Value = Password.Text;

            scmd.Parameters.Add("@name", SqlDbType.VarChar);
            scmd.Parameters["@name"].Value = Fullnamebox.Text;

            scmd.Parameters.Add("@gender", SqlDbType.VarChar);
            scmd.Parameters["@gender"].Value = Gendercbox.Text;

            scmd.Parameters.Add("@date", SqlDbType.Date);
            scmd.Parameters["@date"].Value = date.Text;

            scmd.ExecuteNonQuery();
            con.Close();
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("User has been successfully Registered");
                this.Hide();
                Registerationform sm = new Registerationform();
                sm.ShowDialog();
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform login = new Loginform();
            login.ShowDialog();
        }
    }
}
