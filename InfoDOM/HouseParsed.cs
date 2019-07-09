using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoDOM
{
    public class HouseParsed : connectionBD
    {
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
        String Response;

        public void partParsingCodePages()
        {
            connectionBD connection = new connectionBD();

            connection.ConnectionTheBase(connection.sqlConnection);
            for (int i = 1; i <= numberOfPages; i++)
            {
               
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.Encoding = Encoding.GetEncoding("UTF-8");
                Response = wc.DownloadString("https://www.otodom.pl/sprzedaz/dom/warszawa/?search%5Bfilter_float_m%3Ato%5D=500&search%5Bdescription%5D=1&search%5Bdist%5D=25&search%5Bsubregion_id%5D=197&search%5Bcity_id%5D=26&page=1");
                string partParsingCode = @"<div class=""offer-item-details"">(.*?)<div class=""offer-item-details-bottom"" data-tracking=""click_body"" data-tracking-data=";
                RegexOptions optionsRegex = RegexOptions.Singleline;
                Regex regexMatch = new Regex(partParsingCode, optionsRegex);
                MatchCollection parStringtParsingCode = regexMatch.Matches(Response);
                StartPrsingSet(parStringtParsingCode, optionsRegex);
                listNumberPages++;
            }
        }

        public void StartPrsingSet(MatchCollection ParsingString, RegexOptions optionsRegex)
        {
            int numberCollectionString = 0;
            try
            {
                foreach (Match m in ParsingString)
                {
                    connectionBD connectionString = new connectionBD();
                    connectionString.ConnectionTheBase(connectionString.sqlConnection);
                    SqlCommand command = new SqlCommand("INSERT INTO[BazaBD](Id, Title1, m2_1 , m2_2 , cena1, lokalizacja, id1, pokoje, list)VALUES(@Id, @Title1, @m2_1, @m2_2, @cena1, @lokalizacja, @id1, @pokoje, @list)", connectionString.sqlConnection);

                    string TitleString = @"<span class=""offer-item-title"">(.*?)</span>";
                    Regex newTitleString = new Regex(TitleString, optionsRegex);
                    Match titleSample = newTitleString.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    title = titleSample.Groups[1].Value;
                    command.Parameters.AddWithValue("Title1", title.ToString());

                    string houseAreaString = @"<strong class=""visible-xs-block"">(.*?)\s+m²</strong>";
                    Regex houseAreaSample = new Regex(houseAreaString, optionsRegex);
                    Match houseArea = houseAreaSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    area = houseArea.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_1", area.ToString());

                    string AreaYardString = @"<li class=""hidden-xs offer-item-area"">działka(.*?)</li>";
                    Regex AreaYardSample = new Regex(AreaYardString, optionsRegex);
                    Match AreaYardNew = AreaYardSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    areaYard = AreaYardNew.Groups[1].Value;
                    command.Parameters.AddWithValue("m2_2", areaYard.ToString());

                    string priceString = @"<li class=""offer-item-price"">\s+(.*?)zł\s+</li>";
                    Regex priceSample = new Regex(priceString, optionsRegex);
                    Match Price = priceSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    price = Price.Groups[1].Value;
                    command.Parameters.AddWithValue("cena1", price.ToString());

                    string locationString = @"<span class=""hidden-xs"">Dom na sprzedaż: </span>(.*?)</p>";
                    Regex locationSample = new Regex(locationString, optionsRegex);
                    Match Location = locationSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    location = Location.Groups[1].Value;
                    command.Parameters.AddWithValue("lokalizacja", location.ToString());

                    string IdentifierString = @" data-id=""(.*?)"" href=""#"">";
                    Regex IdentifierSample = new Regex(IdentifierString, optionsRegex);
                    Match IdentifierNew = IdentifierSample.Match(Convert.ToString(ParsingString[numberCollectionString]));
                    identifier = IdentifierNew.Groups[1].Value;
                    command.Parameters.AddWithValue("id1", identifier.ToString());

                    string RoomCountString = @"<li class=""offer-item-rooms hidden-xs"">(.*?)</li>";
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
