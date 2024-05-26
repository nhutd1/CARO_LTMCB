
namespace CARO_LTMCB.FORMS
{
    partial class SettingForm
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrivacy = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnGeneral = new FontAwesome.Sharp.IconButton();
            this.pnMain.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.MistyRose;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMain.Controls.Add(this.panel6);
            this.pnMain.Location = new System.Drawing.Point(221, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(799, 745);
            this.pnMain.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(799, 7);
            this.panel6.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.guna2Panel2);
            this.pnMenu.Controls.Add(this.guna2Panel1);
            this.pnMenu.Controls.Add(this.btnPrivacy);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnGeneral);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.FillColor = System.Drawing.Color.LightCyan;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(229, 745);
            this.pnMenu.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel2.Location = new System.Drawing.Point(4, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(248, 7);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(8, 745);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnPrivacy
            // 
            this.btnPrivacy.BackColor = System.Drawing.Color.LightCyan;
            this.btnPrivacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrivacy.FlatAppearance.BorderSize = 0;
            this.btnPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacy.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrivacy.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnPrivacy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrivacy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrivacy.IconSize = 45;
            this.btnPrivacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivacy.Location = new System.Drawing.Point(0, 188);
            this.btnPrivacy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrivacy.Name = "btnPrivacy";
            this.btnPrivacy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrivacy.Size = new System.Drawing.Size(229, 90);
            this.btnPrivacy.TabIndex = 0;
            this.btnPrivacy.Text = "  Privacy ";
            this.btnPrivacy.UseVisualStyleBackColor = false;
            this.btnPrivacy.Click += new System.EventHandler(this.btnPrivacy_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.LightCyan;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
            this.btnAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.IconSize = 45;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 94);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(229, 94);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "   Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.LightCyan;
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGeneral.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnGeneral.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneral.IconSize = 45;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(229, 94);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "   General";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 745);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.pnMain.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnPrivacy;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnGeneral;
    }
}