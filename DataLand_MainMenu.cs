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
            this.user_TableTableAdapter.Fill(this.dataLandDataSet.User_Table);

        }
    }
}
