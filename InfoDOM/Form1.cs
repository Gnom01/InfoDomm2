﻿using System;
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
            Refresh_NewGrid();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startparsing_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            HouseParsed houseParsedStart = new HouseParsed();

            houseParsedStart.StartPrsingSet(AdressWWW.Text, wwwPag.Text, CodeBlockHtml1.Text, CodeBlockHtml2.Text, textBox1_1.Text, textBox1_2.Text, textBox2_1.Text, 
                textBox2_2.Text, textBox3_1.Text, textBox3_2.Text, textBox4_1.Text, textBox4_2.Text, textBox5_1.Text, textBox5_2.Text, 
                textBox6_1.Text, textBox6_2.Text, textBox7_1.Text, textBox7_2.Text, textBox8_1.Text, textBox8_2.Text);
            controller.DelatOldDataBase();
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
            controller.loaudHTMLTextBox(AdressWWW.Text, wwwPag.Text);
        }
       
    }
}
