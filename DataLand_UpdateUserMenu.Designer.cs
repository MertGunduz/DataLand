
namespace DataLand
{
    partial class DataLand_UpdateUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLand_UpdateUserMenu));
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.UpdateUserFromDatabase_Button = new DataLand.VoidButton();
            this.UserMail_TextBox = new System.Windows.Forms.TextBox();
            this.UserPhone_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Main_Label = new System.Windows.Forms.Label();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Mid_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_PictureBox.Image = global::DataLand.Properties.Resources.DataLand_MainTopLogoIcon;
            this.Logo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(350, 105);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 1;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Mid_Panel.Controls.Add(this.UserID_TextBox);
            this.Mid_Panel.Controls.Add(this.UpdateUserFromDatabase_Button);
            this.Mid_Panel.Controls.Add(this.UserMail_TextBox);
            this.Mid_Panel.Controls.Add(this.UserPhone_TextBox);
            this.Mid_Panel.Controls.Add(this.Surname_TextBox);
            this.Mid_Panel.Controls.Add(this.Username_TextBox);
            this.Mid_Panel.Controls.Add(this.Main_Label);
            this.Mid_Panel.Controls.Add(this.Logo_PictureBox);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(350, 488);
            this.Mid_Panel.TabIndex = 1;
            // 
            // UpdateUserFromDatabase_Button
            // 
            this.UpdateUserFromDatabase_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUserFromDatabase_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateUserFromDatabase_Button.FlatAppearance.BorderSize = 0;
            this.UpdateUserFromDatabase_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUserFromDatabase_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUserFromDatabase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserFromDatabase_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateUserFromDatabase_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.UpdateUserFromDatabase_Button.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.UpdateUserFromDatabase_Button.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredUpdateIcon_png;
            this.UpdateUserFromDatabase_Button.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredUpdateIcon_png;
            this.UpdateUserFromDatabase_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateUserFromDatabase_Button.Location = new System.Drawing.Point(12, 426);
            this.UpdateUserFromDatabase_Button.Name = "UpdateUserFromDatabase_Button";
            this.UpdateUserFromDatabase_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.UpdateUserFromDatabase_Button.Size = new System.Drawing.Size(326, 40);
            this.UpdateUserFromDatabase_Button.TabIndex = 7;
            this.UpdateUserFromDatabase_Button.Text = "Update User";
            this.UpdateUserFromDatabase_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateUserFromDatabase_Button.UseVisualStyleBackColor = false;
            this.UpdateUserFromDatabase_Button.Click += new System.EventHandler(this.UpdateUserFromDatabase_Button_Click);
            // 
            // UserMail_TextBox
            // 
            this.UserMail_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UserMail_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserMail_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.UserMail_TextBox.Location = new System.Drawing.Point(12, 372);
            this.UserMail_TextBox.Name = "UserMail_TextBox";
            this.UserMail_TextBox.Size = new System.Drawing.Size(326, 27);
            this.UserMail_TextBox.TabIndex = 6;
            this.UserMail_TextBox.Text = "  Mail:";
            // 
            // UserPhone_TextBox
            // 
            this.UserPhone_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UserPhone_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPhone_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.UserPhone_TextBox.Location = new System.Drawing.Point(12, 318);
            this.UserPhone_TextBox.Name = "UserPhone_TextBox";
            this.UserPhone_TextBox.Size = new System.Drawing.Size(326, 27);
            this.UserPhone_TextBox.TabIndex = 5;
            this.UserPhone_TextBox.Text = "  Phone:";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Surname_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.Surname_TextBox.Location = new System.Drawing.Point(12, 264);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(326, 27);
            this.Surname_TextBox.TabIndex = 4;
            this.Surname_TextBox.Text = "  Surname:";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.Username_TextBox.Location = new System.Drawing.Point(12, 210);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(326, 27);
            this.Username_TextBox.TabIndex = 3;
            this.Username_TextBox.Text = "  Name:";
            // 
            // Main_Label
            // 
            this.Main_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Main_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.Main_Label.Location = new System.Drawing.Point(0, 105);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(350, 32);
            this.Main_Label.TabIndex = 2;
            this.Main_Label.Text = "DataLand";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserID_TextBox
            // 
            this.UserID_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UserID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserID_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.UserID_TextBox.Location = new System.Drawing.Point(12, 156);
            this.UserID_TextBox.Name = "UserID_TextBox";
            this.UserID_TextBox.Size = new System.Drawing.Size(326, 27);
            this.UserID_TextBox.TabIndex = 8;
            this.UserID_TextBox.Text = "  ID:";
            // 
            // DataLand_UpdateUserMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 488);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataLand_UpdateUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLand_UpdateUserMenu";
            this.Load += new System.EventHandler(this.DataLand_UpdateUserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private VoidButton UpdateUserFromDatabase_Button;
        private System.Windows.Forms.TextBox UserMail_TextBox;
        private System.Windows.Forms.TextBox UserPhone_TextBox;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label Main_Label;
    }
}