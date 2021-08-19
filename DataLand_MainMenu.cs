using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLand
{
    public partial class DataLand_MainMenu : Form
    {
        public DataLand_MainMenu()
        {
            InitializeComponent();
        }

        private void DataLand_MainMenu_Load(object sender, EventArgs e)
        {
            // Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\u\Desktop\DataLand.accdb
            // TODO: This line of code loads data into the 'dataLandDataSet.User_Table' table. You can move, or remove it, as needed.
            this.user_TableTableAdapter.Fill(this.dataLandDataSet.User_Table);
        }
    }
}
