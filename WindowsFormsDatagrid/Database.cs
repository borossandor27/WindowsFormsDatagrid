using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsDatagrid
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Password = "";
            builder.UserID = "root";
            builder.Database = "orszagok";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ToString());
            try
            {
                connection.Open();
                command = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
