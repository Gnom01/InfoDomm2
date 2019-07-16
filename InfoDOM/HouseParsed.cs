using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoDOM
{
    public class HouseParsed : ConnectionBD
    {
        String Response;
        public string title;
        public string area;
        public string areaYard;
        public string price;
        public string location;
        public string identifier;
        public string roomCount;
        public int numberOfPages = 1;
        public int identifierOfBase = 1;
        public int listNumberPages = 1;
        public string wwwAddres;
        public int nrPag;
        public string CodeBlockHtml1; 
        public string CodeBlockHtml2;
        public string textBloc1_1;
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
        public string wwwAddressWhole;

        public void partParsingCodePages()
        {
            ConnectionBD connection = new ConnectionBD();
           
            connection.ConnectionTheBase(connection.sqlConnection);
            for (int i = 1; i <= numberOfPages; i++)
            {
                nrPag = listNumberPages;
                wwwAddressWhole = wwwAddres + nrPag;
                Form1 form1 = new Form1();
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.Encoding = Encoding.GetEncoding("UTF-8");
                Response = wc.DownloadString(wwwAddressWhole);
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
                    title = titleSample.Groups[1].Value;
                    command.Parameters.AddWithValue("Title1", title.ToString());

                    string houseAreaString = $@"{textBloc2_1}(.*?){textBloc2_2}";
                    Regex houseAreaSample = new Regex(houseAreaString, optionsRegex);
                    Match houseArea = houseAreaSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    area = houseArea.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_1", area.ToString());

                    string AreaYardString = $@"{textBloc3_1}(.*?){textBloc3_2}";
                    Regex AreaYardSample = new Regex(AreaYardString, optionsRegex);
                    Match AreaYardNew = AreaYardSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    areaYard = AreaYardNew.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_2", areaYard.ToString());

                    string priceString = $@"{textBloc4_1}(.*?){textBloc4_2}";
                    Regex priceSample = new Regex(priceString, optionsRegex);
                    Match Price = priceSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    price = Price.Groups[1].Value; 
                    command.Parameters.AddWithValue("cena1", price.ToString());

                    string locationString = $@"{textBloc5_1}(.*?){textBloc5_2}";
                    Regex locationSample = new Regex(locationString, optionsRegex);
                    Match Location = locationSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    location = Location.Groups[1].Value; 
                    command.Parameters.AddWithValue("lokalizacja", location.ToString());

                    string IdentifierString = $@"{textBloc6_1}(.*?){textBloc6_2}";
                    Regex IdentifierSample = new Regex(IdentifierString, optionsRegex);
                    Match IdentifierNew = IdentifierSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    identifier = IdentifierNew.Groups[1].Value;
                    command.Parameters.AddWithValue("id1", identifier.ToString());

                    string RoomCountString = $@"{textBloc7_1}(.*?){textBloc7_2}";
                    Regex RoomCountSample = new Regex(RoomCountString, optionsRegex);
                    Match RoomCountNew = RoomCountSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    roomCount = RoomCountNew.Groups[1].Value;
                    command.Parameters.AddWithValue("pokoje", roomCount.ToString());

                    String NumberOfPagesString = System.Text.RegularExpressions.Regex.Match(Response, @"<input id=""pageParam"" type=""number"" name=""page"" placeholder=""(.*?)"" class=""input-number-noSpinners"">").Groups[1].Value;
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
