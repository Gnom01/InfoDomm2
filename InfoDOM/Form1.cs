using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InfoDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller container = new Controller();
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
        ///        
        public void Refresh_NewGrid()
        {
            Controller controller = new Controller();
            List<string[]> data = new List<string[]>();
            controller.loaudBD(data);
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            label1.Text = "Wczytuję dane z BZ Ukończono pomyślnie";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Controller container = new Controller();
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
