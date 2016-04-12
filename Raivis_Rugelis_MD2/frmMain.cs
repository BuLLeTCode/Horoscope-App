using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Data.SQLite;
using System.IO;

namespace Raivis_Rugelis_MD2
{

    public partial class frmMain : Form
    {

        //----Some globals variables
        //Multidimensional array with Zodiac signs and date
        string[,] zodiacSigns = new string[,] {
            { "Auns", "21.03 - 20.04."},
            { "Vērsis", "21.03 - 20.04."},
            { "Dvīņi" , "21.05 - 22.06."},
            { "Vēzis" , "22.06 - 23.07."},
            { "Lauva" , "23.07 - 22.08."},
            { "Jaunava", "22.08 - 23.09."},
            { "Svari", "23.09 - 23.10."},
            { "Skorpions", "23.09 - 22.11."},
            { "Strēlnieks", "23.11 - 22.12."},
            { "Mežāzis", "22.12 - 21.01."},
            { "Ūdensvīrs", "21.01 - 19.02."},
            { "Zivis", "19.02 - 21.03."}
        };
        //Global variable for user selected zodiac sign
        string userSelectedZodiac = "";

        //Bitman what stores picture, what will be displayed in app.
        Bitmap loadingImage = new Bitmap("horoscope_title.png");

        //Sqlite variables
        private SQLiteConnection sq_conn;
        private SQLiteCommand sq_cmd;

        public frmMain()
        {
            InitializeComponent();
            UpdateZodiacSignsCombo();
            //Set date
            UpdateTodayDate();
            //set connection
            SetConnection();
            //create table, if not exist
            ExecuteQuery("CREATE TABLE IF NOT EXISTS zodiac_description(id INTEGER PRIMARY KEY, zodiac_sign TEXT unique, zodiac_element TEXT, zodiac_motto TEXT, zodiac_day TEXT, zodiac_color TEXT, zodiac_planet TEXT, zodiac_lucky_numbers TEXT)");
            //Disable description button - avaible only when user choose zodiac
            btnOpenZodiacDescription.Enabled = false;
        }
        //Display zodiac signs and dates
        private void UpdateZodiacSignsCombo()
        {
            for(int i = 0; i < zodiacSigns.Length/2; i++)
            {
                cmbZotiac_frmMain.Items.Add(zodiacSigns[i, 0] + " " + zodiacSigns[i, 1]);
            }
        }

        private void UpdateTodayDate()
        {
            //Get active day, month and year
            string todaysDay = DateTime.Now.Day.ToString();
            string todaysMonth = DateTime.Now.Month.ToString();
            string todaysYear = DateTime.Now.Year.ToString();
            //Add 0 in front, if necesary
            if(int.Parse(todaysDay) < 10)
            {
                todaysDay = "0" + todaysDay;
            }

            if(int.Parse(todaysMonth) < 10)
            {
                todaysMonth = "0" + todaysMonth;
            }

            if(int.Parse(todaysYear) < 10)
            {
                todaysYear = "0" + todaysYear;
            }
            //Display :)
            lblTodayDate_frmMain.Text = "Šodienas datums: " + todaysDay + "/" + todaysMonth + "/" + todaysYear;
        }

