
namespace DataLand
{
    partial class DataLand_DeleteUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLand_DeleteUserMenu));
            this.Main_Label = new System.Windows.Forms.Label();
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            this.DeleteUserFromDatabase_Button = new DataLand.VoidButton();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
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
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Mid_Panel.Controls.Add(this.UserID_TextBox);
            this.Mid_Panel.Controls.Add(this.DeleteUserFromDatabase_Button);
            this.Mid_Panel.Controls.Add(this.Main_Label);
            this.Mid_Panel.Controls.Add(this.Logo_PictureBox);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(350, 263);
            this.Mid_Panel.TabIndex = 2;
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
            // DeleteUserFromDatabase_Button
            // 
            this.DeleteUserFromDatabase_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUserFromDatabase_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUserFromDatabase_Button.FlatAppearance.BorderSize = 0;
            this.DeleteUserFromDatabase_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUserFromDatabase_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUserFromDatabase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserFromDatabase_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteUserFromDatabase_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.DeleteUserFromDatabase_Button.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.DeleteUserFromDatabase_Button.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredDeleteIcon_png;
            this.DeleteUserFromDatabase_Button.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredDeleteIcon_png;
            this.DeleteUserFromDatabase_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteUserFromDatabase_Button.Location = new System.Drawing.Point(12, 204);
            this.DeleteUserFromDatabase_Button.Name = "DeleteUserFromDatabase_Button";
            this.DeleteUserFromDatabase_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.DeleteUserFromDatabase_Button.Size = new System.Drawing.Size(326, 40);
            this.DeleteUserFromDatabase_Button.TabIndex = 7;
            this.DeleteUserFromDatabase_Button.Text = "Delete User";
            this.DeleteUserFromDatabase_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUserFromDatabase_Button.UseVisualStyleBackColor = false;
            this.DeleteUserFromDatabase_Button.Click += new System.EventHandler(this.DeleteUserFromDatabase_Button_Click);
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
            // DataLand_DeleteUserMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataLand_DeleteUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLand";
            this.Load += new System.EventHandler(this.DataLand_DeleteUserMenu_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private VoidButton DeleteUserFromDatabase_Button;
    }
}