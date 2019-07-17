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

        public void loaudHTMLTextBox()
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            string Response;
            HouseParsed houseParsedStart = new HouseParsed();
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Encoding = Encoding.GetEncoding("UTF-8");
            Response = wc.DownloadString(form1.AdressWWW.Text + form1.wwwPag.Text);
            if (string.IsNullOrWhiteSpace(Response))
            {
                throw new ArgumentNullException("Adres strony nie jest poprawny!");
            }
            else
            {
                form2.textBox(Response);
                form2.Show();
            }
        }
        public void copiHtmlParser()
        {
            HouseParsed houseParsedStart = new HouseParsed();
            Form1 form1 = new Form1();

            if (string.IsNullOrWhiteSpace(form1.CodeBlockHtml1.Text))
            {
                throw new ArgumentNullException("Początek bloku kodu muśi być wpisany ", nameof(houseParsedStart.CodeBlockHtml1));
            }
            else
            {
                houseParsedStart.CodeBlockHtml1 = form1.CodeBlockHtml1.Text;
            }

            if (string.IsNullOrWhiteSpace(form1.CodeBlockHtml2.Text))
            {
                throw new ArgumentNullException("Koniec bloku kodu muśi być wpisany!", nameof(houseParsedStart.CodeBlockHtml2));
            }
            else
            {
                houseParsedStart.CodeBlockHtml2 = form1.CodeBlockHtml2.Text;
            }

            houseParsedStart.textBloc1_1 = form1.textBox1_1.Text;
            houseParsedStart.textBloc1_2 = form1.textBox1_2.Text;
            houseParsedStart.textBloc2_1 = form1.textBox2_1.Text;
            houseParsedStart.textBloc2_2 = form1.textBox2_2.Text;
            houseParsedStart.textBloc3_1 = form1.textBox3_1.Text;
            houseParsedStart.textBloc3_2 = form1.textBox3_2.Text;
            houseParsedStart.textBloc4_1 = form1.textBox4_1.Text;
            houseParsedStart.textBloc4_2 = form1.textBox4_2.Text;
            houseParsedStart.textBloc5_1 = form1.textBox5_1.Text;
            houseParsedStart.textBloc5_2 = form1.textBox5_2.Text;
            houseParsedStart.textBloc6_1 = form1.textBox6_1.Text;
            houseParsedStart.textBloc6_2 = form1.textBox6_2.Text;
            houseParsedStart.textBloc7_1 = form1.textBox7_1.Text;
            houseParsedStart.textBloc7_2 = form1.textBox7_2.Text;
            houseParsedStart.numberPage1_1 = form1.textBox8_1.Text;
            houseParsedStart.numberPage1_2 = form1.textBox8_2.Text;

            if (string.IsNullOrWhiteSpace(form1.AdressWWW.Text))
            {
                throw new ArgumentNullException("Adres strony nie morze być pusty!");
            }
            else
            {
                houseParsedStart.wwwAddres = form1.AdressWWW.Text;
            }

            if (form1.wwwPag.Text.Equals(null))
            {
                throw new ArgumentNullException("Numeracja strony nie morze być pusta!");
            }
            else
            {
                houseParsedStart.nrPag = Convert.ToInt32(form1.wwwPag.Text);
            }
        }

    }
}
