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
using System.Windows.Forms.Design;

namespace Loginform
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            this.Load += Loginform_Load;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Registerationform reg = new Registerationform();
                reg.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;";

            string query = "SELECT COUNT(*) FROM Clinicuser WHERE username = @username AND passcode = @passcode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the SqlCommand
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@passcode", SqlDbType.VarChar).Value = textBox2.Text;

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    int count = (int)command.ExecuteScalar();

                    // Check if login credentials are valid
                    if (count == 1)
                    {
                        this.Hide();
                        Selectionform selection = new Selectionform();
                        selection.ShowDialog();
                    }
                    else
                    {
                        ShowMessage("Invalid login credentials.");
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage("Error: " + ex.Message);
                }
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
