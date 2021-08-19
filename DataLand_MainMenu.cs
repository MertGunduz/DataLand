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
    public partial class DataLand_MainMenu : Form
    {
        OleDbConnection oleDbConnection;

        public DataLand_MainMenu()
        {
            InitializeComponent();
        }

        private void DataLand_MainMenu_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(Database.databaseString);
            ListTable();
        }

        private void AddUser_VoidButton_Click(object sender, EventArgs e)
        {
            DataLand_AddUserMenu dataLand_AddUserMenu = new DataLand_AddUserMenu();
            dataLand_AddUserMenu.Show();
        }

        private void UpdateUser_VoidButton_Click(object sender, EventArgs e)
        {
            if (Database.userName != null || Database.userSurname != null || Database.userPhone != null || Database.userMail != null)
            {
                DataLand_UpdateUserMenu dataLand_UpdateUserMenu = new DataLand_UpdateUserMenu();
                dataLand_UpdateUserMenu.Show();
            }
            else
            {
                MessageBox.Show("Please Select A Row From Table By Clicking To A Row!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser_VoidButton_Click(object sender, EventArgs e)
        {

        }

        private void ListUsers_VoidButton_Click(object sender, EventArgs e)
        {
            ListTable();
        }

        private void Exit_VoidButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                Database.userID = User_DataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                Database.userName = User_DataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                Database.userSurname = User_DataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                Database.userPhone = User_DataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                Database.userMail = User_DataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            }
            catch (Exception excetpion)
            {
                MessageBox.Show(excetpion.Message);
            }
        }

        private void ListTable()
        {
            oleDbConnection.Open();

            DataTable dataTable = new DataTable();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            oleDbDataAdapter.SelectCommand = new OleDbCommand("Select * From User_Table", oleDbConnection);
            oleDbDataAdapter.Fill(dataTable);

            User_DataGridView.DataSource = dataTable;
        }
    }
}
