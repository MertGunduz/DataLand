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
            this.user_TableTableAdapter.Fill(this.dataLandDataSet.User_Table);
        }

        private void AddUser_VoidButton_Click(object sender, EventArgs e)
        {

        }
    }
}
