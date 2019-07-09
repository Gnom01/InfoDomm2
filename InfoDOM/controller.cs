using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoDOM
{
    class Controller : Form1
    {
        /// <summary>
        /// Delat old data base
        /// </summary>
        public void DelatOldDataBase()
        {
            connectionBD sqlConnection = new connectionBD();
            sqlConnection.ConnectionTheBase(sqlConnection.sqlConnection);
        
            SqlCommand command = new SqlCommand("DELETE [BazaBD]", sqlConnection.sqlConnection);
            command.ExecuteNonQuery();
            Application.Restart();
        }
        
        
    }
}
