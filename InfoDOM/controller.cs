using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoDOM
{
    class Controller
    {
        /// <summary>
        /// Delat old data base
        /// </summary>
        public void DelatOldDataBase()
        {
        ConnectionBD sqlConnection = new ConnectionBD();
        sqlConnection.ConnectionTheBase(sqlConnection.sqlConnection);
        SqlCommand command = new SqlCommand("DELETE [BazaBD]", sqlConnection.sqlConnection);
        command.ExecuteNonQuery();
        }
    }
}
