
namespace DataLand
{
    partial class DataLand_MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLand_MainMenu));
            this.MainMenu_Panel = new System.Windows.Forms.Panel();
            this.Top_Border = new System.Windows.Forms.Panel();
            this.Bottom_Border = new System.Windows.Forms.Panel();
            this.Right_Border = new System.Windows.Forms.Panel();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Main_Label = new System.Windows.Forms.Label();
            this.User_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataLandDataSet = new DataLand.DataLandDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_TableTableAdapter = new DataLand.DataLandDataSetTableAdapters.User_TableTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit_VoidButton = new DataLand.VoidButton();
            this.DeleteUser_VoidButton = new DataLand.VoidButton();
            this.UpdateUser_VoidButton = new DataLand.VoidButton();
            this.AddUser_VoidButton = new DataLand.VoidButton();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.MainMenu_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu_Panel
            // 
            this.MainMenu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MainMenu_Panel.Controls.Add(this.User_DataGridView);
            this.MainMenu_Panel.Controls.Add(this.Top_Border);
            this.MainMenu_Panel.Controls.Add(this.Bottom_Border);
            this.MainMenu_Panel.Controls.Add(this.Right_Border);
            this.MainMenu_Panel.Controls.Add(this.Left_Panel);
            this.MainMenu_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_Panel.Name = "MainMenu_Panel";
            this.MainMenu_Panel.Size = new System.Drawing.Size(800, 400);
            this.MainMenu_Panel.TabIndex = 0;
            // 
            // Top_Border
            // 
            this.Top_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Top_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Border.Location = new System.Drawing.Point(176, 0);
            this.Top_Border.Name = "Top_Border";
            this.Top_Border.Size = new System.Drawing.Size(621, 3);
            this.Top_Border.TabIndex = 3;
            // 
            // Bottom_Border
            // 
            this.Bottom_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Bottom_Border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Border.Location = new System.Drawing.Point(176, 397);
            this.Bottom_Border.Name = "Bottom_Border";
            this.Bottom_Border.Size = new System.Drawing.Size(621, 3);
            this.Bottom_Border.TabIndex = 2;
            // 
            // Right_Border
            // 
            this.Right_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Border.Location = new System.Drawing.Point(797, 0);
            this.Right_Border.Name = "Right_Border";
            this.Right_Border.Size = new System.Drawing.Size(3, 400);
            this.Right_Border.TabIndex = 1;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Left_Panel.Controls.Add(this.Exit_VoidButton);
            this.Left_Panel.Controls.Add(this.DeleteUser_VoidButton);
            this.Left_Panel.Controls.Add(this.UpdateUser_VoidButton);
            this.Left_Panel.Controls.Add(this.AddUser_VoidButton);
            this.Left_Panel.Controls.Add(this.Main_Label);
            this.Left_Panel.Controls.Add(this.Logo_PictureBox);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(176, 400);
            this.Left_Panel.TabIndex = 0;
            // 
            // Main_Label
            // 
            this.Main_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Main_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.Main_Label.Location = new System.Drawing.Point(0, 108);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(176, 32);
            this.Main_Label.TabIndex = 1;
            this.Main_Label.Text = "DataLand";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_DataGridView
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.User_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.User_DataGridView.AutoGenerateColumns = false;
            this.User_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.User_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userSurnameDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userMailDataGridViewTextBoxColumn});
            this.User_DataGridView.DataSource = this.userTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.User_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.User_DataGridView.Location = new System.Drawing.Point(176, 3);
            this.User_DataGridView.Name = "User_DataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.User_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.User_DataGridView.Size = new System.Drawing.Size(621, 394);
            this.User_DataGridView.TabIndex = 4;
            this.User_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_DataGridView_CellClick);
            // 
            // dataLandDataSet
            // 
            this.dataLandDataSet.DataSetName = "DataLandDataSet";
            this.dataLandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "User_Table";
            this.userTableBindingSource.DataSource = this.dataLandDataSet;
            // 
            // user_TableTableAdapter
            // 
            this.user_TableTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userSurnameDataGridViewTextBoxColumn
            // 
            this.userSurnameDataGridViewTextBoxColumn.DataPropertyName = "User_Surname";
            this.userSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.userSurnameDataGridViewTextBoxColumn.Name = "userSurnameDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "User_Phone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userMailDataGridViewTextBoxColumn
            // 
            this.userMailDataGridViewTextBoxColumn.DataPropertyName = "User_Mail";
            this.userMailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.userMailDataGridViewTextBoxColumn.Name = "userMailDataGridViewTextBoxColumn";
            // 
            // Exit_VoidButton
            // 
            this.Exit_VoidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Exit_VoidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_VoidButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit_VoidButton.FlatAppearance.BorderSize = 0;
            this.Exit_VoidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Exit_VoidButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Exit_VoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_VoidButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Exit_VoidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.Exit_VoidButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.Exit_VoidButton.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredExitIcon_png;
            this.Exit_VoidButton.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredExitIcon_png;
            this.Exit_VoidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_VoidButton.Location = new System.Drawing.Point(0, 355);
            this.Exit_VoidButton.Name = "Exit_VoidButton";
            this.Exit_VoidButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Exit_VoidButton.Size = new System.Drawing.Size(176, 45);
            this.Exit_VoidButton.TabIndex = 6;
            this.Exit_VoidButton.Text = "Exit";
            this.Exit_VoidButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_VoidButton.UseVisualStyleBackColor = false;
            this.Exit_VoidButton.Click += new System.EventHandler(this.Exit_VoidButton_Click);
            // 
            // DeleteUser_VoidButton
            // 
            this.DeleteUser_VoidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUser_VoidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUser_VoidButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteUser_VoidButton.FlatAppearance.BorderSize = 0;
            this.DeleteUser_VoidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUser_VoidButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteUser_VoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUser_VoidButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteUser_VoidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.DeleteUser_VoidButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.DeleteUser_VoidButton.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredDeleteIcon_png;
            this.DeleteUser_VoidButton.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredDeleteIcon_png;
            this.DeleteUser_VoidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteUser_VoidButton.Location = new System.Drawing.Point(0, 230);
            this.DeleteUser_VoidButton.Name = "DeleteUser_VoidButton";
            this.DeleteUser_VoidButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.DeleteUser_VoidButton.Size = new System.Drawing.Size(176, 45);
            this.DeleteUser_VoidButton.TabIndex = 4;
            this.DeleteUser_VoidButton.Text = "Delete User";
            this.DeleteUser_VoidButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUser_VoidButton.UseVisualStyleBackColor = false;
            this.DeleteUser_VoidButton.Click += new System.EventHandler(this.DeleteUser_VoidButton_Click);
            // 
            // UpdateUser_VoidButton
            // 
            this.UpdateUser_VoidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUser_VoidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateUser_VoidButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateUser_VoidButton.FlatAppearance.BorderSize = 0;
            this.UpdateUser_VoidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUser_VoidButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateUser_VoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUser_VoidButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateUser_VoidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.UpdateUser_VoidButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.UpdateUser_VoidButton.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredUpdateIcon_png;
            this.UpdateUser_VoidButton.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredUpdateIcon_png;
            this.UpdateUser_VoidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateUser_VoidButton.Location = new System.Drawing.Point(0, 185);
            this.UpdateUser_VoidButton.Name = "UpdateUser_VoidButton";
            this.UpdateUser_VoidButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.UpdateUser_VoidButton.Size = new System.Drawing.Size(176, 45);
            this.UpdateUser_VoidButton.TabIndex = 3;
            this.UpdateUser_VoidButton.Text = "Update User";
            this.UpdateUser_VoidButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateUser_VoidButton.UseVisualStyleBackColor = false;
            this.UpdateUser_VoidButton.Click += new System.EventHandler(this.UpdateUser_VoidButton_Click);
            // 
            // AddUser_VoidButton
            // 
            this.AddUser_VoidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddUser_VoidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser_VoidButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddUser_VoidButton.FlatAppearance.BorderSize = 0;
            this.AddUser_VoidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddUser_VoidButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddUser_VoidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser_VoidButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddUser_VoidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.AddUser_VoidButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.AddUser_VoidButton.HoverPicture = global::DataLand.Properties.Resources.DataLand_HoveredAddIcon;
            this.AddUser_VoidButton.Image = global::DataLand.Properties.Resources.DataLand_NonHoveredAddIcon;
            this.AddUser_VoidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUser_VoidButton.Location = new System.Drawing.Point(0, 140);
            this.AddUser_VoidButton.Name = "AddUser_VoidButton";
            this.AddUser_VoidButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.AddUser_VoidButton.Size = new System.Drawing.Size(176, 45);
            this.AddUser_VoidButton.TabIndex = 2;
            this.AddUser_VoidButton.Text = "Add User";
            this.AddUser_VoidButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUser_VoidButton.UseVisualStyleBackColor = false;
            this.AddUser_VoidButton.Click += new System.EventHandler(this.AddUser_VoidButton_Click);
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_PictureBox.Image = global::DataLand.Properties.Resources.DataLand_MainTopLogoIcon;
            this.Logo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(176, 108);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // DataLand_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.MainMenu_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataLand_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLand";
            this.Load += new System.EventHandler(this.DataLand_MainMenu_Load);
            this.MainMenu_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenu_Panel;
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.Panel Right_Border;
        private System.Windows.Forms.Panel Top_Border;
        private System.Windows.Forms.Panel Bottom_Border;
        private VoidButton Exit_VoidButton;
        private VoidButton DeleteUser_VoidButton;
        private VoidButton UpdateUser_VoidButton;
        private VoidButton AddUser_VoidButton;
        private System.Windows.Forms.DataGridView User_DataGridView;
        private DataLandDataSet dataLandDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private DataLandDataSetTableAdapters.User_TableTableAdapter user_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMailDataGridViewTextBoxColumn;
    }
}

