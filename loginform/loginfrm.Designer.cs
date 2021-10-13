namespace loginform
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.text_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pass_show = new Guna.UI2.WinForms.Guna2CheckBox();
            this.text_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.signup = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.Controls.Add(this.text_username);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.login_btn);
            this.guna2GradientPanel1.Controls.Add(this.pass_show);
            this.guna2GradientPanel1.Controls.Add(this.text_pass);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.MediumSlateBlue;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(597, 72);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(405, 487);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // text_username
            // 
            this.text_username.BackColor = System.Drawing.SystemColors.Menu;
            this.text_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_username.DefaultText = "";
            this.text_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_username.DisabledState.Parent = this.text_username;
            this.text_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_username.FillColor = System.Drawing.SystemColors.Menu;
            this.text_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_username.FocusedState.Parent = this.text_username;
            this.text_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_username.HoverState.Parent = this.text_username;
            this.text_username.Location = new System.Drawing.Point(62, 149);
            this.text_username.Name = "text_username";
            this.text_username.PasswordChar = '\0';
            this.text_username.PlaceholderText = "";
            this.text_username.SelectedText = "";
            this.text_username.ShadowDecoration.Parent = this.text_username;
            this.text_username.Size = new System.Drawing.Size(284, 38);
            this.text_username.TabIndex = 8;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderRadius = 30;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.DisabledState.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(7)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.HoverState.Parent = this.login_btn;
            this.login_btn.Location = new System.Drawing.Point(63, 340);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(283, 64);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOGIN";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pass_show
            // 
            this.pass_show.Animated = true;
            this.pass_show.AutoSize = true;
            this.pass_show.BackColor = System.Drawing.Color.Transparent;
            this.pass_show.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pass_show.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.pass_show.CheckedState.BorderRadius = 0;
            this.pass_show.CheckedState.BorderThickness = 0;
            this.pass_show.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(7)))));
            this.pass_show.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_show.ForeColor = System.Drawing.Color.White;
            this.pass_show.Location = new System.Drawing.Point(72, 304);
            this.pass_show.Name = "pass_show";
            this.pass_show.Size = new System.Drawing.Size(125, 22);
            this.pass_show.TabIndex = 3;
            this.pass_show.Text = "Show password";
            this.pass_show.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.pass_show.UncheckedState.BorderRadius = 0;
            this.pass_show.UncheckedState.BorderThickness = 0;
            this.pass_show.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(7)))));
            this.pass_show.UseVisualStyleBackColor = false;
            this.pass_show.CheckedChanged += new System.EventHandler(this.pass_show_CheckedChanged);
            // 
            // text_pass
            // 
            this.text_pass.BackColor = System.Drawing.SystemColors.Menu;
            this.text_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pass.DefaultText = "";
            this.text_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass.DisabledState.Parent = this.text_pass;
            this.text_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass.FillColor = System.Drawing.SystemColors.Menu;
            this.text_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass.FocusedState.Parent = this.text_pass;
            this.text_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass.HoverState.Parent = this.text_pass;
            this.text_pass.Location = new System.Drawing.Point(63, 238);
            this.text_pass.Name = "text_pass";
            this.text_pass.PasswordChar = '\0';
            this.text_pass.PlaceholderText = "";
            this.text_pass.SelectedText = "";
            this.text_pass.ShadowDecoration.Parent = this.text_pass;
            this.text_pass.Size = new System.Drawing.Size(283, 38);
            this.text_pass.TabIndex = 2;
            this.text_pass.UseSystemPasswordChar = true;
            this.text_pass.TextChanged += new System.EventHandler(this.text_pass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(725, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "New User ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.BorderColor = System.Drawing.Color.Transparent;
            this.signup.CheckedState.Parent = this.signup;
            this.signup.CustomImages.Parent = this.signup;
            this.signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup.DisabledState.Parent = this.signup;
            this.signup.FillColor = System.Drawing.Color.Transparent;
            this.signup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.signup.ForeColor = System.Drawing.Color.Indigo;
            this.signup.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.signup.HoverState.Parent = this.signup;
            this.signup.Location = new System.Drawing.Point(790, 563);
            this.signup.Name = "signup";
            this.signup.PressedColor = System.Drawing.Color.Transparent;
            this.signup.ShadowDecoration.Parent = this.signup;
            this.signup.Size = new System.Drawing.Size(108, 45);
            this.signup.TabIndex = 9;
            this.signup.Text = "Sign Up";
            this.signup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(1069, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private Guna.UI2.WinForms.Guna2CheckBox pass_show;
        private Guna.UI2.WinForms.Guna2TextBox text_pass;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button signup;
        private Guna.UI2.WinForms.Guna2TextBox text_username;
    }
}

