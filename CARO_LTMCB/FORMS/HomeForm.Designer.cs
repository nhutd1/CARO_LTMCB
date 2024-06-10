
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
            this.panel1.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnAnotherUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnotherUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyUser)).BeginInit();
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
            this.pnAnotherUser.Controls.Add(this.picAnotherUser);
            this.pnAnotherUser.Controls.Add(this.prcbPlayer2);
            this.pnAnotherUser.Location = new System.Drawing.Point(861, 166);
            this.pnAnotherUser.Name = "pnAnotherUser";
            this.pnAnotherUser.Size = new System.Drawing.Size(152, 319);
            this.pnAnotherUser.TabIndex = 12;
            // 
            // picAnotherUser
            // 
            this.picAnotherUser.Image = ((System.Drawing.Image)(resources.GetObject("picAnotherUser.Image")));
            this.picAnotherUser.Location = new System.Drawing.Point(12, 33);
            this.picAnotherUser.Name = "picAnotherUser";
            this.picAnotherUser.Size = new System.Drawing.Size(128, 118);
            this.picAnotherUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnotherUser.TabIndex = 0;
            this.picAnotherUser.TabStop = false;
            // 
            // prcbPlayer2
            // 
            this.prcbPlayer2.Location = new System.Drawing.Point(27, 157);
            this.prcbPlayer2.Maximum = 10000;
            this.prcbPlayer2.Name = "prcbPlayer2";
            this.prcbPlayer2.Size = new System.Drawing.Size(100, 20);
            this.prcbPlayer2.Step = 100;
            this.prcbPlayer2.TabIndex = 5;
            // 
            // prcbPlayer1
            // 
            this.prcbPlayer1.Location = new System.Drawing.Point(29, 323);
            this.prcbPlayer1.Maximum = 10000;
            this.prcbPlayer1.Name = "prcbPlayer1";
            this.prcbPlayer1.Size = new System.Drawing.Size(100, 20);
            this.prcbPlayer1.Step = 100;
            this.prcbPlayer1.TabIndex = 11;
            // 
            // picMyUser
            // 
            this.picMyUser.Image = ((System.Drawing.Image)(resources.GetObject("picMyUser.Image")));
            this.picMyUser.Location = new System.Drawing.Point(15, 199);
            this.picMyUser.Name = "picMyUser";
            this.picMyUser.Size = new System.Drawing.Size(128, 118);
            this.picMyUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMyUser.TabIndex = 9;
            this.picMyUser.TabStop = false;
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.pnButtons.ResumeLayout(false);
            this.pnAnotherUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnotherUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMyUser)).EndInit();
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
    }
}