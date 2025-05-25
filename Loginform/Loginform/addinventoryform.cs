using DocumentFormat.OpenXml.Bibliography;
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
    public partial class addinventoryform : Form
    {
        public addinventoryform()
        {
            InitializeComponent();
            this.Load += addinventoryform_Load;
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
        private void addinventoryform_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryselectionform staff= new inventoryselectionform();
            staff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Insert into inventory values(@invid,@staffid,@invname,@cata,@quant,@price,@date);";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@invid", SqlDbType.VarChar).Value = item.Text;
                    scmd.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffbox3.Text;
                    scmd.Parameters.Add("@invname", SqlDbType.VarChar).Value = itemname.Text;
                    scmd.Parameters.Add("@cata", SqlDbType.VarChar).Value = catagory.Text;
                    scmd.Parameters.Add("@quant", SqlDbType.Int).Value = quantity.Text;
                    scmd.Parameters.Add("@price", SqlDbType.Money).Value = price.Text;
                    scmd.Parameters.Add("@date", SqlDbType.Date).Value = expirydate.Text;
                    scmd.ExecuteNonQuery();
                }
            }
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("All data has been entered successfully");
                this.Hide();
                addinventoryform sm = new addinventoryform();
                sm.ShowDialog();
            }

        }
        }
}
