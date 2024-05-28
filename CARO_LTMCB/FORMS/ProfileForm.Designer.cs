
namespace CARO_LTMCB.FORMS
{
    partial class ProfileForm
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
            this.components = new System.ComponentModel.Container();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.btnChangeAvatar = new FontAwesome.Sharp.IconButton();
            this.picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxScore = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxWinrate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnLSDau = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmAvtChange = new System.Windows.Forms.Timer(this.components);
            this.pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnProfile.Controls.Add(this.btnChangeAvatar);
            this.pnProfile.Controls.Add(this.picProfile);
            this.pnProfile.Controls.Add(this.label7);
            this.pnProfile.Controls.Add(this.label4);
            this.pnProfile.Controls.Add(this.label6);
            this.pnProfile.Controls.Add(this.label5);
            this.pnProfile.Controls.Add(this.label3);
            this.pnProfile.Controls.Add(this.label2);
            this.pnProfile.Controls.Add(this.tbxDate);
            this.pnProfile.Controls.Add(this.tbxScore);
            this.pnProfile.Controls.Add(this.tbxMail);
            this.pnProfile.Controls.Add(this.tbxWinrate);
            this.pnProfile.Controls.Add(this.tbxUsername);
            this.pnProfile.Controls.Add(this.tbxID);
            this.pnProfile.Controls.Add(this.panel2);
            this.pnProfile.Controls.Add(this.panel1);
            this.pnProfile.Controls.Add(this.panel4);
            this.pnProfile.Controls.Add(this.panel3);
            this.pnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnProfile.Location = new System.Drawing.Point(0, 0);
            this.pnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(1020, 260);
            this.pnProfile.TabIndex = 0;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.FlatAppearance.BorderSize = 0;
            this.btnChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAvatar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnChangeAvatar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChangeAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeAvatar.IconSize = 40;
            this.btnChangeAvatar.Location = new System.Drawing.Point(183, 210);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(42, 36);
            this.btnChangeAvatar.TabIndex = 14;
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.FillColor = System.Drawing.Color.Silver;
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(25, 28);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.Size = new System.Drawing.Size(200, 199);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 13;
            this.picProfile.TabStop = false;
            this.picProfile.UseTransparentBackground = true;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(624, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(253, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(624, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(624, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Win rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(253, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // tbxDate
            // 
            this.tbxDate.BorderRadius = 10;
            this.tbxDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDate.DefaultText = "";
            this.tbxDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDate.FillColor = System.Drawing.Color.LightCyan;
            this.tbxDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDate.Location = new System.Drawing.Point(772, 190);
            this.tbxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.PasswordChar = '\0';
            this.tbxDate.PlaceholderText = "";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.SelectedText = "";
            this.tbxDate.Size = new System.Drawing.Size(220, 28);
            this.tbxDate.TabIndex = 9;
            this.tbxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxScore
            // 
            this.tbxScore.BorderRadius = 10;
            this.tbxScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxScore.DefaultText = "";
            this.tbxScore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScore.FillColor = System.Drawing.Color.LightCyan;
            this.tbxScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScore.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.tbxScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScore.Location = new System.Drawing.Point(772, 121);
            this.tbxScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.PasswordChar = '\0';
            this.tbxScore.PlaceholderText = "";
            this.tbxScore.ReadOnly = true;
            this.tbxScore.SelectedText = "";
            this.tbxScore.Size = new System.Drawing.Size(220, 28);
            this.tbxScore.TabIndex = 9;
            this.tbxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMail
            // 
            this.tbxMail.BorderRadius = 10;
            this.tbxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMail.DefaultText = "";
            this.tbxMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMail.FillColor = System.Drawing.Color.LightCyan;
            this.tbxMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMail.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.tbxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMail.Location = new System.Drawing.Point(372, 190);
            this.tbxMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.PasswordChar = '\0';
            this.tbxMail.PlaceholderText = "";
            this.tbxMail.ReadOnly = true;
            this.tbxMail.SelectedText = "";
            this.tbxMail.Size = new System.Drawing.Size(244, 28);
            this.tbxMail.TabIndex = 9;
            this.tbxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxMail.TextChanged += new System.EventHandler(this.tbxMail_TextChanged);
            // 
            // tbxWinrate
            // 
            this.tbxWinrate.BorderRadius = 10;
            this.tbxWinrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxWinrate.DefaultText = "";
            this.tbxWinrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxWinrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxWinrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxWinrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxWinrate.FillColor = System.Drawing.Color.LightCyan;
            this.tbxWinrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxWinrate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWinrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxWinrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxWinrate.Location = new System.Drawing.Point(772, 47);
            this.tbxWinrate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxWinrate.Name = "tbxWinrate";
            this.tbxWinrate.PasswordChar = '\0';
            this.tbxWinrate.PlaceholderText = "";
            this.tbxWinrate.ReadOnly = true;
            this.tbxWinrate.SelectedText = "";
            this.tbxWinrate.Size = new System.Drawing.Size(220, 28);
            this.tbxWinrate.TabIndex = 9;
            this.tbxWinrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BorderRadius = 10;
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.DefaultText = "";
            this.tbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsername.FillColor = System.Drawing.Color.LightCyan;
            this.tbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsername.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsername.Location = new System.Drawing.Point(372, 121);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.PlaceholderText = "";
            this.tbxUsername.ReadOnly = true;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.Size = new System.Drawing.Size(244, 28);
            this.tbxUsername.TabIndex = 9;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxID
            // 
            this.tbxID.BorderRadius = 10;
            this.tbxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxID.DefaultText = "";
            this.tbxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxID.FillColor = System.Drawing.Color.LightCyan;
            this.tbxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxID.Location = new System.Drawing.Point(372, 47);
            this.tbxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxID.Name = "tbxID";
            this.tbxID.PasswordChar = '\0';
            this.tbxID.PlaceholderText = "";
            this.tbxID.ReadOnly = true;
            this.tbxID.SelectedText = "";
            this.tbxID.Size = new System.Drawing.Size(244, 28);
            this.tbxID.TabIndex = 9;
            this.tbxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1015, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 255);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 255);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 5);
            this.panel3.TabIndex = 0;
            // 
            // pnLSDau
            // 
            this.pnLSDau.AutoScroll = true;
            this.pnLSDau.BackColor = System.Drawing.Color.LightCyan;
            this.pnLSDau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLSDau.Location = new System.Drawing.Point(0, 325);
            this.pnLSDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLSDau.Name = "pnLSDau";
            this.pnLSDau.Size = new System.Drawing.Size(1020, 420);
            this.pnLSDau.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 260);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 65);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(307, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATCH HISTORY";
            // 
            // tmAvtChange
            // 
            this.tmAvtChange.Tick += new System.EventHandler(this.tmAvtChange_Tick);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 745);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnLSDau);
            this.Controls.Add(this.pnProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnLSDau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbxID;
        private Guna.UI2.WinForms.Guna2TextBox tbxDate;
        private Guna.UI2.WinForms.Guna2TextBox tbxScore;
        private Guna.UI2.WinForms.Guna2TextBox tbxMail;
        private Guna.UI2.WinForms.Guna2TextBox tbxWinrate;
        private Guna.UI2.WinForms.Guna2TextBox tbxUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        private FontAwesome.Sharp.IconButton btnChangeAvatar;
        private System.Windows.Forms.Timer tmAvtChange;
    }
}