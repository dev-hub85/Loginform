namespace Loginform
{
    partial class updatespecilizationform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatespecilizationform));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.specializationbox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.staffidbox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.positionstaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.staffno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(600, 600);
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 749);
            this.panel2.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(600, 600);
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.specbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.specializationbox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.staffidbox3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.positionstaff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lastname);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.fnamebox);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.staffno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StaffID);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(88, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 632);
            this.panel1.TabIndex = 1;
            // 
            // specbox
            // 
            this.specbox.Enabled = false;
            this.specbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specbox.Location = new System.Drawing.Point(401, 348);
            this.specbox.Name = "specbox";
            this.specbox.Size = new System.Drawing.Size(184, 26);
            this.specbox.TabIndex = 83;
            this.specbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(397, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Specialization:";
            // 
            // specializationbox3
            // 
            this.specializationbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specializationbox3.FormattingEnabled = true;
            this.specializationbox3.Items.AddRange(new object[] {
            "Ophthalmologist",
            "Internal Medicine Physician",
            "Dermatologist",
            "Cardiologist",
            "Neurologist",
            "ENT",
            "Immunologist"});
            this.specializationbox3.Location = new System.Drawing.Point(179, 454);
            this.specializationbox3.Name = "specializationbox3";
            this.specializationbox3.Size = new System.Drawing.Size(184, 28);
            this.specializationbox3.TabIndex = 81;
            this.specializationbox3.Text = "ENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(175, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Specialization:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(175, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Specialization:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 78;
            this.button1.Text = "Search Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffidbox3
            // 
            this.staffidbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffidbox3.Location = new System.Drawing.Point(179, 170);
            this.staffidbox3.Name = "staffidbox3";
            this.staffidbox3.Size = new System.Drawing.Size(183, 26);
            this.staffidbox3.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(175, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 76;
            this.label18.Text = "Staff ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(257, 24);
            this.label17.TabIndex = 75;
            this.label17.Text = "Enter staff ID to Check Details:";
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(891, 493);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(134, 29);
            this.Insert.TabIndex = 65;
            this.Insert.Text = "Update Record";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // positionstaff
            // 
            this.positionstaff.Enabled = false;
            this.positionstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionstaff.Location = new System.Drawing.Point(179, 349);
            this.positionstaff.Name = "positionstaff";
            this.positionstaff.Size = new System.Drawing.Size(184, 26);
            this.positionstaff.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(175, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Position:";
            // 
            // Lastname
            // 
            this.Lastname.Enabled = false;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(626, 269);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(184, 26);
            this.Lastname.TabIndex = 47;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lname.Location = new System.Drawing.Point(622, 246);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(90, 20);
            this.lname.TabIndex = 46;
            this.lname.Text = "Last Name:";
            // 
            // fnamebox
            // 
            this.fnamebox.Enabled = false;
            this.fnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamebox.Location = new System.Drawing.Point(401, 269);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(184, 26);
            this.fnamebox.TabIndex = 45;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fname.Location = new System.Drawing.Point(397, 246);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(90, 20);
            this.fname.TabIndex = 44;
            this.fname.Text = "First Name:";
            // 
            // staffno
            // 
            this.staffno.Enabled = false;
            this.staffno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffno.Location = new System.Drawing.Point(179, 269);
            this.staffno.Name = "staffno";
            this.staffno.Size = new System.Drawing.Size(183, 26);
            this.staffno.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Check Details and Update:";
            // 
            // StaffID
            // 
            this.StaffID.AutoSize = true;
            this.StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StaffID.Location = new System.Drawing.Point(175, 246);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(51, 20);
            this.StaffID.TabIndex = 41;
            this.StaffID.Text = "CNIC:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(367, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(369, 27);
            this.label16.TabIndex = 40;
            this.label16.Text = "Doctor Update specialization form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loginform.Properties.Resources.arrow_back_37834;
            this.pictureBox1.Location = new System.Drawing.Point(24, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Loginform.Properties.Resources.finalimage4_01;
            this.pictureBox2.Location = new System.Drawing.Point(1010, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 123);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // updatespecilizationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 749);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updatespecilizationform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Specialization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.updatespecilizationform_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox specializationbox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox staffidbox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox positionstaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox staffno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StaffID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox specbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}