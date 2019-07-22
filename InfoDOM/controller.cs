using System;
using System.Data.SqlClient;
using System.Text;

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
    }
}
