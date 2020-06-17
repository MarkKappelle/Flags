using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static string json = File.ReadAllText(@"..\..\country-flags-master/countries.json");
        static Dictionary<string, string> country_codes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        List<string> country_png = country_codes.Keys.ToList();
        List<string> country_name = country_codes.Values.ToList();

        ComboBox CountryBox = new ComboBox();

        Random random = new Random();

        string answer = "";

        int score;

        int highscore;



        private void form_load(object sender, EventArgs e)
        {
            
            Controls.Add(CountryBox);
            CountryBox.Location = new System.Drawing.Point(12, 36);
            CountryBox.Width = 200;
            foreach (string element in country_name)
            {
                CountryBox.Items.Add(element);  
            }
            CountryBox.SelectedIndexChanged += new System.EventHandler(CountryBox_SelectedIndexChanged);
        }

        private void CountryBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayFlag(CountryToCode(CountryBox.Text));
             
        }



        public void DisplayFlag(String code)
        {
            Image flag = Image.FromFile($"..\\..\\country-flags-master\\png250px\\{code}.png");
            flagBoxOne.Image = flag;
            flagBoxOne.Width = flag.Width;
            flagBoxOne.Height = flag.Height;

        }

        public string CountryToCode(string country)
        {
            int i = country_name.IndexOf(country);
            return country_png[i];
        }

        private void StartGame(object sender, EventArgs e)
        {
            FlagGame();
        }

        public void FlagGame()
        {
            List<string> answers = new List<string>();
            for (int i = 0; i<3; i++)
            {
                answers.Add(country_name[RandomNumber(0,(country_name.Count-1))]);
            }
            
            buttonA.Text = answers[0];
            buttonB.Text = answers[1];
            buttonC.Text = answers[2];

            if (answers[0] == answers[1] || answers[1] == answers[2] || answers[2] == answers [0])
            {
                FlagGame();
                return;
            }



            int x = RandomNumber(0,2);
            answer = answers[x];
            DisplayFlag(CountryToCode(answer));
            CountryBox.Enabled = false;
            


        }

        private void AnswerClick(object sender, EventArgs e)
        {
            Button bAnswer = (Button)sender;
            string answerCheck = bAnswer.Text;
            if (answerCheck == answer)
            {
                
                score += 1;
                scoreBox.Text = ("Score: " + score.ToString());
                labelAnswer.Text = "Correct"; 
                FlagGame();
            }
            else
            {
                
                
                if (highscore < score)
                {
                    HighscoreBox.Text = ("Highscore: " + score.ToString());
                }
                score = 0;
                scoreBox.Text = "Score: ";
                labelAnswer.Text = "Wrong";
                CountryBox.Enabled = true;
            }
            
            
        }


        public int RandomNumber(int min, int max)
        {
            
            return random.Next(min, max);
        }

        
    }
}
