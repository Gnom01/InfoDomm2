using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoDOM
{
    public class HouseParsed : ConnectionBD
    {
        Form1 form1 = new Form1();

        public int numberOfPages = 1;
        public int identifierOfBase = 1;
        public int listNumberPages = 1;
        public string wwwAddresForm;
        public int nrPag = 1;
        public string CodeBlockHtml1; 
        public string CodeBlockHtml2;
        public string textBloc1_1 ;
        public string textBloc1_2;
        public string textBloc2_1;
        public string textBloc2_2;
        public string textBloc3_1;
        public string textBloc3_2;
        public string textBloc4_1;
        public string textBloc4_2;
        public string textBloc5_1;
        public string textBloc5_2;
        public string textBloc6_1;
        public string textBloc6_2;
        public string textBloc7_1;
        public string textBloc7_2;
        public string textBloc8_1;
        public string textBloc8_2;
        public string numberPage1_1;
        public string numberPage1_2;
        public String Response;
       

        public void copiHtmlParser()
        {
            textBloc1_1 = form1.textBox1_1.Text;
            textBloc1_2 = form1.textBox1_2.Text;
            textBloc2_1 = form1.textBox2_1.Text;
            textBloc2_2 = form1.textBox2_2.Text;
            textBloc3_1 = form1.textBox3_1.Text;
            textBloc3_2 = form1.textBox3_2.Text;
            textBloc4_1 = form1.textBox4_1.Text;
            textBloc4_2 = form1.textBox4_2.Text;
            textBloc5_1 = form1.textBox5_1.Text;
            textBloc5_2 = form1.textBox5_2.Text;
            textBloc6_1 = form1.textBox6_1.Text;
            textBloc6_2 = form1.textBox6_2.Text;
            textBloc7_1 = form1.textBox7_1.Text;
            textBloc7_2 = form1.textBox7_2.Text;
            numberPage1_1 = form1.textBox8_1.Text;
            numberPage1_2 = form1.textBox8_2.Text;

            if (string.IsNullOrWhiteSpace(form1.CodeBlockHtml1.Text))
            {
                throw new ArgumentNullException("Początek bloku kodu muśi być wpisany ", nameof(CodeBlockHtml1));
            }
            else
            {
                CodeBlockHtml1 = form1.CodeBlockHtml1.Text;
            }

            if (string.IsNullOrWhiteSpace(form1.CodeBlockHtml2.Text))
            {
                throw new ArgumentNullException("Koniec bloku kodu muśi być wpisany!", nameof(CodeBlockHtml2));
            }
            else
            {
                CodeBlockHtml2 = form1.CodeBlockHtml2.Text;
            }

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
                nrPag = Convert.ToInt32(form1.wwwPag.Text);
            }
        }

        public void partParsingCodePages()
        {
            ConnectionBD connection = new ConnectionBD();
           copiHtmlParser();
            connection.ConnectionTheBase(connection.sqlConnection);
            for (int i = 1; i <= numberOfPages; i++)
            {
                nrPag = listNumberPages;
                Form1 form1 = new Form1();
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.Encoding = Encoding.GetEncoding("UTF-8");
                Response = wc.DownloadString(wwwAddresForm + nrPag);
                string partParsingCode = $@"{CodeBlockHtml1}(.*?){CodeBlockHtml2}";
                RegexOptions optionsRegex = RegexOptions.Singleline;
                Regex regexMatch = new Regex(partParsingCode, optionsRegex);
                MatchCollection parStringtParsingCode = regexMatch.Matches(Response);
                StartPrsingSet(parStringtParsingCode, optionsRegex);
                ++listNumberPages;
            }
        }

        public void StartPrsingSet(MatchCollection ParsingString, RegexOptions optionsRegex)
        {
            int numberCollectionString = 0;
            try
            {
                foreach (Match m in ParsingString)
                {
                    ConnectionBD connectionString = new ConnectionBD();
                    connectionString.ConnectionTheBase(connectionString.sqlConnection);
                    SqlCommand command = new SqlCommand("INSERT INTO[BazaBD](Id, Title1, m2_1 , m2_2 , cena1, lokalizacja, id1, pokoje, list)" +
                                                         "VALUES          (@Id, @Title1, @m2_1, @m2_2, @cena1, @lokalizacja, @id1, @pokoje, @list)", 
                                                         connectionString.sqlConnection);

                    string TitleString = $@"{textBloc1_1}(.*?){textBloc1_2}";
                    Regex newTitleString = new Regex(TitleString, optionsRegex);
                    Match titleSample = newTitleString.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string title = titleSample.Groups[1].Value;
                    command.Parameters.AddWithValue("Title1", title.ToString());

                    string houseAreaString = $@"{textBloc2_1}(.*?){textBloc2_2}";
                    Regex houseAreaSample = new Regex(houseAreaString, optionsRegex);
                    Match houseArea = houseAreaSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string area = houseArea.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_1", area.ToString());

                    string AreaYardString = $@"{textBloc3_1}(.*?){textBloc3_2}";
                    Regex AreaYardSample = new Regex(AreaYardString, optionsRegex);
                    Match AreaYardNew = AreaYardSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string areaYard = AreaYardNew.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_2", areaYard.ToString());

                    string priceString = $@"{textBloc4_1}(.*?){textBloc4_2}";
                    Regex priceSample = new Regex(priceString, optionsRegex);
                    Match Price = priceSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string price = Price.Groups[1].Value; 
                    command.Parameters.AddWithValue("cena1", price.ToString());

                    string locationString = $@"{textBloc5_1}(.*?){textBloc5_2}";
                    Regex locationSample = new Regex(locationString, optionsRegex);
                    Match Location = locationSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string location = Location.Groups[1].Value; 
                    command.Parameters.AddWithValue("lokalizacja", location.ToString());

                    string IdentifierString = $@"{textBloc6_1}(.*?){textBloc6_2}";
                    Regex IdentifierSample = new Regex(IdentifierString, optionsRegex);
                    Match IdentifierNew = IdentifierSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string identifier = IdentifierNew.Groups[1].Value;
                    command.Parameters.AddWithValue("id1", identifier.ToString());

                    string RoomCountString = $@"{textBloc7_1}(.*?){textBloc7_2}";
                    Regex RoomCountSample = new Regex(RoomCountString, optionsRegex);
                    Match RoomCountNew = RoomCountSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    string roomCount = RoomCountNew.Groups[1].Value;
                    command.Parameters.AddWithValue("pokoje", roomCount.ToString());

                    String NumberOfPagesString = System.Text.RegularExpressions.Regex.Match(Response, $@"{numberPage1_1}(.*?){numberPage1_2}").Groups[1].Value;
                    numberOfPages = Convert.ToInt32(NumberOfPagesString);
                    command.Parameters.AddWithValue("list", listNumberPages);
                    command.Parameters.AddWithValue("Id", identifierOfBase);
                    command.ExecuteNonQuery(); 

                    identifierOfBase++;
                    numberCollectionString++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
