using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataLand
{
    public partial class DataLand_UpdateUserMenu : Form
    {
        OleDbConnection oleDbConnection;

        public DataLand_UpdateUserMenu()
        {
            InitializeComponent();
        }

        private void DataLand_UpdateUserMenu_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(Database.databaseString);
        }

        private void UpdateUserFromDatabase_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand updateUserCommand = new OleDbCommand("Update User_Table Set User_Name = @p1, User_Surname = @p2, User_Phone = @p3, User_Mail = @p4 Where Used_ID = @p5", oleDbConnection);
            updateUserCommand.Parameters.AddWithValue("@p1", Username_TextBox.Text);
            updateUserCommand.Parameters.AddWithValue("@p2", Surname_TextBox.Text);
            updateUserCommand.Parameters.AddWithValue("@p3", UserPhone_TextBox.Text);
            updateUserCommand.Parameters.AddWithValue("@p4", UserMail_TextBox.Text);
            updateUserCommand.Parameters.AddWithValue("@p5", UserID_TextBox.Text);
            updateUserCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
