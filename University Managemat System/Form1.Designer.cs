namespace University_Managemat_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userName = new TextBox();
            userPassword = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 227);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 288);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 24);
            label3.Name = "label3";
            label3.Size = new Size(225, 29);
            label3.TabIndex = 2;
            label3.Text = "Welcome to BIMS";
            // 
            // userName
            // 
            userName.Location = new Point(290, 224);
            userName.Name = "userName";
            userName.Size = new Size(282, 25);
            userName.TabIndex = 3;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(290, 285);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(282, 25);
            userPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Calibri", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(356, 354);
            button1.Name = "button1";
            button1.Size = new Size(117, 41);
            button1.TabIndex = 6;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(774, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(userPassword);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userName;
        private TextBox userPassword;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
