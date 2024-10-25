namespace Lab_14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            loginButton = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            exitButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(131, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(317, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(144, 227);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 2;
            label1.Text = "LOG IN";
            // 
            // pictureBox3
            // 
            pictureBox3.AccessibleRole = AccessibleRole.None;
            pictureBox3.Image = Properties.Resources.user3;
            pictureBox3.Location = new Point(43, 295);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.ForeColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(43, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 1);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(43, 370);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(43, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 1);
            panel2.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 117, 214);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(43, 468);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(347, 55);
            loginButton.TabIndex = 6;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(0, 117, 214);
            txtUsername.Location = new Point(97, 303);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 21);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(0, 117, 214);
            txtPassword.Location = new Point(97, 378);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 21);
            txtPassword.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.FromArgb(0, 117, 214);
            exitButton.Location = new Point(172, 542);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(87, 30);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.FromArgb(0, 117, 214);
            clearButton.Location = new Point(251, 436);
            clearButton.Margin = new Padding(0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(139, 29);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear Fields";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 603);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(loginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Button loginButton;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button exitButton;
        private Button clearButton;
    }
}
