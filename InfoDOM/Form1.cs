using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace InfoDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refresh_NewGrid();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startparsing_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.DelatOldDataBase();
            HouseParsed houseParsedStart = new HouseParsed();
            controller.copiHtmlParser();
            houseParsedStart.partParsingCodePages();
        }

        /// <summary>
        /// Loaud BD
        /// </summary>
        public void Refresh_NewGrid()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            ConnectionBD my_sqlConnection = new ConnectionBD();
            my_sqlConnection.ConnectionTheBase(my_sqlConnection.sqlConnection);
            try
            {
                string query = "SELECT * FROM BazaBD ORDER BY Id ";
                SqlCommand command = new SqlCommand(query, my_sqlConnection.sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString(); data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString(); data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString(); data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString(); data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                
                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                label1.Text = "Wczytuję dane z BZ Ukończono pomyślnie";
                reader.Close();
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
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresh_NewGrid();
        }

        private void AdressWWW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HouseParsed houseParsedwww = new HouseParsed();
                houseParsedwww.wwwAddres = this.AdressWWW.Text;
                houseParsedwww.partParsingCodePages();
            }
        }

        private void wwwPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ShowHTML_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.loaudHTMLTextBox();
        }
    }
}
