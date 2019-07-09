using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoDOM
{
    public partial class Form1 : Form 
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void StartParsing_Click(object sender, EventArgs e)
        {
            HouseParsed houseParsedSearchResult = new HouseParsed();
            houseParsedSearchResult.partParsingCodePages();
        }

        private void deletOldBD_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.DelatOldDataBase();
        }
        public void ChangeText(string text)
        {
             label1.Text = text;
        }

        public void newLableText(string text)
        {
            label1.Text = text;
        }

        public void loaudBD_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
            async void UpdateDataBase()
            {
                connectionBD my_sqlConnection = new connectionBD();
                my_sqlConnection.ConnectionTheBase(my_sqlConnection.sqlConnection);

                try
                {
                    Form1 form = new Form1();
                    form.label1.Text = "Wczytuję dane z BZ.";
                    string query = "SELECT * FROM BazaBD ORDER BY Id ";
                    SqlCommand command = new SqlCommand(query, my_sqlConnection.sqlConnection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    List<string[]> data = new List<string[]>();

                    while (reader.Read())
                    {
                        data.Add(new string[9]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                        data[data.Count - 1][8] = reader[8].ToString();
                    }

                    foreach (string[] s in data)
                    {
                        dataGridView.Rows.Add(s);
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
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}