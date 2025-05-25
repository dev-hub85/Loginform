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

namespace Loginform
{
    public partial class Receptionistinsertform : Form
    {
        [Obsolete]
        int bill = 0;
        public Receptionistinsertform()
        {
            InitializeComponent();
            this.Load += Receptionistinsertform_Load;
            this.Resize += MainForm_Resize;
        }
        private void InitializeComponents()
        {
            // ... (existing initialization code)

            // Attach event handler for doctorbox's SelectedIndexChanged event
            doctorbox.SelectedIndexChanged += doctorbox_SelectedIndexChanged;
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

        private void Receptionistinsertform_Load(object sender, EventArgs e)
        {
            specializationGroupBox.Controls.Add(radioButton1);
            specializationGroupBox.Controls.Add(radioButton2);
            specializationGroupBox.Controls.Add(radioButton3);
            specializationGroupBox.Controls.Add(radioButton4);
            specializationGroupBox.Controls.Add(radioButton5);
            specializationGroupBox.Controls.Add(radioButton6);
            specializationGroupBox.Controls.Add(radioButton7);

            int xPos = 20;
            int yPos = 20;

            foreach (System.Windows.Forms.RadioButton radioButton in specializationGroupBox.Controls)
            {
                radioButton.AutoSize = true;
                radioButton.Location = new System.Drawing.Point(xPos, yPos);

                yPos += radioButton.Height + 5; // Adjust the vertical spacing

                // Move to the next column after every 3 radio buttons
                if (yPos > 2 * radioButton1.Height + 20)
                {
                    xPos += radioButton.Width + 50; // Adjust the horizontal spacing
                    yPos = 20;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistSelectionform staff = new ReceptionistSelectionform();
            staff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedSpecialization = GetSelectedSpecialization();
           

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query3 = "Select doc.staffId, doc.Firstname, doc.Lastname,dep.droomno FROM ClinicStaffmembers doc, Doctor d,  Clinicdepartment dep where doc.staffId=d.DoctorID and d.DoctorId = dep.departmentno and d.Specialization = @SelectedSpecialization;";
                using (SqlCommand scmd = new SqlCommand(query3, con))
                {
                    scmd.Parameters.AddWithValue("@SelectedSpecialization", selectedSpecialization);
                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        doctorbox.Text = "";
                        doctorbox.Items.Clear();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string doctorId = reader["staffId"].ToString();
                                string firstname = reader["Firstname"].ToString();
                                string lastname = reader["Lastname"].ToString();
                                string roomno = reader["droomno"].ToString();

                                string doctorName = $"{doctorId} {firstname} {lastname}";
                                doctorbox.Items.Add(doctorName);
                            }
                            if (doctorbox.Items.Count > 0)
                            {
                                doctorbox.Text = doctorbox.Items[0].ToString();
                            }
                        }
                    }

                }


            }
        }
        private string GetSelectedSpecialization()
        {
            foreach (System.Windows.Forms.Control control in specializationGroupBox.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return "None"; // Return "None" if no specialization is selected
        }

        private void specializationGroupBox_Enter(object sender, EventArgs e)
        {

        }


        private void doctorbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputString = doctorbox.Text; // Replace this with your actual string
            string[] parts = inputString.Split(' ');

            if (parts.Length >= 1)
            {
                string doctorId = parts[0];

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
                {
                    con.Open();

                    // Modified query with @doc parameter
                    string query1 = "SELECT doc.staffId, doc.Firstname, doc.Lastname, dep.droomno " +
                                    "FROM ClinicStaffmembers doc, Doctor d, Clinicdepartment dep " +
                                    "WHERE doc.staffId = d.DoctorID AND d.DoctorId = dep.departmentno AND doc.staffId = @doc;";

                    using (SqlCommand scmd = new SqlCommand(query1, con))
                    {
                        // Set the @doc parameter value
                        scmd.Parameters.AddWithValue("@doc", doctorId);

                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string room = reader["droomno"].ToString();
                                    textBox1.Text = room;
                                }
                            }
                            else
                            {
                                textBox1.Text = "Doctor not found";
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input string format");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query3 = "SELECT staffId, Firstname, Lastname FROM ClinicStaffmembers WHERE staffId = @rec and position = 'Receptionist';";
                using (SqlCommand scmd = new SqlCommand(query3, con))
                {
                    scmd.Parameters.Add("@rec", SqlDbType.VarChar).Value = receptionistTextBox.Text;

                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string recId = reader["staffId"].ToString();
                                string firstname = reader["Firstname"].ToString();
                                string lastname = reader["Lastname"].ToString();

                                string name = $"{firstname} {lastname}";

                                // Assign the name to receptionistNameTextBox.Text
                                receptionistNameTextBox.Text = name;
                            }
                        }
                        else
                        {
                            // Receptionist not found, handle it as needed
                            receptionistNameTextBox.Text = "Receptionist not found";
                        }
                    }


                }
            }
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedSpecialization = GetSelectedSpecialization();
            
            if (selectedSpecialization == "ENT")
            {
                bill = 500;
            }
            else if (selectedSpecialization == "Dermatologist")
            {
                bill = 1000;
            }
            else if (selectedSpecialization == "Neurologist")
            {
                bill = 2000;
            }
            else if (selectedSpecialization == "Ophthalmologist")
            {
                bill = 2500;
            }
            else if (selectedSpecialization == "Internal Medicine Physician")
            {
                bill = 2000;
            }
            else if (selectedSpecialization == "Cardiologist")
            {
                bill = 5000;
            }
            else if (selectedSpecialization == "Immunologist")
            {
                bill = 3500;
            }
            else
            {
                bill = 0;
            }

            string inputString = doctorbox.Text; // Replace this with your actual string
            string[] parts = inputString.Split(' ');

            if (parts.Length >= 1)
            {
                string doctorId = parts[0];

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
                {
                    con.Open();
                    string query1 = "Insert into patient values(@pid,@fname,@lname,@dob,@gen,@cell);";
                    using (SqlCommand scmd = new SqlCommand(query1, con))
                    {
                        scmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = pid.Text;
                        scmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fnamebox.Text;
                        scmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = Lastnamebox.Text;
                        scmd.Parameters.Add("@dob", SqlDbType.Date).Value = datepatient.Text;
                        scmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = genderbox.Text;
                        scmd.Parameters.Add("@cell", SqlDbType.VarChar).Value = Cellnobox.Text;
                        scmd.ExecuteNonQuery();
                    }

                    string query2 = "Insert into rec_doc_pat values(@docid,@recid,@patid,@appdate,@apptime)";
                    using (SqlCommand scmd = new SqlCommand(query2, con))
                    {

                        scmd.Parameters.AddWithValue("@docid", doctorId);
                        scmd.Parameters.Add("@recid", SqlDbType.VarChar).Value = receptionistTextBox.Text;
                        scmd.Parameters.Add("@patid", SqlDbType.VarChar).Value = pid.Text;
                        scmd.Parameters.Add("@appdate", SqlDbType.Date).Value = dateapp.Text;
                        scmd.Parameters.Add("@apptime", SqlDbType.Time).Value = timebox.Text;

                        scmd.ExecuteNonQuery();
                    }

                    string query4 = "Insert into Payments values(@patid,@amount,@payment)";
                    using (SqlCommand scmd = new SqlCommand(query4, con))
                    {
                        
                        scmd.Parameters.Add("@patid", SqlDbType.VarChar).Value = pid.Text;
                        scmd.Parameters.AddWithValue("@amount", bill);
                        scmd.Parameters.AddWithValue("@payment", "Unpaid");

                        scmd.ExecuteNonQuery();
                    }
                }
                int number = 1;
                if (number == 1)
                {
                    MessageBox.Show("All data has been entered successfully");
                }
            }
            else
            {
                Console.WriteLine("Invalid input string format");
            }
        }

        private void datepatient_ValueChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            string templateFilePath = "E:\\University Document\\Semester 4\\Database System\\Project\\Loginform\\Loginform\\Loginform\\bin\\Debug\\PatientData.docx"; // Replace with the path to your Word template file

            if (!string.IsNullOrEmpty(templateFilePath))
            {
                try
                {
                    using (var doc = DocX.Load(templateFilePath))
                    {
                        if (doc != null)
                        {
                            // Replace placeholders in the document with form data
                            ReplacePlaceholder(doc, "{patientid}", pid.Text);
                            ReplacePlaceholder(doc, "{patinetname}", $"{fnamebox.Text} {Lastnamebox.Text}");
                            ReplacePlaceholder(doc, "{patientage}", CalculateAge(datepatient.Value));
                            ReplacePlaceholder(doc, "{Doctorname}", GetSelectedDoctorName());
                            ReplacePlaceholder(doc, "{roomno}", GetDoctorRoomNo(GetSelectedDoctorID()));
                            ReplacePlaceholder(doc, "{Receptionistid}", receptionistTextBox.Text);
                            ReplacePlaceholder(doc, "{Receptionistname}", GetReceptionistName(receptionistTextBox.Text));
                            ReplacePlaceholder(doc, "{Date}", dateapp.Text);
                            ReplacePlaceholder(doc, "{Time}", timebox.Text);
                            String bills = bill.ToString();
                            ReplacePlaceholder(doc, "{patinetcharges}", bills);

                            // Save the modified document
                            doc.SaveAs("UpdatedPatientInfo.docx");

                            MessageBox.Show("Word document updated successfully. You can find it as 'UpdatedPatientInfo.docx'.");
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


        private string CalculateAge(DateTime birthDate)
        {
            try
            {
                // Calculate age based on the birth date
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now < birthDate.AddYears(age))
                {
                    age--;
                }
                return age.ToString();
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., invalid date format)
                MessageBox.Show($"Error calculating age: {ex.Message}");
                return "N/A";
            }
        }
        private string GetSelectedDoctorID()
        {
            string inputString = doctorbox.Text; // Replace this with your actual string
            string[] parts = inputString.Split(' ');

            if (parts.Length >= 1)
            {
                return parts[0];
            }
            else
            {
                Console.WriteLine("Invalid input string format");
                return null;
            }
        }

        private string GetSelectedDoctorName()
        {
            string inputString = doctorbox.Text; // Replace this with your actual string
            string[] parts = inputString.Split(' ');

            if (parts.Length >= 2)
            {
                return $"{parts[1]} {parts[2]}"; // Assuming that the doctor's name is stored in the second and third parts
            }
            else
            {
                Console.WriteLine("Invalid input string format");
                return null;
            }
        }

        private string GetDoctorRoomNo(string doctorID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query = "SELECT dep.droomno FROM ClinicStaffmembers doc, Doctor d, Clinicdepartment dep " +
                               "WHERE doc.staffId = d.DoctorID AND d.DoctorId = dep.departmentno AND doc.staffId = @doc;";

                using (SqlCommand scmd = new SqlCommand(query, con))
                {
                    scmd.Parameters.AddWithValue("@doc", doctorID);

                    object result = scmd.ExecuteScalar();
                    return result != null ? result.ToString() : "Room not found";
                }
            }
        }

        private string GetReceptionistName(string receptionistID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;"))
            {
                con.Open();
                string query = "SELECT Firstname, Lastname FROM ClinicStaffmembers WHERE staffId = @rec and position = 'Receptionist';";

                using (SqlCommand scmd = new SqlCommand(query, con))
                {
                    scmd.Parameters.Add("@rec", SqlDbType.VarChar).Value = receptionistID;

                    using (SqlDataReader reader = scmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string firstname = reader["Firstname"].ToString();
                                string lastname = reader["Lastname"].ToString();

                                return $"{firstname} {lastname}";
                            }
                        }
                    }
                }

                return "Receptionist not found";
            }
        }


    }
}
