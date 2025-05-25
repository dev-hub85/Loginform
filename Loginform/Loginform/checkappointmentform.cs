using ClosedXML.Excel;
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
    public partial class checkappointmentform : Form
    {
        private string connectionString = "Data Source=DESKTOP-80220EL;Initial Catalog=Clinic;Integrated Security=True;";
        public checkappointmentform()
        {
            InitializeComponent();
            this.Load += checkappointmentform_Load;
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
        private void checkappointmentform_Load(object sender, EventArgs e)
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
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData1();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Your SQL query
                    string query = "Select p.PatientID As PatientID,p.Fname As FirstName,p.Lname As Lastname,p.Gender As Gender,p.DOB As DateofBirth,r.Apptime As AppointmentTime from patient p,rec_doc_pat r,Doctor d where d.DoctorId = @staffid and d.DoctorId=r.DoctorId and r.PatientID = p.PatientID and r.Appdate = @date;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffidbox3.Text;
                        command.Parameters.Add("@date", SqlDbType.Date).Value = date.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the results
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData1()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Your SQL query
                    string query = "Select p.PatientID As PatientID,p.Fname As FirstName,p.Lname As Lastname,p.Gender As Gender,p.DOB As DateofBirth ,r.Apptime As AppointmentTime from patient p,rec_doc_pat r,Doctor d where d.DoctorId = @staffid and d.DoctorId=r.DoctorId and r.PatientID = p.PatientID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@staffid", SqlDbType.VarChar).Value = staffbox3.Text;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the results
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveDialog.FilterIndex = 1;
                    saveDialog.RestoreDirectory = true;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dataTable = (DataTable)dataGridView1.DataSource;

                            // Create a worksheet
                            var worksheet = workbook.Worksheets.Add(dataTable, "ClinicData");

                            // Format the DateofBirth column as date
                            var dateOfBirthColumnIndex = dataTable.Columns["DateofBirth"].Ordinal + 1; // Column indices are 1-based
                            var dateOfBirthColumn = worksheet.Column(dateOfBirthColumnIndex);

                            dateOfBirthColumn.Cells().Style.NumberFormat.Format = "yyyy-mm-dd";

                            // Save the workbook to the specified file
                            workbook.SaveAs(saveDialog.FileName);

                            MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int number = 1;
            if (number == 1)
            {
                this.Hide();
                checkappointmentform sm = new checkappointmentform();
                sm.ShowDialog();
            }
        }
    }
}
