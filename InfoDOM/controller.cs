using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
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

        public void loaudHTMLTextBox(string wwwAddresForm, string nrPag)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            HouseParsed houseParsedStart = new HouseParsed();
            if (string.IsNullOrWhiteSpace(form1.AdressWWW.Text))
            {
                throw new ArgumentNullException("Adres strony nie morze być pusty!");
            }
            else
            {
                wwwAddresForm = form1.AdressWWW.Text;
            }

            if (form1.wwwPag.Text.Equals(null))
            {
                throw new ArgumentNullException("Numeracja strony nie morze być pusta!");
            }
            else
            {
                nrPag = form1.wwwPag.Text;
            }
            String Response2;
            System.Net.WebClient wc2 = new System.Net.WebClient();
            wc2.Encoding = Encoding.GetEncoding("UTF-8");
            Response2 = wc2.DownloadString(wwwAddresForm + nrPag);
            if (string.IsNullOrWhiteSpace(Response2))
            {
                throw new ArgumentNullException("Adres strony nie jest poprawny!");
            }
            else
            {
                form2.textBox(Response2);
                form2.Show();
            }
        }

        public string loaudBD(List<string[]> data)
        {
            ConnectionBD my_sqlConnection = new ConnectionBD();
            my_sqlConnection.ConnectionTheBase(my_sqlConnection.sqlConnection);

            try
            {
                string query = "SELECT * FROM BazaBD ORDER BY Id ";
                SqlCommand command = new SqlCommand(query, my_sqlConnection.sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                //List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString(); data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString(); data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString(); data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString(); data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                return string.Join(" ", data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (my_sqlConnection.sqlReader != null)
                {
                    my_sqlConnection.sqlReader.Close();
                    my_sqlConnection.sqlConnection.Close();
                }
            }
            return string.Join(" ", data);
        }
    }
}
