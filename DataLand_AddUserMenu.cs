using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataLand
{
    public partial class DataLand_AddUserMenu : Form
    {
        OleDbConnection oleDbConnection;

        public DataLand_AddUserMenu()
        {
            InitializeComponent();
        }

        private void DataLand_AddUserMenu_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(Database.databaseString);
        }

        private void AddUserToDatabase_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand AddUserCommand = new OleDbCommand("Insert Into User_Table (User_Name, User_Surname, User_Phone, User_Email) Values (@p1, @p2, @p3, @p4, @p5)", oleDbConnection);
            AddUserCommand.Parameters.AddWithValue("@p1", Username_TextBox.Text);
            AddUserCommand.Parameters.AddWithValue("@p1", Surname_TextBox.Text);
            AddUserCommand.Parameters.AddWithValue("@p1", UserPhone_TextBox.Text);
            AddUserCommand.Parameters.AddWithValue("@p1", UserMail_TextBox);
            AddUserCommand.ExecuteNonQuery();
            oleDbConnection.Close();

            this.Hide();
        }
    }
}
