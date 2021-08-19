using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataLand
{
    public partial class DataLand_DeleteUserMenu : Form
    {
        OleDbConnection oleDbConnection;
        public DataLand_DeleteUserMenu()
        {
            InitializeComponent();
        }
        private void DataLand_DeleteUserMenu_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(Database.databaseString);
            UserID_TextBox.Text = Database.userID;
        }

        private void DeleteUserFromDatabase_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand deleteUserCommand = new OleDbCommand("Delete From User_Table Where User_ID = @p1", oleDbConnection);
            deleteUserCommand.Parameters.AddWithValue("@p1", Database.userID);
            deleteUserCommand.ExecuteNonQuery();
            oleDbConnection.Close();

            Database.userID = null;
            Database.userName = null;
            Database.userSurname = null;
            Database.userPhone = null;
            Database.userMail = null;

            this.Close();
        }
    }
}
