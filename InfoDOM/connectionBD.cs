using System;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace InfoDOM
{
    public class ConnectionBD 
    {
        public SqlConnection sqlConnection;
        public SqlDataReader sqlReader = null;

        public void ConnectionTheBase(SqlConnection sqlConnection)
        {
            try
            {
                string connectionString = @"Data Source=GNOM-MINI1\SQLEXPRESS;Initial Catalog=dsf;Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                this.sqlConnection = sqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                    sqlConnection.Close();
                }
            }
        }



    }
}
