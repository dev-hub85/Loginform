using System;
using System.Linq;
using Xceed.Words.NET;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Loginform
{
    public partial class paymentform : Form
    {
        [Obsolete]
        public paymentform()
        {
            InitializeComponent();
            this.Load += paymentform_Load;
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
        private void paymentform_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            billingselectionform staff = new billingselectionform();
            staff.ShowDialog();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
                {
                    con.Open();

                    string query3 = "Select Fname,Lname from patient where PatientID=@patid;";
                    using (SqlCommand scmd = new SqlCommand(query3, con))
                    {
                        scmd.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;
                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string Fn = reader["Fname"].ToString();
                                    string Ln = reader["Lname"].ToString();
                                    fnamebox.Text = Fn;
                                    Lastnamebox.Text = Ln;
                                }
                            }
                        }

                    }
                    string query4 = "SELECT SUM(Amount) As [Total Amount]  FROM Payments where PatientID = @patid AND Payment = 'Unpaid';";
                    using (SqlCommand scmd = new SqlCommand(query4, con))
                    {
                        scmd.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;
                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string am = reader["Total Amount"].ToString();
                                    textBox1.Text = am;
                                    if(am == null)
                                    {
                                        int number = 1;
                                        if (number == 1)
                                        {
                                            MessageBox.Show("There is no amount to pay for the Patient");
                                            this.Hide();
                                            paymentform sm = new paymentform();
                                                sm.ShowDialog();
                              
                                        }
                                    }
                                }
                            }
                        }

                    }
                    string query5 = "Select P.Amount,P.PatientID,pat.Fname ,pat.Lname, d.Specialization from Payments P , rec_doc_pat r, Doctor D, patient pat where P.PatientID=r.PatientID and P.PatientID = pat.PatientID and r.DoctorId = d.DoctorId and P.PatientID = @patid ;";
                    using (SqlCommand scmd = new SqlCommand(query5, con))
                    {
                        scmd.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;

                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string spec = reader["Specialization"].ToString();
                                    specializationbox.Text = spec;
                                }
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

        [Obsolete]
        private void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query2 = "Update Payments set Payment= 'Paid' where PatientID = @patid;";
                using (SqlCommand sc = new SqlCommand(query2, con))
                {
                    sc.Parameters.Add("@patid", SqlDbType.VarChar).Value = patientid.Text;
                    sc.ExecuteNonQuery();
                }
            }
            int number = 1;
            if (number == 1)
            {
                MessageBox.Show("Payment has been made successfully");
            }
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            string templateFilePath = "E:\\University Document\\Semester 4\\Database System\\Project\\Loginform\\Loginform\\Loginform\\bin\\Debug\\InvoiceData.docx"; // Replace with the path to your Word template file

            if (!string.IsNullOrEmpty(templateFilePath))
            {
                try
                {
                    using (var doc = DocX.Load(templateFilePath))
                    {
                        if (doc != null)
                        {
                            // Replace placeholders in the document with form data
                            ReplacePlaceholder(doc, "{patientid}", patientid.Text);
                            ReplacePlaceholder(doc, "{name}", $"{fnamebox.Text} {Lastnamebox.Text}");
                            ReplacePlaceholder(doc, "{purpose}", specializationbox.Text);
                            ReplacePlaceholder(doc, "{amount}", textBox1.Text);
                            string filesave = patientid.Text;

                            doc.SaveAs(filesave+".docx");

                            MessageBox.Show("Invoice has been generated successfully");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating Word document: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please provide the path to the Word template file.");
            }

        }
        [Obsolete]
        private void ReplacePlaceholder(DocX document, string placeholder, string replacement)
        {
            var paragraphs = document.Paragraphs.Where(p => p.Text.Contains(placeholder));

            foreach (var paragraph in paragraphs)
            {
                paragraph.ReplaceText(placeholder, replacement);
            }
        }
    }
}
