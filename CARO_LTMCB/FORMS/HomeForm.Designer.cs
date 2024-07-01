
namespace CARO_LTMCB.FORMS
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMessage = new System.Windows.Forms.Panel();
            this.rtbxCurMess = new System.Windows.Forms.RichTextBox();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.tbxMess = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEmotion = new FontAwesome.Sharp.IconButton();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnPvP = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnPvBot = new System.Windows.Forms.Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnAnotherUser = new System.Windows.Forms.Panel();
            this.picAnotherUser = new System.Windows.Forms.PictureBox();
            this.prcbPlayer2 = new System.Windows.Forms.ProgressBar();
            this.prcbPlayer1 = new System.Windows.Forms.ProgressBar();
            this.picMyUser = new System.Windows.Forms.PictureBox();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.picIcon1 = new System.Windows.Forms.PictureBox();
            this.picIcon2 = new System.Windows.Forms.PictureBox();
            this.tmCD_Icon1 = new System.Windows.Forms.Timer(this.components);
            this.tmCD_Icon2 = new System.Windows.Forms.Timer(this.components);
            this.pnPvP = new System.Windows.Forms.Panel();
            this.btnFindMatch = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnMessage.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnAnotherUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnotherUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon2)).BeginInit();
            this.pnPvP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 745);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 5);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pnPvP);
            this.panel1.Controls.Add(this.picIcon1);
            this.panel1.Controls.Add(this.pnMessage);
            this.panel1.Controls.Add(this.pnButtons);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pnAnotherUser);
            this.panel1.Controls.Add(this.prcbPlayer1);
            this.panel1.Controls.Add(this.picMyUser);
            this.panel1.Controls.Add(this.pnChessBoard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 745);
            this.panel1.TabIndex = 0;
            // 
            // pnMessage
            // 
            this.pnMessage.Controls.Add(this.rtbxCurMess);
            this.pnMessage.Controls.Add(this.btnSend);
            this.pnMessage.Controls.Add(this.tbxMess);
            this.pnMessage.Controls.Add(this.btnEmotion);
            this.pnMessage.Location = new System.Drawing.Point(29, 641);
            this.pnMessage.Name = "pnMessage";
            this.pnMessage.Size = new System.Drawing.Size(972, 104);
            this.pnMessage.TabIndex = 1;
            // 
            // rtbxCurMess
            // 
            this.rtbxCurMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxCurMess.Location = new System.Drawing.Point(205, 3);
            this.rtbxCurMess.Name = "rtbxCurMess";
            this.rtbxCurMess.ReadOnly = true;
            this.rtbxCurMess.Size = new System.Drawing.Size(529, 57);
            this.rtbxCurMess.TabIndex = 6;
            this.rtbxCurMess.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightCyan;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.IconSize = 40;
            this.btnSend.Location = new System.Drawing.Point(740, 63);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMess
            // 
            this.tbxMess.AcceptsReturn = true;
            this.tbxMess.AutoScroll = true;
            this.tbxMess.BackColor = System.Drawing.Color.LightCyan;
            this.tbxMess.BorderRadius = 20;
            this.tbxMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMess.DefaultText = "";
            this.tbxMess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMess.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMess.Location = new System.Drawing.Point(205, 63);
            this.tbxMess.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxMess.Name = "tbxMess";
            this.tbxMess.PasswordChar = '\0';
            this.tbxMess.PlaceholderText = "";
            this.tbxMess.SelectedText = "";
            this.tbxMess.Size = new System.Drawing.Size(529, 38);
            this.tbxMess.TabIndex = 4;
            // 
            // btnEmotion
            // 
            this.btnEmotion.BackColor = System.Drawing.Color.LightCyan;
            this.btnEmotion.FlatAppearance.BorderSize = 0;
            this.btnEmotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmotion.IconChar = FontAwesome.Sharp.IconChar.FaceSmileBeam;
            this.btnEmotion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmotion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmotion.IconSize = 40;
            this.btnEmotion.Location = new System.Drawing.Point(158, 63);
            this.btnEmotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmotion.Name = "btnEmotion";
            this.btnEmotion.Size = new System.Drawing.Size(40, 40);
            this.btnEmotion.TabIndex = 3;
            this.btnEmotion.UseVisualStyleBackColor = false;
            this.btnEmotion.Click += new System.EventHandler(this.btnEmotion_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnPvP);
            this.pnButtons.Controls.Add(this.btnPractice);
            this.pnButtons.Controls.Add(this.btnPvBot);
            this.pnButtons.Location = new System.Drawing.Point(144, 653);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(728, 79);
            this.pnButtons.TabIndex = 7;
            // 
            // btnPvP
            // 
            this.btnPvP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPvP.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvP.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPvP.Location = new System.Drawing.Point(563, 10);
            this.btnPvP.Name = "btnPvP";
            this.btnPvP.Size = new System.Drawing.Size(149, 59);
            this.btnPvP.TabIndex = 4;
            this.btnPvP.Text = "PvP";
            this.btnPvP.UseVisualStyleBackColor = false;
            this.btnPvP.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPractice.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPractice.Location = new System.Drawing.Point(12, 10);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(149, 59);
            this.btnPractice.TabIndex = 4;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPvBot
            // 
            this.btnPvBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPvBot.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvBot.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPvBot.Location = new System.Drawing.Point(294, 10);
            this.btnPvBot.Name = "btnPvBot";
            this.btnPvBot.Size = new System.Drawing.Size(149, 59);
            this.btnPvBot.TabIndex = 4;
            this.btnPvBot.Text = "PvBot";
            this.btnPvBot.UseVisualStyleBackColor = false;
            this.btnPvBot.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.LightCyan;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(9, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Practice";
            this.btnBack.TextOffset = new System.Drawing.Point(7, 0);
            this.btnBack.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnAnotherUser
            // 
            this.pnAnotherUser.Controls.Add(this.picIcon2);
            this.pnAnotherUser.Controls.Add(this.picAnotherUser);
            this.pnAnotherUser.Controls.Add(this.prcbPlayer2);
            this.pnAnotherUser.Location = new System.Drawing.Point(861, 101);
            this.pnAnotherUser.Name = "pnAnotherUser";
            this.pnAnotherUser.Size = new System.Drawing.Size(152, 359);
            this.pnAnotherUser.TabIndex = 12;
            // 
            // picAnotherUser
            // 
            this.picAnotherUser.Image = ((System.Drawing.Image)(resources.GetObject("picAnotherUser.Image")));
            this.picAnotherUser.Location = new System.Drawing.Point(12, 170);
            this.picAnotherUser.Name = "picAnotherUser";
            this.picAnotherUser.Size = new System.Drawing.Size(128, 118);
            this.picAnotherUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnotherUser.TabIndex = 0;
            this.picAnotherUser.TabStop = false;
            this.picAnotherUser.Click += new System.EventHandler(this.picAnotherUser_Click);
            // 
            // prcbPlayer2
            // 
            this.prcbPlayer2.Location = new System.Drawing.Point(27, 294);
            this.prcbPlayer2.Maximum = 10000;
            this.prcbPlayer2.Name = "prcbPlayer2";
            this.prcbPlayer2.Size = new System.Drawing.Size(100, 20);
            this.prcbPlayer2.Step = 100;
            this.prcbPlayer2.TabIndex = 5;
            // 
            // prcbPlayer1
            // 
            this.prcbPlayer1.Location = new System.Drawing.Point(29, 395);
            this.prcbPlayer1.Maximum = 10000;
            this.prcbPlayer1.Name = "prcbPlayer1";
            this.prcbPlayer1.Size = new System.Drawing.Size(100, 20);
            this.prcbPlayer1.Step = 100;
            this.prcbPlayer1.TabIndex = 11;
            // 
            // picMyUser
            // 
            this.picMyUser.Image = ((System.Drawing.Image)(resources.GetObject("picMyUser.Image")));
            this.picMyUser.Location = new System.Drawing.Point(15, 271);
            this.picMyUser.Name = "picMyUser";
            this.picMyUser.Size = new System.Drawing.Size(128, 118);
            this.picMyUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMyUser.TabIndex = 9;
            this.picMyUser.TabStop = false;
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.pnChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnChessBoard.Location = new System.Drawing.Point(155, 13);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(700, 630);
            this.pnChessBoard.TabIndex = 10;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // picIcon1
            // 
            this.picIcon1.Location = new System.Drawing.Point(29, 161);
            this.picIcon1.Name = "picIcon1";
            this.picIcon1.Size = new System.Drawing.Size(100, 100);
            this.picIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon1.TabIndex = 6;
            this.picIcon1.TabStop = false;
            // 
            // picIcon2
            // 
            this.picIcon2.Location = new System.Drawing.Point(27, 60);
            this.picIcon2.Name = "picIcon2";
            this.picIcon2.Size = new System.Drawing.Size(100, 100);
            this.picIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon2.TabIndex = 6;
            this.picIcon2.TabStop = false;
            // 
            // tmCD_Icon1
            // 
            this.tmCD_Icon1.Interval = 3000;
            this.tmCD_Icon1.Tick += new System.EventHandler(this.tmCD_Icon1_Tick);
            // 
            // tmCD_Icon2
            // 
            this.tmCD_Icon2.Interval = 3000;
            this.tmCD_Icon2.Tick += new System.EventHandler(this.tmCD_Icon2_Tick);
            // 
            // pnPvP
            // 
            this.pnPvP.Controls.Add(this.btnCreateRoom);
            this.pnPvP.Controls.Add(this.btnFindMatch);
            this.pnPvP.Location = new System.Drawing.Point(238, 649);
            this.pnPvP.Name = "pnPvP";
            this.pnPvP.Size = new System.Drawing.Size(541, 93);
            this.pnPvP.TabIndex = 0;
            // 
            // btnFindMatch
            // 
            this.btnFindMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFindMatch.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMatch.ForeColor = System.Drawing.Color.LightCyan;
            this.btnFindMatch.Location = new System.Drawing.Point(48, 14);
            this.btnFindMatch.Name = "btnFindMatch";
            this.btnFindMatch.Size = new System.Drawing.Size(149, 59);
            this.btnFindMatch.TabIndex = 5;
            this.btnFindMatch.Text = "Play";
            this.btnFindMatch.UseVisualStyleBackColor = false;
            this.btnFindMatch.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateRoom.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCreateRoom.Location = new System.Drawing.Point(346, 14);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(149, 59);
            this.btnCreateRoom.TabIndex = 6;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 745);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.pnMessage.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnAnotherUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnotherUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon2)).EndInit();
            this.pnPvP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Button btnPvP;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnPvBot;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Panel pnAnotherUser;
        private System.Windows.Forms.PictureBox picAnotherUser;
        private System.Windows.Forms.ProgressBar prcbPlayer2;
        private System.Windows.Forms.ProgressBar prcbPlayer1;
        private System.Windows.Forms.PictureBox picMyUser;
        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Panel pnMessage;
        private FontAwesome.Sharp.IconButton btnSend;
        private Guna.UI2.WinForms.Guna2TextBox tbxMess;
        private FontAwesome.Sharp.IconButton btnEmotion;
        private System.Windows.Forms.RichTextBox rtbxCurMess;
        private System.Windows.Forms.PictureBox picIcon1;
        private System.Windows.Forms.PictureBox picIcon2;
        private System.Windows.Forms.Timer tmCD_Icon1;
        private System.Windows.Forms.Timer tmCD_Icon2;
        private System.Windows.Forms.Panel pnPvP;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnFindMatch;
    }
}