        private void cmbZotiac_frmMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] userZodiac = cmbZotiac_frmMain.SelectedItem.ToString().Split(' ');
            //Set global variable to value
            userSelectedZodiac = userZodiac[0];
            //Update today and tomorrow zodiac windows
            TodayZodiac(userZodiac[0]);
            //Enable button - to can read description about his sign.
            btnOpenZodiacDescription.Enabled = true;
        }
        //Open description about zodiac sign
        private void btnOpenZodiacDescription_Click(object sender, EventArgs e)
        {
            frmZodiacDescription zodiacDescription = new frmZodiacDescription();
            //set info to display
            zodiacDescription.SetZodiacInfo(SelectData());
            zodiacDescription.ShowDialog();
        }

        private void TodayZodiac(string userZodiacSign)
        {
            Console.WriteLine("Zodiac Sign: " + userZodiacSign);

            try
            {
                //Create HtmlWeb object to Load and store Html document source.
                var webGet = new HtmlWeb();
                //Variable to store HTML document.
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
          
                //Switch between pages - according to zodiac sign
                switch (userZodiacSign)
                {
                    case "Auns":
                        doc = webGet.Load("http://skaties.lv/horoskopi/auns/");
                        break;
                    case "Vērsis":
                        doc = webGet.Load("http://skaties.lv/horoskopi/versis/");
                        break;
                    case "Dvīņi":
                        doc = webGet.Load("http://skaties.lv/horoskopi/dvini/");
                        break;
                    case "Vēzis":
                        doc = webGet.Load("http://skaties.lv/horoskopi/vezis/");
                        break;
                    case "Lauva":
                        doc = webGet.Load("http://skaties.lv/horoskopi/lauva/");
                        break;
                    case "Jaunava":
                        doc = webGet.Load("http://skaties.lv/horoskopi/jaunava/");
                        break;
                    case "Svari":
                        doc = webGet.Load("http://skaties.lv/horoskopi/svari/");
                        break;
                    case "Skorpions":
                        doc = webGet.Load("http://skaties.lv/horoskopi/skorpions/");
                        break;
                    case "Strēlnieks":
                        doc = webGet.Load("http://skaties.lv/horoskopi/strelnieks/");
                        break;
                    case "Mežāzis":
                        doc = webGet.Load("http://skaties.lv/horoskopi/mezazis/");
                        break;
                    case "Ūdensvīrs":
                        doc = webGet.Load("http://skaties.lv/horoskopi/udensvirs/");
                        break;
                    case "Zivis":
                        doc = webGet.Load("http://skaties.lv/horoskopi/zivis/");
                        break;
                }
                //--Get today horoscope
                //Use HtmlAgilityPack to get specific Node in WebPage, very similar to XML node getting in C#
                HtmlNode todayZodiacNode = doc.DocumentNode.SelectSingleNode("//div[@class='horoscopes-day-prognosis-content']");
                //Use Regex to split <p> tag from div node
                Match m = Regex.Match(todayZodiacNode.InnerHtml, @"<p>\s*(.+?)\s*</p>");
                //Store value in variable - with <p> tags
                string todayBeforeCut = m.Groups[0].Value;
                //Cut <p> tags from text
                string todayAfterCut = todayBeforeCut.Substring(3, (todayBeforeCut.Length - 8));
                Console.WriteLine("Cut horoscope text: " + todayAfterCut);
                //Display to TextBox
                tbTodayZodiac_frmMain.Text = todayAfterCut;

                //Get tomorrow horoscope
                HtmlNodeCollection tomorrowZodiacNode = doc.DocumentNode.SelectNodes("//*[contains(@class,'horoscopes-day-prognosis-content')]");
                //Store value in variabale - with <p> tags
                string tomorrowBeforeCut = tomorrowZodiacNode[(tomorrowZodiacNode.Count - 1)].InnerHtml.Trim();//Use Trim() to cut whitespaces
                //Cut <p> tags out
                string tomorrowAfterCut = tomorrowBeforeCut.Substring(3, (tomorrowBeforeCut.Length - 8));
                //Set value to textBox
                tbTomorrowZodiac_frmMain.Text = tomorrowAfterCut;
                Console.WriteLine("After cut: " + tomorrowAfterCut);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //He have problem :(
            }
        }
        //Paint event to drawImage bitmap image in app.
        protected override void OnPaint(PaintEventArgs e)
        {
            //DrawImage in specific place and specific size.
            e.Graphics.DrawImage(this.loadingImage, 360, 60, 130, 130);
        }

        //-- Some ToolStripMenu item click events.
        private void izietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If press Exit - Exit Application
            Application.Exit();
        }

        //-- SQLite functions

        //function to set connection to DB or create, if one doesnt exist
        public void SetConnection()
        {
            //Check, if we have DB file - if not - create one
            if (!File.Exists("ZodiacSignDescription.db"))
            { 
                SQLiteConnection.CreateFile("ZodiacSignDescription.db");
            }  
            //Create connection
            sq_conn = new SQLiteConnection(
                "DataSource=ZodiacSignDescription.db;Version=3;New=false;Compress=True;"
                );
        }
        //Get description data from DB.
        public string SelectData()
        {
            //Store - need close connection with DB, before return info
            string infoAboutUserZodiac = "";

            sq_conn.Open();
            using (SQLiteCommand fmd = sq_conn.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM zodiac_description WHERE zodiac_sign = '" + userSelectedZodiac + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    Console.WriteLine("Sign: " + r["zodiac_sign"] + "\tElement: " + r["zodiac_element"]);
                    infoAboutUserZodiac = r["zodiac_sign"] + "|" + r["zodiac_element"] + "|" + r["zodiac_motto"] + "|" + r["zodiac_day"] + "|" + r["zodiac_color"] + "|" + r["zodiac_planet"] + "|" + r["zodiac_lucky_numbers"];
                }
            }
            sq_conn.Close();

            return infoAboutUserZodiac;
        }
        //Function to insert data  into db.
        private void InsertData()
        {
            string sql = "insert into zodiac_description (zodiac_sign, zodiac_element, zodiac_motto, zodiac_day,zodiac_color, zodiac_planet, zodiac_lucky_numbers) values ('Zivis', 'Ūdens', 'es ticu', 'piektdiena', 'bāli violeta, zilzaļa, jūras zaļa', 'Neptūns un Jupiters', '6, 7, 11')";
            sq_conn.Open();
            //Create and execute command
            SQLiteCommand command = new SQLiteCommand(sql, sq_conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("error inserting data");
            }
            
            sq_conn.Close();
        }
        //Simple query execution function
        private void ExecuteQuery(string txtQuery)
        {
            try
            {
                //Open connection
                sq_conn.Open();
                //Create command
                sq_cmd = sq_conn.CreateCommand();
                sq_cmd.CommandText = txtQuery;
                //Execute
                sq_cmd.ExecuteNonQuery();
                sq_conn.Close();
            }
            catch(Exception er)
            {
                Console.WriteLine("Query execution error: " + er.Message.ToString());
            }
        }
    }
}
