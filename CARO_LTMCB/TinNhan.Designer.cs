
namespace CARO_LTMCB
{
    partial class TinNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMess = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lbMess
            // 
            this.lbMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbMess.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess.ForeColor = System.Drawing.Color.LightCyan;
            this.lbMess.Location = new System.Drawing.Point(14, 14);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(361, 83);
            this.lbMess.TabIndex = 0;
            this.lbMess.Text = "Xin chaooooooo, he loooooo";
            this.lbMess.Resize += new System.EventHandler(this.lbMess_Resize);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTime.Location = new System.Drawing.Point(14, 100);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(128, 22);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "29/4/2024 1:53";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // TinNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbMess);
            this.Name = "TinNhan";
            this.Size = new System.Drawing.Size(390, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Label lbTime;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
