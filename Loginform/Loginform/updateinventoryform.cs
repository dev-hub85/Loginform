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
    public partial class updateinventoryform : Form
    {
        public updateinventoryform()
        {
            InitializeComponent();
            this.Load += updateinventoryform_Load;
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

        private void updateinventoryform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            inventoryselectionform staff = new inventoryselectionform();
            staff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Select itemname,catagory,Quantity,Price,Expirydate from inventory where itemid = @itemid;";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@itemid", SqlDbType.VarChar).Value = item.Text;
                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader["itemname"].ToString();
                                string cat = reader["catagory"].ToString();
                                string qu = reader["Quantity"].ToString();
                                string pr = reader["Price"].ToString();
                                string date = reader["Expirydate"].ToString();
                                itemname.Text = name;
                                catagory.Text = cat;
                                quantity.Text = qu;
                                price.Text = pr;
                                expirydate.Text = date;
                            }
                        }
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query1 = "Update inventory set itemname = @name,catagory=@cat,Quantity=@quant,Price=@price,Expirydate=@date where itemid = @itemid;";
                using (SqlCommand scmd = new SqlCommand(query1, con))
                {
                    scmd.Parameters.Add("@itemid", SqlDbType.VarChar).Value = item.Text;
                    scmd.Parameters.Add("@name", SqlDbType.VarChar).Value = itemname.Text;
                    scmd.Parameters.Add("@cat", SqlDbType.VarChar).Value = catagory.Text;
                    scmd.Parameters.Add("@quant", SqlDbType.Int).Value = quantity.Text;
                    scmd.Parameters.Add("@price", SqlDbType.Money).Value = price.Text;
                    scmd.Parameters.Add("@date", SqlDbType.Date).Value = expirydate.Text;
                    scmd.ExecuteNonQuery();
                }
            }
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("All data has been updated successfully");

                this.Hide();
                updateinventoryform sm = new updateinventoryform();
                sm.ShowDialog();
            }
        }
    }
}
