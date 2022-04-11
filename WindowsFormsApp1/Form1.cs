using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FormWeek7 : Form
    {
        public FormWeek7()
        {
            InitializeComponent();
            
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter; 
        public string sqlQuery;


        private void FormWeek7_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
            DataTable dtPlayer = new DataTable();
            //mulai dari sini 
            sqlQuery = txbQuery.Text;
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            //sampai disini 
            dvgPlayer.DataSource = dtPlayer;
        }
    }
}
