using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoDOM
{
    public class HouseParsed : ConnectionBD
    {
        ConnectionBD connection = new ConnectionBD();
       
        public void StartPrsingSet(string wwwAddresForm, string nrPag, string CodeBlockHtml1, string CodeBlockHtml2, string textBloc1_1, string textBloc1_2, string textBloc2_1, string textBloc2_2, string textBloc3_1,
          string textBloc3_2, string textBloc4_1, string textBloc4_2, string textBloc5_1, string textBloc5_2,
          string textBloc6_1, string textBloc6_2, string textBloc7_1, string textBloc7_2, string numberPage1_1, string numberPage1_2)
        {
            Controller controller = new Controller();
            controller.DelatOldDataBase();
            
            connection.ConnectionTheBase(connection.sqlConnection);

            int numberOfPages = 1;
            int identifierOfBase = 1;
            int listNumberPages = 1;

            for (int i = 1; i <= numberOfPages; i++)
            {
                
                nrPag = listNumberPages.ToString();

                String Response;
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.Encoding = Encoding.GetEncoding("UTF-8");
                Response = wc.DownloadString(wwwAddresForm + nrPag);
                string partParsingCode = $@"{CodeBlockHtml1}(.*?){CodeBlockHtml2}";
                RegexOptions optionsRegex = RegexOptions.Singleline;
                Regex regexMatch = new Regex(partParsingCode, optionsRegex);
                MatchCollection parStringtParsingCode = regexMatch.Matches(Response);
               

                int numberCollectionString = 0;
                try
                {
                    foreach (Match m in parStringtParsingCode)
                    {
                        ConnectionBD connectionString = new ConnectionBD();
                        connectionString.ConnectionTheBase(connectionString.sqlConnection);
                        SqlCommand command = new SqlCommand("INSERT INTO[BazaBD](Id, Title1, m2_1 , m2_2 , cena1, lokalizacja, id1, pokoje, list)" +
                                                             "VALUES          (@Id, @Title1, @m2_1, @m2_2, @cena1, @lokalizacja, @id1, @pokoje, @list)",
                                                             connectionString.sqlConnection);

                        string TitleString = $@"{textBloc1_1}(.*?){textBloc1_2}";
                        Regex newTitleString = new Regex(TitleString, optionsRegex);
                        Match titleSample = newTitleString.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string title = titleSample.Groups[1].Value;
                        command.Parameters.AddWithValue("Title1", title.ToString());

                        string houseAreaString = $@"{textBloc2_1}(.*?){textBloc2_2}";
                        Regex houseAreaSample = new Regex(houseAreaString, optionsRegex);
                        Match houseArea = houseAreaSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string area = houseArea.Groups[1].Value;
                        command.Parameters.AddWithValue("m2_1", area.ToString());

                        string AreaYardString = $@"{textBloc3_1}(.*?){textBloc3_2}";
                        Regex AreaYardSample = new Regex(AreaYardString, optionsRegex);
                        Match AreaYardNew = AreaYardSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string areaYard = AreaYardNew.Groups[1].Value;
                        command.Parameters.AddWithValue("m2_2", areaYard.ToString());

                        string priceString = $@"{textBloc4_1}(.*?){textBloc4_2}";
                        Regex priceSample = new Regex(priceString, optionsRegex);
                        Match Price = priceSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string price = Price.Groups[1].Value;
                        command.Parameters.AddWithValue("cena1", price.ToString());

                        string locationString = $@"{textBloc5_1}(.*?){textBloc5_2}";
                        Regex locationSample = new Regex(locationString, optionsRegex);
                        Match Location = locationSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string location = Location.Groups[1].Value;
                        command.Parameters.AddWithValue("lokalizacja", location.ToString());

                        string IdentifierString = $@"{textBloc6_1}(.*?){textBloc6_2}";
                        Regex IdentifierSample = new Regex(IdentifierString, optionsRegex);
                        Match IdentifierNew = IdentifierSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
                        string identifier = IdentifierNew.Groups[1].Value;
                        command.Parameters.AddWithValue("id1", identifier.ToString());

                        string RoomCountString = $@"{textBloc7_1}(.*?){textBloc7_2}";
                        Regex RoomCountSample = new Regex(RoomCountString, optionsRegex);
                        Match RoomCountNew = RoomCountSample.Match(Convert.ToString(parStringtParsingCode[numberCollectionString]));
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
                    listNumberPages++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}