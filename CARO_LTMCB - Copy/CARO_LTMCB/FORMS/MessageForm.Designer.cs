﻿
namespace CARO_LTMCB.FORMS
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.pn5 = new System.Windows.Forms.Panel();
            this.pnFriend = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxFindFriend = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pn6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnFriendRequests = new System.Windows.Forms.Panel();
            this.pnNotFriend = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxFindUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnShowMess = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pnSendMess = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.tbxMess = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEmotion = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnToUsers = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.contextmnFriend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowInfor_Friend = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnfriend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmnNotFriend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowInfor_NotFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmnRequests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowInfor_Requests = new System.Windows.Forms.ToolStripMenuItem();
            this.timmerLoadTN = new System.Windows.Forms.Timer(this.components);
            this.pn5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnSendMess.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnToUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.contextmnFriend.SuspendLayout();
            this.contextmnNotFriend.SuspendLayout();
            this.contextmnRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn5
            // 
            this.pn5.BackColor = System.Drawing.Color.LightCyan;
            this.pn5.Controls.Add(this.pnFriend);
            this.pn5.Controls.Add(this.panel5);
            this.pn5.Controls.Add(this.panel4);
            this.pn5.Controls.Add(this.panel2);
            this.pn5.Controls.Add(this.panel10);
            this.pn5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pn5.Location = new System.Drawing.Point(0, 0);
            this.pn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn5.Name = "pn5";
            this.pn5.Size = new System.Drawing.Size(180, 605);
            this.pn5.TabIndex = 0;
            // 
            // pnFriend
            // 
            this.pnFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFriend.Location = new System.Drawing.Point(4, 65);
            this.pnFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnFriend.Name = "pnFriend";
            this.pnFriend.Size = new System.Drawing.Size(172, 540);
            this.pnFriend.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(176, 65);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 540);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 540);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxFindFriend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 61);
            this.panel2.TabIndex = 3;
            // 
            // tbxFindFriend
            // 
            this.tbxFindFriend.BorderRadius = 20;
            this.tbxFindFriend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFindFriend.DefaultText = "Find Friend";
            this.tbxFindFriend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxFindFriend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxFindFriend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxFindFriend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxFindFriend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxFindFriend.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbxFindFriend.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxFindFriend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxFindFriend.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbxFindFriend.IconLeft")));
            this.tbxFindFriend.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbxFindFriend.Location = new System.Drawing.Point(8, 12);
            this.tbxFindFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFindFriend.Name = "tbxFindFriend";
            this.tbxFindFriend.PasswordChar = '\0';
            this.tbxFindFriend.PlaceholderText = "";
            this.tbxFindFriend.SelectedText = "";
            this.tbxFindFriend.Size = new System.Drawing.Size(164, 37);
            this.tbxFindFriend.TabIndex = 3;
            this.tbxFindFriend.TextOffset = new System.Drawing.Point(6, 0);
            this.tbxFindFriend.TextChanged += new System.EventHandler(this.tbxFindFriend_TextChanged);
            this.tbxFindFriend.Enter += new System.EventHandler(this.tbxSearchFriend_Enter);
            this.tbxFindFriend.Leave += new System.EventHandler(this.tbxSearchFriend_Leave);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(180, 4);
            this.panel10.TabIndex = 2;
            // 
            // pn6
            // 
            this.pn6.BackColor = System.Drawing.Color.LightCyan;
            this.pn6.Controls.Add(this.label1);
            this.pn6.Controls.Add(this.panel9);
            this.pn6.Controls.Add(this.pnFriendRequests);
            this.pn6.Controls.Add(this.pnNotFriend);
            this.pn6.Controls.Add(this.panel8);
            this.pn6.Controls.Add(this.panel7);
            this.pn6.Controls.Add(this.panel3);
            this.pn6.Controls.Add(this.panel6);
            this.pn6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn6.Location = new System.Drawing.Point(585, 0);
            this.pn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn6.Name = "pn6";
            this.pn6.Size = new System.Drawing.Size(180, 605);
            this.pn6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Friend Requests";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel9.Location = new System.Drawing.Point(-2, 280);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(178, 4);
            this.panel9.TabIndex = 9;
            // 
            // pnFriendRequests
            // 
            this.pnFriendRequests.AutoScroll = true;
            this.pnFriendRequests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFriendRequests.Location = new System.Drawing.Point(4, 312);
            this.pnFriendRequests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnFriendRequests.Name = "pnFriendRequests";
            this.pnFriendRequests.Size = new System.Drawing.Size(172, 293);
            this.pnFriendRequests.TabIndex = 10;
            // 
            // pnNotFriend
            // 
            this.pnNotFriend.AutoScroll = true;
            this.pnNotFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNotFriend.Location = new System.Drawing.Point(4, 65);
            this.pnNotFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNotFriend.Name = "pnNotFriend";
            this.pnNotFriend.Size = new System.Drawing.Size(172, 217);
            this.pnNotFriend.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(176, 65);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 540);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 65);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 540);
            this.panel7.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxFindUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 61);
            this.panel3.TabIndex = 5;
            // 
            // tbxFindUser
            // 
            this.tbxFindUser.BorderRadius = 20;
            this.tbxFindUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFindUser.DefaultText = "Find Another User";
            this.tbxFindUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxFindUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxFindUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxFindUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxFindUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxFindUser.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbxFindUser.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxFindUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxFindUser.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbxFindUser.IconLeft")));
            this.tbxFindUser.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbxFindUser.Location = new System.Drawing.Point(7, 12);
            this.tbxFindUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFindUser.Name = "tbxFindUser";
            this.tbxFindUser.PasswordChar = '\0';
            this.tbxFindUser.PlaceholderText = "";
            this.tbxFindUser.SelectedText = "";
            this.tbxFindUser.Size = new System.Drawing.Size(164, 37);
            this.tbxFindUser.TabIndex = 4;
            this.tbxFindUser.TextOffset = new System.Drawing.Point(6, 0);
            this.tbxFindUser.TextChanged += new System.EventHandler(this.tbxFindUser_TextChanged);
            this.tbxFindUser.Enter += new System.EventHandler(this.tbxFindUser_Enter);
            this.tbxFindUser.Leave += new System.EventHandler(this.tbxFindUser_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 4);
            this.panel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pnShowMess);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.pn6);
            this.panel1.Controls.Add(this.pn5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 605);
            this.panel1.TabIndex = 0;
            // 
            // pnShowMess
            // 
            this.pnShowMess.AutoScroll = true;
            this.pnShowMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnShowMess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShowMess.Location = new System.Drawing.Point(180, 60);
            this.pnShowMess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnShowMess.Name = "pnShowMess";
            this.pnShowMess.Size = new System.Drawing.Size(405, 475);
            this.pnShowMess.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pnSendMess);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(180, 535);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(405, 70);
            this.panel12.TabIndex = 5;
            // 
            // pnSendMess
            // 
            this.pnSendMess.BorderRadius = 10;
            this.pnSendMess.Controls.Add(this.btnSend);
            this.pnSendMess.Controls.Add(this.tbxMess);
            this.pnSendMess.Controls.Add(this.btnEmotion);
            this.pnSendMess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnSendMess.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnSendMess.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnSendMess.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnSendMess.Location = new System.Drawing.Point(0, 5);
            this.pnSendMess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnSendMess.Name = "pnSendMess";
            this.pnSendMess.Size = new System.Drawing.Size(405, 61);
            this.pnSendMess.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.IconSize = 50;
            this.btnSend.Location = new System.Drawing.Point(364, 15);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(38, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMess
            // 
            this.tbxMess.AcceptsReturn = true;
            this.tbxMess.AutoScroll = true;
            this.tbxMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbxMess.BorderRadius = 20;
            this.tbxMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMess.DefaultText = "";
            this.tbxMess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMess.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxMess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMess.Location = new System.Drawing.Point(46, 10);
            this.tbxMess.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxMess.Name = "tbxMess";
            this.tbxMess.PasswordChar = '\0';
            this.tbxMess.PlaceholderText = "";
            this.tbxMess.SelectedText = "";
            this.tbxMess.Size = new System.Drawing.Size(316, 42);
            this.tbxMess.TabIndex = 1;
            this.tbxMess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMess_KeyDown);
            // 
            // btnEmotion
            // 
            this.btnEmotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEmotion.FlatAppearance.BorderSize = 0;
            this.btnEmotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmotion.IconChar = FontAwesome.Sharp.IconChar.FaceSmileBeam;
            this.btnEmotion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmotion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmotion.IconSize = 50;
            this.btnEmotion.Location = new System.Drawing.Point(4, 15);
            this.btnEmotion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmotion.Name = "btnEmotion";
            this.btnEmotion.Size = new System.Drawing.Size(38, 34);
            this.btnEmotion.TabIndex = 0;
            this.btnEmotion.UseVisualStyleBackColor = false;
            this.btnEmotion.Click += new System.EventHandler(this.btnEmotion_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pnToUsers);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(180, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(405, 56);
            this.panel11.TabIndex = 4;
            // 
            // pnToUsers
            // 
            this.pnToUsers.BorderRadius = 10;
            this.pnToUsers.Controls.Add(this.lbMessage);
            this.pnToUsers.Controls.Add(this.lbUserName);
            this.pnToUsers.Controls.Add(this.picUserAvatar);
            this.pnToUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnToUsers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnToUsers.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnToUsers.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnToUsers.Location = new System.Drawing.Point(0, 4);
            this.pnToUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnToUsers.Name = "pnToUsers";
            this.pnToUsers.Size = new System.Drawing.Size(405, 48);
            this.pnToUsers.TabIndex = 4;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbMessage.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbMessage.Location = new System.Drawing.Point(123, 3);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(199, 40);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "MESSAGE";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbUserName.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbUserName.Location = new System.Drawing.Point(72, 4);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(199, 40);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "MESSAGE";
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picUserAvatar.Location = new System.Drawing.Point(18, 2);
            this.picUserAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(42, 43);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 0;
            this.picUserAvatar.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(180, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(405, 4);
            this.guna2Panel1.TabIndex = 3;
            // 
            // contextmnFriend
            // 
            this.contextmnFriend.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextmnFriend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowInfor_Friend,
            this.btnUnfriend});
            this.contextmnFriend.Name = "contextmnFriend";
            this.contextmnFriend.Size = new System.Drawing.Size(157, 52);
            // 
            // btnShowInfor_Friend
            // 
            this.btnShowInfor_Friend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowInfor_Friend.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfor_Friend.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowInfor_Friend.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowInfor_Friend.Name = "btnShowInfor_Friend";
            this.btnShowInfor_Friend.Size = new System.Drawing.Size(156, 22);
            this.btnShowInfor_Friend.Text = "Show Infor";
            this.btnShowInfor_Friend.Click += new System.EventHandler(this.btnShowInfor_Friend_Click);
            // 
            // btnUnfriend
            // 
            this.btnUnfriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUnfriend.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnfriend.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUnfriend.Margin = new System.Windows.Forms.Padding(1);
            this.btnUnfriend.Name = "btnUnfriend";
            this.btnUnfriend.Size = new System.Drawing.Size(156, 22);
            this.btnUnfriend.Text = "Unfriend";
            this.btnUnfriend.Click += new System.EventHandler(this.btnUnfriend_Click);
            // 
            // contextmnNotFriend
            // 
            this.contextmnNotFriend.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextmnNotFriend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowInfor_NotFriend,
            this.btnAddFriend});
            this.contextmnNotFriend.Name = "contextmnNotFriend";
            this.contextmnNotFriend.Size = new System.Drawing.Size(157, 52);
            // 
            // btnShowInfor_NotFriend
            // 
            this.btnShowInfor_NotFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowInfor_NotFriend.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfor_NotFriend.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowInfor_NotFriend.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowInfor_NotFriend.Name = "btnShowInfor_NotFriend";
            this.btnShowInfor_NotFriend.Size = new System.Drawing.Size(156, 22);
            this.btnShowInfor_NotFriend.Text = "Show Infor";
            this.btnShowInfor_NotFriend.Click += new System.EventHandler(this.btnShowInfor_NotFriend_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddFriend.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddFriend.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(156, 22);
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // contextmnRequests
            // 
            this.contextmnRequests.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextmnRequests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowInfor_Requests});
            this.contextmnRequests.Name = "contextmnRequests";
            this.contextmnRequests.Size = new System.Drawing.Size(157, 28);
            // 
            // btnShowInfor_Requests
            // 
            this.btnShowInfor_Requests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowInfor_Requests.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfor_Requests.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowInfor_Requests.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowInfor_Requests.Name = "btnShowInfor_Requests";
            this.btnShowInfor_Requests.Size = new System.Drawing.Size(156, 22);
            this.btnShowInfor_Requests.Text = "Show Infor";
            this.btnShowInfor_Requests.Click += new System.EventHandler(this.btnShowInfor_Requests_Click);
            // 
            // timmerLoadTN
            // 
            this.timmerLoadTN.Interval = 200;
            this.timmerLoadTN.Tick += new System.EventHandler(this.timmerLoadTN_Tick);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(765, 605);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.pn5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pn6.ResumeLayout(false);
            this.pn6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnSendMess.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnToUsers.ResumeLayout(false);
            this.pnToUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.contextmnFriend.ResumeLayout(false);
            this.contextmnNotFriend.ResumeLayout(false);
            this.contextmnRequests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn5;
        private System.Windows.Forms.Panel pn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox tbxFindFriend;
        private Guna.UI2.WinForms.Guna2TextBox tbxFindUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnSendMess;
        private FontAwesome.Sharp.IconButton btnEmotion;
        private Guna.UI2.WinForms.Guna2TextBox tbxMess;
        private FontAwesome.Sharp.IconButton btnSend;
        private System.Windows.Forms.Panel pnFriend;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnToUsers;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel pnNotFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnFriendRequests;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ContextMenuStrip contextmnFriend;
        private System.Windows.Forms.ToolStripMenuItem btnShowInfor_Friend;
        private System.Windows.Forms.ToolStripMenuItem btnUnfriend;
        private System.Windows.Forms.ContextMenuStrip contextmnNotFriend;
        private System.Windows.Forms.ToolStripMenuItem btnShowInfor_NotFriend;
        private System.Windows.Forms.ToolStripMenuItem btnAddFriend;
        private System.Windows.Forms.ContextMenuStrip contextmnRequests;
        private System.Windows.Forms.ToolStripMenuItem btnShowInfor_Requests;
        private System.Windows.Forms.Panel pnShowMess;
        private System.Windows.Forms.Timer timmerLoadTN;
    }
}