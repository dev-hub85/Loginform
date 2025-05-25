namespace Loginform
{
    partial class Registerationform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerationform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Gendercbox = new System.Windows.Forms.ComboBox();
            this.DOB = new System.Windows.Forms.Label();
            this.Fullnamebox = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Passcode = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.Gendercbox);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.Fullnamebox);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Passcode);
            this.panel1.Controls.Add(this.User);
            this.panel1.Location = new System.Drawing.Point(301, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 488);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(140, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "OR";
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.BackColor = System.Drawing.Color.MediumOrchid;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(51, 413);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 37);
            this.Login.TabIndex = 15;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(51, 304);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(211, 26);
            this.date.TabIndex = 14;
            // 
            // Gendercbox
            // 
            this.Gendercbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendercbox.FormattingEnabled = true;
            this.Gendercbox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.Gendercbox.Location = new System.Drawing.Point(51, 240);
            this.Gendercbox.Name = "Gendercbox";
            this.Gendercbox.Size = new System.Drawing.Size(211, 28);
            this.Gendercbox.TabIndex = 12;
            this.Gendercbox.Text = "Male";
            // 
            // DOB
            // 
            this.DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DOB.Location = new System.Drawing.Point(50, 282);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(125, 19);
            this.DOB.TabIndex = 11;
            this.DOB.Text = "Date of Birth";
            // 
            // Fullnamebox
            // 
            this.Fullnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullnamebox.Location = new System.Drawing.Point(51, 182);
            this.Fullnamebox.Name = "Fullnamebox";
            this.Fullnamebox.Size = new System.Drawing.Size(211, 26);
            this.Fullnamebox.TabIndex = 9;
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Gender.Location = new System.Drawing.Point(50, 218);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 19);
            this.Gender.TabIndex = 8;
            this.Gender.Text = "Gender";
            // 
            // Fullname
            // 
            this.Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Fullname.Location = new System.Drawing.Point(50, 156);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(94, 19);
            this.Fullname.TabIndex = 7;
            this.Fullname.Text = "Full Name";
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Register.BackColor = System.Drawing.Color.MediumOrchid;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(51, 350);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(211, 37);
            this.Register.TabIndex = 6;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(51, 120);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(211, 26);
            this.Password.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(51, 64);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(211, 26);
            this.Username.TabIndex = 2;
            // 
            // Passcode
            // 
            this.Passcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Passcode.AutoSize = true;
            this.Passcode.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passcode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Passcode.Location = new System.Drawing.Point(50, 98);
            this.Passcode.Name = "Passcode";
            this.Passcode.Size = new System.Drawing.Size(91, 19);
            this.Passcode.TabIndex = 1;
            this.Passcode.Text = "Password";
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DodgerBlue;
            this.User.Location = new System.Drawing.Point(47, 42);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(92, 19);
            this.User.TabIndex = 0;
            this.User.Text = "UserName";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(600, 600);
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 535);
            this.panel2.TabIndex = 14;
            // 
            // Registerationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registerationform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registerationform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label Passcode;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox Fullnamebox;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox Gendercbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
    }
}